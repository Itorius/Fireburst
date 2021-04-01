using System;

namespace Fireburst
{
	public static unsafe partial class Vulkan
	{
		internal static delegate* unmanaged<VkInstanceCreateInfo*, VkAllocationCallbacks*, out VkInstance, VkResult> vkCreateInstance_ptr;

		public static VkResult vkCreateInstance(VkInstanceCreateInfo pCreateInfo, out VkInstance pInstance, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateInstance_ptr(&pCreateInfo, pAllocator, out pInstance);
		}

		internal static delegate* unmanaged<VkInstance, VkAllocationCallbacks*, void> vkDestroyInstance_ptr;

		public static void vkDestroyInstance(VkInstance instance = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyInstance_ptr(instance, pAllocator);
		}

		internal static delegate* unmanaged<VkInstance, uint*, VkPhysicalDevice*, VkResult> vkEnumeratePhysicalDevices_ptr;

		public static VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices = default)
		{
			return vkEnumeratePhysicalDevices_ptr(instance, pPhysicalDeviceCount, pPhysicalDevices);
		}

		internal static delegate* unmanaged<VkDevice, byte*, IntPtr> vkGetDeviceProcAddr_ptr;

		public static IntPtr vkGetDeviceProcAddr(VkDevice device, byte* pName)
		{
			return vkGetDeviceProcAddr_ptr(device, pName);
		}

		internal static delegate* unmanaged<VkInstance, byte*, IntPtr> vkGetInstanceProcAddr_ptr;

