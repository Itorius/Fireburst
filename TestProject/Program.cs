using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Fireburst;
using GLFW;
using Constants = Fireburst.Constants;

namespace TestProject
{
	public static unsafe class Program
	{
		private static readonly HashSet<string> DeviceExtensions = new() { "VK_KHR_swapchain" };

		private static Window window;

		private static VkInstance instance;
		private static VkDebugUtilsMessengerEXT messenger;
		private static VkPhysicalDevice physicalDevice;
		private static VkDevice device;
		private static VkQueue graphicsQueue;
		private static VkQueue presentQueue;
		private static VkSurfaceKHR surface;
		private static VkSwapchainKHR swapChain;
		private static List<VkImage> swapChainImages;
		private static VkFormat swapChainImageFormat;
		private static Vector2ui swapChainExtent;
		private static VkImageView[] swapChainImageViews;
		private static VkRenderPass renderPass;
		private static VkPipelineLayout pipelineLayout;
		private static VkPipeline graphicsPipeline;
		private static VkFramebuffer[] swapChainFramebuffers;
		private static VkCommandPool commandPool;
		private static VkCommandBuffer[] commandBuffers;

		private static VkBool32 Debug(VkDebugUtilsMessageSeverityFlagsEXT a, VkDebugUtilsMessageTypeFlagsEXT b, VkDebugUtilsMessengerCallbackDataEXT* c, void* d)
		{
			Console.WriteLine(VulkanUtility.GetString(c->pMessage));

			return false;
		}

		public static void Main(string[] args)
		{
			Glfw.Init();
			Glfw.WindowHint(Hint.ClientApi, ClientApi.None);
			Glfw.WindowHint(Hint.Resizable, false);

			window = Glfw.CreateWindow(800, 600, "Vulkan Test", Monitor.None, Window.None);

			Vulkan.vkInitialize();

			VkDebugUtilsMessengerCreateInfoEXT createInfo = new()
			{
				sType = VkStructureType.DebugUtilsMessengerCreateInfoEXT,
				messageSeverity = VkDebugUtilsMessageSeverityFlagsEXT.Verbose | VkDebugUtilsMessageSeverityFlagsEXT.Warning | VkDebugUtilsMessageSeverityFlagsEXT.Error,
				messageType = VkDebugUtilsMessageTypeFlagsEXT.General | VkDebugUtilsMessageTypeFlagsEXT.Validation | VkDebugUtilsMessageTypeFlagsEXT.Performance,
				pfnUserCallback = &Debug
			};

			CreateInstance();

			Vulkan.vkCreateDebugUtilsMessengerEXT(instance, createInfo, out messenger).CheckResult();

			GlfwVulkan.CreateWindowSurface(instance.Handle, window, IntPtr.Zero, out IntPtr ptr);
			surface = new VkSurfaceKHR(ptr);

			PickPhysicalDevice();

			CreateLogicalDevice();

			CreateSwapchain();

			CreateImageViews();

			CreateRenderpass();

			CreateGraphicsPipeline();

			CreateFramebuffers();

			CreateCommandPool();

			CreateCommandBuffers();

			CreateSemaphores();

			while (!Glfw.WindowShouldClose(window))
			{
				Glfw.PollEvents();

				DrawFrame();
			}

			Vulkan.vkDeviceWaitIdle(device);

			Cleanup();
		}

		private static void CreateSemaphores()
		{
			VkSemaphoreCreateInfo semaphoreInfo = new();
			semaphoreInfo.sType = VkStructureType.SemaphoreCreateInfo;

			Vulkan.vkCreateSemaphore(device, semaphoreInfo, out imageAvailableSemaphore).CheckResult();
			Vulkan.vkCreateSemaphore(device, semaphoreInfo, out renderFinishedSemaphore).CheckResult();
		}

		private static VkSemaphore imageAvailableSemaphore;
		private static VkSemaphore renderFinishedSemaphore;

