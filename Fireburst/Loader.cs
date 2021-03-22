using System;
using System.Runtime.InteropServices;

namespace Fireburst
{
	public static unsafe partial class Vulkan
	{
		private static IntPtr VulkanLibrary = IntPtr.Zero;

		public static VkResult vkInitialize()
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				VulkanLibrary = NativeLibrary.Load("vulkan-1.dll");
				if (VulkanLibrary == IntPtr.Zero) return VkResult.ErrorInitializationFailed;

				vkGetInstanceProcAddr_ptr = (delegate* unmanaged<VkInstance, byte*, IntPtr>)NativeLibrary.GetExport(VulkanLibrary, nameof(vkGetInstanceProcAddr));
			}
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			{
				VulkanLibrary = NativeLibrary.Load("libvulkan.dylib");
				if (VulkanLibrary == IntPtr.Zero) VulkanLibrary = NativeLibrary.Load("libvulkan.1.dylib");
				if (VulkanLibrary == IntPtr.Zero) VulkanLibrary = NativeLibrary.Load("libMoltenVK.dylib");
				if (VulkanLibrary == IntPtr.Zero) return VkResult.ErrorInitializationFailed;

				vkGetInstanceProcAddr_ptr = (delegate* unmanaged<VkInstance, byte*, IntPtr>)NativeLibrary.GetExport(VulkanLibrary, nameof(vkGetInstanceProcAddr));
			}
			else
			{
				VulkanLibrary = NativeLibrary.Load("libvulkan.so.1");
				if (VulkanLibrary == IntPtr.Zero) VulkanLibrary = NativeLibrary.Load("libvulkan.so");
				if (VulkanLibrary == IntPtr.Zero) return VkResult.ErrorInitializationFailed;

				vkGetInstanceProcAddr_ptr = (delegate* unmanaged<VkInstance, byte*, IntPtr>)NativeLibrary.GetExport(VulkanLibrary, nameof(vkGetInstanceProcAddr));
			}

			GenLoadLoader(VkInstance.Null, vkGetInstanceProcAddr);

			return VkResult.Success;
		}

		private delegate delegate* unmanaged<void> LoadFunction(VkInstance context, string name);

		private static void GenLoadLoader(VkInstance context, LoadFunction load)
		{
			vkCreateInstance_ptr = (delegate* unmanaged<VkInstanceCreateInfo*, VkAllocationCallbacks*, VkInstance*, VkResult>)load(context, "vkCreateInstance");
			vkEnumerateInstanceExtensionProperties_ptr = (delegate* unmanaged<byte*, uint*, VkExtensionProperties*, VkResult>)load(context, "vkEnumerateInstanceExtensionProperties");
			vkEnumerateInstanceLayerProperties_ptr = (delegate* unmanaged<uint*, VkLayerProperties*, VkResult>)load(context, "vkEnumerateInstanceLayerProperties");
			vkEnumerateInstanceVersion_ptr = (delegate* unmanaged<uint*, VkResult>)load(context, "vkEnumerateInstanceVersion");
		}
	}
}