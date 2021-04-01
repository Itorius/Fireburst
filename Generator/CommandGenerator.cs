using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FireburstGenerator
{
	public class CommandGenerator : IGenerator
	{
		public int Priority() => -1000;

		private static readonly HashSet<string> IgnoredLoads = new()
		{
			"vkGetInstanceProcAddr",
			"vkCreateInstance",
			"vkEnumerateInstanceExtensionProperties",
			"vkEnumerateInstanceLayerProperties",
			"vkEnumerateInstanceVersion"
		};

		private static readonly HashSet<string> OutReturnFunctions = new()
		{
			"vkCreateInstance",
			"vkCreateDevice",
			"vkGetPhysicalDeviceFeatures",
			"vkGetPhysicalDeviceFormatProperties",
			"vkGetPhysicalDeviceImageFormatProperties",
			"vkGetPhysicalDeviceProperties",
			"vkGetPhysicalDeviceMemoryProperties",
			"vkGetDeviceQueue",
			"vkGetDeviceMemoryCommitment",
			"vkGetBufferMemoryRequirements",
			"vkGetImageMemoryRequirements",
			"vkAllocateMemory",
			"vkCreateAndroidSurfaceKHR",
			"vkCreateWin32SurfaceKHR",
			"vkCreateXlibSurfaceKHR",
			"vkCreateWaylandSurfaceKHR",
			"vkCreateMetalSurfaceEXT",
			"vkCreateIOSSurfaceMVK",
			"vkCreateMacOSSurfaceMVK",
			"vkCreateFence",
			"vkCreateSemaphore",
			"vkCreateEvent",
			"vkCreateQueryPool",
			"vkCreateBuffer",
			"vkCreateBufferView",
			"vkCreateImage",
			"vkGetImageSubresourceLayout",
			"vkCreateImageView",
			"vkCreateShaderModule",
			"vkCreatePipelineCache",
			//"vkCreateGraphicsPipelines",
			//"vkCreateComputePipelines",
			"vkCreatePipelineLayout",
			"vkCreateSampler",
			"vkCreateDescriptorSetLayout",
			"vkCreateDescriptorPool",
			//"vkAllocateDescriptorSets",
			"vkCreateFramebuffer",
			"vkCreateRenderPass",
			"vkGetRenderAreaGranularity",
			"vkCreateCommandPool",
			//"vkAllocateCommandBuffers",

			"vkEnumerateInstanceVersion",
			"vkGetDeviceGroupPeerMemoryFeaturesKHR",
			"vkGetImageMemoryRequirements2",
			"vkGetBufferMemoryRequirements2",
			"vkGetPhysicalDeviceFeatures2",
			"vkGetPhysicalDeviceProperties2",
			"vkGetPhysicalDeviceFormatProperties2",
			"vkGetPhysicalDeviceImageFormatProperties2",
			"vkGetPhysicalDeviceMemoryProperties2",
			"vkGetDeviceQueue2",
			"vkCreateSamplerYcbcrConversion",
			"vkCreateDescriptorUpdateTemplate",
			"vkGetPhysicalDeviceExternalBufferProperties",
			"vkGetPhysicalDeviceExternalFenceProperties",
			"vkGetPhysicalDeviceExternalSemaphoreProperties",
			"vkGetDescriptorSetLayoutSupport",
			"vkCreateRenderPass2",
			"vkGetPhysicalDeviceSurfaceSupportKHR",
			"vkGetPhysicalDeviceSurfaceCapabilitiesKHR",

			"vkCreateSwapchainKHR",
			"vkAcquireNextImageKHR",
			"vkGetDeviceGroupPresentCapabilitiesKHR",
			"vkGetDeviceGroupSurfacePresentModesKHR",
			"vkAcquireNextImage2KHR",

			"vkCreateDisplayModeKHR",
			"vkGetDisplayPlaneCapabilitiesKHR",
			"vkCreateDisplayPlaneSurfaceKHR",
			"vkCreateSharedSwapchainsKHR",

			"vkGetPhysicalDeviceFeatures2KHR",
			"vkGetPhysicalDeviceProperties2KHR",
			"vkGetPhysicalDeviceFormatProperties2KHR",
			"vkGetPhysicalDeviceImageFormatProperties2KHR",
			"vkGetPhysicalDeviceMemoryProperties2KHR",
			"vkGetDeviceGroupPeerMemoryFeaturesKHR",
			"vkGetPhysicalDeviceExternalBufferPropertiesKHR",
			//"vkGetMemoryFdKHR",
			//"vkGetMemoryFdPropertiesKHR",
			"vkGetPhysicalDeviceExternalSemaphorePropertiesKHR",
			//"vkGetSemaphoreFdKHR",

			"vkCreateDebugUtilsMessengerEXT"
		};

		// todo: automatically take addresses of parameters

		public void Generate(Registry registry, string outputDir)
		{
			CodeWriter writer = new("Fireburst", "System");
			writer.WriteLine("public static unsafe partial class Vulkan");
			writer.WriteLine("{");
			writer.Indent();

			CodeWriter loaderWriter = new("Fireburst", "System");
			loaderWriter.WriteLine("public static unsafe partial class Vulkan");
			loaderWriter.WriteLine("{");
			loaderWriter.Indent();
			loaderWriter.WriteLine("private static void LoadCommands(VkInstance instance, LoadFunction load)");
			loaderWriter.WriteLine("{");
			loaderWriter.Indent();

			foreach (Command command in registry.Commands.Command)
			{
				if (command.Alias != null) continue;

				List<(string type, string name, bool isOut, bool isOptional)> parameters = new();

				int i = 0;
				foreach (Param param in command.Param)
				{
					param.Name = param.Name switch
					{
						"object" => "@object",
						"event" => "@event",
						_ => param.Name
					};

					int count = 0;
					foreach (char c in param.Name)
					{
						if (c == 'p') count++;
						else
						{
							if (char.IsLower(c)) count = 0;
							break;
						}
					}

					bool optional = param.Optional != null && param.Optional == "true";

					if (i == command.Param.Count - 1 && OutReturnFunctions.Contains(command.Proto.Name)) parameters.Add((Utility.ResolveType(param.Type), param.Name, true, optional));
					else parameters.Add((Utility.ResolveType(param.Type) + new string('*', count), param.Name, false, optional));

					i++;
				}

				string returnType = Utility.ResolveType(command.Proto.Type);
				string funcPtrType = $"delegate* unmanaged<{parameters.Select(x => (x.isOut ? "out " : "") + x.type).JoinStrings()}, {returnType}>";
				string name = command.Proto.Name;

				writer.WriteLine($"internal static {funcPtrType} {name}_ptr;");
				writer.WriteLine();
				writer.WriteLine(@$"public static {returnType} {name}({parameters.Select((x, i) => new { x, index = i }).OrderBy(x => x.x.isOptional).ThenBy(x => x.index)
					.Select(x => (x.x.isOut ? "out " : "") + (x.x.type.Contains("CreateInfo") ? x.x.type[..^1] : x.x.type) + " " + x.x.name + (x.x.isOptional ? " = default" : "")).JoinStrings()})");
				writer.WriteLine("{");
				writer.Indent();
				if (returnType != "void") writer.WriteLine($"return {name}_ptr({parameters.Select(x => (x.isOut ? "out " : "") + (x.type.Contains("CreateInfo") ? "&" : "") + x.name).JoinStrings()});");
				else writer.WriteLine($"{name}_ptr({parameters.Select(x => (x.isOut ? "out " : "")+ (x.type.Contains("CreateInfo") ? "&" : "") + x.name).JoinStrings()});");
				writer.Unindent();
				writer.WriteLine("}");
				writer.WriteLine();

				if (!IgnoredLoads.Contains(name)) loaderWriter.WriteLine($"{name}_ptr = ({funcPtrType})load(instance, nameof({name}));");
			}

			writer.Unindent();
			writer.WriteLine("}");

			loaderWriter.Unindent();
			loaderWriter.WriteLine("}");
			loaderWriter.Unindent();
			loaderWriter.WriteLine("}");

			File.WriteAllText(outputDir + "Vulkan.Commands.cs", writer.ToString());
			File.WriteAllText(outputDir + "Vulkan.Loader.cs", loaderWriter.ToString());
		}
	}
}