		private static void DrawFrame()
		{
			Vulkan.vkAcquireNextImageKHR(device, swapChain, UInt64.MaxValue, out var imageIndex, imageAvailableSemaphore);

			VkSubmitInfo submitInfo = new();
			submitInfo.sType = VkStructureType.SubmitInfo;

			var waitSemaphores = stackalloc VkSemaphore[] { imageAvailableSemaphore };
			var waitStages = stackalloc VkPipelineStageFlags[] { VkPipelineStageFlags.ColorAttachmentOutput };
			submitInfo.waitSemaphoreCount = 1;
			submitInfo.pWaitSemaphores = waitSemaphores;
			submitInfo.pWaitDstStageMask = waitStages;
			submitInfo.commandBufferCount = 1;
			fixed (VkCommandBuffer* ptr = &commandBuffers[imageIndex])
				submitInfo.pCommandBuffers = ptr;

			var signalSemaphores = stackalloc VkSemaphore[] { renderFinishedSemaphore };
			submitInfo.signalSemaphoreCount = 1;
			submitInfo.pSignalSemaphores = signalSemaphores;

			Vulkan.vkQueueSubmit(graphicsQueue, submitInfo, VkFence.Null);

			VkPresentInfoKHR presentInfo = new();
			presentInfo.sType = VkStructureType.PresentInfoKHR;

			presentInfo.waitSemaphoreCount = 1;
			presentInfo.pWaitSemaphores = signalSemaphores;

			var swapChains = stackalloc VkSwapchainKHR[] { swapChain };
			presentInfo.swapchainCount = 1;
			presentInfo.pSwapchains = swapChains;
			presentInfo.pImageIndices = &imageIndex;

			Vulkan.vkQueuePresentKHR(presentQueue, &presentInfo);
		}

		private static void CreateCommandBuffers()
		{
			commandBuffers = new VkCommandBuffer[swapChainFramebuffers.Length];

			VkCommandBufferAllocateInfo allocInfo = new();
			allocInfo.sType = VkStructureType.CommandBufferAllocateInfo;
			allocInfo.commandPool = commandPool;
			allocInfo.level = VkCommandBufferLevel.Primary;
			allocInfo.commandBufferCount = (uint)commandBuffers.Length;

			fixed (VkCommandBuffer* ptr = commandBuffers) Vulkan.vkAllocateCommandBuffers(device, &allocInfo, ptr).CheckResult();

			for (int i = 0; i < commandBuffers.Length; i++)
			{
				VkCommandBufferBeginInfo beginInfo = new();
				beginInfo.sType = VkStructureType.CommandBufferBeginInfo;

				VkCommandBuffer commandBuffer = commandBuffers[i];
				Vulkan.vkBeginCommandBuffer(commandBuffer, &beginInfo).CheckResult();

				VkRenderPassBeginInfo renderPassInfo = new();
				renderPassInfo.sType = VkStructureType.RenderPassBeginInfo;
				renderPassInfo.renderPass = renderPass;
				renderPassInfo.framebuffer = swapChainFramebuffers[i];
				renderPassInfo.renderArea.offset = new Vector2i(0, 0);
				renderPassInfo.renderArea.extent = swapChainExtent;

				VkClearValue clearColor = new VkClearValue(Color.CornflowerBlue.R, Color.CornflowerBlue.G, Color.CornflowerBlue.B);
				renderPassInfo.clearValueCount = 1;
				renderPassInfo.pClearValues = &clearColor;

				Vulkan.vkCmdBeginRenderPass(commandBuffer, &renderPassInfo, VkSubpassContents.Inline);

				Vulkan.vkCmdBindPipeline(commandBuffer, VkPipelineBindPoint.Graphics, graphicsPipeline);
				Vulkan.vkCmdDraw(commandBuffer, 3, 1, 0, 0);
				Vulkan.vkCmdEndRenderPass(commandBuffer);

				Vulkan.vkEndCommandBuffer(commandBuffer);
			}
		}

		private static void CreateCommandPool()
		{
			QueueFamilyIndices queueFamilyIndices = FindQueueFamilyIndices(physicalDevice);

			VkCommandPoolCreateInfo poolInfo = new();
			poolInfo.sType = VkStructureType.CommandPoolCreateInfo;
			poolInfo.queueFamilyIndex = queueFamilyIndices.graphicsFamily.Value;

			Vulkan.vkCreateCommandPool(device, poolInfo, out commandPool).CheckResult();
		}

