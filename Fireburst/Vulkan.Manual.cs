using System;
using System.Runtime.InteropServices;

namespace Fireburst
{
	public static unsafe partial class Vulkan
	{
		public static delegate* unmanaged<void> vkGetInstanceProcAddr(VkInstance instance, string name)
		{
			int byteCount = VulkanUtility.GetMaxByteCount(name);
			byte* stringPtr = stackalloc byte[byteCount];
			VulkanUtility.StringToPointer(name, stringPtr, byteCount);
			return (delegate* unmanaged<void>)vkGetInstanceProcAddr(instance, stringPtr);
		}

		public static ReadOnlySpan<VkPhysicalDevice> vkEnumeratePhysicalDevices(VkInstance instance)
		{
			uint physicalDeviceCount = 0;
			vkEnumeratePhysicalDevices(instance, &physicalDeviceCount, null).CheckResult();

			ReadOnlySpan<VkPhysicalDevice> physicalDevices = new VkPhysicalDevice[physicalDeviceCount];
			fixed (VkPhysicalDevice* physicalDevicesPtr = physicalDevices)
			{
				vkEnumeratePhysicalDevices(instance, &physicalDeviceCount, physicalDevicesPtr).CheckResult();
			}

			return physicalDevices;
		}

		public static ReadOnlySpan<VkQueueFamilyProperties> vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice)
		{
			uint queueFamilyPropertyCount = 0;
			vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &queueFamilyPropertyCount, null);

