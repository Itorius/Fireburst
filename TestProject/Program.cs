using System;
using Fireburst;

namespace TestProject
{
	public static unsafe class Program
	{
		public static void Main(string[] args)
		{
			Vulkan.vkInitialize();

			VkApplicationInfo appInfo = new();
			appInfo.sType = VkStructureType.ApplicationInfo;
			appInfo.pApplicationName = new VkString("Hello Triangle");
			appInfo.applicationVersion = new VkVersion(1, 0, 0);
			appInfo.pEngineName = new VkString("No Engine");
			appInfo.engineVersion = new VkVersion(1, 0, 0);
			appInfo.apiVersion = VkVersion.Version_1_0;

			VkInstanceCreateInfo info = new VkInstanceCreateInfo();
			info.sType = VkStructureType.InstanceCreateInfo;
			info.flags = VkInstanceCreateFlags.None;
			info.pApplicationInfo = &appInfo;

			// uint32_t glfwExtensionCount = 0;
			// const char** glfwExtensions;
			//
			// glfwExtensions = glfwGetRequiredInstanceExtensions(&glfwExtensionCount);
			//
			// info.enabledExtensionCount = glfwExtensionCount;
			// info.ppEnabledExtensionNames = glfwExtensions;

			VkInstance instance = VkInstance.Null;
			Vulkan.vkCreateInstance(&info, null, &instance);

			Vulkan.vkLoadInstance(instance);

			VkVersion version = new VkVersion();
			Vulkan.vkEnumerateInstanceVersion((uint*)&version);
			
			var extensionProp = Vulkan.vkEnumerateInstanceExtensionProperties();
			foreach (VkExtensionProperties properties in extensionProp)
			{
				if (properties.extensionName == null) continue;

				Console.WriteLine(VulkanUtility.GetString(properties.extensionName));
			}
		}
	}
}