		private static void CreateFramebuffers()
		{
			swapChainFramebuffers = new VkFramebuffer[swapChainImageViews.Length];

			for (int i = 0; i < swapChainImageViews.Length; i++)
			{
				VkFramebufferCreateInfo framebufferInfo = new();
				framebufferInfo.sType = VkStructureType.FramebufferCreateInfo;
				framebufferInfo.renderPass = renderPass;
				framebufferInfo.attachmentCount = 1;
				fixed (VkImageView* ptr = &swapChainImageViews[i]) framebufferInfo.pAttachments = ptr;
				framebufferInfo.width = swapChainExtent.width;
				framebufferInfo.height = swapChainExtent.height;
				framebufferInfo.layers = 1;

				Vulkan.vkCreateFramebuffer(device, framebufferInfo, out swapChainFramebuffers[i]).CheckResult();
			}
		}

		private static void CreateRenderpass()
		{
			VkAttachmentDescription colorAttachment = new();
			colorAttachment.format = swapChainImageFormat;
			colorAttachment.samples = VkSampleCountFlags.Count1;
			colorAttachment.loadOp = VkAttachmentLoadOp.Clear;
			colorAttachment.storeOp = VkAttachmentStoreOp.Store;
			colorAttachment.stencilLoadOp = VkAttachmentLoadOp.DontCare;
			colorAttachment.stencilStoreOp = VkAttachmentStoreOp.DontCare;
			colorAttachment.initialLayout = VkImageLayout.Undefined;
			colorAttachment.finalLayout = VkImageLayout.PresentSrcKHR;

			VkAttachmentReference colorAttachmentRef = new();
			colorAttachmentRef.attachment = 0;
			colorAttachmentRef.layout = VkImageLayout.ColorAttachmentOptimal;

			VkSubpassDescription subpass = new();
			subpass.pipelineBindPoint = VkPipelineBindPoint.Graphics;
			subpass.colorAttachmentCount = 1;
			subpass.pColorAttachments = &colorAttachmentRef;

			VkRenderPassCreateInfo renderPassInfo = new();
			renderPassInfo.sType = VkStructureType.RenderPassCreateInfo;
			renderPassInfo.attachmentCount = 1;
			renderPassInfo.pAttachments = &colorAttachment;
			renderPassInfo.subpassCount = 1;
			renderPassInfo.pSubpasses = &subpass;

			VkSubpassDependency dependency = new();
			dependency.srcSubpass = (uint)Constants.VK_SUBPASS_EXTERNAL;
			dependency.dstSubpass = 0;
			dependency.srcStageMask = VkPipelineStageFlags.ColorAttachmentOutput;
			dependency.srcAccessMask = 0;
			dependency.dstStageMask = VkPipelineStageFlags.ColorAttachmentOutput;
			dependency.dstAccessMask = VkAccessFlags.ColorAttachmentWrite;
			renderPassInfo.dependencyCount = 1;
			renderPassInfo.pDependencies = &dependency;

			Vulkan.vkCreateRenderPass(device, renderPassInfo, out renderPass).CheckResult();
		}

