using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Fireburst;

public static unsafe class VMA
{
	private static IntPtr VMALibrary = IntPtr.Zero;
	public static VmaVulkanFunctions Functions;

	public static VkResult vmaInitialize(VkInstance instance)
	{
		if (instance == VkInstance.Null) throw new Exception("VMA requires a valid Vulkan instance");

		VMALibrary = NativeLibrary.Load("vk_mem_alloc.so", Assembly.GetCallingAssembly(), DllImportSearchPath.AssemblyDirectory);
		if (VMALibrary == IntPtr.Zero) return VkResult.ErrorInitializationFailed;

		foreach (FieldInfo info in typeof(VMA).GetFields(BindingFlags.NonPublic | BindingFlags.Static).Where(info => info.FieldType == typeof(IntPtr) && info.Name.EndsWith("_ptr")))
		{
			var export = NativeLibrary.GetExport(VMALibrary, info.Name[..^4]);
			info.SetValue(null, export);
		}

		Functions = new VmaVulkanFunctions
		{
			vkGetPhysicalDeviceProperties = (IntPtr)Vulkan.vkGetPhysicalDeviceProperties_ptr,
			vkGetPhysicalDeviceMemoryProperties = (IntPtr)Vulkan.vkGetPhysicalDeviceMemoryProperties_ptr,
			vkAllocateMemory = (IntPtr)Vulkan.vkAllocateMemory_ptr,
			vkFreeMemory = (IntPtr)Vulkan.vkFreeMemory_ptr,
			vkMapMemory = (IntPtr)Vulkan.vkMapMemory_ptr,
			vkUnmapMemory = (IntPtr)Vulkan.vkUnmapMemory_ptr,
			vkFlushMappedMemoryRanges = (IntPtr)Vulkan.vkFlushMappedMemoryRanges_ptr,
			vkInvalidateMappedMemoryRanges = (IntPtr)Vulkan.vkInvalidateMappedMemoryRanges_ptr,
			vkBindBufferMemory = (IntPtr)Vulkan.vkBindBufferMemory_ptr,
			vkBindImageMemory = (IntPtr)Vulkan.vkBindImageMemory_ptr,
			vkGetBufferMemoryRequirements = (IntPtr)Vulkan.vkGetBufferMemoryRequirements_ptr,
			vkGetImageMemoryRequirements = (IntPtr)Vulkan.vkGetImageMemoryRequirements_ptr,
			vkCreateBuffer = (IntPtr)Vulkan.vkCreateBuffer_ptr,
			vkDestroyBuffer = (IntPtr)Vulkan.vkDestroyBuffer_ptr,
			vkCreateImage = (IntPtr)Vulkan.vkCreateImage_ptr,
			vkDestroyImage = (IntPtr)Vulkan.vkDestroyImage_ptr,
			vkCmdCopyBuffer = (IntPtr)Vulkan.vkCmdCopyBuffer_ptr,
			vkGetBufferMemoryRequirements2KHR = (IntPtr)Vulkan.vkGetBufferMemoryRequirements2_ptr,
			vkGetImageMemoryRequirements2KHR = (IntPtr)Vulkan.vkGetImageMemoryRequirements2_ptr,
			vkBindBufferMemory2KHR = (IntPtr)Vulkan.vkBindBufferMemory2_ptr,
			vkBindImageMemory2KHR = (IntPtr)Vulkan.vkBindImageMemory2_ptr,
			vkGetPhysicalDeviceMemoryProperties2KHR = (IntPtr)Vulkan.vkGetPhysicalDeviceMemoryProperties2_ptr
		};

		return VkResult.Success;
	}

	internal static delegate* unmanaged<VmaAllocatorCreateInfo*, out VmaAllocator, VkResult> vmaCreateAllocator_ptr;

	public static VkResult vmaCreateAllocator(VmaAllocatorCreateInfo pCreateInfo, out VmaAllocator allocator)
	{
		fixed (VmaVulkanFunctions* ptr = &Functions) pCreateInfo.pVulkanFunctions = (IntPtr)ptr;
		return vmaCreateAllocator_ptr(&pCreateInfo, out allocator);
	}

	internal static delegate* unmanaged<VmaAllocator, VkBufferCreateInfo*, VmaAllocationCreateInfo*, out VkBuffer, out VmaAllocation, out VmaAllocationInfo, VkResult> vmaCreateBuffer_ptr;

	public static VkResult vmaCreateBuffer(VmaAllocator allocator, VkBufferCreateInfo pBufferCreateInfo, VmaAllocationCreateInfo pAllocationCreateInfo, out VkBuffer pBuffer, out VmaAllocation pAllocation, out VmaAllocationInfo pAllocationInfo)
	{
		return vmaCreateBuffer_ptr(allocator, &pBufferCreateInfo, &pAllocationCreateInfo, out pBuffer, out pAllocation, out pAllocationInfo);
	}

	internal static delegate* unmanaged<VmaAllocator, VkBuffer, VmaAllocation, void> vmaDestroyBuffer_ptr;

	public static void vmaDestroyBuffer(VmaAllocator allocator, VkBuffer buffer, VmaAllocation allocation)
	{
		vmaDestroyBuffer_ptr(allocator, buffer, allocation);
	}

	internal static delegate* unmanaged<VmaAllocator, VkImageCreateInfo*, VmaAllocationCreateInfo*, out VkImage, out VmaAllocation, out VmaAllocationInfo, VkResult> vmaCreateImage_ptr;

	public static VkResult vmaCreateImage(VmaAllocator allocator, VkImageCreateInfo pImageCreateInfo, VmaAllocationCreateInfo pAllocationCreateInfo, out VkImage pImage, out VmaAllocation pAllocation, out VmaAllocationInfo pAllocationInfo)
	{
		return vmaCreateImage_ptr(allocator, &pImageCreateInfo, &pAllocationCreateInfo, out pImage, out pAllocation, out pAllocationInfo);
	}

	internal static delegate* unmanaged<VmaAllocator, VkImage, VmaAllocation, void> vmaDestroyImage_ptr;

	public static void vmaDestroyImage(VmaAllocator allocator, VkImage image, VmaAllocation allocation)
	{
		vmaDestroyImage_ptr(allocator, image, allocation);
	}

	internal static delegate* unmanaged<VmaAllocator, void> vmaDestroyAllocator_ptr;

	public static void vmaDestroyAllocator(VmaAllocator allocator)
	{
		vmaDestroyAllocator_ptr(allocator);
	}

	internal static delegate* unmanaged<VmaAllocator, VmaAllocation, void> vmaFreeMemory_ptr;

	public static void vmaFreeMemory(VmaAllocator allocator, VmaAllocation allocation)
	{
		vmaFreeMemory_ptr(allocator, allocation);
	}

	internal static delegate* unmanaged<VmaAllocator, VmaAllocation, void**, void> vmaMapMemory_ptr;

	public static void vmaMapMemory(VmaAllocator allocator, VmaAllocation allocation, void** memory)
	{
		vmaMapMemory_ptr(allocator, allocation, memory);
	}

	internal static delegate* unmanaged<VmaAllocator, VmaAllocation, void> vmaUnmapMemory_ptr;

	public static void vmaUnmapMemory(VmaAllocator allocator, VmaAllocation allocation)
	{
		vmaUnmapMemory_ptr(allocator, allocation);
	}
}