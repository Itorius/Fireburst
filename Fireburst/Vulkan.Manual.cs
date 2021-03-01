using System;
using System.Runtime.InteropServices;

namespace Fireburst
{
	public static class p
	{
		public static readonly unsafe delegate* managed<VkInstanceCreateInfo*, VkAllocationCallbacks*, VkInstance*, VkResult> d;
		
		public static unsafe VkResult vkCreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)
		{
			return d(pCreateInfo, pAllocator, pInstance);
		}
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct VkAllocationCallbacks
	{
		public unsafe void* pUserData;
		public unsafe delegate* managed<IntPtr, VkPointerSize, VkPointerSize, VkSystemAllocationScope, IntPtr> pfnAllocation;
		public unsafe delegate* managed<IntPtr, IntPtr, VkPointerSize, VkPointerSize, VkSystemAllocationScope, void> pfnReallocation;
		public unsafe delegate* managed<IntPtr, IntPtr, void> pfnFree;
		public unsafe delegate* managed<IntPtr, VkPointerSize, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalAllocation;
		public unsafe delegate* managed<IntPtr, VkPointerSize, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalFree;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct VkDebugReportCallbackCreateInfoEXT
	{
		public VkStructureType sType;
		public unsafe void* pNext;
		public VkDebugReportFlagsEXT flags;
		public unsafe delegate* managed<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, VkPointerSize, int, char*, char*, void*, VkBool32> pfnCallback;
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
		public unsafe delegate* managed<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, VkBool32 > pfnUserCallback;
		public unsafe void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct VkDeviceDeviceMemoryReportCreateInfoEXT
	{
		public VkStructureType sType;
		public unsafe void* pNext;
		public VkDeviceMemoryReportFlagsEXT flags;
		public unsafe delegate* managed<VkDeviceMemoryReportCallbackDataEXT*, void*, void> pfnUserCallback;
		public unsafe void* pUserData;
	}
}