		private static void CreateGraphicsPipeline()
		{
			static VkShaderModule CreateShaderModule(byte[] code)
			{
				VkShaderModuleCreateInfo createInfo = new()
				{
					sType = VkStructureType.ShaderModuleCreateInfo,
					codeSize = (nuint)code.Length
				};
				fixed (byte* ptr = code) createInfo.pCode = (uint*)ptr;
				Vulkan.vkCreateShaderModule(device, createInfo, out var module);
				return module;
			}

			var vertShaderModule = CreateShaderModule(File.ReadAllBytes("vert.spv"));
			var fragShaderModule = CreateShaderModule(File.ReadAllBytes("frag.spv"));

			VkPipelineShaderStageCreateInfo vertShaderStageInfo = new()
			{
				sType = VkStructureType.PipelineShaderStageCreateInfo,
				stage = VkShaderStageFlags.Vertex,
				module = vertShaderModule,
				pName = new VkString("main")
			};

			VkPipelineShaderStageCreateInfo fragShaderStageInfo = new()
			{
				sType = VkStructureType.PipelineShaderStageCreateInfo,
				stage = VkShaderStageFlags.Fragment,
				module = fragShaderModule,
				pName = new VkString("main")
			};

			var shaderStages = stackalloc VkPipelineShaderStageCreateInfo[2] { vertShaderStageInfo, fragShaderStageInfo };

			VkPipelineVertexInputStateCreateInfo vertexInputInfo = new();
			vertexInputInfo.sType = VkStructureType.PipelineVertexInputStateCreateInfo;
			vertexInputInfo.vertexBindingDescriptionCount = 0;
			vertexInputInfo.vertexAttributeDescriptionCount = 0;

			VkPipelineInputAssemblyStateCreateInfo inputAssembly = new();
			inputAssembly.sType = VkStructureType.PipelineInputAssemblyStateCreateInfo;
			inputAssembly.topology = VkPrimitiveTopology.TriangleList;
			inputAssembly.primitiveRestartEnable = false;

			VkViewport viewport = new()
			{
				x = 0.0f,
				y = 0.0f,
				width = swapChainExtent.width,
				height = swapChainExtent.height,
				minDepth = 0.0f,
				maxDepth = 1.0f
			};

			VkRect2D scissor = new()
			{
				offset = Vector2i.Zero,
				extent = swapChainExtent
			};

			VkPipelineViewportStateCreateInfo viewportState = new();
			viewportState.sType = VkStructureType.PipelineViewportStateCreateInfo;
			viewportState.viewportCount = 1;
			viewportState.pViewports = &viewport;
			viewportState.scissorCount = 1;
			viewportState.pScissors = &scissor;

			VkPipelineRasterizationStateCreateInfo rasterizer = new();
			rasterizer.sType = VkStructureType.PipelineRasterizationStateCreateInfo;
			rasterizer.depthClampEnable = false;
			rasterizer.rasterizerDiscardEnable = false;
			rasterizer.polygonMode = VkPolygonMode.Fill;
			rasterizer.lineWidth = 1.0f;
			rasterizer.cullMode = VkCullModeFlags.Back;
			rasterizer.frontFace = VkFrontFace.Clockwise;
			rasterizer.depthBiasEnable = false;

			VkPipelineMultisampleStateCreateInfo multisampling = new();
			multisampling.sType = VkStructureType.PipelineMultisampleStateCreateInfo;
			multisampling.sampleShadingEnable = false;
			multisampling.rasterizationSamples = VkSampleCountFlags.Count1;

			VkPipelineColorBlendAttachmentState colorBlendAttachment = new();
			colorBlendAttachment.colorWriteMask = VkColorComponentFlags.All;
			colorBlendAttachment.blendEnable = false;
			colorBlendAttachment.blendEnable = true;
			colorBlendAttachment.srcColorBlendFactor = VkBlendFactor.SrcAlpha;
			colorBlendAttachment.dstColorBlendFactor = VkBlendFactor.OneMinusSrcAlpha;
			colorBlendAttachment.colorBlendOp = VkBlendOp.Add;
			colorBlendAttachment.srcAlphaBlendFactor = VkBlendFactor.One;
			colorBlendAttachment.dstAlphaBlendFactor = VkBlendFactor.Zero;
			colorBlendAttachment.alphaBlendOp = VkBlendOp.Add;

			VkPipelineColorBlendStateCreateInfo colorBlending = new();
			colorBlending.sType = VkStructureType.PipelineColorBlendStateCreateInfo;
			colorBlending.logicOpEnable = false;
			colorBlending.logicOp = VkLogicOp.Copy; // Optional
			colorBlending.attachmentCount = 1;
			colorBlending.pAttachments = &colorBlendAttachment;

			var dynamicStates = stackalloc VkDynamicState[2] { VkDynamicState.Viewport, VkDynamicState.LineWidth };

			VkPipelineDynamicStateCreateInfo dynamicState = new();
			dynamicState.sType = VkStructureType.PipelineDynamicStateCreateInfo;
			dynamicState.dynamicStateCount = 2;
			dynamicState.pDynamicStates = dynamicStates;

			VkPipelineLayoutCreateInfo pipelineLayoutInfo = new();
			pipelineLayoutInfo.sType = VkStructureType.PipelineLayoutCreateInfo;

			Vulkan.vkCreatePipelineLayout(device, pipelineLayoutInfo, out pipelineLayout).CheckResult();

			VkGraphicsPipelineCreateInfo pipelineInfo = new();
			pipelineInfo.sType = VkStructureType.GraphicsPipelineCreateInfo;
			pipelineInfo.stageCount = 2;
			pipelineInfo.pStages = shaderStages;
			pipelineInfo.pVertexInputState = &vertexInputInfo;
			pipelineInfo.pInputAssemblyState = &inputAssembly;
			pipelineInfo.pViewportState = &viewportState;
			pipelineInfo.pRasterizationState = &rasterizer;
			pipelineInfo.pMultisampleState = &multisampling;
			pipelineInfo.pColorBlendState = &colorBlending;
			pipelineInfo.layout = pipelineLayout;
			pipelineInfo.renderPass = renderPass;
			pipelineInfo.subpass = 0;

			Vulkan.vkCreateGraphicsPipeline(device, pipelineInfo, out graphicsPipeline).CheckResult();

			Vulkan.vkDestroyShaderModule(device, vertShaderModule);
			Vulkan.vkDestroyShaderModule(device, fragShaderModule);
		}