		public static IntPtr vkGetInstanceProcAddr(byte* pName, VkInstance instance = default)
		{
			return vkGetInstanceProcAddr_ptr(instance, pName);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, out VkPhysicalDeviceProperties, void> vkGetPhysicalDeviceProperties_ptr;

		public static void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties pProperties)
		{
			vkGetPhysicalDeviceProperties_ptr(physicalDevice, out pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties*, void> vkGetPhysicalDeviceQueueFamilyProperties_ptr;

		public static void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties = default)
		{
			vkGetPhysicalDeviceQueueFamilyProperties_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, out VkPhysicalDeviceMemoryProperties, void> vkGetPhysicalDeviceMemoryProperties_ptr;

		public static void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties pMemoryProperties)
		{
			vkGetPhysicalDeviceMemoryProperties_ptr(physicalDevice, out pMemoryProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, out VkPhysicalDeviceFeatures, void> vkGetPhysicalDeviceFeatures_ptr;

		public static void vkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures pFeatures)
		{
			vkGetPhysicalDeviceFeatures_ptr(physicalDevice, out pFeatures);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkFormat, out VkFormatProperties, void> vkGetPhysicalDeviceFormatProperties_ptr;

		public static void vkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties pFormatProperties)
		{
			vkGetPhysicalDeviceFormatProperties_ptr(physicalDevice, format, out pFormatProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, out VkImageFormatProperties, VkResult> vkGetPhysicalDeviceImageFormatProperties_ptr;

		public static VkResult vkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, out VkImageFormatProperties pImageFormatProperties, VkImageCreateFlags flags = default)
		{
			return vkGetPhysicalDeviceImageFormatProperties_ptr(physicalDevice, format, type, tiling, usage, flags, out pImageFormatProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkDeviceCreateInfo*, VkAllocationCallbacks*, out VkDevice, VkResult> vkCreateDevice_ptr;

		public static VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo pCreateInfo, out VkDevice pDevice, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDevice_ptr(physicalDevice, &pCreateInfo, pAllocator, out pDevice);
		}

		internal static delegate* unmanaged<VkDevice, VkAllocationCallbacks*, void> vkDestroyDevice_ptr;

		public static void vkDestroyDevice(VkDevice device = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyDevice_ptr(device, pAllocator);
		}

		internal static delegate* unmanaged<out uint, VkResult> vkEnumerateInstanceVersion_ptr;

		public static VkResult vkEnumerateInstanceVersion(out uint pApiVersion)
		{
			return vkEnumerateInstanceVersion_ptr(out pApiVersion);
		}

		internal static delegate* unmanaged<uint*, VkLayerProperties*, VkResult> vkEnumerateInstanceLayerProperties_ptr;

		public static VkResult vkEnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties = default)
		{
			return vkEnumerateInstanceLayerProperties_ptr(pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<byte*, uint*, VkExtensionProperties*, VkResult> vkEnumerateInstanceExtensionProperties_ptr;

		public static VkResult vkEnumerateInstanceExtensionProperties(uint* pPropertyCount, byte* pLayerName = default, VkExtensionProperties* pProperties = default)
		{
			return vkEnumerateInstanceExtensionProperties_ptr(pLayerName, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkLayerProperties*, VkResult> vkEnumerateDeviceLayerProperties_ptr;

		public static VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties = default)
		{
			return vkEnumerateDeviceLayerProperties_ptr(physicalDevice, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, byte*, uint*, VkExtensionProperties*, VkResult> vkEnumerateDeviceExtensionProperties_ptr;

		public static VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, byte* pLayerName = default, VkExtensionProperties* pProperties = default)
		{
			return vkEnumerateDeviceExtensionProperties_ptr(physicalDevice, pLayerName, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkDevice, uint, uint, out VkQueue, void> vkGetDeviceQueue_ptr;

		public static void vkGetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, out VkQueue pQueue)
		{
			vkGetDeviceQueue_ptr(device, queueFamilyIndex, queueIndex, out pQueue);
		}

		internal static delegate* unmanaged<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult> vkQueueSubmit_ptr;

		public static VkResult vkQueueSubmit(VkQueue queue, VkSubmitInfo* pSubmits, uint submitCount = default, VkFence fence = default)
		{
			return vkQueueSubmit_ptr(queue, submitCount, pSubmits, fence);
		}

		internal static delegate* unmanaged<VkQueue, VkResult> vkQueueWaitIdle_ptr;

		public static VkResult vkQueueWaitIdle(VkQueue queue)
		{
			return vkQueueWaitIdle_ptr(queue);
		}

		internal static delegate* unmanaged<VkDevice, VkResult> vkDeviceWaitIdle_ptr;

		public static VkResult vkDeviceWaitIdle(VkDevice device)
		{
			return vkDeviceWaitIdle_ptr(device);
		}

		internal static delegate* unmanaged<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, out VkDeviceMemory, VkResult> vkAllocateMemory_ptr;

		public static VkResult vkAllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, out VkDeviceMemory pMemory, VkAllocationCallbacks* pAllocator = default)
		{
			return vkAllocateMemory_ptr(device, pAllocateInfo, pAllocator, out pMemory);
		}

		internal static delegate* unmanaged<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> vkFreeMemory_ptr;

		public static void vkFreeMemory(VkDevice device, VkDeviceMemory memory = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkFreeMemory_ptr(device, memory, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlags, void**, VkResult> vkMapMemory_ptr;

		public static VkResult vkMapMemory(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, void** ppData, VkMemoryMapFlags flags = default)
		{
			return vkMapMemory_ptr(device, memory, offset, size, flags, ppData);
		}

		internal static delegate* unmanaged<VkDevice, VkDeviceMemory, void> vkUnmapMemory_ptr;

		public static void vkUnmapMemory(VkDevice device, VkDeviceMemory memory)
		{
			vkUnmapMemory_ptr(device, memory);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> vkFlushMappedMemoryRanges_ptr;

		public static VkResult vkFlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
		{
			return vkFlushMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> vkInvalidateMappedMemoryRanges_ptr;

		public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
		{
			return vkInvalidateMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);
		}

		internal static delegate* unmanaged<VkDevice, VkDeviceMemory, out ulong, void> vkGetDeviceMemoryCommitment_ptr;

		public static void vkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, out ulong pCommittedMemoryInBytes)
		{
			vkGetDeviceMemoryCommitment_ptr(device, memory, out pCommittedMemoryInBytes);
		}

		internal static delegate* unmanaged<VkDevice, VkBuffer, out VkMemoryRequirements, void> vkGetBufferMemoryRequirements_ptr;

		public static void vkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, out VkMemoryRequirements pMemoryRequirements)
		{
			vkGetBufferMemoryRequirements_ptr(device, buffer, out pMemoryRequirements);
		}

		internal static delegate* unmanaged<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult> vkBindBufferMemory_ptr;

		public static VkResult vkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
		{
			return vkBindBufferMemory_ptr(device, buffer, memory, memoryOffset);
		}

		internal static delegate* unmanaged<VkDevice, VkImage, out VkMemoryRequirements, void> vkGetImageMemoryRequirements_ptr;

		public static void vkGetImageMemoryRequirements(VkDevice device, VkImage image, out VkMemoryRequirements pMemoryRequirements)
		{
			vkGetImageMemoryRequirements_ptr(device, image, out pMemoryRequirements);
		}

		internal static delegate* unmanaged<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult> vkBindImageMemory_ptr;

		public static VkResult vkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
		{
			return vkBindImageMemory_ptr(device, image, memory, memoryOffset);
		}

		internal static delegate* unmanaged<VkDevice, VkImage, uint*, VkSparseImageMemoryRequirements*, void> vkGetImageSparseMemoryRequirements_ptr;

		public static void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements = default)
		{
			vkGetImageSparseMemoryRequirements_ptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlags, VkImageUsageFlags, VkImageTiling, uint*, VkSparseImageFormatProperties*, void> vkGetPhysicalDeviceSparseImageFormatProperties_ptr;

		public static void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties = default)
		{
			vkGetPhysicalDeviceSparseImageFormatProperties_ptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult> vkQueueBindSparse_ptr;

		public static VkResult vkQueueBindSparse(VkQueue queue, VkBindSparseInfo* pBindInfo, uint bindInfoCount = default, VkFence fence = default)
		{
			return vkQueueBindSparse_ptr(queue, bindInfoCount, pBindInfo, fence);
		}

		internal static delegate* unmanaged<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, out VkFence, VkResult> vkCreateFence_ptr;

		public static VkResult vkCreateFence(VkDevice device, VkFenceCreateInfo pCreateInfo, out VkFence pFence, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateFence_ptr(device, &pCreateInfo, pAllocator, out pFence);
		}

		internal static delegate* unmanaged<VkDevice, VkFence, VkAllocationCallbacks*, void> vkDestroyFence_ptr;

		public static void vkDestroyFence(VkDevice device, VkFence fence = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyFence_ptr(device, fence, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkFence*, VkResult> vkResetFences_ptr;

		public static VkResult vkResetFences(VkDevice device, uint fenceCount, VkFence* pFences)
		{
			return vkResetFences_ptr(device, fenceCount, pFences);
		}

		internal static delegate* unmanaged<VkDevice, VkFence, VkResult> vkGetFenceStatus_ptr;

		public static VkResult vkGetFenceStatus(VkDevice device, VkFence fence)
		{
			return vkGetFenceStatus_ptr(device, fence);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkFence*, VkBool32, ulong, VkResult> vkWaitForFences_ptr;

		public static VkResult vkWaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout)
		{
			return vkWaitForFences_ptr(device, fenceCount, pFences, waitAll, timeout);
		}

		internal static delegate* unmanaged<VkDevice, VkSemaphoreCreateInfo*, VkAllocationCallbacks*, out VkSemaphore, VkResult> vkCreateSemaphore_ptr;

		public static VkResult vkCreateSemaphore(VkDevice device, VkSemaphoreCreateInfo pCreateInfo, out VkSemaphore pSemaphore, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateSemaphore_ptr(device, &pCreateInfo, pAllocator, out pSemaphore);
		}

		internal static delegate* unmanaged<VkDevice, VkSemaphore, VkAllocationCallbacks*, void> vkDestroySemaphore_ptr;

		public static void vkDestroySemaphore(VkDevice device, VkSemaphore semaphore = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroySemaphore_ptr(device, semaphore, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, out VkEvent, VkResult> vkCreateEvent_ptr;

		public static VkResult vkCreateEvent(VkDevice device, VkEventCreateInfo pCreateInfo, out VkEvent pEvent, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateEvent_ptr(device, &pCreateInfo, pAllocator, out pEvent);
		}

		internal static delegate* unmanaged<VkDevice, VkEvent, VkAllocationCallbacks*, void> vkDestroyEvent_ptr;

		public static void vkDestroyEvent(VkDevice device, VkEvent @event = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyEvent_ptr(device, @event, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkEvent, VkResult> vkGetEventStatus_ptr;

		public static VkResult vkGetEventStatus(VkDevice device, VkEvent @event)
		{
			return vkGetEventStatus_ptr(device, @event);
		}

		internal static delegate* unmanaged<VkDevice, VkEvent, VkResult> vkSetEvent_ptr;

		public static VkResult vkSetEvent(VkDevice device, VkEvent @event)
		{
			return vkSetEvent_ptr(device, @event);
		}

		internal static delegate* unmanaged<VkDevice, VkEvent, VkResult> vkResetEvent_ptr;

		public static VkResult vkResetEvent(VkDevice device, VkEvent @event)
		{
			return vkResetEvent_ptr(device, @event);
		}

		internal static delegate* unmanaged<VkDevice, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, out VkQueryPool, VkResult> vkCreateQueryPool_ptr;

		public static VkResult vkCreateQueryPool(VkDevice device, VkQueryPoolCreateInfo pCreateInfo, out VkQueryPool pQueryPool, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateQueryPool_ptr(device, &pCreateInfo, pAllocator, out pQueryPool);
		}

		internal static delegate* unmanaged<VkDevice, VkQueryPool, VkAllocationCallbacks*, void> vkDestroyQueryPool_ptr;

		public static void vkDestroyQueryPool(VkDevice device, VkQueryPool queryPool = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyQueryPool_ptr(device, queryPool, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, nuint, void*, ulong, VkQueryResultFlags, VkResult> vkGetQueryPoolResults_ptr;

		public static VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, ulong stride, VkQueryResultFlags flags = default)
		{
			return vkGetQueryPoolResults_ptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
		}

		internal static delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void> vkResetQueryPool_ptr;

		public static void vkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
		{
			vkResetQueryPool_ptr(device, queryPool, firstQuery, queryCount);
		}

		internal static delegate* unmanaged<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, out VkBuffer, VkResult> vkCreateBuffer_ptr;

		public static VkResult vkCreateBuffer(VkDevice device, VkBufferCreateInfo pCreateInfo, out VkBuffer pBuffer, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateBuffer_ptr(device, &pCreateInfo, pAllocator, out pBuffer);
		}

		internal static delegate* unmanaged<VkDevice, VkBuffer, VkAllocationCallbacks*, void> vkDestroyBuffer_ptr;

		public static void vkDestroyBuffer(VkDevice device, VkBuffer buffer = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyBuffer_ptr(device, buffer, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkBufferViewCreateInfo*, VkAllocationCallbacks*, out VkBufferView, VkResult> vkCreateBufferView_ptr;

		public static VkResult vkCreateBufferView(VkDevice device, VkBufferViewCreateInfo pCreateInfo, out VkBufferView pView, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateBufferView_ptr(device, &pCreateInfo, pAllocator, out pView);
		}

		internal static delegate* unmanaged<VkDevice, VkBufferView, VkAllocationCallbacks*, void> vkDestroyBufferView_ptr;

		public static void vkDestroyBufferView(VkDevice device, VkBufferView bufferView = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyBufferView_ptr(device, bufferView, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, out VkImage, VkResult> vkCreateImage_ptr;

		public static VkResult vkCreateImage(VkDevice device, VkImageCreateInfo pCreateInfo, out VkImage pImage, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateImage_ptr(device, &pCreateInfo, pAllocator, out pImage);
		}

		internal static delegate* unmanaged<VkDevice, VkImage, VkAllocationCallbacks*, void> vkDestroyImage_ptr;

		public static void vkDestroyImage(VkDevice device, VkImage image = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyImage_ptr(device, image, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkImage, VkImageSubresource*, out VkSubresourceLayout, void> vkGetImageSubresourceLayout_ptr;

		public static void vkGetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, out VkSubresourceLayout pLayout)
		{
			vkGetImageSubresourceLayout_ptr(device, image, pSubresource, out pLayout);
		}

		internal static delegate* unmanaged<VkDevice, VkImageViewCreateInfo*, VkAllocationCallbacks*, out VkImageView, VkResult> vkCreateImageView_ptr;

		public static VkResult vkCreateImageView(VkDevice device, VkImageViewCreateInfo pCreateInfo, out VkImageView pView, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateImageView_ptr(device, &pCreateInfo, pAllocator, out pView);
		}

		internal static delegate* unmanaged<VkDevice, VkImageView, VkAllocationCallbacks*, void> vkDestroyImageView_ptr;

		public static void vkDestroyImageView(VkDevice device, VkImageView imageView = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyImageView_ptr(device, imageView, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, out VkShaderModule, VkResult> vkCreateShaderModule_ptr;

		public static VkResult vkCreateShaderModule(VkDevice device, VkShaderModuleCreateInfo pCreateInfo, out VkShaderModule pShaderModule, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateShaderModule_ptr(device, &pCreateInfo, pAllocator, out pShaderModule);
		}

		internal static delegate* unmanaged<VkDevice, VkShaderModule, VkAllocationCallbacks*, void> vkDestroyShaderModule_ptr;

		public static void vkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyShaderModule_ptr(device, shaderModule, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineCacheCreateInfo*, VkAllocationCallbacks*, out VkPipelineCache, VkResult> vkCreatePipelineCache_ptr;

		public static VkResult vkCreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo pCreateInfo, out VkPipelineCache pPipelineCache, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreatePipelineCache_ptr(device, &pCreateInfo, pAllocator, out pPipelineCache);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void> vkDestroyPipelineCache_ptr;

		public static void vkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyPipelineCache_ptr(device, pipelineCache, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineCache, nuint*, void*, VkResult> vkGetPipelineCacheData_ptr;

		public static VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData = default)
		{
			return vkGetPipelineCacheData_ptr(device, pipelineCache, pDataSize, pData);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult> vkMergePipelineCaches_ptr;

		public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
		{
			return vkMergePipelineCaches_ptr(device, dstCache, srcCacheCount, pSrcCaches);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateGraphicsPipelines_ptr;

		public static VkResult vkCreateGraphicsPipelines(VkDevice device, uint createInfoCount, VkGraphicsPipelineCreateInfo pCreateInfos, VkPipeline* pPipelines, VkPipelineCache pipelineCache = default, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateGraphicsPipelines_ptr(device, pipelineCache, createInfoCount, &pCreateInfos, pAllocator, pPipelines);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateComputePipelines_ptr;

		public static VkResult vkCreateComputePipelines(VkDevice device, uint createInfoCount, VkComputePipelineCreateInfo pCreateInfos, VkPipeline* pPipelines, VkPipelineCache pipelineCache = default, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateComputePipelines_ptr(device, pipelineCache, createInfoCount, &pCreateInfos, pAllocator, pPipelines);
		}

		internal static delegate* unmanaged<VkDevice, VkPipeline, VkAllocationCallbacks*, void> vkDestroyPipeline_ptr;

		public static void vkDestroyPipeline(VkDevice device, VkPipeline pipeline = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyPipeline_ptr(device, pipeline, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineLayoutCreateInfo*, VkAllocationCallbacks*, out VkPipelineLayout, VkResult> vkCreatePipelineLayout_ptr;

		public static VkResult vkCreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo pCreateInfo, out VkPipelineLayout pPipelineLayout, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreatePipelineLayout_ptr(device, &pCreateInfo, pAllocator, out pPipelineLayout);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void> vkDestroyPipelineLayout_ptr;

		public static void vkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyPipelineLayout_ptr(device, pipelineLayout, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkSamplerCreateInfo*, VkAllocationCallbacks*, out VkSampler, VkResult> vkCreateSampler_ptr;

		public static VkResult vkCreateSampler(VkDevice device, VkSamplerCreateInfo pCreateInfo, out VkSampler pSampler, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateSampler_ptr(device, &pCreateInfo, pAllocator, out pSampler);
		}

		internal static delegate* unmanaged<VkDevice, VkSampler, VkAllocationCallbacks*, void> vkDestroySampler_ptr;

		public static void vkDestroySampler(VkDevice device, VkSampler sampler = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroySampler_ptr(device, sampler, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkAllocationCallbacks*, out VkDescriptorSetLayout, VkResult> vkCreateDescriptorSetLayout_ptr;

		public static VkResult vkCreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo pCreateInfo, out VkDescriptorSetLayout pSetLayout, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDescriptorSetLayout_ptr(device, &pCreateInfo, pAllocator, out pSetLayout);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void> vkDestroyDescriptorSetLayout_ptr;

		public static void vkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyDescriptorSetLayout_ptr(device, descriptorSetLayout, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, out VkDescriptorPool, VkResult> vkCreateDescriptorPool_ptr;

		public static VkResult vkCreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo pCreateInfo, out VkDescriptorPool pDescriptorPool, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDescriptorPool_ptr(device, &pCreateInfo, pAllocator, out pDescriptorPool);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void> vkDestroyDescriptorPool_ptr;

		public static void vkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyDescriptorPool_ptr(device, descriptorPool, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult> vkResetDescriptorPool_ptr;

		public static VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags = default)
		{
			return vkResetDescriptorPool_ptr(device, descriptorPool, flags);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult> vkAllocateDescriptorSets_ptr;

		public static VkResult vkAllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)
		{
			return vkAllocateDescriptorSets_ptr(device, pAllocateInfo, pDescriptorSets);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult> vkFreeDescriptorSets_ptr;

		public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
		{
			return vkFreeDescriptorSets_ptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void> vkUpdateDescriptorSets_ptr;

		public static void vkUpdateDescriptorSets(VkDevice device, VkWriteDescriptorSet* pDescriptorWrites, VkCopyDescriptorSet* pDescriptorCopies, uint descriptorWriteCount = default, uint descriptorCopyCount = default)
		{
			vkUpdateDescriptorSets_ptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
		}

		internal static delegate* unmanaged<VkDevice, VkFramebufferCreateInfo*, VkAllocationCallbacks*, out VkFramebuffer, VkResult> vkCreateFramebuffer_ptr;

		public static VkResult vkCreateFramebuffer(VkDevice device, VkFramebufferCreateInfo pCreateInfo, out VkFramebuffer pFramebuffer, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateFramebuffer_ptr(device, &pCreateInfo, pAllocator, out pFramebuffer);
		}

		internal static delegate* unmanaged<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void> vkDestroyFramebuffer_ptr;

		public static void vkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyFramebuffer_ptr(device, framebuffer, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkRenderPassCreateInfo*, VkAllocationCallbacks*, out VkRenderPass, VkResult> vkCreateRenderPass_ptr;

		public static VkResult vkCreateRenderPass(VkDevice device, VkRenderPassCreateInfo pCreateInfo, out VkRenderPass pRenderPass, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateRenderPass_ptr(device, &pCreateInfo, pAllocator, out pRenderPass);
		}

		internal static delegate* unmanaged<VkDevice, VkRenderPass, VkAllocationCallbacks*, void> vkDestroyRenderPass_ptr;

		public static void vkDestroyRenderPass(VkDevice device, VkRenderPass renderPass = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyRenderPass_ptr(device, renderPass, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkRenderPass, out Vector2ui, void> vkGetRenderAreaGranularity_ptr;

		public static void vkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, out Vector2ui pGranularity)
		{
			vkGetRenderAreaGranularity_ptr(device, renderPass, out pGranularity);
		}

		internal static delegate* unmanaged<VkDevice, VkCommandPoolCreateInfo*, VkAllocationCallbacks*, out VkCommandPool, VkResult> vkCreateCommandPool_ptr;

		public static VkResult vkCreateCommandPool(VkDevice device, VkCommandPoolCreateInfo pCreateInfo, out VkCommandPool pCommandPool, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateCommandPool_ptr(device, &pCreateInfo, pAllocator, out pCommandPool);
		}

		internal static delegate* unmanaged<VkDevice, VkCommandPool, VkAllocationCallbacks*, void> vkDestroyCommandPool_ptr;

		public static void vkDestroyCommandPool(VkDevice device, VkCommandPool commandPool = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyCommandPool_ptr(device, commandPool, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolResetFlags, VkResult> vkResetCommandPool_ptr;

		public static VkResult vkResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags = default)
		{
			return vkResetCommandPool_ptr(device, commandPool, flags);
		}

		internal static delegate* unmanaged<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult> vkAllocateCommandBuffers_ptr;

		public static VkResult vkAllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)
		{
			return vkAllocateCommandBuffers_ptr(device, pAllocateInfo, pCommandBuffers);
		}

		internal static delegate* unmanaged<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void> vkFreeCommandBuffers_ptr;

		public static void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
		{
			vkFreeCommandBuffers_ptr(device, commandPool, commandBufferCount, pCommandBuffers);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult> vkBeginCommandBuffer_ptr;

		public static VkResult vkBeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
		{
			return vkBeginCommandBuffer_ptr(commandBuffer, pBeginInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkResult> vkEndCommandBuffer_ptr;

		public static VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer)
		{
			return vkEndCommandBuffer_ptr(commandBuffer);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCommandBufferResetFlags, VkResult> vkResetCommandBuffer_ptr;

		public static VkResult vkResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags = default)
		{
			return vkResetCommandBuffer_ptr(commandBuffer, flags);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> vkCmdBindPipeline_ptr;

		public static void vkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
		{
			vkCmdBindPipeline_ptr(commandBuffer, pipelineBindPoint, pipeline);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewport*, void> vkCmdSetViewport_ptr;

		public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
		{
			vkCmdSetViewport_ptr(commandBuffer, firstViewport, viewportCount, pViewports);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetScissor_ptr;

		public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
		{
			vkCmdSetScissor_ptr(commandBuffer, firstScissor, scissorCount, pScissors);
		}

		internal static delegate* unmanaged<VkCommandBuffer, float, void> vkCmdSetLineWidth_ptr;

		public static void vkCmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth)
		{
			vkCmdSetLineWidth_ptr(commandBuffer, lineWidth);
		}

		internal static delegate* unmanaged<VkCommandBuffer, float, float, float, void> vkCmdSetDepthBias_ptr;

		public static void vkCmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
		{
			vkCmdSetDepthBias_ptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
		}

		internal static delegate* unmanaged<VkCommandBuffer, float, void> vkCmdSetBlendConstants_ptr;

		public static void vkCmdSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants)
		{
			vkCmdSetBlendConstants_ptr(commandBuffer, blendConstants);
		}

		internal static delegate* unmanaged<VkCommandBuffer, float, float, void> vkCmdSetDepthBounds_ptr;

		public static void vkCmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
		{
			vkCmdSetDepthBounds_ptr(commandBuffer, minDepthBounds, maxDepthBounds);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlags, uint, void> vkCmdSetStencilCompareMask_ptr;

		public static void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask)
		{
			vkCmdSetStencilCompareMask_ptr(commandBuffer, faceMask, compareMask);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlags, uint, void> vkCmdSetStencilWriteMask_ptr;

		public static void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask)
		{
			vkCmdSetStencilWriteMask_ptr(commandBuffer, faceMask, writeMask);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlags, uint, void> vkCmdSetStencilReference_ptr;

		public static void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference)
		{
			vkCmdSetStencilReference_ptr(commandBuffer, faceMask, reference);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void> vkCmdBindDescriptorSets_ptr;

		public static void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint* pDynamicOffsets, uint dynamicOffsetCount = default)
		{
			vkCmdBindDescriptorSets_ptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void> vkCmdBindIndexBuffer_ptr;

		public static void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
		{
			vkCmdBindIndexBuffer_ptr(commandBuffer, buffer, offset, indexType);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> vkCmdBindVertexBuffers_ptr;

		public static void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets)
		{
			vkCmdBindVertexBuffers_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, void> vkCmdDraw_ptr;

		public static void vkCmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
		{
			vkCmdDraw_ptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, int, uint, void> vkCmdDrawIndexed_ptr;

		public static void vkCmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
		{
			vkCmdDrawIndexed_ptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirect_ptr;

		public static void vkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
		{
			vkCmdDrawIndirect_ptr(commandBuffer, buffer, offset, drawCount, stride);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndexedIndirect_ptr;

		public static void vkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
		{
			vkCmdDrawIndexedIndirect_ptr(commandBuffer, buffer, offset, drawCount, stride);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> vkCmdDispatch_ptr;

		public static void vkCmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
		{
			vkCmdDispatch_ptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void> vkCmdDispatchIndirect_ptr;

		public static void vkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
		{
			vkCmdDispatchIndirect_ptr(commandBuffer, buffer, offset);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void> vkCmdCopyBuffer_ptr;

		public static void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
		{
			vkCmdCopyBuffer_ptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void> vkCmdCopyImage_ptr;

		public static void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
		{
			vkCmdCopyImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void> vkCmdBlitImage_ptr;

		public static void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
		{
			vkCmdBlitImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void> vkCmdCopyBufferToImage_ptr;

		public static void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
		{
			vkCmdCopyBufferToImage_ptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void> vkCmdCopyImageToBuffer_ptr;

		public static void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
		{
			vkCmdCopyImageToBuffer_ptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, void*, void> vkCmdUpdateBuffer_ptr;

		public static void vkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
		{
			vkCmdUpdateBuffer_ptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void> vkCmdFillBuffer_ptr;

		public static void vkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
		{
			vkCmdFillBuffer_ptr(commandBuffer, dstBuffer, dstOffset, size, data);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearColorValue*, uint, VkImageSubresourceRange*, void> vkCmdClearColorImage_ptr;

		public static void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
		{
			vkCmdClearColorImage_ptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearDepthStencilValue*, uint, VkImageSubresourceRange*, void> vkCmdClearDepthStencilImage_ptr;

		public static void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
		{
			vkCmdClearDepthStencilImage_ptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void> vkCmdClearAttachments_ptr;

		public static void vkCmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
		{
			vkCmdClearAttachments_ptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void> vkCmdResolveImage_ptr;

		public static void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
		{
			vkCmdResolveImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> vkCmdSetEvent_ptr;

		public static void vkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask)
		{
			vkCmdSetEvent_ptr(commandBuffer, @event, stageMask);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> vkCmdResetEvent_ptr;

		public static void vkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask)
		{
			vkCmdResetEvent_ptr(commandBuffer, @event, stageMask);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlags, VkPipelineStageFlags, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> vkCmdWaitEvents_ptr;

		public static void vkCmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkMemoryBarrier* pMemoryBarriers, VkBufferMemoryBarrier* pBufferMemoryBarriers, VkImageMemoryBarrier* pImageMemoryBarriers, VkPipelineStageFlags srcStageMask = default, VkPipelineStageFlags dstStageMask = default, uint memoryBarrierCount = default, uint bufferMemoryBarrierCount = default, uint imageMemoryBarrierCount = default)
		{
			vkCmdWaitEvents_ptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags, VkPipelineStageFlags, VkDependencyFlags, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> vkCmdPipelineBarrier_ptr;

		public static void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkMemoryBarrier* pMemoryBarriers, VkBufferMemoryBarrier* pBufferMemoryBarriers, VkImageMemoryBarrier* pImageMemoryBarriers, VkDependencyFlags dependencyFlags = default, uint memoryBarrierCount = default, uint bufferMemoryBarrierCount = default, uint imageMemoryBarrierCount = default)
		{
			vkCmdPipelineBarrier_ptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, void> vkCmdBeginQuery_ptr;

		public static void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags = default)
		{
			vkCmdBeginQuery_ptr(commandBuffer, queryPool, query, flags);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, void> vkCmdEndQuery_ptr;

		public static void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
		{
			vkCmdEndQuery_ptr(commandBuffer, queryPool, query);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> vkCmdBeginConditionalRenderingEXT_ptr;

		public static void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
		{
			vkCmdBeginConditionalRenderingEXT_ptr(commandBuffer, pConditionalRenderingBegin);
		}

		internal static delegate* unmanaged<VkCommandBuffer, void> vkCmdEndConditionalRenderingEXT_ptr;

		public static void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
		{
			vkCmdEndConditionalRenderingEXT_ptr(commandBuffer);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void> vkCmdResetQueryPool_ptr;

		public static void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
		{
			vkCmdResetQueryPool_ptr(commandBuffer, queryPool, firstQuery, queryCount);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags, VkQueryPool, uint, void> vkCmdWriteTimestamp_ptr;

		public static void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query)
		{
			vkCmdWriteTimestamp_ptr(commandBuffer, pipelineStage, queryPool, query);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlags, void> vkCmdCopyQueryPoolResults_ptr;

		public static void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags = default)
		{
			vkCmdCopyQueryPoolResults_ptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlags, uint, uint, void*, void> vkCmdPushConstants_ptr;

		public static void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues)
		{
			vkCmdPushConstants_ptr(commandBuffer, layout, stageFlags, offset, size, pValues);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void> vkCmdBeginRenderPass_ptr;

		public static void vkCmdBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
		{
			vkCmdBeginRenderPass_ptr(commandBuffer, pRenderPassBegin, contents);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkSubpassContents, void> vkCmdNextSubpass_ptr;

		public static void vkCmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents)
		{
			vkCmdNextSubpass_ptr(commandBuffer, contents);
		}

		internal static delegate* unmanaged<VkCommandBuffer, void> vkCmdEndRenderPass_ptr;

		public static void vkCmdEndRenderPass(VkCommandBuffer commandBuffer)
		{
			vkCmdEndRenderPass_ptr(commandBuffer);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkCommandBuffer*, void> vkCmdExecuteCommands_ptr;

		public static void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
		{
			vkCmdExecuteCommands_ptr(commandBuffer, commandBufferCount, pCommandBuffers);
		}

		internal static delegate* unmanaged<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> vkCreateAndroidSurfaceKHR_ptr;

		public static VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR pCreateInfo, out VkSurfaceKHR pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateAndroidSurfaceKHR_ptr(instance, &pCreateInfo, pAllocator, out pSurface);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult> vkGetPhysicalDeviceDisplayPropertiesKHR_ptr;

		public static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties = default)
		{
			return vkGetPhysicalDeviceDisplayPropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult> vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr;

		public static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties = default)
		{
			return vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult> vkGetDisplayPlaneSupportedDisplaysKHR_ptr;

		public static VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays = default)
		{
			return vkGetDisplayPlaneSupportedDisplaysKHR_ptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult> vkGetDisplayModePropertiesKHR_ptr;

		public static VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties = default)
		{
			return vkGetDisplayModePropertiesKHR_ptr(physicalDevice, display, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, out VkDisplayModeKHR, VkResult> vkCreateDisplayModeKHR_ptr;

		public static VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR pCreateInfo, out VkDisplayModeKHR pMode, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDisplayModeKHR_ptr(physicalDevice, display, &pCreateInfo, pAllocator, out pMode);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkDisplayModeKHR, uint, out VkDisplayPlaneCapabilitiesKHR, VkResult> vkGetDisplayPlaneCapabilitiesKHR_ptr;

		public static VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR pCapabilities)
		{
			return vkGetDisplayPlaneCapabilitiesKHR_ptr(physicalDevice, mode, planeIndex, out pCapabilities);
		}

		internal static delegate* unmanaged<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> vkCreateDisplayPlaneSurfaceKHR_ptr;

		public static VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR pCreateInfo, out VkSurfaceKHR pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDisplayPlaneSurfaceKHR_ptr(instance, &pCreateInfo, pAllocator, out pSurface);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult> vkCreateSharedSwapchainsKHR_ptr;

		public static VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR pCreateInfos, out VkSwapchainKHR pSwapchains, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateSharedSwapchainsKHR_ptr(device, swapchainCount, &pCreateInfos, pAllocator, out pSwapchains);
		}

		internal static delegate* unmanaged<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void> vkDestroySurfaceKHR_ptr;

		public static void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroySurfaceKHR_ptr(instance, surface, pAllocator);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, VkSurfaceKHR, out VkBool32, VkResult> vkGetPhysicalDeviceSurfaceSupportKHR_ptr;

		public static VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 pSupported)
		{
			return vkGetPhysicalDeviceSurfaceSupportKHR_ptr(physicalDevice, queueFamilyIndex, surface, out pSupported);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, out VkSurfaceCapabilitiesKHR, VkResult> vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr;

		public static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR pSurfaceCapabilities)
		{
			return vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr(physicalDevice, surface, out pSurfaceCapabilities);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult> vkGetPhysicalDeviceSurfaceFormatsKHR_ptr;

		public static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats = default)
		{
			return vkGetPhysicalDeviceSurfaceFormatsKHR_ptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult> vkGetPhysicalDeviceSurfacePresentModesKHR_ptr;

		public static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes = default)
		{
			return vkGetPhysicalDeviceSurfacePresentModesKHR_ptr(physicalDevice, surface, pPresentModeCount, pPresentModes);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult> vkCreateSwapchainKHR_ptr;

		public static VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR pCreateInfo, out VkSwapchainKHR pSwapchain, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateSwapchainKHR_ptr(device, &pCreateInfo, pAllocator, out pSwapchain);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void> vkDestroySwapchainKHR_ptr;

		public static void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroySwapchainKHR_ptr(device, swapchain, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult> vkGetSwapchainImagesKHR_ptr;

		public static VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages = default)
		{
			return vkGetSwapchainImagesKHR_ptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, out uint, VkResult> vkAcquireNextImageKHR_ptr;

		public static VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, out uint pImageIndex, VkSemaphore semaphore = default, VkFence fence = default)
		{
			return vkAcquireNextImageKHR_ptr(device, swapchain, timeout, semaphore, fence, out pImageIndex);
		}

		internal static delegate* unmanaged<VkQueue, VkPresentInfoKHR*, VkResult> vkQueuePresentKHR_ptr;

		public static VkResult vkQueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
		{
			return vkQueuePresentKHR_ptr(queue, pPresentInfo);
		}

		internal static delegate* unmanaged<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateViSurfaceNN_ptr;

		public static VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN pCreateInfo, VkSurfaceKHR* pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateViSurfaceNN_ptr(instance, &pCreateInfo, pAllocator, pSurface);
		}

		internal static delegate* unmanaged<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> vkCreateWaylandSurfaceKHR_ptr;

		public static VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR pCreateInfo, out VkSurfaceKHR pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateWaylandSurfaceKHR_ptr(instance, &pCreateInfo, pAllocator, out pSurface);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, VkBool32> vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr;

		public static VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
		{
			return vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, display);
		}

		internal static delegate* unmanaged<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> vkCreateWin32SurfaceKHR_ptr;

		public static VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR pCreateInfo, out VkSurfaceKHR pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateWin32SurfaceKHR_ptr(instance, &pCreateInfo, pAllocator, out pSurface);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, VkBool32> vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr;

		public static VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
		{
			return vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex);
		}

		internal static delegate* unmanaged<VkInstance, VkXlibSurfaceCreateInfoKHR*, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> vkCreateXlibSurfaceKHR_ptr;

		public static VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR pCreateInfo, out VkSurfaceKHR pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateXlibSurfaceKHR_ptr(instance, &pCreateInfo, pAllocator, out pSurface);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, IntPtr, VkBool32> vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr;

		public static VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
		{
			return vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, dpy, visualID);
		}

		internal static delegate* unmanaged<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateXcbSurfaceKHR_ptr;

		public static VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR pCreateInfo, VkSurfaceKHR* pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateXcbSurfaceKHR_ptr(instance, &pCreateInfo, pAllocator, pSurface);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, IntPtr, VkBool32> vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr;

		public static VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id)
		{
			return vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, connection, visual_id);
		}

		internal static delegate* unmanaged<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateDirectFBSurfaceEXT_ptr;

		public static VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT pCreateInfo, VkSurfaceKHR* pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDirectFBSurfaceEXT_ptr(instance, &pCreateInfo, pAllocator, pSurface);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, VkBool32> vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr;

		public static VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb)
		{
			return vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr(physicalDevice, queueFamilyIndex, dfb);
		}

		internal static delegate* unmanaged<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateImagePipeSurfaceFUCHSIA_ptr;

		public static VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, VkSurfaceKHR* pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateImagePipeSurfaceFUCHSIA_ptr(instance, &pCreateInfo, pAllocator, pSurface);
		}

		internal static delegate* unmanaged<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateStreamDescriptorSurfaceGGP_ptr;

		public static VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, VkSurfaceKHR* pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateStreamDescriptorSurfaceGGP_ptr(instance, &pCreateInfo, pAllocator, pSurface);
		}

		internal static delegate* unmanaged<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateScreenSurfaceQNX_ptr;

		public static VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX pCreateInfo, VkSurfaceKHR* pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateScreenSurfaceQNX_ptr(instance, &pCreateInfo, pAllocator, pSurface);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, VkBool32> vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr;

		public static VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr window)
		{
			return vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr(physicalDevice, queueFamilyIndex, window);
		}

		internal static delegate* unmanaged<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult> vkCreateDebugReportCallbackEXT_ptr;

		public static VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT pCreateInfo, VkDebugReportCallbackEXT* pCallback, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDebugReportCallbackEXT_ptr(instance, &pCreateInfo, pAllocator, pCallback);
		}

		internal static delegate* unmanaged<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void> vkDestroyDebugReportCallbackEXT_ptr;

		public static void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyDebugReportCallbackEXT_ptr(instance, callback, pAllocator);
		}

		internal static delegate* unmanaged<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void> vkDebugReportMessageEXT_ptr;

		public static void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage)
		{
			vkDebugReportMessageEXT_ptr(instance, flags, objectType, @object, location, messageCode, pLayerPrefix, pMessage);
		}

		internal static delegate* unmanaged<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> vkDebugMarkerSetObjectNameEXT_ptr;

		public static VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
		{
			return vkDebugMarkerSetObjectNameEXT_ptr(device, pNameInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> vkDebugMarkerSetObjectTagEXT_ptr;

		public static VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
		{
			return vkDebugMarkerSetObjectTagEXT_ptr(device, pTagInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> vkCmdDebugMarkerBeginEXT_ptr;

		public static void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
		{
			vkCmdDebugMarkerBeginEXT_ptr(commandBuffer, pMarkerInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, void> vkCmdDebugMarkerEndEXT_ptr;

		public static void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
		{
			vkCmdDebugMarkerEndEXT_ptr(commandBuffer);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> vkCmdDebugMarkerInsertEXT_ptr;

		public static void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
		{
			vkCmdDebugMarkerInsertEXT_ptr(commandBuffer, pMarkerInfo);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, VkExternalMemoryHandleTypeFlagsNV, VkExternalImageFormatPropertiesNV*, VkResult> vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr;

		public static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties, VkImageCreateFlags flags = default, VkExternalMemoryHandleTypeFlagsNV externalHandleType = default)
		{
			return vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagsNV, IntPtr*, VkResult> vkGetMemoryWin32HandleNV_ptr;

		public static VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr* pHandle)
		{
			return vkGetMemoryWin32HandleNV_ptr(device, memory, handleType, pHandle);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBool32, VkGeneratedCommandsInfoNV*, void> vkCmdExecuteGeneratedCommandsNV_ptr;

		public static void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
		{
			vkCmdExecuteGeneratedCommandsNV_ptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> vkCmdPreprocessGeneratedCommandsNV_ptr;

		public static void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
		{
			vkCmdPreprocessGeneratedCommandsNV_ptr(commandBuffer, pGeneratedCommandsInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void> vkCmdBindPipelineShaderGroupNV_ptr;

		public static void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
		{
			vkCmdBindPipelineShaderGroupNV_ptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
		}

		internal static delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetGeneratedCommandsMemoryRequirementsNV_ptr;

		public static void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
		{
			vkGetGeneratedCommandsMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);
		}

		internal static delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult> vkCreateIndirectCommandsLayoutNV_ptr;

		public static VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateIndirectCommandsLayoutNV_ptr(device, &pCreateInfo, pAllocator, pIndirectCommandsLayout);
		}

		internal static delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> vkDestroyIndirectCommandsLayoutNV_ptr;

		public static void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyIndirectCommandsLayoutNV_ptr(device, indirectCommandsLayout, pAllocator);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, out VkPhysicalDeviceFeatures2, void> vkGetPhysicalDeviceFeatures2_ptr;

		public static void vkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2 pFeatures)
		{
			vkGetPhysicalDeviceFeatures2_ptr(physicalDevice, out pFeatures);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, out VkPhysicalDeviceProperties2, void> vkGetPhysicalDeviceProperties2_ptr;

		public static void vkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2 pProperties)
		{
			vkGetPhysicalDeviceProperties2_ptr(physicalDevice, out pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkFormat, out VkFormatProperties2, void> vkGetPhysicalDeviceFormatProperties2_ptr;

		public static void vkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2 pFormatProperties)
		{
			vkGetPhysicalDeviceFormatProperties2_ptr(physicalDevice, format, out pFormatProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, out VkImageFormatProperties2, VkResult> vkGetPhysicalDeviceImageFormatProperties2_ptr;

		public static VkResult vkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, out VkImageFormatProperties2 pImageFormatProperties)
		{
			return vkGetPhysicalDeviceImageFormatProperties2_ptr(physicalDevice, pImageFormatInfo, out pImageFormatProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> vkGetPhysicalDeviceQueueFamilyProperties2_ptr;

		public static void vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties = default)
		{
			vkGetPhysicalDeviceQueueFamilyProperties2_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, out VkPhysicalDeviceMemoryProperties2, void> vkGetPhysicalDeviceMemoryProperties2_ptr;

		public static void vkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2 pMemoryProperties)
		{
			vkGetPhysicalDeviceMemoryProperties2_ptr(physicalDevice, out pMemoryProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> vkGetPhysicalDeviceSparseImageFormatProperties2_ptr;

		public static void vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties = default)
		{
			vkGetPhysicalDeviceSparseImageFormatProperties2_ptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void> vkCmdPushDescriptorSetKHR_ptr;

		public static void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
		{
			vkCmdPushDescriptorSetKHR_ptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
		}

		internal static delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> vkTrimCommandPool_ptr;

		public static void vkTrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags = default)
		{
			vkTrimCommandPool_ptr(device, commandPool, flags);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, out VkExternalBufferProperties, void> vkGetPhysicalDeviceExternalBufferProperties_ptr;

		public static void vkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, out VkExternalBufferProperties pExternalBufferProperties)
		{
			vkGetPhysicalDeviceExternalBufferProperties_ptr(physicalDevice, pExternalBufferInfo, out pExternalBufferProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkMemoryGetWin32HandleInfoKHR*, IntPtr*, VkResult> vkGetMemoryWin32HandleKHR_ptr;

		public static VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
		{
			return vkGetMemoryWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);
		}

		internal static delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlags, IntPtr, VkMemoryWin32HandlePropertiesKHR*, VkResult> vkGetMemoryWin32HandlePropertiesKHR_ptr;

		public static VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
		{
			return vkGetMemoryWin32HandlePropertiesKHR_ptr(device, handleType, handle, pMemoryWin32HandleProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult> vkGetMemoryFdKHR_ptr;

		public static VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
		{
			return vkGetMemoryFdKHR_ptr(device, pGetFdInfo, pFd);
		}

		internal static delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlags, int, VkMemoryFdPropertiesKHR*, VkResult> vkGetMemoryFdPropertiesKHR_ptr;

		public static VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
		{
			return vkGetMemoryFdPropertiesKHR_ptr(device, handleType, fd, pMemoryFdProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, IntPtr*, VkResult> vkGetMemoryZirconHandleFUCHSIA_ptr;

		public static VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr* pZirconHandle)
		{
			return vkGetMemoryZirconHandleFUCHSIA_ptr(device, pGetZirconHandleInfo, pZirconHandle);
		}

		internal static delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlags, IntPtr, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult> vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr;

		public static VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
		{
			return vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr(device, handleType, zirconHandle, pMemoryZirconHandleProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, out VkExternalSemaphoreProperties, void> vkGetPhysicalDeviceExternalSemaphoreProperties_ptr;

		public static void vkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, out VkExternalSemaphoreProperties pExternalSemaphoreProperties)
		{
			vkGetPhysicalDeviceExternalSemaphoreProperties_ptr(physicalDevice, pExternalSemaphoreInfo, out pExternalSemaphoreProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, IntPtr*, VkResult> vkGetSemaphoreWin32HandleKHR_ptr;

		public static VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
		{
			return vkGetSemaphoreWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);
		}

		internal static delegate* unmanaged<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> vkImportSemaphoreWin32HandleKHR_ptr;

		public static VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
		{
			return vkImportSemaphoreWin32HandleKHR_ptr(device, pImportSemaphoreWin32HandleInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult> vkGetSemaphoreFdKHR_ptr;

		public static VkResult vkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
		{
			return vkGetSemaphoreFdKHR_ptr(device, pGetFdInfo, pFd);
		}

		internal static delegate* unmanaged<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> vkImportSemaphoreFdKHR_ptr;

		public static VkResult vkImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
		{
			return vkImportSemaphoreFdKHR_ptr(device, pImportSemaphoreFdInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, IntPtr*, VkResult> vkGetSemaphoreZirconHandleFUCHSIA_ptr;

		public static VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr* pZirconHandle)
		{
			return vkGetSemaphoreZirconHandleFUCHSIA_ptr(device, pGetZirconHandleInfo, pZirconHandle);
		}

		internal static delegate* unmanaged<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult> vkImportSemaphoreZirconHandleFUCHSIA_ptr;

		public static VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
		{
			return vkImportSemaphoreZirconHandleFUCHSIA_ptr(device, pImportSemaphoreZirconHandleInfo);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, out VkExternalFenceProperties, void> vkGetPhysicalDeviceExternalFenceProperties_ptr;

		public static void vkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, out VkExternalFenceProperties pExternalFenceProperties)
		{
			vkGetPhysicalDeviceExternalFenceProperties_ptr(physicalDevice, pExternalFenceInfo, out pExternalFenceProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkFenceGetWin32HandleInfoKHR*, IntPtr*, VkResult> vkGetFenceWin32HandleKHR_ptr;

		public static VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
		{
			return vkGetFenceWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);
		}

		internal static delegate* unmanaged<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> vkImportFenceWin32HandleKHR_ptr;

		public static VkResult vkImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
		{
			return vkImportFenceWin32HandleKHR_ptr(device, pImportFenceWin32HandleInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult> vkGetFenceFdKHR_ptr;

		public static VkResult vkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
		{
			return vkGetFenceFdKHR_ptr(device, pGetFdInfo, pFd);
		}

		internal static delegate* unmanaged<VkDevice, VkImportFenceFdInfoKHR*, VkResult> vkImportFenceFdKHR_ptr;

		public static VkResult vkImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
		{
			return vkImportFenceFdKHR_ptr(device, pImportFenceFdInfo);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> vkReleaseDisplayEXT_ptr;

		public static VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
		{
			return vkReleaseDisplayEXT_ptr(physicalDevice, display);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, IntPtr, VkDisplayKHR, VkResult> vkAcquireXlibDisplayEXT_ptr;

		public static VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
		{
			return vkAcquireXlibDisplayEXT_ptr(physicalDevice, dpy, display);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, IntPtr, IntPtr, VkDisplayKHR*, VkResult> vkGetRandROutputDisplayEXT_ptr;

		public static VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
		{
			return vkGetRandROutputDisplayEXT_ptr(physicalDevice, dpy, rrOutput, pDisplay);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> vkAcquireWinrtDisplayNV_ptr;

		public static VkResult vkAcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
		{
			return vkAcquireWinrtDisplayNV_ptr(physicalDevice, display);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult> vkGetWinrtDisplayNV_ptr;

		public static VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
		{
			return vkGetWinrtDisplayNV_ptr(physicalDevice, deviceRelativeId, pDisplay);
		}

		internal static delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> vkDisplayPowerControlEXT_ptr;

		public static VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
		{
			return vkDisplayPowerControlEXT_ptr(device, display, pDisplayPowerInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> vkRegisterDeviceEventEXT_ptr;

		public static VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkFence* pFence, VkAllocationCallbacks* pAllocator = default)
		{
			return vkRegisterDeviceEventEXT_ptr(device, pDeviceEventInfo, pAllocator, pFence);
		}

		internal static delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> vkRegisterDisplayEventEXT_ptr;

		public static VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkFence* pFence, VkAllocationCallbacks* pAllocator = default)
		{
			return vkRegisterDisplayEventEXT_ptr(device, display, pDisplayEventInfo, pAllocator, pFence);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagsEXT, ulong*, VkResult> vkGetSwapchainCounterEXT_ptr;

		public static VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue)
		{
			return vkGetSwapchainCounterEXT_ptr(device, swapchain, counter, pCounterValue);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr;

		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
		{
			return vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr(physicalDevice, surface, pSurfaceCapabilities);
		}

		internal static delegate* unmanaged<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> vkEnumeratePhysicalDeviceGroups_ptr;

		public static VkResult vkEnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties = default)
		{
			return vkEnumeratePhysicalDeviceGroups_ptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
		}

		internal static delegate* unmanaged<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void> vkGetDeviceGroupPeerMemoryFeatures_ptr;

		public static void vkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures)
		{
			vkGetDeviceGroupPeerMemoryFeatures_ptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> vkBindBufferMemory2_ptr;

		public static VkResult vkBindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
		{
			return vkBindBufferMemory2_ptr(device, bindInfoCount, pBindInfos);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> vkBindImageMemory2_ptr;

		public static VkResult vkBindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
		{
			return vkBindImageMemory2_ptr(device, bindInfoCount, pBindInfos);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDeviceMask_ptr;

		public static void vkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
		{
			vkCmdSetDeviceMask_ptr(commandBuffer, deviceMask);
		}

		internal static delegate* unmanaged<VkDevice, out VkDeviceGroupPresentCapabilitiesKHR, VkResult> vkGetDeviceGroupPresentCapabilitiesKHR_ptr;

		public static VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities)
		{
			return vkGetDeviceGroupPresentCapabilitiesKHR_ptr(device, out pDeviceGroupPresentCapabilities);
		}

		internal static delegate* unmanaged<VkDevice, VkSurfaceKHR, out VkDeviceGroupPresentModeFlagsKHR, VkResult> vkGetDeviceGroupSurfacePresentModesKHR_ptr;

		public static VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHR pModes)
		{
			return vkGetDeviceGroupSurfacePresentModesKHR_ptr(device, surface, out pModes);
		}

		internal static delegate* unmanaged<VkDevice, VkAcquireNextImageInfoKHR*, out uint, VkResult> vkAcquireNextImage2KHR_ptr;

		public static VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, out uint pImageIndex)
		{
			return vkAcquireNextImage2KHR_ptr(device, pAcquireInfo, out pImageIndex);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> vkCmdDispatchBase_ptr;

		public static void vkCmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
		{
			vkCmdDispatchBase_ptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult> vkGetPhysicalDevicePresentRectanglesKHR_ptr;

		public static VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects = default)
		{
			return vkGetPhysicalDevicePresentRectanglesKHR_ptr(physicalDevice, surface, pRectCount, pRects);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, out VkDescriptorUpdateTemplate, VkResult> vkCreateDescriptorUpdateTemplate_ptr;

		public static VkResult vkCreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo pCreateInfo, out VkDescriptorUpdateTemplate pDescriptorUpdateTemplate, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDescriptorUpdateTemplate_ptr(device, &pCreateInfo, pAllocator, out pDescriptorUpdateTemplate);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> vkDestroyDescriptorUpdateTemplate_ptr;

		public static void vkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyDescriptorUpdateTemplate_ptr(device, descriptorUpdateTemplate, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> vkUpdateDescriptorSetWithTemplate_ptr;

		public static void vkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
		{
			vkUpdateDescriptorSetWithTemplate_ptr(device, descriptorSet, descriptorUpdateTemplate, pData);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> vkCmdPushDescriptorSetWithTemplateKHR_ptr;

		public static void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
		{
			vkCmdPushDescriptorSetWithTemplateKHR_ptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void> vkSetHdrMetadataEXT_ptr;

		public static void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
		{
			vkSetHdrMetadataEXT_ptr(device, swapchainCount, pSwapchains, pMetadata);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> vkGetSwapchainStatusKHR_ptr;

		public static VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
		{
			return vkGetSwapchainStatusKHR_ptr(device, swapchain);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult> vkGetRefreshCycleDurationGOOGLE_ptr;

		public static VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
		{
			return vkGetRefreshCycleDurationGOOGLE_ptr(device, swapchain, pDisplayTimingProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult> vkGetPastPresentationTimingGOOGLE_ptr;

		public static VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings = default)
		{
			return vkGetPastPresentationTimingGOOGLE_ptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);
		}

		internal static delegate* unmanaged<VkInstance, VkIOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> vkCreateIOSSurfaceMVK_ptr;

		public static VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK pCreateInfo, out VkSurfaceKHR pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateIOSSurfaceMVK_ptr(instance, &pCreateInfo, pAllocator, out pSurface);
		}

		internal static delegate* unmanaged<VkInstance, VkMacOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> vkCreateMacOSSurfaceMVK_ptr;

		public static VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK pCreateInfo, out VkSurfaceKHR pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateMacOSSurfaceMVK_ptr(instance, &pCreateInfo, pAllocator, out pSurface);
		}

		internal static delegate* unmanaged<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> vkCreateMetalSurfaceEXT_ptr;

		public static VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT pCreateInfo, out VkSurfaceKHR pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateMetalSurfaceEXT_ptr(instance, &pCreateInfo, pAllocator, out pSurface);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void> vkCmdSetViewportWScalingNV_ptr;

		public static void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
		{
			vkCmdSetViewportWScalingNV_ptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetDiscardRectangleEXT_ptr;

		public static void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
		{
			vkCmdSetDiscardRectangleEXT_ptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> vkCmdSetSampleLocationsEXT_ptr;

		public static void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
		{
			vkCmdSetSampleLocationsEXT_ptr(commandBuffer, pSampleLocationsInfo);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void> vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr;

		public static void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
		{
			vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr(physicalDevice, samples, pMultisampleProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr;

		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
		{
			return vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult> vkGetPhysicalDeviceSurfaceFormats2KHR_ptr;

		public static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats = default)
		{
			return vkGetPhysicalDeviceSurfaceFormats2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult> vkGetPhysicalDeviceDisplayProperties2KHR_ptr;

		public static VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties = default)
		{
			return vkGetPhysicalDeviceDisplayProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult> vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr;

		public static VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties = default)
		{
			return vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult> vkGetDisplayModeProperties2KHR_ptr;

		public static VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties = default)
		{
			return vkGetDisplayModeProperties2KHR_ptr(physicalDevice, display, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult> vkGetDisplayPlaneCapabilities2KHR_ptr;

		public static VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
		{
			return vkGetDisplayPlaneCapabilities2KHR_ptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);
		}

		internal static delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, out VkMemoryRequirements2, void> vkGetBufferMemoryRequirements2_ptr;

		public static void vkGetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, out VkMemoryRequirements2 pMemoryRequirements)
		{
			vkGetBufferMemoryRequirements2_ptr(device, pInfo, out pMemoryRequirements);
		}

		internal static delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, out VkMemoryRequirements2, void> vkGetImageMemoryRequirements2_ptr;

		public static void vkGetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, out VkMemoryRequirements2 pMemoryRequirements)
		{
			vkGetImageMemoryRequirements2_ptr(device, pInfo, out pMemoryRequirements);
		}

		internal static delegate* unmanaged<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetImageSparseMemoryRequirements2_ptr;

		public static void vkGetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements = default)
		{
			vkGetImageSparseMemoryRequirements2_ptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
		}

		internal static delegate* unmanaged<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, out VkSamplerYcbcrConversion, VkResult> vkCreateSamplerYcbcrConversion_ptr;

		public static VkResult vkCreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo pCreateInfo, out VkSamplerYcbcrConversion pYcbcrConversion, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateSamplerYcbcrConversion_ptr(device, &pCreateInfo, pAllocator, out pYcbcrConversion);
		}

		internal static delegate* unmanaged<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> vkDestroySamplerYcbcrConversion_ptr;

		public static void vkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroySamplerYcbcrConversion_ptr(device, ycbcrConversion, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkDeviceQueueInfo2*, out VkQueue, void> vkGetDeviceQueue2_ptr;

		public static void vkGetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, out VkQueue pQueue)
		{
			vkGetDeviceQueue2_ptr(device, pQueueInfo, out pQueue);
		}

		internal static delegate* unmanaged<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult> vkCreateValidationCacheEXT_ptr;

		public static VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT pCreateInfo, VkValidationCacheEXT* pValidationCache, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateValidationCacheEXT_ptr(device, &pCreateInfo, pAllocator, pValidationCache);
		}

		internal static delegate* unmanaged<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void> vkDestroyValidationCacheEXT_ptr;

		public static void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyValidationCacheEXT_ptr(device, validationCache, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult> vkGetValidationCacheDataEXT_ptr;

		public static VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData = default)
		{
			return vkGetValidationCacheDataEXT_ptr(device, validationCache, pDataSize, pData);
		}

		internal static delegate* unmanaged<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult> vkMergeValidationCachesEXT_ptr;

		public static VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
		{
			return vkMergeValidationCachesEXT_ptr(device, dstCache, srcCacheCount, pSrcCaches);
		}

		internal static delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, out VkDescriptorSetLayoutSupport, void> vkGetDescriptorSetLayoutSupport_ptr;

		public static void vkGetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo pCreateInfo, out VkDescriptorSetLayoutSupport pSupport)
		{
			vkGetDescriptorSetLayoutSupport_ptr(device, &pCreateInfo, out pSupport);
		}

		internal static delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlags, int, VkResult> vkGetSwapchainGrallocUsageANDROID_ptr;

		public static VkResult vkGetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, int grallocUsage)
		{
			return vkGetSwapchainGrallocUsageANDROID_ptr(device, format, imageUsage, grallocUsage);
		}

		internal static delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlags, VkSwapchainImageUsageFlagsANDROID, ulong, ulong, VkResult> vkGetSwapchainGrallocUsage2ANDROID_ptr;

		public static VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ulong grallocConsumerUsage, ulong grallocProducerUsage)
		{
			return vkGetSwapchainGrallocUsage2ANDROID_ptr(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, grallocProducerUsage);
		}

		internal static delegate* unmanaged<VkDevice, VkImage, int, VkSemaphore, VkFence, VkResult> vkAcquireImageANDROID_ptr;

		public static VkResult vkAcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
		{
			return vkAcquireImageANDROID_ptr(device, image, nativeFenceFd, semaphore, fence);
		}

		internal static delegate* unmanaged<VkQueue, uint, VkSemaphore*, VkImage, int*, VkResult> vkQueueSignalReleaseImageANDROID_ptr;

		public static VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
		{
			return vkQueueSignalReleaseImageANDROID_ptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);
		}

		internal static delegate* unmanaged<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, nuint*, void*, VkResult> vkGetShaderInfoAMD_ptr;

		public static VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo = default)
		{
			return vkGetShaderInfoAMD_ptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkBool32, void> vkSetLocalDimmingAMD_ptr;

		public static void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable)
		{
			vkSetLocalDimmingAMD_ptr(device, swapChain, localDimmingEnable);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainEXT*, VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr;

		public static VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains = default)
		{
			return vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr(physicalDevice, pTimeDomainCount, pTimeDomains);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoEXT*, ulong*, ulong*, VkResult> vkGetCalibratedTimestampsEXT_ptr;

		public static VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
		{
			return vkGetCalibratedTimestampsEXT_ptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
		}

		internal static delegate* unmanaged<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> vkSetDebugUtilsObjectNameEXT_ptr;

		public static VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
		{
			return vkSetDebugUtilsObjectNameEXT_ptr(device, pNameInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> vkSetDebugUtilsObjectTagEXT_ptr;

		public static VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
		{
			return vkSetDebugUtilsObjectTagEXT_ptr(device, pTagInfo);
		}

		internal static delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void> vkQueueBeginDebugUtilsLabelEXT_ptr;

		public static void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
		{
			vkQueueBeginDebugUtilsLabelEXT_ptr(queue, pLabelInfo);
		}

		internal static delegate* unmanaged<VkQueue, void> vkQueueEndDebugUtilsLabelEXT_ptr;

		public static void vkQueueEndDebugUtilsLabelEXT(VkQueue queue)
		{
			vkQueueEndDebugUtilsLabelEXT_ptr(queue);
		}

		internal static delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void> vkQueueInsertDebugUtilsLabelEXT_ptr;

		public static void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
		{
			vkQueueInsertDebugUtilsLabelEXT_ptr(queue, pLabelInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdBeginDebugUtilsLabelEXT_ptr;

		public static void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
		{
			vkCmdBeginDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, void> vkCmdEndDebugUtilsLabelEXT_ptr;

		public static void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
		{
			vkCmdEndDebugUtilsLabelEXT_ptr(commandBuffer);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdInsertDebugUtilsLabelEXT_ptr;

		public static void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
		{
			vkCmdInsertDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);
		}

		internal static delegate* unmanaged<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, out VkDebugUtilsMessengerEXT, VkResult> vkCreateDebugUtilsMessengerEXT_ptr;

		public static VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, out VkDebugUtilsMessengerEXT pMessenger, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDebugUtilsMessengerEXT_ptr(instance, &pCreateInfo, pAllocator, out pMessenger);
		}

		internal static delegate* unmanaged<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void> vkDestroyDebugUtilsMessengerEXT_ptr;

		public static void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyDebugUtilsMessengerEXT_ptr(instance, messenger, pAllocator);
		}

		internal static delegate* unmanaged<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void> vkSubmitDebugUtilsMessageEXT_ptr;

		public static void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
		{
			vkSubmitDebugUtilsMessageEXT_ptr(instance, messageSeverity, messageTypes, pCallbackData);
		}

		internal static delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlags, void*, VkMemoryHostPointerPropertiesEXT*, VkResult> vkGetMemoryHostPointerPropertiesEXT_ptr;

		public static VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
		{
			return vkGetMemoryHostPointerPropertiesEXT_ptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, ulong, uint, void> vkCmdWriteBufferMarkerAMD_ptr;

		public static void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
		{
			vkCmdWriteBufferMarkerAMD_ptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
		}

		internal static delegate* unmanaged<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, out VkRenderPass, VkResult> vkCreateRenderPass2_ptr;

		public static VkResult vkCreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2 pCreateInfo, out VkRenderPass pRenderPass, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateRenderPass2_ptr(device, &pCreateInfo, pAllocator, out pRenderPass);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> vkCmdBeginRenderPass2_ptr;

		public static void vkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
		{
			vkCmdBeginRenderPass2_ptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> vkCmdNextSubpass2_ptr;

		public static void vkCmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
		{
			vkCmdNextSubpass2_ptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkSubpassEndInfo*, void> vkCmdEndRenderPass2_ptr;

		public static void vkCmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
		{
			vkCmdEndRenderPass2_ptr(commandBuffer, pSubpassEndInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkSemaphore, ulong*, VkResult> vkGetSemaphoreCounterValue_ptr;

		public static VkResult vkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
		{
			return vkGetSemaphoreCounterValue_ptr(device, semaphore, pValue);
		}

		internal static delegate* unmanaged<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> vkWaitSemaphores_ptr;

		public static VkResult vkWaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
		{
			return vkWaitSemaphores_ptr(device, pWaitInfo, timeout);
		}

		internal static delegate* unmanaged<VkDevice, VkSemaphoreSignalInfo*, VkResult> vkSignalSemaphore_ptr;

		public static VkResult vkSignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
		{
			return vkSignalSemaphore_ptr(device, pSignalInfo);
		}

		internal static delegate* unmanaged<VkDevice, IntPtr, VkAndroidHardwareBufferPropertiesANDROID*, VkResult> vkGetAndroidHardwareBufferPropertiesANDROID_ptr;

		public static VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
		{
			return vkGetAndroidHardwareBufferPropertiesANDROID_ptr(device, buffer, pProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, IntPtr*, VkResult> vkGetMemoryAndroidHardwareBufferANDROID_ptr;

		public static VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr* pBuffer)
		{
			return vkGetMemoryAndroidHardwareBufferANDROID_ptr(device, pInfo, pBuffer);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirectCount_ptr;

		public static void vkCmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
		{
			vkCmdDrawIndirectCount_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndexedIndirectCount_ptr;

		public static void vkCmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
		{
			vkCmdDrawIndexedIndirectCount_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		}

		internal static delegate* unmanaged<VkCommandBuffer, void*, void> vkCmdSetCheckpointNV_ptr;

		public static void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
		{
			vkCmdSetCheckpointNV_ptr(commandBuffer, pCheckpointMarker);
		}

		internal static delegate* unmanaged<VkQueue, uint*, VkCheckpointDataNV*, void> vkGetQueueCheckpointDataNV_ptr;

		public static void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData = default)
		{
			vkGetQueueCheckpointDataNV_ptr(queue, pCheckpointDataCount, pCheckpointData);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, void> vkCmdBindTransformFeedbackBuffersEXT_ptr;

		public static void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes = default)
		{
			vkCmdBindTransformFeedbackBuffersEXT_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> vkCmdBeginTransformFeedbackEXT_ptr;

		public static void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, VkBuffer* pCounterBuffers, uint counterBufferCount = default, ulong* pCounterBufferOffsets = default)
		{
			vkCmdBeginTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> vkCmdEndTransformFeedbackEXT_ptr;

		public static void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, VkBuffer* pCounterBuffers, uint counterBufferCount = default, ulong* pCounterBufferOffsets = default)
		{
			vkCmdEndTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, uint, void> vkCmdBeginQueryIndexedEXT_ptr;

		public static void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index, VkQueryControlFlags flags = default)
		{
			vkCmdBeginQueryIndexedEXT_ptr(commandBuffer, queryPool, query, flags, index);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void> vkCmdEndQueryIndexedEXT_ptr;

		public static void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
		{
			vkCmdEndQueryIndexedEXT_ptr(commandBuffer, queryPool, query, index);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirectByteCountEXT_ptr;

		public static void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
		{
			vkCmdDrawIndirectByteCountEXT_ptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetExclusiveScissorNV_ptr;

		public static void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
		{
			vkCmdSetExclusiveScissorNV_ptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindShadingRateImageNV_ptr;

		public static void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageLayout imageLayout, VkImageView imageView = default)
		{
			vkCmdBindShadingRateImageNV_ptr(commandBuffer, imageView, imageLayout);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void> vkCmdSetViewportShadingRatePaletteNV_ptr;

		public static void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
		{
			vkCmdSetViewportShadingRatePaletteNV_ptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> vkCmdSetCoarseSampleOrderNV_ptr;

		public static void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, VkCoarseSampleOrderCustomNV* pCustomSampleOrders, uint customSampleOrderCount = default)
		{
			vkCmdSetCoarseSampleOrderNV_ptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, void> vkCmdDrawMeshTasksNV_ptr;

		public static void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
		{
			vkCmdDrawMeshTasksNV_ptr(commandBuffer, taskCount, firstTask);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectNV_ptr;

		public static void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
		{
			vkCmdDrawMeshTasksIndirectNV_ptr(commandBuffer, buffer, offset, drawCount, stride);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectCountNV_ptr;

		public static void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
		{
			vkCmdDrawMeshTasksIndirectCountNV_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
		}

		internal static delegate* unmanaged<VkDevice, VkPipeline, uint, VkResult> vkCompileDeferredNV_ptr;

		public static VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
		{
			return vkCompileDeferredNV_ptr(device, pipeline, shader);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult> vkCreateAccelerationStructureNV_ptr;

		public static VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV pCreateInfo, VkAccelerationStructureNV* pAccelerationStructure, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateAccelerationStructureNV_ptr(device, &pCreateInfo, pAllocator, pAccelerationStructure);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void> vkDestroyAccelerationStructureKHR_ptr;

		public static void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyAccelerationStructureKHR_ptr(device, accelerationStructure, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void> vkDestroyAccelerationStructureNV_ptr;

		public static void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyAccelerationStructureNV_ptr(device, accelerationStructure, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetAccelerationStructureMemoryRequirementsNV_ptr;

		public static void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
		{
			vkGetAccelerationStructureMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> vkBindAccelerationStructureMemoryNV_ptr;

		public static VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
		{
			return vkBindAccelerationStructureMemoryNV_ptr(device, bindInfoCount, pBindInfos);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void> vkCmdCopyAccelerationStructureNV_ptr;

		public static void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
		{
			vkCmdCopyAccelerationStructureNV_ptr(commandBuffer, dst, src, mode);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> vkCmdCopyAccelerationStructureKHR_ptr;

		public static void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
		{
			vkCmdCopyAccelerationStructureKHR_ptr(commandBuffer, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult> vkCopyAccelerationStructureKHR_ptr;

		public static VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkCopyAccelerationStructureInfoKHR* pInfo, VkDeferredOperationKHR deferredOperation = default)
		{
			return vkCopyAccelerationStructureKHR_ptr(device, deferredOperation, pInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> vkCmdCopyAccelerationStructureToMemoryKHR_ptr;

		public static void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
		{
			vkCmdCopyAccelerationStructureToMemoryKHR_ptr(commandBuffer, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult> vkCopyAccelerationStructureToMemoryKHR_ptr;

		public static VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo, VkDeferredOperationKHR deferredOperation = default)
		{
			return vkCopyAccelerationStructureToMemoryKHR_ptr(device, deferredOperation, pInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> vkCmdCopyMemoryToAccelerationStructureKHR_ptr;

		public static void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
		{
			vkCmdCopyMemoryToAccelerationStructureKHR_ptr(commandBuffer, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult> vkCopyMemoryToAccelerationStructureKHR_ptr;

		public static VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo, VkDeferredOperationKHR deferredOperation = default)
		{
			return vkCopyMemoryToAccelerationStructureKHR_ptr(device, deferredOperation, pInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesKHR_ptr;

		public static void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
		{
			vkCmdWriteAccelerationStructuresPropertiesKHR_ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesNV_ptr;

		public static void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
		{
			vkCmdWriteAccelerationStructuresPropertiesNV_ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, ulong, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void> vkCmdBuildAccelerationStructureNV_ptr;

		public static void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkBuffer scratch, ulong scratchOffset, VkBuffer instanceData = default, VkAccelerationStructureNV src = default)
		{
			vkCmdBuildAccelerationStructureNV_ptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
		}

		internal static delegate* unmanaged<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult> vkWriteAccelerationStructuresPropertiesKHR_ptr;

		public static VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
		{
			return vkWriteAccelerationStructuresPropertiesKHR_ptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void> vkCmdTraceRaysKHR_ptr;

		public static void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
		{
			vkCmdTraceRaysKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void> vkCmdTraceRaysNV_ptr;

		public static void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, ulong missShaderBindingOffset, ulong missShaderBindingStride, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth, VkBuffer missShaderBindingTableBuffer = default, VkBuffer hitShaderBindingTableBuffer = default, VkBuffer callableShaderBindingTableBuffer = default)
		{
			vkCmdTraceRaysNV_ptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
		}

		internal static delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> vkGetRayTracingShaderGroupHandlesKHR_ptr;

		public static VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
		{
			return vkGetRayTracingShaderGroupHandlesKHR_ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
		}

		internal static delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr;

		public static VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
		{
			return vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult> vkGetAccelerationStructureHandleNV_ptr;

		public static VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* pData)
		{
			return vkGetAccelerationStructureHandleNV_ptr(device, accelerationStructure, dataSize, pData);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateRayTracingPipelinesNV_ptr;

		public static VkResult vkCreateRayTracingPipelinesNV(VkDevice device, uint createInfoCount, VkRayTracingPipelineCreateInfoNV pCreateInfos, VkPipeline* pPipelines, VkPipelineCache pipelineCache = default, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateRayTracingPipelinesNV_ptr(device, pipelineCache, createInfoCount, &pCreateInfos, pAllocator, pPipelines);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateRayTracingPipelinesKHR_ptr;

		public static VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR pCreateInfos, VkPipeline* pPipelines, VkDeferredOperationKHR deferredOperation = default, VkPipelineCache pipelineCache = default, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateRayTracingPipelinesKHR_ptr(device, deferredOperation, pipelineCache, createInfoCount, &pCreateInfos, pAllocator, pPipelines);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr;

		public static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties = default)
		{
			return vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr(physicalDevice, pPropertyCount, pProperties);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, IntPtr, void> vkCmdTraceRaysIndirectKHR_ptr;

		public static void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, IntPtr indirectDeviceAddress)
		{
			vkCmdTraceRaysIndirectKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void> vkGetDeviceAccelerationStructureCompatibilityKHR_ptr;

		public static void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
		{
			vkGetDeviceAccelerationStructureCompatibilityKHR_ptr(device, pVersionInfo, pCompatibility);
		}

		internal static delegate* unmanaged<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, ulong> vkGetRayTracingShaderGroupStackSizeKHR_ptr;

		public static ulong vkGetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
		{
			return vkGetRayTracingShaderGroupStackSizeKHR_ptr(device, pipeline, group, groupShader);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetRayTracingPipelineStackSizeKHR_ptr;

		public static void vkCmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
		{
			vkCmdSetRayTracingPipelineStackSizeKHR_ptr(commandBuffer, pipelineStackSize);
		}

		internal static delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, uint> vkGetImageViewHandleNVX_ptr;

		public static uint vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
		{
			return vkGetImageViewHandleNVX_ptr(device, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> vkGetImageViewAddressNVX_ptr;

		public static VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
		{
			return vkGetImageViewAddressNVX_ptr(device, imageView, pProperties);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult> vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr;

		public static VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes = default)
		{
			return vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
		}

		internal static delegate* unmanaged<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagsKHR*, VkResult> vkGetDeviceGroupSurfacePresentModes2EXT_ptr;

		public static VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes)
		{
			return vkGetDeviceGroupSurfacePresentModes2EXT_ptr(device, pSurfaceInfo, pModes);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> vkAcquireFullScreenExclusiveModeEXT_ptr;

		public static VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
		{
			return vkAcquireFullScreenExclusiveModeEXT_ptr(device, swapchain);
		}

		internal static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> vkReleaseFullScreenExclusiveModeEXT_ptr;

		public static VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
		{
			return vkReleaseFullScreenExclusiveModeEXT_ptr(device, swapchain);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr;

		public static VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters = default, VkPerformanceCounterDescriptionKHR* pCounterDescriptions = default)
		{
			return vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr;

		public static void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, uint* pNumPasses)
		{
			vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr(physicalDevice, &pPerformanceQueryCreateInfo, pNumPasses);
		}

		internal static delegate* unmanaged<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> vkAcquireProfilingLockKHR_ptr;

		public static VkResult vkAcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
		{
			return vkAcquireProfilingLockKHR_ptr(device, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, void> vkReleaseProfilingLockKHR_ptr;

		public static void vkReleaseProfilingLockKHR(VkDevice device)
		{
			vkReleaseProfilingLockKHR_ptr(device);
		}

		internal static delegate* unmanaged<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> vkGetImageDrmFormatModifierPropertiesEXT_ptr;

		public static VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
		{
			return vkGetImageDrmFormatModifierPropertiesEXT_ptr(device, image, pProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferOpaqueCaptureAddress_ptr;

		public static ulong vkGetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
		{
			return vkGetBufferOpaqueCaptureAddress_ptr(device, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, IntPtr> vkGetBufferDeviceAddress_ptr;

		public static IntPtr vkGetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
		{
			return vkGetBufferDeviceAddress_ptr(device, pInfo);
		}

		internal static delegate* unmanaged<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateHeadlessSurfaceEXT_ptr;

		public static VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT pCreateInfo, VkSurfaceKHR* pSurface, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateHeadlessSurfaceEXT_ptr(instance, &pCreateInfo, pAllocator, pSurface);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr;

		public static VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations = default)
		{
			return vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr(physicalDevice, pCombinationCount, pCombinations);
		}

		internal static delegate* unmanaged<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> vkInitializePerformanceApiINTEL_ptr;

		public static VkResult vkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
		{
			return vkInitializePerformanceApiINTEL_ptr(device, pInitializeInfo);
		}

		internal static delegate* unmanaged<VkDevice, void> vkUninitializePerformanceApiINTEL_ptr;

		public static void vkUninitializePerformanceApiINTEL(VkDevice device)
		{
			vkUninitializePerformanceApiINTEL_ptr(device);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> vkCmdSetPerformanceMarkerINTEL_ptr;

		public static VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
		{
			return vkCmdSetPerformanceMarkerINTEL_ptr(commandBuffer, pMarkerInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult> vkCmdSetPerformanceStreamMarkerINTEL_ptr;

		public static VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
		{
			return vkCmdSetPerformanceStreamMarkerINTEL_ptr(commandBuffer, pMarkerInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> vkCmdSetPerformanceOverrideINTEL_ptr;

		public static VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
		{
			return vkCmdSetPerformanceOverrideINTEL_ptr(commandBuffer, pOverrideInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult> vkAcquirePerformanceConfigurationINTEL_ptr;

		public static VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
		{
			return vkAcquirePerformanceConfigurationINTEL_ptr(device, pAcquireInfo, pConfiguration);
		}

		internal static delegate* unmanaged<VkDevice, VkPerformanceConfigurationINTEL, VkResult> vkReleasePerformanceConfigurationINTEL_ptr;

		public static VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration = default)
		{
			return vkReleasePerformanceConfigurationINTEL_ptr(device, configuration);
		}

		internal static delegate* unmanaged<VkQueue, VkPerformanceConfigurationINTEL, VkResult> vkQueueSetPerformanceConfigurationINTEL_ptr;

		public static VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
		{
			return vkQueueSetPerformanceConfigurationINTEL_ptr(queue, configuration);
		}

		internal static delegate* unmanaged<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> vkGetPerformanceParameterINTEL_ptr;

		public static VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
		{
			return vkGetPerformanceParameterINTEL_ptr(device, parameter, pValue);
		}

		internal static delegate* unmanaged<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> vkGetDeviceMemoryOpaqueCaptureAddress_ptr;

		public static ulong vkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
		{
			return vkGetDeviceMemoryOpaqueCaptureAddress_ptr(device, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult> vkGetPipelineExecutablePropertiesKHR_ptr;

		public static VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties = default)
		{
			return vkGetPipelineExecutablePropertiesKHR_ptr(device, pPipelineInfo, pExecutableCount, pProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult> vkGetPipelineExecutableStatisticsKHR_ptr;

		public static VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics = default)
		{
			return vkGetPipelineExecutableStatisticsKHR_ptr(device, pExecutableInfo, pStatisticCount, pStatistics);
		}

		internal static delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult> vkGetPipelineExecutableInternalRepresentationsKHR_ptr;

		public static VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations = default)
		{
			return vkGetPipelineExecutableInternalRepresentationsKHR_ptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, ushort, void> vkCmdSetLineStippleEXT_ptr;

		public static void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
		{
			vkCmdSetLineStippleEXT_ptr(commandBuffer, lineStippleFactor, lineStipplePattern);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolPropertiesEXT*, VkResult> vkGetPhysicalDeviceToolPropertiesEXT_ptr;

		public static VkResult vkGetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties = default)
		{
			return vkGetPhysicalDeviceToolPropertiesEXT_ptr(physicalDevice, pToolCount, pToolProperties);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult> vkCreateAccelerationStructureKHR_ptr;

		public static VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR pCreateInfo, VkAccelerationStructureKHR* pAccelerationStructure, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateAccelerationStructureKHR_ptr(device, &pCreateInfo, pAllocator, pAccelerationStructure);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void> vkCmdBuildAccelerationStructuresKHR_ptr;

		public static void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
		{
			vkCmdBuildAccelerationStructuresKHR_ptr(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, IntPtr*, uint*, uint**, void> vkCmdBuildAccelerationStructuresIndirectKHR_ptr;

		public static void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
		{
			vkCmdBuildAccelerationStructuresIndirectKHR_ptr(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> vkBuildAccelerationStructuresKHR_ptr;

		public static VkResult vkBuildAccelerationStructuresKHR(VkDevice device, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos, VkDeferredOperationKHR deferredOperation = default)
		{
			return vkBuildAccelerationStructuresKHR_ptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, IntPtr> vkGetAccelerationStructureDeviceAddressKHR_ptr;

		public static IntPtr vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
		{
			return vkGetAccelerationStructureDeviceAddressKHR_ptr(device, pInfo);
		}

		internal static delegate* unmanaged<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult> vkCreateDeferredOperationKHR_ptr;

		public static VkResult vkCreateDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR* pDeferredOperation, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreateDeferredOperationKHR_ptr(device, pAllocator, pDeferredOperation);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void> vkDestroyDeferredOperationKHR_ptr;

		public static void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyDeferredOperationKHR_ptr(device, operation, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint> vkGetDeferredOperationMaxConcurrencyKHR_ptr;

		public static uint vkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
		{
			return vkGetDeferredOperationMaxConcurrencyKHR_ptr(device, operation);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult> vkGetDeferredOperationResultKHR_ptr;

		public static VkResult vkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
		{
			return vkGetDeferredOperationResultKHR_ptr(device, operation);
		}

		internal static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult> vkDeferredOperationJoinKHR_ptr;

		public static VkResult vkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
		{
			return vkDeferredOperationJoinKHR_ptr(device, operation);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCullModeFlags, void> vkCmdSetCullModeEXT_ptr;

		public static void vkCmdSetCullModeEXT(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode = default)
		{
			vkCmdSetCullModeEXT_ptr(commandBuffer, cullMode);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkFrontFace, void> vkCmdSetFrontFaceEXT_ptr;

		public static void vkCmdSetFrontFaceEXT(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
		{
			vkCmdSetFrontFaceEXT_ptr(commandBuffer, frontFace);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPrimitiveTopology, void> vkCmdSetPrimitiveTopologyEXT_ptr;

		public static void vkCmdSetPrimitiveTopologyEXT(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
		{
			vkCmdSetPrimitiveTopologyEXT_ptr(commandBuffer, primitiveTopology);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkViewport*, void> vkCmdSetViewportWithCountEXT_ptr;

		public static void vkCmdSetViewportWithCountEXT(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
		{
			vkCmdSetViewportWithCountEXT_ptr(commandBuffer, viewportCount, pViewports);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkRect2D*, void> vkCmdSetScissorWithCountEXT_ptr;

		public static void vkCmdSetScissorWithCountEXT(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
		{
			vkCmdSetScissorWithCountEXT_ptr(commandBuffer, scissorCount, pScissors);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void> vkCmdBindVertexBuffers2EXT_ptr;

		public static void vkCmdBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes = default, ulong* pStrides = default)
		{
			vkCmdBindVertexBuffers2EXT_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetDepthTestEnableEXT_ptr;

		public static void vkCmdSetDepthTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable)
		{
			vkCmdSetDepthTestEnableEXT_ptr(commandBuffer, depthTestEnable);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetDepthWriteEnableEXT_ptr;

		public static void vkCmdSetDepthWriteEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable)
		{
			vkCmdSetDepthWriteEnableEXT_ptr(commandBuffer, depthWriteEnable);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCompareOp, void> vkCmdSetDepthCompareOpEXT_ptr;

		public static void vkCmdSetDepthCompareOpEXT(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
		{
			vkCmdSetDepthCompareOpEXT_ptr(commandBuffer, depthCompareOp);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetDepthBoundsTestEnableEXT_ptr;

		public static void vkCmdSetDepthBoundsTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable)
		{
			vkCmdSetDepthBoundsTestEnableEXT_ptr(commandBuffer, depthBoundsTestEnable);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetStencilTestEnableEXT_ptr;

		public static void vkCmdSetStencilTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable)
		{
			vkCmdSetStencilTestEnableEXT_ptr(commandBuffer, stencilTestEnable);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> vkCmdSetStencilOpEXT_ptr;

		public static void vkCmdSetStencilOpEXT(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
		{
			vkCmdSetStencilOpEXT_ptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
		}

		internal static delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfoEXT*, VkAllocationCallbacks*, VkPrivateDataSlotEXT*, VkResult> vkCreatePrivateDataSlotEXT_ptr;

		public static VkResult vkCreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfoEXT pCreateInfo, VkPrivateDataSlotEXT* pPrivateDataSlot, VkAllocationCallbacks* pAllocator = default)
		{
			return vkCreatePrivateDataSlotEXT_ptr(device, &pCreateInfo, pAllocator, pPrivateDataSlot);
		}

		internal static delegate* unmanaged<VkDevice, VkPrivateDataSlotEXT, VkAllocationCallbacks*, void> vkDestroyPrivateDataSlotEXT_ptr;

		public static void vkDestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotEXT privateDataSlot = default, VkAllocationCallbacks* pAllocator = default)
		{
			vkDestroyPrivateDataSlotEXT_ptr(device, privateDataSlot, pAllocator);
		}

		internal static delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlotEXT, ulong, VkResult> vkSetPrivateDataEXT_ptr;

		public static VkResult vkSetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong data)
		{
			return vkSetPrivateDataEXT_ptr(device, objectType, objectHandle, privateDataSlot, data);
		}

		internal static delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlotEXT, ulong*, void> vkGetPrivateDataEXT_ptr;

		public static void vkGetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong* pData)
		{
			vkGetPrivateDataEXT_ptr(device, objectType, objectHandle, privateDataSlot, pData);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2KHR*, void> vkCmdCopyBuffer2KHR_ptr;

		public static void vkCmdCopyBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyBufferInfo2KHR* pCopyBufferInfo)
		{
			vkCmdCopyBuffer2KHR_ptr(commandBuffer, pCopyBufferInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2KHR*, void> vkCmdCopyImage2KHR_ptr;

		public static void vkCmdCopyImage2KHR(VkCommandBuffer commandBuffer, VkCopyImageInfo2KHR* pCopyImageInfo)
		{
			vkCmdCopyImage2KHR_ptr(commandBuffer, pCopyImageInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2KHR*, void> vkCmdBlitImage2KHR_ptr;

		public static void vkCmdBlitImage2KHR(VkCommandBuffer commandBuffer, VkBlitImageInfo2KHR* pBlitImageInfo)
		{
			vkCmdBlitImage2KHR_ptr(commandBuffer, pBlitImageInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2KHR*, void> vkCmdCopyBufferToImage2KHR_ptr;

		public static void vkCmdCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo)
		{
			vkCmdCopyBufferToImage2KHR_ptr(commandBuffer, pCopyBufferToImageInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2KHR*, void> vkCmdCopyImageToBuffer2KHR_ptr;

		public static void vkCmdCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo)
		{
			vkCmdCopyImageToBuffer2KHR_ptr(commandBuffer, pCopyImageToBufferInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2KHR*, void> vkCmdResolveImage2KHR_ptr;

		public static void vkCmdResolveImage2KHR(VkCommandBuffer commandBuffer, VkResolveImageInfo2KHR* pResolveImageInfo)
		{
			vkCmdResolveImage2KHR_ptr(commandBuffer, pResolveImageInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, Vector2ui*, VkFragmentShadingRateCombinerOpKHR, void> vkCmdSetFragmentShadingRateKHR_ptr;

		public static void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, Vector2ui* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
		{
			vkCmdSetFragmentShadingRateKHR_ptr(commandBuffer, pFragmentSize, combinerOps);
		}

		internal static delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr;

		public static VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates = default)
		{
			return vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR, void> vkCmdSetFragmentShadingRateEnumNV_ptr;

		public static void vkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps)
		{
			vkCmdSetFragmentShadingRateEnumNV_ptr(commandBuffer, shadingRate, combinerOps);
		}

		internal static delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void> vkGetAccelerationStructureBuildSizesKHR_ptr;

		public static void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo, uint* pMaxPrimitiveCounts = default)
		{
			vkGetAccelerationStructureBuildSizesKHR_ptr(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfoKHR*, void> vkCmdSetEvent2KHR_ptr;

		public static void vkCmdSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfoKHR* pDependencyInfo)
		{
			vkCmdSetEvent2KHR_ptr(commandBuffer, @event, pDependencyInfo);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlags2KHR, void> vkCmdResetEvent2KHR_ptr;

		public static void vkCmdResetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2KHR stageMask)
		{
			vkCmdResetEvent2KHR_ptr(commandBuffer, @event, stageMask);
		}

		internal static delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfoKHR*, void> vkCmdWaitEvents2KHR_ptr;

		public static void vkCmdWaitEvents2KHR(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfoKHR* pDependencyInfos)
		{
			vkCmdWaitEvents2KHR_ptr(commandBuffer, eventCount, pEvents, pDependencyInfos);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkDependencyInfoKHR*, void> vkCmdPipelineBarrier2KHR_ptr;

		public static void vkCmdPipelineBarrier2KHR(VkCommandBuffer commandBuffer, VkDependencyInfoKHR* pDependencyInfo)
		{
			vkCmdPipelineBarrier2KHR_ptr(commandBuffer, pDependencyInfo);
		}

		internal static delegate* unmanaged<VkQueue, uint, VkSubmitInfo2KHR*, VkFence, VkResult> vkQueueSubmit2KHR_ptr;

		public static VkResult vkQueueSubmit2KHR(VkQueue queue, VkSubmitInfo2KHR* pSubmits, uint submitCount = default, VkFence fence = default)
		{
			return vkQueueSubmit2KHR_ptr(queue, submitCount, pSubmits, fence);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags2KHR, VkQueryPool, uint, void> vkCmdWriteTimestamp2KHR_ptr;

		public static void vkCmdWriteTimestamp2KHR(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkQueryPool queryPool, uint query)
		{
			vkCmdWriteTimestamp2KHR_ptr(commandBuffer, stage, queryPool, query);
		}

		internal static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags2KHR, VkBuffer, ulong, uint, void> vkCmdWriteBufferMarker2AMD_ptr;

		public static void vkCmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
		{
			vkCmdWriteBufferMarker2AMD_ptr(commandBuffer, stage, dstBuffer, dstOffset, marker);
		}

		internal static delegate* unmanaged<VkQueue, uint*, VkCheckpointData2NV*, void> vkGetQueueCheckpointData2NV_ptr;

		public static void vkGetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData = default)
		{
			vkGetQueueCheckpointData2NV_ptr(queue, pCheckpointDataCount, pCheckpointData);
		}

	}
}