			ReadOnlySpan<VkQueueFamilyProperties> queueFamilyProperties = new VkQueueFamilyProperties[queueFamilyPropertyCount];
			fixed (VkQueueFamilyProperties* queueFamilyPropertiesPtr = queueFamilyProperties)
			{
				vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &queueFamilyPropertyCount, queueFamilyPropertiesPtr);
			}

			return queueFamilyProperties;
		}

		public static ReadOnlySpan<VkExtensionProperties> vkEnumerateInstanceExtensionProperties()
		{
			uint extensionCount = 0;
			vkEnumerateInstanceExtensionProperties(null, &extensionCount, null).CheckResult();

			ReadOnlySpan<VkExtensionProperties> extensions = new VkExtensionProperties[extensionCount];
			fixed (VkExtensionProperties* propertiesPtr = extensions)
			{
				vkEnumerateInstanceExtensionProperties(null, &extensionCount, propertiesPtr).CheckResult();
			}

			return extensions;
		}

		public static ReadOnlySpan<VkLayerProperties> vkEnumerateInstanceLayerProperties()
		{
			uint propertyCount = 0;
			vkEnumerateInstanceLayerProperties(&propertyCount, null).CheckResult();

			ReadOnlySpan<VkLayerProperties> properties = new VkLayerProperties[propertyCount];
			fixed (VkLayerProperties* propertiesPtr = properties)
			{
				vkEnumerateInstanceLayerProperties(&propertyCount, propertiesPtr).CheckResult();
			}

			return properties;
		}

		public static ReadOnlySpan<VkLayerProperties> vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice)
		{
			uint propertyCount = 0;
			vkEnumerateDeviceLayerProperties(physicalDevice, &propertyCount, null).CheckResult();

			ReadOnlySpan<VkLayerProperties> properties = new VkLayerProperties[propertyCount];
			fixed (VkLayerProperties* propertiesPtr = properties)
			{
				vkEnumerateDeviceLayerProperties(physicalDevice, &propertyCount, propertiesPtr).CheckResult();
			}

			return properties;
		}

		public static VkResult vkQueueSubmit(VkQueue queue, VkSubmitInfo submit, VkFence fence)
		{
			return vkQueueSubmit(queue, 1, &submit, fence);
		}

		public static VkResult vkQueueSubmit(VkQueue queue, ReadOnlySpan<VkSubmitInfo> submits, VkFence fence)
		{
			fixed (VkSubmitInfo* submitsPtr = submits)
			{
				return vkQueueSubmit(queue, (uint)submits.Length, submitsPtr, fence);
			}
		}

		public static VkResult vkFlushMappedMemoryRanges(VkDevice device, VkMappedMemoryRange memoryRange)
		{
			return vkFlushMappedMemoryRanges(device, 1, &memoryRange);
		}

		public static VkResult vkFlushMappedMemoryRanges(VkDevice device, ReadOnlySpan<VkMappedMemoryRange> memoryRanges)
		{
			fixed (VkMappedMemoryRange* memoryRangesPtr = memoryRanges)
			{
				return vkFlushMappedMemoryRanges(device, (uint)memoryRanges.Length, memoryRangesPtr);
			}
		}

		public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, VkMappedMemoryRange memoryRange)
		{
			return vkInvalidateMappedMemoryRanges(device, 1, &memoryRange);
		}

		public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, ReadOnlySpan<VkMappedMemoryRange> memoryRanges)
		{
			fixed (VkMappedMemoryRange* memoryRangesPtr = memoryRanges)
			{
				return vkInvalidateMappedMemoryRanges(device, (uint)memoryRanges.Length, memoryRangesPtr);
			}
		}

		public static ReadOnlySpan<VkSparseImageMemoryRequirements> vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image)
		{
			uint sparseMemoryRequirementCount = 0;
			vkGetImageSparseMemoryRequirements(device, image, &sparseMemoryRequirementCount, null);

			ReadOnlySpan<VkSparseImageMemoryRequirements> sparseMemoryRequirements = new VkSparseImageMemoryRequirements[sparseMemoryRequirementCount];
			fixed (VkSparseImageMemoryRequirements* sparseMemoryRequirementsPtr = sparseMemoryRequirements)
			{
				vkGetImageSparseMemoryRequirements(device, image, &sparseMemoryRequirementCount, sparseMemoryRequirementsPtr);
			}

			return sparseMemoryRequirements;
		}

		public static ReadOnlySpan<VkSparseImageFormatProperties> vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling)
		{
			uint propertyCount = 0;
			vkGetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, type, samples, usage, tiling, &propertyCount, null);

			ReadOnlySpan<VkSparseImageFormatProperties> properties = new VkSparseImageFormatProperties[propertyCount];
			fixed (VkSparseImageFormatProperties* propertiesPtr = properties)
			{
				vkGetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, type, samples, usage, tiling, &propertyCount, propertiesPtr);
			}

			return properties;
		}

		public static VkResult vkQueueBindSparse(VkQueue queue, VkBindSparseInfo bindInfo, VkFence fence)
		{
			return vkQueueBindSparse(queue, 1, &bindInfo, fence);
		}

		public static VkResult vkQueueBindSparse(VkQueue queue, ReadOnlySpan<VkBindSparseInfo> bindInfo, VkFence fence)
		{
			fixed (VkBindSparseInfo* bindInfoPtr = bindInfo)
			{
				return vkQueueBindSparse(queue, (uint)bindInfo.Length, bindInfoPtr, fence);
			}
		}

		public static VkResult vkResetFences(VkDevice device, VkFence fence)
		{
			return vkResetFences(device, 1, &fence);
		}

		public static VkResult vkResetFences(VkDevice device, ReadOnlySpan<VkFence> fences)
		{
			fixed (VkFence* fencesPtr = fences)
			{
				return vkResetFences(device, (uint)fences.Length, fencesPtr);
			}
		}

		public static VkResult vkWaitForFences(VkDevice device, VkFence fence, VkBool32 waitAll, ulong timeout)
		{
			return vkWaitForFences(device, 1, &fence, waitAll, timeout);
		}

		public static VkResult vkWaitForFences(VkDevice device, ReadOnlySpan<VkFence> fences, VkBool32 waitAll, ulong timeout)
		{
			fixed (VkFence* fencesPtr = fences)
			{
				return vkWaitForFences(device, (uint)fences.Length, fencesPtr, waitAll, timeout);
			}
		}

		public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, VkPipelineCache srcCache)
		{
			return vkMergePipelineCaches(device, dstCache, 1, &srcCache);
		}

		public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, ReadOnlySpan<VkPipelineCache> srcCaches)
		{
			fixed (VkPipelineCache* srcCachesPtr = srcCaches)
			{
				return vkMergePipelineCaches(device, dstCache, (uint)srcCaches.Length, srcCachesPtr);
			}
		}

		public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorSet descriptorSet)
		{
			return vkFreeDescriptorSets(device, descriptorPool, 1, &descriptorSet);
		}

		public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, ReadOnlySpan<VkDescriptorSet> descriptorSets)
		{
			fixed (VkDescriptorSet* descriptorSetsPtr = descriptorSets)
			{
				return vkFreeDescriptorSets(device, descriptorPool, (uint)descriptorSets.Length, descriptorSetsPtr);
			}
		}

		public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, VkViewport viewport)
		{
			vkCmdSetViewport(commandBuffer, firstViewport, 1, &viewport);
		}

		public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, ReadOnlySpan<VkViewport> viewports)
		{
			fixed (VkViewport* viewportsPtr = viewports)
			{
				vkCmdSetViewport(commandBuffer, firstViewport, (uint)viewports.Length, viewportsPtr);
			}
		}

		public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, VkRect2D scissor)
		{
			vkCmdSetScissor(commandBuffer, firstScissor, 1, &scissor);
		}

		public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, ReadOnlySpan<VkRect2D> scissors)
		{
			fixed (VkRect2D* scissorsPtr = scissors)
			{
				vkCmdSetScissor(commandBuffer, firstScissor, (uint)scissors.Length, scissorsPtr);
			}
		}

		public static VkResult vkBindBufferMemory2(VkDevice device, VkBindBufferMemoryInfo bindInfo)
		{
			return vkBindBufferMemory2(device, 1, &bindInfo);
		}

		public static VkResult vkBindBufferMemory2(VkDevice device, ReadOnlySpan<VkBindBufferMemoryInfo> bindInfos)
		{
			fixed (VkBindBufferMemoryInfo* bindInfosPtr = bindInfos)
			{
				return vkBindBufferMemory2(device, (uint)bindInfos.Length, bindInfosPtr);
			}
		}

		public static VkResult vkBindImageMemory2(VkDevice device, VkBindImageMemoryInfo bindInfo)
		{
			return vkBindImageMemory2(device, 1, &bindInfo);
		}

		public static VkResult vkBindImageMemory2(VkDevice device, ReadOnlySpan<VkBindImageMemoryInfo> bindInfos)
		{
			fixed (VkBindImageMemoryInfo* bindInfosPtr = bindInfos)
			{
				return vkBindImageMemory2(device, (uint)bindInfos.Length, bindInfosPtr);
			}
		}

		public static ReadOnlySpan<VkSparseImageMemoryRequirements2> vkGetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info)
		{
			uint sparseMemoryRequirementCount = 0;
			vkGetImageSparseMemoryRequirements2(device, info, &sparseMemoryRequirementCount, null);

			ReadOnlySpan<VkSparseImageMemoryRequirements2> sparseMemoryRequirements = new VkSparseImageMemoryRequirements2[sparseMemoryRequirementCount];
			fixed (VkSparseImageMemoryRequirements2* sparseMemoryRequirementsPtr = sparseMemoryRequirements)
			{
				vkGetImageSparseMemoryRequirements2(device, info, &sparseMemoryRequirementCount, sparseMemoryRequirementsPtr);
			}

			return sparseMemoryRequirements;
		}

		public static ReadOnlySpan<VkQueueFamilyProperties2> vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice)
		{
			uint queueFamilyPropertyCount = 0;
			vkGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, &queueFamilyPropertyCount, null);

			ReadOnlySpan<VkQueueFamilyProperties2> queueFamilyProperties = new VkQueueFamilyProperties2[queueFamilyPropertyCount];
			fixed (VkQueueFamilyProperties2* queueFamilyPropertiesPtr = queueFamilyProperties)
			{
				vkGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, &queueFamilyPropertyCount, queueFamilyPropertiesPtr);
			}

			return queueFamilyProperties;
		}

		public static ReadOnlySpan<VkSparseImageFormatProperties2> vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo)
		{
			uint propertyCount = 0;
			vkGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, formatInfo, &propertyCount, null);

			ReadOnlySpan<VkSparseImageFormatProperties2> properties = new VkSparseImageFormatProperties2[propertyCount];
			fixed (VkSparseImageFormatProperties2* propertiesPtr = properties)
			{
				vkGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, formatInfo, &propertyCount, propertiesPtr);
			}

			return properties;
		}

		public static ReadOnlySpan<VkSurfaceFormatKHR> vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface)
		{
			uint surfaceFormatCount = 0;
			vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface, &surfaceFormatCount, null).CheckResult();

			ReadOnlySpan<VkSurfaceFormatKHR> surfaceFormats = new VkSurfaceFormatKHR[surfaceFormatCount];
			fixed (VkSurfaceFormatKHR* surfaceFormatsPtr = surfaceFormats)
			{
				vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface, &surfaceFormatCount, surfaceFormatsPtr).CheckResult();
			}

			return surfaceFormats;
		}

		public static ReadOnlySpan<VkPresentModeKHR> vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface)
		{
			uint presentModeCount = 0;
			vkGetPhysicalDeviceSurfacePresentModesKHR(physicalDevice, surface, &presentModeCount, null).CheckResult();

			ReadOnlySpan<VkPresentModeKHR> presentModes = new VkPresentModeKHR[presentModeCount];
			fixed (VkPresentModeKHR* presentModesPtr = presentModes)
			{
				vkGetPhysicalDeviceSurfacePresentModesKHR(physicalDevice, surface, &presentModeCount, presentModesPtr).CheckResult();
			}

			return presentModes;
		}

		public static ReadOnlySpan<VkImage> vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain)
		{
			uint swapchainImageCount = 0;
			vkGetSwapchainImagesKHR(device, swapchain, &swapchainImageCount, null).CheckResult();

			ReadOnlySpan<VkImage> swapchainImages = new VkImage[swapchainImageCount];
			fixed (VkImage* swapchainImagesPtr = swapchainImages)
			{
				vkGetSwapchainImagesKHR(device, swapchain, &swapchainImageCount, swapchainImagesPtr).CheckResult();
			}

			return swapchainImages;
		}

		public static ReadOnlySpan<VkRect2D> vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface)
		{
			uint rectCount = 0;
			vkGetPhysicalDevicePresentRectanglesKHR(physicalDevice, surface, &rectCount, null).CheckResult();

			ReadOnlySpan<VkRect2D> rects = new VkRect2D[rectCount];
			fixed (VkRect2D* rectsPtr = rects)
			{
				vkGetPhysicalDevicePresentRectanglesKHR(physicalDevice, surface, &rectCount, rectsPtr).CheckResult();
			}

			return rects;
		}

		public static ReadOnlySpan<VkDisplayPropertiesKHR> vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice)
		{
			uint propertyCount = 0;
			vkGetPhysicalDeviceDisplayPropertiesKHR(physicalDevice, &propertyCount, null).CheckResult();

			ReadOnlySpan<VkDisplayPropertiesKHR> properties = new VkDisplayPropertiesKHR[propertyCount];
			fixed (VkDisplayPropertiesKHR* propertiesPtr = properties)
			{
				vkGetPhysicalDeviceDisplayPropertiesKHR(physicalDevice, &propertyCount, propertiesPtr).CheckResult();
			}

			return properties;
		}

		public static ReadOnlySpan<VkDisplayPlanePropertiesKHR> vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice)
		{
			uint propertyCount = 0;
			vkGetPhysicalDeviceDisplayPlanePropertiesKHR(physicalDevice, &propertyCount, null).CheckResult();

			ReadOnlySpan<VkDisplayPlanePropertiesKHR> properties = new VkDisplayPlanePropertiesKHR[propertyCount];
			fixed (VkDisplayPlanePropertiesKHR* propertiesPtr = properties)
			{
				vkGetPhysicalDeviceDisplayPlanePropertiesKHR(physicalDevice, &propertyCount, propertiesPtr).CheckResult();
			}

			return properties;
		}

		public static ReadOnlySpan<VkDisplayKHR> vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex)
		{
			uint displayCount = 0;
			vkGetDisplayPlaneSupportedDisplaysKHR(physicalDevice, planeIndex, &displayCount, null).CheckResult();

			ReadOnlySpan<VkDisplayKHR> displays = new VkDisplayKHR[displayCount];
			fixed (VkDisplayKHR* displaysPtr = displays)
			{
				vkGetDisplayPlaneSupportedDisplaysKHR(physicalDevice, planeIndex, &displayCount, displaysPtr).CheckResult();
			}

			return displays;
		}

		public static ReadOnlySpan<VkDisplayModePropertiesKHR> vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
		{
			uint propertyCount = 0;
			vkGetDisplayModePropertiesKHR(physicalDevice, display, &propertyCount, null).CheckResult();

			ReadOnlySpan<VkDisplayModePropertiesKHR> properties = new VkDisplayModePropertiesKHR[propertyCount];
			fixed (VkDisplayModePropertiesKHR* propertiesPtr = properties)
			{
				vkGetDisplayModePropertiesKHR(physicalDevice, display, &propertyCount, propertiesPtr).CheckResult();
			}

			return properties;
		}

		public static ReadOnlySpan<VkQueueFamilyProperties2> vkGetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice)
		{
			uint queueFamilyPropertyCount = 0;
			vkGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, &queueFamilyPropertyCount, null);

			ReadOnlySpan<VkQueueFamilyProperties2> queueFamilyProperties = new VkQueueFamilyProperties2[queueFamilyPropertyCount];
			fixed (VkQueueFamilyProperties2* queueFamilyPropertiesPtr = queueFamilyProperties)
			{
				vkGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, &queueFamilyPropertyCount, queueFamilyPropertiesPtr);
			}

			return queueFamilyProperties;
		}

		public static ReadOnlySpan<VkSparseImageFormatProperties2> vkGetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo)
		{
			uint propertyCount = 0;
			vkGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, formatInfo, &propertyCount, null);

			ReadOnlySpan<VkSparseImageFormatProperties2> properties = new VkSparseImageFormatProperties2[propertyCount];
			fixed (VkSparseImageFormatProperties2* propertiesPtr = properties)
			{
				vkGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, formatInfo, &propertyCount, propertiesPtr);
			}

			return properties;
		}

		public static ReadOnlySpan<VkPhysicalDeviceGroupProperties> vkEnumeratePhysicalDeviceGroups(VkInstance instance)
		{
			uint physicalDeviceGroupCount = 0;
			vkEnumeratePhysicalDeviceGroups(instance, &physicalDeviceGroupCount, null).CheckResult();

			ReadOnlySpan<VkPhysicalDeviceGroupProperties> physicalDeviceGroupProperties = new VkPhysicalDeviceGroupProperties[physicalDeviceGroupCount];
			fixed (VkPhysicalDeviceGroupProperties* physicalDeviceGroupPropertiesPtr = physicalDeviceGroupProperties)
			{
				vkEnumeratePhysicalDeviceGroups(instance, &physicalDeviceGroupCount, physicalDeviceGroupPropertiesPtr).CheckResult();
			}

			return physicalDeviceGroupProperties;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct VkAllocationCallbacks
	{
		public unsafe void* pUserData;
		public unsafe delegate* unmanaged<IntPtr, nuint, nuint, VkSystemAllocationScope, IntPtr> pfnAllocation;
		public unsafe delegate* unmanaged<IntPtr, IntPtr, nuint, nuint, VkSystemAllocationScope, void> pfnReallocation;
		public unsafe delegate* unmanaged<IntPtr, IntPtr, void> pfnFree;
		public unsafe delegate* unmanaged<IntPtr, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnuinternalAllocation;
		public unsafe delegate* unmanaged<IntPtr, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnuinternalFree;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct VkDebugReportCallbackCreateInfoEXT
	{
		public VkStructureType sType;
		public unsafe void* pNext;
		public VkDebugReportFlagsEXT flags;
		public unsafe delegate* unmanaged<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, char*, char*, void*, VkBool32> pfnCallback;
		public unsafe void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct VkDebugUtilsMessengerCreateInfoEXT
	{
		public VkStructureType sType;
		public unsafe void* pNext;
		public VkDebugUtilsMessengerCreateFlagsEXT flags;
		public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
		public VkDebugUtilsMessageTypeFlagsEXT messageType;
		public unsafe delegate* unmanaged<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, VkBool32 > pfnUserCallback;
		public unsafe void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct VkDeviceDeviceMemoryReportCreateInfoEXT
	{
		public VkStructureType sType;
		public unsafe void* pNext;
		public VkDeviceMemoryReportFlagsEXT flags;
		public unsafe delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void> pfnUserCallback;
		public unsafe void* pUserData;
	}

	public partial struct VkExtensionProperties
	{
		public unsafe string ExtensionName
		{
			get
			{
				fixed (byte* ptr = extensionName) return VulkanUtility.GetString(ptr);
			}
		}
	}

	public partial struct VkLayerProperties
	{
		public unsafe string LayerName
		{
			get
			{
				fixed (byte* ptr = layerName) return VulkanUtility.GetString(ptr);
			}
		}

		public unsafe string Description
		{
			get
			{
				fixed (byte* ptr = description) return VulkanUtility.GetString(ptr);
			}
		}
	}
}