		private static void CreateImageViews()
		{
			swapChainImageViews = new VkImageView[swapChainImages.Count];

			for (int i = 0; i < swapChainImages.Count; i++)
			{
				VkImageViewCreateInfo createInfo = new()
				{
					sType = VkStructureType.ImageViewCreateInfo,
					image = swapChainImages[i],
					viewType = VkImageViewType.Image2D,
					format = swapChainImageFormat,
					components = VkComponentMapping.Identity,
					subresourceRange =
					{
						aspectMask = VkImageAspectFlags.Color,
						baseMipLevel = 0,
						levelCount = 1,
						baseArrayLayer = 0,
						layerCount = 1
					}
				};

				Vulkan.vkCreateImageView(device, createInfo, out swapChainImageViews[i]).CheckResult();
			}
		}

		private static void CreateSwapchain()
		{
			SwapChainSupportDetails swapChainSupport = QuerySwapChainSupport(physicalDevice);

			var surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.formats);
			var presentMode = ChooseSwapPresentMode(swapChainSupport.presentModes);
			var extent = ChooseSwapExtent(swapChainSupport.capabilities);

			uint imageCount = swapChainSupport.capabilities.minImageCount + 1;

			if (swapChainSupport.capabilities.maxImageCount > 0 && imageCount > swapChainSupport.capabilities.maxImageCount)
			{
				imageCount = swapChainSupport.capabilities.maxImageCount;
			}

			VkSwapchainCreateInfoKHR createInfo = new()
			{
				sType = VkStructureType.SwapchainCreateInfoKHR,
				surface = surface,
				minImageCount = imageCount,
				imageFormat = surfaceFormat.format,
				imageColorSpace = surfaceFormat.colorSpace,
				imageExtent = extent,
				imageArrayLayers = 1,
				imageUsage = VkImageUsageFlags.ColorAttachment
			};

			QueueFamilyIndices indices = FindQueueFamilyIndices(physicalDevice);
			var queueFamilyIndices = stackalloc uint[2] { indices.graphicsFamily.Value, indices.presentFamily.Value };

			if (indices.graphicsFamily != indices.presentFamily)
			{
				createInfo.imageSharingMode = VkSharingMode.Concurrent;
				createInfo.queueFamilyIndexCount = 2;
				createInfo.pQueueFamilyIndices = queueFamilyIndices;
			}
			else
			{
				createInfo.imageSharingMode = VkSharingMode.Exclusive;
				createInfo.queueFamilyIndexCount = 0; // Optional
				createInfo.pQueueFamilyIndices = null; // Optional
			}

			createInfo.preTransform = swapChainSupport.capabilities.currentTransform;
			createInfo.compositeAlpha = VkCompositeAlphaFlagsKHR.Opaque;
			createInfo.presentMode = presentMode;
			createInfo.clipped = true;
			createInfo.oldSwapchain = VkSwapchainKHR.Null;

			Vulkan.vkCreateSwapchainKHR(device, createInfo, out swapChain).CheckResult();

			swapChainImages = new List<VkImage>(Vulkan.vkGetSwapchainImagesKHR(device, swapChain).ToArray());
			swapChainImageFormat = surfaceFormat.format;
			swapChainExtent = extent;
		}

		private static void CreateLogicalDevice()
		{
			QueueFamilyIndices indices = FindQueueFamilyIndices(physicalDevice);

			HashSet<uint> uniqueQueueFamilies = new HashSet<uint> { indices.graphicsFamily.Value, indices.presentFamily.Value };
			var queueCreateInfos = stackalloc VkDeviceQueueCreateInfo[uniqueQueueFamilies.Count];

			float queuePriority = 1.0f;
			int i = 0;
			foreach (uint queueFamily in uniqueQueueFamilies)
			{
				VkDeviceQueueCreateInfo queueCreateInfo = new()
				{
					sType = VkStructureType.DeviceQueueCreateInfo,
					queueFamilyIndex = queueFamily,
					queueCount = 1,
					pQueuePriorities = &queuePriority
				};
				queueCreateInfos[i++] = queueCreateInfo;
			}

			VkPhysicalDeviceFeatures deviceFeatures = new();

			VkDeviceCreateInfo createInfo = new()
			{
				sType = VkStructureType.DeviceCreateInfo,
				queueCreateInfoCount = (uint)uniqueQueueFamilies.Count,
				pQueueCreateInfos = queueCreateInfos,

				pEnabledFeatures = &deviceFeatures,

				enabledLayerCount = 1,
				ppEnabledLayerNames = new VkStringArray("VK_LAYER_KHRONOS_validation"),

				enabledExtensionCount = (uint)DeviceExtensions.Count,
				ppEnabledExtensionNames = new VkStringArray(DeviceExtensions)
			};

			Vulkan.vkCreateDevice(physicalDevice, createInfo, out device).CheckResult();

			Vulkan.vkGetDeviceQueue(device, indices.graphicsFamily.Value, 0, out graphicsQueue);
			Vulkan.vkGetDeviceQueue(device, indices.presentFamily.Value, 0, out presentQueue);
		}

		private ref struct SwapChainSupportDetails
		{
			public VkSurfaceCapabilitiesKHR capabilities;
			public ReadOnlySpan<VkSurfaceFormatKHR> formats;
			public ReadOnlySpan<VkPresentModeKHR> presentModes;
		}

		private static SwapChainSupportDetails QuerySwapChainSupport(VkPhysicalDevice device)
		{
			SwapChainSupportDetails details = new SwapChainSupportDetails();

			Vulkan.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(device, surface, out details.capabilities);

			details.formats = Vulkan.vkGetPhysicalDeviceSurfaceFormatsKHR(device, surface);
			details.presentModes = Vulkan.vkGetPhysicalDeviceSurfacePresentModesKHR(device, surface);

			return details;
		}

		private struct QueueFamilyIndices
		{
			public uint? graphicsFamily;
			public uint? presentFamily;

			public bool IsComplete()
			{
				return graphicsFamily.HasValue && presentFamily.HasValue;
			}
		}

		private static VkSurfaceFormatKHR ChooseSwapSurfaceFormat(ReadOnlySpan<VkSurfaceFormatKHR> availableFormats)
		{
			foreach (var availableFormat in availableFormats)
			{
				if (availableFormat.format == VkFormat.B8g8r8a8Srgb && availableFormat.colorSpace == VkColorSpaceKHR.SrgbNonLinearKHR)
				{
					return availableFormat;
				}
			}

			return availableFormats[0];
		}

		private static VkPresentModeKHR ChooseSwapPresentMode(ReadOnlySpan<VkPresentModeKHR> availablePresentModes)
		{
			foreach (var availablePresentMode in availablePresentModes)
			{
				if (availablePresentMode == VkPresentModeKHR.Mailbox)
				{
					return availablePresentMode;
				}
			}

			return VkPresentModeKHR.Fifo;
		}

		private static Vector2ui ChooseSwapExtent(VkSurfaceCapabilitiesKHR capabilities)
		{
			if (capabilities.currentExtent.width != uint.MaxValue)
			{
				return capabilities.currentExtent;
			}

			Glfw.GetFramebufferSize(window, out var width, out var height);

			Vector2ui actualExtent = new Vector2ui((uint)width, (uint)height);

			actualExtent.width = Math.Max(capabilities.minImageExtent.width, Math.Min(capabilities.maxImageExtent.width, actualExtent.width));
			actualExtent.height = Math.Max(capabilities.minImageExtent.height, Math.Min(capabilities.maxImageExtent.height, actualExtent.height));

			return actualExtent;
		}

		private static void PickPhysicalDevice()
		{
			var physicalDevices = Vulkan.vkEnumeratePhysicalDevices(instance);

			foreach (VkPhysicalDevice pd in physicalDevices)
			{
				if (IsDeviceSuitable(pd))
					physicalDevice = pd;
			}

			static bool IsDeviceSuitable(VkPhysicalDevice device)
			{
				var indices = FindQueueFamilyIndices(device);
				bool extensionsSupported = CheckDeviceExtensionSupport(device);

				bool swapChainAdequate = false;
				if (extensionsSupported)
				{
					SwapChainSupportDetails swapChainSupport = QuerySwapChainSupport(device);
					swapChainAdequate = !swapChainSupport.formats.IsEmpty && !swapChainSupport.presentModes.IsEmpty;
				}

				return indices.IsComplete() && extensionsSupported && swapChainAdequate;
			}
		}

		private static bool CheckDeviceExtensionSupport(VkPhysicalDevice device)
		{
			var extensions = Vulkan.vkEnumerateDeviceExtensionProperties(device);

			var requiredExtensions = new List<string>(DeviceExtensions);

			foreach (var extension in extensions) requiredExtensions.Remove(extension.ExtensionName);

			return requiredExtensions.Count == 0;
		}

		private static QueueFamilyIndices FindQueueFamilyIndices(VkPhysicalDevice device)
		{
			ReadOnlySpan<VkQueueFamilyProperties> properties = Vulkan.vkGetPhysicalDeviceQueueFamilyProperties(device);
			QueueFamilyIndices indices = new();

			for (int i = 0; i < properties.Length; i++)
			{
				VkQueueFamilyProperties property = properties[i];
				if ((property.queueFlags & VkQueueFlags.Graphics) != 0)
				{
					indices.graphicsFamily = (uint)i;
				}

				Vulkan.vkGetPhysicalDeviceSurfaceSupportKHR(device, (uint)i, surface, out var presentSupport);
				if (presentSupport) indices.presentFamily = (uint)i;

				if (indices.IsComplete()) break;
			}

			return indices;
		}

		private static void CreateInstance()
		{
			VkApplicationInfo appInfo = new()
			{
				sType = VkStructureType.ApplicationInfo,
				pApplicationName = new VkString("Hello Triangle"),
				applicationVersion = new VkVersion(1, 0, 0),
				pEngineName = new VkString("No Engine"),
				engineVersion = new VkVersion(1, 0, 0),
				apiVersion = VkVersion.Version_1_2
			};

			VkInstanceCreateInfo info = new()
			{
				sType = VkStructureType.InstanceCreateInfo,
				flags = VkInstanceCreateFlags.None,
				pApplicationInfo = &appInfo
			};

			var extensions = GlfwVulkan.GetRequiredInstanceExtensions().ToList();
			extensions.Add("VK_EXT_debug_utils");

			info.enabledExtensionCount = (uint)extensions.Count;
			info.ppEnabledExtensionNames = new VkStringArray(extensions);
			info.enabledLayerCount = 1;
			info.ppEnabledLayerNames = new VkStringArray("VK_LAYER_KHRONOS_validation");

			Vulkan.vkCreateInstance(info, out instance).CheckResult();

			Vulkan.vkLoadInstance(instance);
		}

		private static void Cleanup()
		{
			Vulkan.vkDestroySemaphore(device, imageAvailableSemaphore);
			Vulkan.vkDestroySemaphore(device, renderFinishedSemaphore);

			Vulkan.vkDestroyCommandPool(device, commandPool);

			foreach (VkFramebuffer framebuffer in swapChainFramebuffers)
			{
				Vulkan.vkDestroyFramebuffer(device, framebuffer);
			}

			Vulkan.vkDestroyPipeline(device, graphicsPipeline);
			Vulkan.vkDestroyPipelineLayout(device, pipelineLayout);
			Vulkan.vkDestroyRenderPass(device, renderPass);

			foreach (VkImageView imageView in swapChainImageViews)
			{
				Vulkan.vkDestroyImageView(device, imageView);
			}

			Vulkan.vkDestroySwapchainKHR(device, swapChain);

			Vulkan.vkDestroyDevice(device);
			Vulkan.vkDestroySurfaceKHR(instance, surface);

			Vulkan.vkDestroyDebugUtilsMessengerEXT(instance, messenger);
			Vulkan.vkDestroyInstance(instance);

			Glfw.DestroyWindow(window);
			Glfw.Terminate();
		}
	}
}