// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable PartialTypeWithSinglePart

using System;
using System.Runtime.InteropServices;

namespace Fireburst;
[StructLayout(LayoutKind.Sequential)]
public partial struct VkBaseOutStructure
{
	public VkStructureType sType;
	public unsafe VkBaseOutStructure* pNext;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBaseInStructure
{
	public VkStructureType sType;
	public unsafe VkBaseInStructure* pNext;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkClearRect
{
	public VkRect2D rect;
	public uint baseArrayLayer;
	public uint layerCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceProperties
{
	public uint apiVersion;
	public uint driverVersion;
	public uint vendorID;
	public uint deviceID;
	public VkPhysicalDeviceType deviceType;
	public unsafe fixed byte deviceName[Vulkan.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
	public unsafe fixed byte pipelineCacheUUID[Vulkan.VK_UUID_SIZE];
	public VkPhysicalDeviceLimits limits;
	public VkPhysicalDeviceSparseProperties sparseProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExtensionProperties
{
	public unsafe fixed byte extensionName[Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
	public uint specVersion;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkLayerProperties
{
	public unsafe fixed byte layerName[Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
	public uint specVersion;
	public uint implementationVersion;
	public unsafe fixed byte description[Vulkan.VK_MAX_DESCRIPTION_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkApplicationInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe byte* pApplicationName;
	public uint applicationVersion;
	public unsafe byte* pEngineName;
	public uint engineVersion;
	public uint apiVersion;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceQueueCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceQueueCreateFlags flags;
	public uint queueFamilyIndex;
	public uint queueCount;
	public unsafe float* pQueuePriorities;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceCreateFlags flags;
	public uint queueCreateInfoCount;
	public unsafe VkDeviceQueueCreateInfo* pQueueCreateInfos;
	public uint enabledLayerCount;
	public unsafe byte** ppEnabledLayerNames;
	public uint enabledExtensionCount;
	public unsafe byte** ppEnabledExtensionNames;
	public unsafe VkPhysicalDeviceFeatures* pEnabledFeatures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkInstanceCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkInstanceCreateFlags flags;
	public unsafe VkApplicationInfo* pApplicationInfo;
	public uint enabledLayerCount;
	public unsafe byte** ppEnabledLayerNames;
	public uint enabledExtensionCount;
	public unsafe byte** ppEnabledExtensionNames;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueueFamilyProperties
{
	public VkQueueFlags queueFlags;
	public uint queueCount;
	public uint timestampValidBits;
	public Vector3ui minImageTransferGranularity;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMemoryProperties
{
	public uint memoryTypeCount;
	public VkMemoryType memoryTypes_0;
	public VkMemoryType memoryTypes_1;
	public VkMemoryType memoryTypes_2;
	public VkMemoryType memoryTypes_3;
	public VkMemoryType memoryTypes_4;
	public VkMemoryType memoryTypes_5;
	public VkMemoryType memoryTypes_6;
	public VkMemoryType memoryTypes_7;
	public VkMemoryType memoryTypes_8;
	public VkMemoryType memoryTypes_9;
	public VkMemoryType memoryTypes_10;
	public VkMemoryType memoryTypes_11;
	public VkMemoryType memoryTypes_12;
	public VkMemoryType memoryTypes_13;
	public VkMemoryType memoryTypes_14;
	public VkMemoryType memoryTypes_15;
	public VkMemoryType memoryTypes_16;
	public VkMemoryType memoryTypes_17;
	public VkMemoryType memoryTypes_18;
	public VkMemoryType memoryTypes_19;
	public VkMemoryType memoryTypes_20;
	public VkMemoryType memoryTypes_21;
	public VkMemoryType memoryTypes_22;
	public VkMemoryType memoryTypes_23;
	public VkMemoryType memoryTypes_24;
	public VkMemoryType memoryTypes_25;
	public VkMemoryType memoryTypes_26;
	public VkMemoryType memoryTypes_27;
	public VkMemoryType memoryTypes_28;
	public VkMemoryType memoryTypes_29;
	public VkMemoryType memoryTypes_30;
	public VkMemoryType memoryTypes_31;
	public uint memoryHeapCount;
	public VkMemoryHeap memoryHeaps_0;
	public VkMemoryHeap memoryHeaps_1;
	public VkMemoryHeap memoryHeaps_2;
	public VkMemoryHeap memoryHeaps_3;
	public VkMemoryHeap memoryHeaps_4;
	public VkMemoryHeap memoryHeaps_5;
	public VkMemoryHeap memoryHeaps_6;
	public VkMemoryHeap memoryHeaps_7;
	public VkMemoryHeap memoryHeaps_8;
	public VkMemoryHeap memoryHeaps_9;
	public VkMemoryHeap memoryHeaps_10;
	public VkMemoryHeap memoryHeaps_11;
	public VkMemoryHeap memoryHeaps_12;
	public VkMemoryHeap memoryHeaps_13;
	public VkMemoryHeap memoryHeaps_14;
	public VkMemoryHeap memoryHeaps_15;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryAllocateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong allocationSize;
	public uint memoryTypeIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryRequirements
{
	public ulong size;
	public ulong alignment;
	public uint memoryTypeBits;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseImageFormatProperties
{
	public VkImageAspectFlags aspectMask;
	public Vector3ui imageGranularity;
	public VkSparseImageFormatFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseImageMemoryRequirements
{
	public VkSparseImageFormatProperties formatProperties;
	public uint imageMipTailFirstLod;
	public ulong imageMipTailSize;
	public ulong imageMipTailOffset;
	public ulong imageMipTailStride;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryType
{
	public VkMemoryPropertyFlags propertyFlags;
	public uint heapIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryHeap
{
	public ulong size;
	public VkMemoryHeapFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMappedMemoryRange
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceMemory memory;
	public ulong offset;
	public ulong size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFormatProperties
{
	public VkFormatFeatureFlags linearTilingFeatures;
	public VkFormatFeatureFlags optimalTilingFeatures;
	public VkFormatFeatureFlags bufferFeatures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageFormatProperties
{
	public Vector3ui maxExtent;
	public uint maxMipLevels;
	public uint maxArrayLayers;
	public VkSampleCountFlags sampleCounts;
	public ulong maxResourceSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorBufferInfo
{
	public VkBuffer buffer;
	public ulong offset;
	public ulong range;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorImageInfo
{
	public VkSampler sampler;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkWriteDescriptorSet
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDescriptorSet dstSet;
	public uint dstBinding;
	public uint dstArrayElement;
	public uint descriptorCount;
	public VkDescriptorType descriptorType;
	public unsafe VkDescriptorImageInfo* pImageInfo;
	public unsafe VkDescriptorBufferInfo* pBufferInfo;
	public unsafe VkBufferView* pTexelBufferView;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyDescriptorSet
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDescriptorSet srcSet;
	public uint srcBinding;
	public uint srcArrayElement;
	public VkDescriptorSet dstSet;
	public uint dstBinding;
	public uint dstArrayElement;
	public uint descriptorCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBufferCreateFlags flags;
	public ulong size;
	public VkBufferUsageFlags usage;
	public VkSharingMode sharingMode;
	public uint queueFamilyIndexCount;
	public unsafe uint* pQueueFamilyIndices;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferViewCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBufferViewCreateFlags flags;
	public VkBuffer buffer;
	public VkFormat format;
	public ulong offset;
	public ulong range;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageSubresource
{
	public VkImageAspectFlags aspectMask;
	public uint mipLevel;
	public uint arrayLayer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageSubresourceLayers
{
	public VkImageAspectFlags aspectMask;
	public uint mipLevel;
	public uint baseArrayLayer;
	public uint layerCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageSubresourceRange
{
	public VkImageAspectFlags aspectMask;
	public uint baseMipLevel;
	public uint levelCount;
	public uint baseArrayLayer;
	public uint layerCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryBarrier
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferMemoryBarrier
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkBuffer buffer;
	public ulong offset;
	public ulong size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageMemoryBarrier
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkImageLayout oldLayout;
	public VkImageLayout newLayout;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkImage image;
	public VkImageSubresourceRange subresourceRange;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageCreateFlags flags;
	public VkImageType imageType;
	public VkFormat format;
	public Vector3ui extent;
	public uint mipLevels;
	public uint arrayLayers;
	public VkSampleCountFlags samples;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkSharingMode sharingMode;
	public uint queueFamilyIndexCount;
	public unsafe uint* pQueueFamilyIndices;
	public VkImageLayout initialLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubresourceLayout
{
	public ulong offset;
	public ulong size;
	public ulong rowPitch;
	public ulong arrayPitch;
	public ulong depthPitch;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageViewCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageViewCreateFlags flags;
	public VkImage image;
	public VkImageViewType viewType;
	public VkFormat format;
	public VkComponentMapping components;
	public VkImageSubresourceRange subresourceRange;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferCopy
{
	public ulong srcOffset;
	public ulong dstOffset;
	public ulong size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseMemoryBind
{
	public ulong resourceOffset;
	public ulong size;
	public VkDeviceMemory memory;
	public ulong memoryOffset;
	public VkSparseMemoryBindFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseImageMemoryBind
{
	public VkImageSubresource subresource;
	public Vector3i offset;
	public Vector3ui extent;
	public VkDeviceMemory memory;
	public ulong memoryOffset;
	public VkSparseMemoryBindFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseBufferMemoryBindInfo
{
	public VkBuffer buffer;
	public uint bindCount;
	public unsafe VkSparseMemoryBind* pBinds;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseImageOpaqueMemoryBindInfo
{
	public VkImage image;
	public uint bindCount;
	public unsafe VkSparseMemoryBind* pBinds;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseImageMemoryBindInfo
{
	public VkImage image;
	public uint bindCount;
	public unsafe VkSparseImageMemoryBind* pBinds;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindSparseInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint waitSemaphoreCount;
	public unsafe VkSemaphore* pWaitSemaphores;
	public uint bufferBindCount;
	public unsafe VkSparseBufferMemoryBindInfo* pBufferBinds;
	public uint imageOpaqueBindCount;
	public unsafe VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
	public uint imageBindCount;
	public unsafe VkSparseImageMemoryBindInfo* pImageBinds;
	public uint signalSemaphoreCount;
	public unsafe VkSemaphore* pSignalSemaphores;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageCopy
{
	public VkImageSubresourceLayers srcSubresource;
	public Vector3i srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public Vector3i dstOffset;
	public Vector3ui extent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageBlit
{
	public VkImageSubresourceLayers srcSubresource;
	public Vector3i srcOffsets_0;
	public Vector3i srcOffsets_1;
	public VkImageSubresourceLayers dstSubresource;
	public Vector3i dstOffsets_0;
	public Vector3i dstOffsets_1;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferImageCopy
{
	public ulong bufferOffset;
	public uint bufferRowLength;
	public uint bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public Vector3i imageOffset;
	public Vector3ui imageExtent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageResolve
{
	public VkImageSubresourceLayers srcSubresource;
	public Vector3i srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public Vector3i dstOffset;
	public Vector3ui extent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkShaderModuleCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkShaderModuleCreateFlags flags;
	public nuint codeSize;
	public unsafe uint* pCode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetLayoutBinding
{
	public uint binding;
	public VkDescriptorType descriptorType;
	public uint descriptorCount;
	public VkShaderStageFlags stageFlags;
	public unsafe VkSampler* pImmutableSamplers;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetLayoutCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDescriptorSetLayoutCreateFlags flags;
	public uint bindingCount;
	public unsafe VkDescriptorSetLayoutBinding* pBindings;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorPoolSize
{
	public VkDescriptorType type;
	public uint descriptorCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorPoolCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDescriptorPoolCreateFlags flags;
	public uint maxSets;
	public uint poolSizeCount;
	public unsafe VkDescriptorPoolSize* pPoolSizes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetAllocateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDescriptorPool descriptorPool;
	public uint descriptorSetCount;
	public unsafe VkDescriptorSetLayout* pSetLayouts;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSpecializationMapEntry
{
	public uint constantID;
	public uint offset;
	public nuint size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSpecializationInfo
{
	public uint mapEntryCount;
	public unsafe VkSpecializationMapEntry* pMapEntries;
	public nuint dataSize;
	public unsafe void* pData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineShaderStageCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineShaderStageCreateFlags flags;
	public VkShaderStageFlags stage;
	public VkShaderModule module;
	public unsafe byte* pName;
	public unsafe VkSpecializationInfo* pSpecializationInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkComputePipelineCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCreateFlags flags;
	public VkPipelineShaderStageCreateInfo stage;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int basePipelineIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVertexInputBindingDescription
{
	public uint binding;
	public uint stride;
	public VkVertexInputRate inputRate;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVertexInputAttributeDescription
{
	public uint location;
	public uint binding;
	public VkFormat format;
	public uint offset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineVertexInputStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineVertexInputStateCreateFlags flags;
	public uint vertexBindingDescriptionCount;
	public unsafe VkVertexInputBindingDescription* pVertexBindingDescriptions;
	public uint vertexAttributeDescriptionCount;
	public unsafe VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineInputAssemblyStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineInputAssemblyStateCreateFlags flags;
	public VkPrimitiveTopology topology;
	public VkBool32 primitiveRestartEnable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineTessellationStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineTessellationStateCreateFlags flags;
	public uint patchControlPoints;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineViewportStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineViewportStateCreateFlags flags;
	public uint viewportCount;
	public unsafe VkViewport* pViewports;
	public uint scissorCount;
	public unsafe VkRect2D* pScissors;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRasterizationStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineRasterizationStateCreateFlags flags;
	public VkBool32 depthClampEnable;
	public VkBool32 rasterizerDiscardEnable;
	public VkPolygonMode polygonMode;
	public VkCullModeFlags cullMode;
	public VkFrontFace frontFace;
	public VkBool32 depthBiasEnable;
	public float depthBiasConstantFactor;
	public float depthBiasClamp;
	public float depthBiasSlopeFactor;
	public float lineWidth;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineMultisampleStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineMultisampleStateCreateFlags flags;
	public VkSampleCountFlags rasterizationSamples;
	public VkBool32 sampleShadingEnable;
	public float minSampleShading;
	public unsafe uint* pSampleMask;
	public VkBool32 alphaToCoverageEnable;
	public VkBool32 alphaToOneEnable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineColorBlendAttachmentState
{
	public VkBool32 blendEnable;
	public VkBlendFactor srcColorBlendFactor;
	public VkBlendFactor dstColorBlendFactor;
	public VkBlendOp colorBlendOp;
	public VkBlendFactor srcAlphaBlendFactor;
	public VkBlendFactor dstAlphaBlendFactor;
	public VkBlendOp alphaBlendOp;
	public VkColorComponentFlags colorWriteMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineColorBlendStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineColorBlendStateCreateFlags flags;
	public VkBool32 logicOpEnable;
	public VkLogicOp logicOp;
	public uint attachmentCount;
	public unsafe VkPipelineColorBlendAttachmentState* pAttachments;
	public float blendConstants_0;
	public float blendConstants_1;
	public float blendConstants_2;
	public float blendConstants_3;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineDynamicStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineDynamicStateCreateFlags flags;
	public uint dynamicStateCount;
	public unsafe VkDynamicState* pDynamicStates;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkStencilOpState
{
	public VkStencilOp failOp;
	public VkStencilOp passOp;
	public VkStencilOp depthFailOp;
	public VkCompareOp compareOp;
	public uint compareMask;
	public uint writeMask;
	public uint reference;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineDepthStencilStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineDepthStencilStateCreateFlags flags;
	public VkBool32 depthTestEnable;
	public VkBool32 depthWriteEnable;
	public VkCompareOp depthCompareOp;
	public VkBool32 depthBoundsTestEnable;
	public VkBool32 stencilTestEnable;
	public VkStencilOpState front;
	public VkStencilOpState back;
	public float minDepthBounds;
	public float maxDepthBounds;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGraphicsPipelineCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCreateFlags flags;
	public uint stageCount;
	public unsafe VkPipelineShaderStageCreateInfo* pStages;
	public unsafe VkPipelineVertexInputStateCreateInfo* pVertexInputState;
	public unsafe VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
	public unsafe VkPipelineTessellationStateCreateInfo* pTessellationState;
	public unsafe VkPipelineViewportStateCreateInfo* pViewportState;
	public unsafe VkPipelineRasterizationStateCreateInfo* pRasterizationState;
	public unsafe VkPipelineMultisampleStateCreateInfo* pMultisampleState;
	public unsafe VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
	public unsafe VkPipelineColorBlendStateCreateInfo* pColorBlendState;
	public unsafe VkPipelineDynamicStateCreateInfo* pDynamicState;
	public VkPipelineLayout layout;
	public VkRenderPass renderPass;
	public uint subpass;
	public VkPipeline basePipelineHandle;
	public int basePipelineIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineCacheCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCacheCreateFlags flags;
	public nuint initialDataSize;
	public unsafe void* pInitialData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineCacheHeaderVersionOne
{
	public uint headerSize;
	public VkPipelineCacheHeaderVersion headerVersion;
	public uint vendorID;
	public uint deviceID;
	public unsafe fixed byte pipelineCacheUUID[Vulkan.VK_UUID_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPushConstantRange
{
	public VkShaderStageFlags stageFlags;
	public uint offset;
	public uint size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineLayoutCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineLayoutCreateFlags flags;
	public uint setLayoutCount;
	public unsafe VkDescriptorSetLayout* pSetLayouts;
	public uint pushConstantRangeCount;
	public unsafe VkPushConstantRange* pPushConstantRanges;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSamplerCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSamplerCreateFlags flags;
	public VkFilter magFilter;
	public VkFilter minFilter;
	public VkSamplerMipmapMode mipmapMode;
	public VkSamplerAddressMode addressModeU;
	public VkSamplerAddressMode addressModeV;
	public VkSamplerAddressMode addressModeW;
	public float mipLodBias;
	public VkBool32 anisotropyEnable;
	public float maxAnisotropy;
	public VkBool32 compareEnable;
	public VkCompareOp compareOp;
	public float minLod;
	public float maxLod;
	public VkBorderColor borderColor;
	public VkBool32 unnormalizedCoordinates;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandPoolCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkCommandPoolCreateFlags flags;
	public uint queueFamilyIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandBufferAllocateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkCommandPool commandPool;
	public VkCommandBufferLevel level;
	public uint commandBufferCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandBufferInheritanceInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRenderPass renderPass;
	public uint subpass;
	public VkFramebuffer framebuffer;
	public VkBool32 occlusionQueryEnable;
	public VkQueryControlFlags queryFlags;
	public VkQueryPipelineStatisticFlags pipelineStatistics;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandBufferBeginInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkCommandBufferUsageFlags flags;
	public unsafe VkCommandBufferInheritanceInfo* pInheritanceInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassBeginInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRenderPass renderPass;
	public VkFramebuffer framebuffer;
	public VkRect2D renderArea;
	public uint clearValueCount;
	public unsafe VkClearValue* pClearValues;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkClearDepthStencilValue
{
	public float depth;
	public uint stencil;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkClearAttachment
{
	public VkImageAspectFlags aspectMask;
	public uint colorAttachment;
	public VkClearValue clearValue;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAttachmentDescription
{
	public VkAttachmentDescriptionFlags flags;
	public VkFormat format;
	public VkSampleCountFlags samples;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkAttachmentLoadOp stencilLoadOp;
	public VkAttachmentStoreOp stencilStoreOp;
	public VkImageLayout initialLayout;
	public VkImageLayout finalLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAttachmentReference
{
	public uint attachment;
	public VkImageLayout layout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassDescription
{
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint inputAttachmentCount;
	public unsafe VkAttachmentReference* pInputAttachments;
	public uint colorAttachmentCount;
	public unsafe VkAttachmentReference* pColorAttachments;
	public unsafe VkAttachmentReference* pResolveAttachments;
	public unsafe VkAttachmentReference* pDepthStencilAttachment;
	public uint preserveAttachmentCount;
	public unsafe uint* pPreserveAttachments;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassDependency
{
	public uint srcSubpass;
	public uint dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint attachmentCount;
	public unsafe VkAttachmentDescription* pAttachments;
	public uint subpassCount;
	public unsafe VkSubpassDescription* pSubpasses;
	public uint dependencyCount;
	public unsafe VkSubpassDependency* pDependencies;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkEventCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkEventCreateFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFenceCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFenceCreateFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFeatures
{
	public VkBool32 robustBufferAccess;
	public VkBool32 fullDrawIndexUint32;
	public VkBool32 imageCubeArray;
	public VkBool32 independentBlend;
	public VkBool32 geometryShader;
	public VkBool32 tessellationShader;
	public VkBool32 sampleRateShading;
	public VkBool32 dualSrcBlend;
	public VkBool32 logicOp;
	public VkBool32 multiDrawIndirect;
	public VkBool32 drawIndirectFirstInstance;
	public VkBool32 depthClamp;
	public VkBool32 depthBiasClamp;
	public VkBool32 fillModeNonSolid;
	public VkBool32 depthBounds;
	public VkBool32 wideLines;
	public VkBool32 largePoints;
	public VkBool32 alphaToOne;
	public VkBool32 multiViewport;
	public VkBool32 samplerAnisotropy;
	public VkBool32 textureCompressionETC2;
	public VkBool32 textureCompressionASTC_LDR;
	public VkBool32 textureCompressionBC;
	public VkBool32 occlusionQueryPrecise;
	public VkBool32 pipelineStatisticsQuery;
	public VkBool32 vertexPipelineStoresAndAtomics;
	public VkBool32 fragmentStoresAndAtomics;
	public VkBool32 shaderTessellationAndGeometryPointSize;
	public VkBool32 shaderImageGatherExtended;
	public VkBool32 shaderStorageImageExtendedFormats;
	public VkBool32 shaderStorageImageMultisample;
	public VkBool32 shaderStorageImageReadWithoutFormat;
	public VkBool32 shaderStorageImageWriteWithoutFormat;
	public VkBool32 shaderUniformBufferArrayDynamicIndexing;
	public VkBool32 shaderSampledImageArrayDynamicIndexing;
	public VkBool32 shaderStorageBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageImageArrayDynamicIndexing;
	public VkBool32 shaderClipDistance;
	public VkBool32 shaderCullDistance;
	public VkBool32 shaderFloat64;
	public VkBool32 shaderInt64;
	public VkBool32 shaderInt16;
	public VkBool32 shaderResourceResidency;
	public VkBool32 shaderResourceMinLod;
	public VkBool32 sparseBinding;
	public VkBool32 sparseResidencyBuffer;
	public VkBool32 sparseResidencyImage2D;
	public VkBool32 sparseResidencyImage3D;
	public VkBool32 sparseResidency2Samples;
	public VkBool32 sparseResidency4Samples;
	public VkBool32 sparseResidency8Samples;
	public VkBool32 sparseResidency16Samples;
	public VkBool32 sparseResidencyAliased;
	public VkBool32 variableMultisampleRate;
	public VkBool32 inheritedQueries;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSparseProperties
{
	public VkBool32 residencyStandard2DBlockShape;
	public VkBool32 residencyStandard2DMultisampleBlockShape;
	public VkBool32 residencyStandard3DBlockShape;
	public VkBool32 residencyAlignedMipSize;
	public VkBool32 residencyNonResidentStrict;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceLimits
{
	public uint maxImageDimension1D;
	public uint maxImageDimension2D;
	public uint maxImageDimension3D;
	public uint maxImageDimensionCube;
	public uint maxImageArrayLayers;
	public uint maxTexelBufferElements;
	public uint maxUniformBufferRange;
	public uint maxStorageBufferRange;
	public uint maxPushConstantsSize;
	public uint maxMemoryAllocationCount;
	public uint maxSamplerAllocationCount;
	public ulong bufferImageGranularity;
	public ulong sparseAddressSpaceSize;
	public uint maxBoundDescriptorSets;
	public uint maxPerStageDescriptorSamplers;
	public uint maxPerStageDescriptorUniformBuffers;
	public uint maxPerStageDescriptorStorageBuffers;
	public uint maxPerStageDescriptorSampledImages;
	public uint maxPerStageDescriptorStorageImages;
	public uint maxPerStageDescriptorInputAttachments;
	public uint maxPerStageResources;
	public uint maxDescriptorSetSamplers;
	public uint maxDescriptorSetUniformBuffers;
	public uint maxDescriptorSetUniformBuffersDynamic;
	public uint maxDescriptorSetStorageBuffers;
	public uint maxDescriptorSetStorageBuffersDynamic;
	public uint maxDescriptorSetSampledImages;
	public uint maxDescriptorSetStorageImages;
	public uint maxDescriptorSetInputAttachments;
	public uint maxVertexInputAttributes;
	public uint maxVertexInputBindings;
	public uint maxVertexInputAttributeOffset;
	public uint maxVertexInputBindingStride;
	public uint maxVertexOutputComponents;
	public uint maxTessellationGenerationLevel;
	public uint maxTessellationPatchSize;
	public uint maxTessellationControlPerVertexInputComponents;
	public uint maxTessellationControlPerVertexOutputComponents;
	public uint maxTessellationControlPerPatchOutputComponents;
	public uint maxTessellationControlTotalOutputComponents;
	public uint maxTessellationEvaluationInputComponents;
	public uint maxTessellationEvaluationOutputComponents;
	public uint maxGeometryShaderInvocations;
	public uint maxGeometryInputComponents;
	public uint maxGeometryOutputComponents;
	public uint maxGeometryOutputVertices;
	public uint maxGeometryTotalOutputComponents;
	public uint maxFragmentInputComponents;
	public uint maxFragmentOutputAttachments;
	public uint maxFragmentDualSrcAttachments;
	public uint maxFragmentCombinedOutputResources;
	public uint maxComputeSharedMemorySize;
	public uint maxComputeWorkGroupCount_0;
	public uint maxComputeWorkGroupCount_1;
	public uint maxComputeWorkGroupCount_2;
	public uint maxComputeWorkGroupInvocations;
	public uint maxComputeWorkGroupSize_0;
	public uint maxComputeWorkGroupSize_1;
	public uint maxComputeWorkGroupSize_2;
	public uint subPixelPrecisionBits;
	public uint subTexelPrecisionBits;
	public uint mipmapPrecisionBits;
	public uint maxDrawIndexedIndexValue;
	public uint maxDrawIndirectCount;
	public float maxSamplerLodBias;
	public float maxSamplerAnisotropy;
	public uint maxViewports;
	public uint maxViewportDimensions_0;
	public uint maxViewportDimensions_1;
	public float viewportBoundsRange_0;
	public float viewportBoundsRange_1;
	public uint viewportSubPixelBits;
	public nuint minMemoryMapAlignment;
	public ulong minTexelBufferOffsetAlignment;
	public ulong minUniformBufferOffsetAlignment;
	public ulong minStorageBufferOffsetAlignment;
	public int minTexelOffset;
	public uint maxTexelOffset;
	public int minTexelGatherOffset;
	public uint maxTexelGatherOffset;
	public float minInterpolationOffset;
	public float maxInterpolationOffset;
	public uint subPixelInterpolationOffsetBits;
	public uint maxFramebufferWidth;
	public uint maxFramebufferHeight;
	public uint maxFramebufferLayers;
	public VkSampleCountFlags framebufferColorSampleCounts;
	public VkSampleCountFlags framebufferDepthSampleCounts;
	public VkSampleCountFlags framebufferStencilSampleCounts;
	public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
	public uint maxColorAttachments;
	public VkSampleCountFlags sampledImageColorSampleCounts;
	public VkSampleCountFlags sampledImageIntegerSampleCounts;
	public VkSampleCountFlags sampledImageDepthSampleCounts;
	public VkSampleCountFlags sampledImageStencilSampleCounts;
	public VkSampleCountFlags storageImageSampleCounts;
	public uint maxSampleMaskWords;
	public VkBool32 timestampComputeAndGraphics;
	public float timestampPeriod;
	public uint maxClipDistances;
	public uint maxCullDistances;
	public uint maxCombinedClipAndCullDistances;
	public uint discreteQueuePriorities;
	public float pointSizeRange_0;
	public float pointSizeRange_1;
	public float lineWidthRange_0;
	public float lineWidthRange_1;
	public float pointSizeGranularity;
	public float lineWidthGranularity;
	public VkBool32 strictLines;
	public VkBool32 standardSampleLocations;
	public ulong optimalBufferCopyOffsetAlignment;
	public ulong optimalBufferCopyRowPitchAlignment;
	public ulong nonCoherentAtomSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSemaphoreCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphoreCreateFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueryPoolCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkQueryPoolCreateFlags flags;
	public VkQueryType queryType;
	public uint queryCount;
	public VkQueryPipelineStatisticFlags pipelineStatistics;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFramebufferCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFramebufferCreateFlags flags;
	public VkRenderPass renderPass;
	public uint attachmentCount;
	public unsafe VkImageView* pAttachments;
	public uint width;
	public uint height;
	public uint layers;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDrawIndirectCommand
{
	public uint vertexCount;
	public uint instanceCount;
	public uint firstVertex;
	public uint firstInstance;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDrawIndexedIndirectCommand
{
	public uint indexCount;
	public uint instanceCount;
	public uint firstIndex;
	public int vertexOffset;
	public uint firstInstance;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDispatchIndirectCommand
{
	public uint x;
	public uint y;
	public uint z;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMultiDrawInfoEXT
{
	public uint firstVertex;
	public uint vertexCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMultiDrawIndexedInfoEXT
{
	public uint firstIndex;
	public uint indexCount;
	public int vertexOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubmitInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint waitSemaphoreCount;
	public unsafe VkSemaphore* pWaitSemaphores;
	public unsafe VkPipelineStageFlags* pWaitDstStageMask;
	public uint commandBufferCount;
	public unsafe VkCommandBuffer* pCommandBuffers;
	public uint signalSemaphoreCount;
	public unsafe VkSemaphore* pSignalSemaphores;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayPropertiesKHR
{
	public VkDisplayKHR display;
	public unsafe byte* displayName;
	public Vector2ui physicalDimensions;
	public Vector2ui physicalResolution;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkBool32 planeReorderPossible;
	public VkBool32 persistentContent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayPlanePropertiesKHR
{
	public VkDisplayKHR currentDisplay;
	public uint currentStackIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayModeParametersKHR
{
	public Vector2ui visibleRegion;
	public uint refreshRate;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayModePropertiesKHR
{
	public VkDisplayModeKHR displayMode;
	public VkDisplayModeParametersKHR parameters;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayModeCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplayModeCreateFlagsKHR flags;
	public VkDisplayModeParametersKHR parameters;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayPlaneCapabilitiesKHR
{
	public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
	public Vector2i minSrcPosition;
	public Vector2i maxSrcPosition;
	public Vector2ui minSrcExtent;
	public Vector2ui maxSrcExtent;
	public Vector2i minDstPosition;
	public Vector2i maxDstPosition;
	public Vector2ui minDstExtent;
	public Vector2ui maxDstExtent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplaySurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplaySurfaceCreateFlagsKHR flags;
	public VkDisplayModeKHR displayMode;
	public uint planeIndex;
	public uint planeStackIndex;
	public VkSurfaceTransformFlagsKHR transform;
	public float globalAlpha;
	public VkDisplayPlaneAlphaFlagsKHR alphaMode;
	public Vector2ui imageExtent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayPresentInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRect2D srcRect;
	public VkRect2D dstRect;
	public VkBool32 persistent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceCapabilitiesKHR
{
	public uint minImageCount;
	public uint maxImageCount;
	public Vector2ui currentExtent;
	public Vector2ui minImageExtent;
	public Vector2ui maxImageExtent;
	public uint maxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkSurfaceTransformFlagsKHR currentTransform;
	public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
	public VkImageUsageFlags supportedUsageFlags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAndroidSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAndroidSurfaceCreateFlagsKHR flags;
	public unsafe IntPtr* window;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkViSurfaceCreateInfoNN
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkViSurfaceCreateFlagsNN flags;
	public unsafe void* window;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkWaylandSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkWaylandSurfaceCreateFlagsKHR flags;
	public unsafe IntPtr* display;
	public unsafe IntPtr* surface;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkWin32SurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkWin32SurfaceCreateFlagsKHR flags;
	public IntPtr hinstance;
	public IntPtr hwnd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkXlibSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkXlibSurfaceCreateFlagsKHR flags;
	public unsafe IntPtr* dpy;
	public IntPtr window;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkXcbSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkXcbSurfaceCreateFlagsKHR flags;
	public unsafe IntPtr* connection;
	public IntPtr window;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDirectFBSurfaceCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDirectFBSurfaceCreateFlagsEXT flags;
	public unsafe IntPtr* dfb;
	public unsafe IntPtr* surface;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImagePipeSurfaceCreateInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImagePipeSurfaceCreateFlagsFUCHSIA flags;
	public IntPtr imagePipeHandle;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkStreamDescriptorSurfaceCreateInfoGGP
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkStreamDescriptorSurfaceCreateFlagsGGP flags;
	public IntPtr streamDescriptor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkScreenSurfaceCreateInfoQNX
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkScreenSurfaceCreateFlagsQNX flags;
	public unsafe IntPtr* context;
	public unsafe IntPtr* window;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceFormatKHR
{
	public VkFormat format;
	public VkColorSpaceKHR colorSpace;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSwapchainCreateFlagsKHR flags;
	public VkSurfaceKHR surface;
	public uint minImageCount;
	public VkFormat imageFormat;
	public VkColorSpaceKHR imageColorSpace;
	public Vector2ui imageExtent;
	public uint imageArrayLayers;
	public VkImageUsageFlags imageUsage;
	public VkSharingMode imageSharingMode;
	public uint queueFamilyIndexCount;
	public unsafe uint* pQueueFamilyIndices;
	public VkSurfaceTransformFlagsKHR preTransform;
	public VkCompositeAlphaFlagsKHR compositeAlpha;
	public VkPresentModeKHR presentMode;
	public VkBool32 clipped;
	public VkSwapchainKHR oldSwapchain;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPresentInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint waitSemaphoreCount;
	public unsafe VkSemaphore* pWaitSemaphores;
	public uint swapchainCount;
	public unsafe VkSwapchainKHR* pSwapchains;
	public unsafe uint* pImageIndices;
	public unsafe VkResult* pResults;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkValidationFlagsEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint disabledValidationCheckCount;
	public unsafe VkValidationCheckEXT* pDisabledValidationChecks;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkValidationFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint enabledValidationFeatureCount;
	public unsafe VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
	public uint disabledValidationFeatureCount;
	public unsafe VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRasterizationStateRasterizationOrderAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRasterizationOrderAMD rasterizationOrder;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDebugMarkerObjectNameInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDebugReportObjectTypeEXT objectType;
	public ulong @object;
	public unsafe byte* pObjectName;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDebugMarkerObjectTagInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDebugReportObjectTypeEXT objectType;
	public ulong @object;
	public ulong tagName;
	public nuint tagSize;
	public unsafe void* pTag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDebugMarkerMarkerInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe byte* pMarkerName;
	public float color_0;
	public float color_1;
	public float color_2;
	public float color_3;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDedicatedAllocationImageCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 dedicatedAllocation;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDedicatedAllocationBufferCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 dedicatedAllocation;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDedicatedAllocationMemoryAllocateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage image;
	public VkBuffer buffer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalImageFormatPropertiesNV
{
	public VkImageFormatProperties imageFormatProperties;
	public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalMemoryImageCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExportMemoryAllocateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportMemoryWin32HandleInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleType;
	public IntPtr handle;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExportMemoryWin32HandleInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe IntPtr* pAttributes;
	public IntPtr dwAccess;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint acquireCount;
	public unsafe VkDeviceMemory* pAcquireSyncs;
	public unsafe ulong* pAcquireKeys;
	public unsafe uint* pAcquireTimeoutMilliseconds;
	public uint releaseCount;
	public unsafe VkDeviceMemory* pReleaseSyncs;
	public unsafe ulong* pReleaseKeys;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 deviceGeneratedCommands;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDevicePrivateDataCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint privateDataSlotRequestCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPrivateDataSlotCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPrivateDataSlotCreateFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePrivateDataFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 privateData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxGraphicsShaderGroupCount;
	public uint maxIndirectSequenceCount;
	public uint maxIndirectCommandsTokenCount;
	public uint maxIndirectCommandsStreamCount;
	public uint maxIndirectCommandsTokenOffset;
	public uint maxIndirectCommandsStreamStride;
	public uint minSequencesCountBufferOffsetAlignment;
	public uint minSequencesIndexBufferOffsetAlignment;
	public uint minIndirectCommandsBufferOffsetAlignment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxMultiDrawCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGraphicsShaderGroupCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint stageCount;
	public unsafe VkPipelineShaderStageCreateInfo* pStages;
	public unsafe VkPipelineVertexInputStateCreateInfo* pVertexInputState;
	public unsafe VkPipelineTessellationStateCreateInfo* pTessellationState;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint groupCount;
	public unsafe VkGraphicsShaderGroupCreateInfoNV* pGroups;
	public uint pipelineCount;
	public unsafe VkPipeline* pPipelines;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindShaderGroupIndirectCommandNV
{
	public uint groupIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindIndexBufferIndirectCommandNV
{
	public IntPtr bufferAddress;
	public uint size;
	public VkIndexType indexType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindVertexBufferIndirectCommandNV
{
	public IntPtr bufferAddress;
	public uint size;
	public uint stride;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSetStateFlagsIndirectCommandNV
{
	public uint data;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkIndirectCommandsStreamNV
{
	public VkBuffer buffer;
	public ulong offset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkIndirectCommandsLayoutTokenNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkIndirectCommandsTokenTypeNV tokenType;
	public uint stream;
	public uint offset;
	public uint vertexBindingUnit;
	public VkBool32 vertexDynamicStride;
	public VkPipelineLayout pushconstantPipelineLayout;
	public VkShaderStageFlags pushconstantShaderStageFlags;
	public uint pushconstantOffset;
	public uint pushconstantSize;
	public VkIndirectStateFlagsNV indirectStateFlags;
	public uint indexTypeCount;
	public unsafe VkIndexType* pIndexTypes;
	public unsafe uint* pIndexTypeValues;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkIndirectCommandsLayoutCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkIndirectCommandsLayoutUsageFlagsNV flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint tokenCount;
	public unsafe VkIndirectCommandsLayoutTokenNV* pTokens;
	public uint streamCount;
	public unsafe uint* pStreamStrides;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGeneratedCommandsInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipeline pipeline;
	public VkIndirectCommandsLayoutNV indirectCommandsLayout;
	public uint streamCount;
	public unsafe VkIndirectCommandsStreamNV* pStreams;
	public uint sequencesCount;
	public VkBuffer preprocessBuffer;
	public ulong preprocessOffset;
	public ulong preprocessSize;
	public VkBuffer sequencesCountBuffer;
	public ulong sequencesCountOffset;
	public VkBuffer sequencesIndexBuffer;
	public ulong sequencesIndexOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGeneratedCommandsMemoryRequirementsInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipeline pipeline;
	public VkIndirectCommandsLayoutNV indirectCommandsLayout;
	public uint maxSequencesCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFeatures2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPhysicalDeviceFeatures features;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceProperties2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPhysicalDeviceProperties properties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFormatProperties2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormatProperties formatProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageFormatProperties2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageFormatProperties imageFormatProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceImageFormatInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkImageCreateFlags flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueueFamilyProperties2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkQueueFamilyProperties queueFamilyProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMemoryProperties2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPhysicalDeviceMemoryProperties memoryProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseImageFormatProperties2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSparseImageFormatProperties properties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSparseImageFormatInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkSampleCountFlags samples;
	public VkImageUsageFlags usage;
	public VkImageTiling tiling;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxPushDescriptors;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkConformanceVersion
{
	public byte major;
	public byte minor;
	public byte subminor;
	public byte patch;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDriverProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDriverId driverID;
	public unsafe fixed byte driverName[Vulkan.VK_MAX_DRIVER_NAME_SIZE];
	public unsafe fixed byte driverInfo[Vulkan.VK_MAX_DRIVER_INFO_SIZE];
	public VkConformanceVersion conformanceVersion;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPresentRegionsKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint swapchainCount;
	public unsafe VkPresentRegionKHR* pRegions;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPresentRegionKHR
{
	public uint rectangleCount;
	public unsafe VkRectLayerKHR* pRectangles;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRectLayerKHR
{
	public Vector2i offset;
	public Vector2ui extent;
	public uint layer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVariablePointersFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalMemoryProperties
{
	public VkExternalMemoryFeatureFlags externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExternalImageFormatInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalImageFormatProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExternalBufferInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBufferCreateFlags flags;
	public VkBufferUsageFlags usage;
	public VkExternalMemoryHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalBufferProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceIDProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe fixed byte deviceUUID[Vulkan.VK_UUID_SIZE];
	public unsafe fixed byte driverUUID[Vulkan.VK_UUID_SIZE];
	public unsafe fixed byte deviceLUID[Vulkan.VK_LUID_SIZE];
	public uint deviceNodeMask;
	public VkBool32 deviceLUIDValid;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalMemoryImageCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalMemoryBufferCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExportMemoryAllocateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportMemoryWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
	public IntPtr handle;
	public IntPtr name;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExportMemoryWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe IntPtr* pAttributes;
	public IntPtr dwAccess;
	public IntPtr name;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportMemoryZirconHandleInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
	public IntPtr handle;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryZirconHandlePropertiesFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint memoryTypeBits;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryGetZirconHandleInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryWin32HandlePropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint memoryTypeBits;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportMemoryFdInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
	public int fd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryFdPropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint memoryTypeBits;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryGetFdInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint acquireCount;
	public unsafe VkDeviceMemory* pAcquireSyncs;
	public unsafe ulong* pAcquireKeys;
	public unsafe uint* pAcquireTimeouts;
	public uint releaseCount;
	public unsafe VkDeviceMemory* pReleaseSyncs;
	public unsafe ulong* pReleaseKeys;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExternalSemaphoreInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalSemaphoreHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalSemaphoreProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExportSemaphoreCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalSemaphoreHandleTypeFlags handleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlags flags;
	public VkExternalSemaphoreHandleTypeFlags handleType;
	public IntPtr handle;
	public IntPtr name;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe IntPtr* pAttributes;
	public IntPtr dwAccess;
	public IntPtr name;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkD3D12FenceSubmitInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint waitSemaphoreValuesCount;
	public unsafe ulong* pWaitSemaphoreValues;
	public uint signalSemaphoreValuesCount;
	public unsafe ulong* pSignalSemaphoreValues;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSemaphoreGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportSemaphoreFdInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlags flags;
	public VkExternalSemaphoreHandleTypeFlags handleType;
	public int fd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSemaphoreGetFdInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportSemaphoreZirconHandleInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlags flags;
	public VkExternalSemaphoreHandleTypeFlags handleType;
	public IntPtr zirconHandle;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSemaphoreGetZirconHandleInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExternalFenceInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalFenceHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalFenceProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
	public VkExternalFenceFeatureFlags externalFenceFeatures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExportFenceCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalFenceHandleTypeFlags handleTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportFenceWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFence fence;
	public VkFenceImportFlags flags;
	public VkExternalFenceHandleTypeFlags handleType;
	public IntPtr handle;
	public IntPtr name;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExportFenceWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe IntPtr* pAttributes;
	public IntPtr dwAccess;
	public IntPtr name;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFenceGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportFenceFdInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFence fence;
	public VkFenceImportFlags flags;
	public VkExternalFenceHandleTypeFlags handleType;
	public int fd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFenceGetFdInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMultiviewFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMultiviewProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxMultiviewViewCount;
	public uint maxMultiviewInstanceIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassMultiviewCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint subpassCount;
	public unsafe uint* pViewMasks;
	public uint dependencyCount;
	public unsafe int* pViewOffsets;
	public uint correlationMaskCount;
	public unsafe uint* pCorrelationMasks;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceCapabilities2EXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint minImageCount;
	public uint maxImageCount;
	public Vector2ui currentExtent;
	public Vector2ui minImageExtent;
	public Vector2ui maxImageExtent;
	public uint maxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkSurfaceTransformFlagsKHR currentTransform;
	public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
	public VkImageUsageFlags supportedUsageFlags;
	public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayPowerInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplayPowerStateEXT powerState;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceEventInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceEventTypeEXT deviceEvent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayEventInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplayEventTypeEXT displayEvent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSwapchainCounterCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSurfaceCounterFlagsEXT surfaceCounters;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceGroupProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint physicalDeviceCount;
	public VkPhysicalDevice physicalDevices_0;
	public VkPhysicalDevice physicalDevices_1;
	public VkPhysicalDevice physicalDevices_2;
	public VkPhysicalDevice physicalDevices_3;
	public VkPhysicalDevice physicalDevices_4;
	public VkPhysicalDevice physicalDevices_5;
	public VkPhysicalDevice physicalDevices_6;
	public VkPhysicalDevice physicalDevices_7;
	public VkPhysicalDevice physicalDevices_8;
	public VkPhysicalDevice physicalDevices_9;
	public VkPhysicalDevice physicalDevices_10;
	public VkPhysicalDevice physicalDevices_11;
	public VkPhysicalDevice physicalDevices_12;
	public VkPhysicalDevice physicalDevices_13;
	public VkPhysicalDevice physicalDevices_14;
	public VkPhysicalDevice physicalDevices_15;
	public VkPhysicalDevice physicalDevices_16;
	public VkPhysicalDevice physicalDevices_17;
	public VkPhysicalDevice physicalDevices_18;
	public VkPhysicalDevice physicalDevices_19;
	public VkPhysicalDevice physicalDevices_20;
	public VkPhysicalDevice physicalDevices_21;
	public VkPhysicalDevice physicalDevices_22;
	public VkPhysicalDevice physicalDevices_23;
	public VkPhysicalDevice physicalDevices_24;
	public VkPhysicalDevice physicalDevices_25;
	public VkPhysicalDevice physicalDevices_26;
	public VkPhysicalDevice physicalDevices_27;
	public VkPhysicalDevice physicalDevices_28;
	public VkPhysicalDevice physicalDevices_29;
	public VkPhysicalDevice physicalDevices_30;
	public VkPhysicalDevice physicalDevices_31;
	public VkBool32 subsetAllocation;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryAllocateFlagsInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkMemoryAllocateFlags flags;
	public uint deviceMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindBufferMemoryInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBuffer buffer;
	public VkDeviceMemory memory;
	public ulong memoryOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindBufferMemoryDeviceGroupInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint deviceIndexCount;
	public unsafe uint* pDeviceIndices;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindImageMemoryInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage image;
	public VkDeviceMemory memory;
	public ulong memoryOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindImageMemoryDeviceGroupInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint deviceIndexCount;
	public unsafe uint* pDeviceIndices;
	public uint splitInstanceBindRegionCount;
	public unsafe VkRect2D* pSplitInstanceBindRegions;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceGroupRenderPassBeginInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint deviceMask;
	public uint deviceRenderAreaCount;
	public unsafe VkRect2D* pDeviceRenderAreas;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceGroupCommandBufferBeginInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint deviceMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceGroupSubmitInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint waitSemaphoreCount;
	public unsafe uint* pWaitSemaphoreDeviceIndices;
	public uint commandBufferCount;
	public unsafe uint* pCommandBufferDeviceMasks;
	public uint signalSemaphoreCount;
	public unsafe uint* pSignalSemaphoreDeviceIndices;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceGroupBindSparseInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint resourceDeviceIndex;
	public uint memoryDeviceIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceGroupPresentCapabilitiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe fixed uint presentMask[Vulkan.VK_MAX_DEVICE_GROUP_SIZE];
	public VkDeviceGroupPresentModeFlagsKHR modes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSwapchainKHR swapchain;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindImageMemorySwapchainInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSwapchainKHR swapchain;
	public uint imageIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAcquireNextImageInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSwapchainKHR swapchain;
	public ulong timeout;
	public VkSemaphore semaphore;
	public VkFence fence;
	public uint deviceMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceGroupPresentInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint swapchainCount;
	public unsafe uint* pDeviceMasks;
	public VkDeviceGroupPresentModeFlagsKHR mode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceGroupDeviceCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint physicalDeviceCount;
	public unsafe VkPhysicalDevice* pPhysicalDevices;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceGroupSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceGroupPresentModeFlagsKHR modes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorUpdateTemplateEntry
{
	public uint dstBinding;
	public uint dstArrayElement;
	public uint descriptorCount;
	public VkDescriptorType descriptorType;
	public nuint offset;
	public nuint stride;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorUpdateTemplateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDescriptorUpdateTemplateCreateFlags flags;
	public uint descriptorUpdateEntryCount;
	public unsafe VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType templateType;
	public VkDescriptorSetLayout descriptorSetLayout;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipelineLayout pipelineLayout;
	public uint set;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkXYColorEXT
{
	public float x;
	public float y;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePresentIdFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 presentId;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPresentIdKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint swapchainCount;
	public unsafe ulong* pPresentIds;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePresentWaitFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 presentWait;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkHdrMetadataEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkXYColorEXT displayPrimaryRed;
	public VkXYColorEXT displayPrimaryGreen;
	public VkXYColorEXT displayPrimaryBlue;
	public VkXYColorEXT whitePoint;
	public float maxLuminance;
	public float minLuminance;
	public float maxContentLightLevel;
	public float maxFrameAverageLightLevel;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 localDimmingSupport;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 localDimmingEnable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRefreshCycleDurationGOOGLE
{
	public ulong refreshDuration;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPastPresentationTimingGOOGLE
{
	public uint presentID;
	public ulong desiredPresentTime;
	public ulong actualPresentTime;
	public ulong earliestPresentTime;
	public ulong presentMargin;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPresentTimesInfoGOOGLE
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint swapchainCount;
	public unsafe VkPresentTimeGOOGLE* pTimes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPresentTimeGOOGLE
{
	public uint presentID;
	public ulong desiredPresentTime;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkIOSSurfaceCreateInfoMVK
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkIOSSurfaceCreateFlagsMVK flags;
	public unsafe void* pView;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMacOSSurfaceCreateInfoMVK
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkMacOSSurfaceCreateFlagsMVK flags;
	public unsafe void* pView;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMetalSurfaceCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkMetalSurfaceCreateFlagsEXT flags;
	public unsafe IntPtr* pLayer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkViewportWScalingNV
{
	public float xcoeff;
	public float ycoeff;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineViewportWScalingStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 viewportWScalingEnable;
	public uint viewportCount;
	public unsafe VkViewportWScalingNV* pViewportWScalings;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkViewportSwizzleNV
{
	public VkViewportCoordinateSwizzleNV x;
	public VkViewportCoordinateSwizzleNV y;
	public VkViewportCoordinateSwizzleNV z;
	public VkViewportCoordinateSwizzleNV w;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineViewportSwizzleStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
	public uint viewportCount;
	public unsafe VkViewportSwizzleNV* pViewportSwizzles;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxDiscardRectangles;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
	public VkDiscardRectangleModeEXT discardRectangleMode;
	public uint discardRectangleCount;
	public unsafe VkRect2D* pDiscardRectangles;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 perViewPositionAllComponents;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkInputAttachmentAspectReference
{
	public uint subpass;
	public uint inputAttachmentIndex;
	public VkImageAspectFlags aspectMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassInputAttachmentAspectCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint aspectReferenceCount;
	public unsafe VkInputAttachmentAspectReference* pAspectReferences;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSurfaceInfo2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSurfaceKHR surface;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceCapabilities2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSurfaceCapabilitiesKHR surfaceCapabilities;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceFormat2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSurfaceFormatKHR surfaceFormat;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayProperties2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplayPropertiesKHR displayProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayPlaneProperties2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplayPlanePropertiesKHR displayPlaneProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayModeProperties2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplayModePropertiesKHR displayModeProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayPlaneInfo2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplayModeKHR mode;
	public uint planeIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDisplayPlaneCapabilities2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDisplayPlaneCapabilitiesKHR capabilities;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSharedPresentSurfaceCapabilitiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageUsageFlags sharedPresentSupportedUsageFlags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevice16BitStorageFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 storageBuffer16BitAccess;
	public VkBool32 uniformAndStorageBuffer16BitAccess;
	public VkBool32 storagePushConstant16;
	public VkBool32 storageInputOutput16;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSubgroupProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint subgroupSize;
	public VkShaderStageFlags supportedStages;
	public VkSubgroupFeatureFlags supportedOperations;
	public VkBool32 quadOperationsInAllStages;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderSubgroupExtendedTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBuffer buffer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceBufferMemoryRequirements
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe VkBufferCreateInfo* pCreateInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage image;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageSparseMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage image;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceImageMemoryRequirements
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe VkImageCreateInfo* pCreateInfo;
	public VkImageAspectFlags planeAspect;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryRequirements2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkMemoryRequirements memoryRequirements;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSparseImageMemoryRequirements2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSparseImageMemoryRequirements memoryRequirements;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePointClippingProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPointClippingBehavior pointClippingBehavior;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryDedicatedRequirements
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 prefersDedicatedAllocation;
	public VkBool32 requiresDedicatedAllocation;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryDedicatedAllocateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage image;
	public VkBuffer buffer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageViewUsageCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageUsageFlags usage;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineTessellationDomainOriginStateCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkTessellationDomainOrigin domainOrigin;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSamplerYcbcrConversionInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSamplerYcbcrConversion conversion;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSamplerYcbcrConversionCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormat format;
	public VkSamplerYcbcrModelConversion ycbcrModel;
	public VkSamplerYcbcrRange ycbcrRange;
	public VkComponentMapping components;
	public VkChromaLocation xChromaOffset;
	public VkChromaLocation yChromaOffset;
	public VkFilter chromaFilter;
	public VkBool32 forceExplicitReconstruction;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindImagePlaneMemoryInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageAspectFlags planeAspect;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImagePlaneMemoryRequirementsInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageAspectFlags planeAspect;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 samplerYcbcrConversion;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSamplerYcbcrConversionImageFormatProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint combinedImageSamplerDescriptorCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkTextureLODGatherFormatPropertiesAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 supportsTextureGatherLODBiasAMD;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkConditionalRenderingBeginInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBuffer buffer;
	public ulong offset;
	public VkConditionalRenderingFlagsEXT flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkProtectedSubmitInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 protectedSubmit;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceProtectedMemoryFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 protectedMemory;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceProtectedMemoryProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 protectedNoFault;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceQueueInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceQueueCreateFlags flags;
	public uint queueFamilyIndex;
	public uint queueIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineCoverageToColorStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCoverageToColorStateCreateFlagsNV flags;
	public VkBool32 coverageToColorEnable;
	public uint coverageToColorLocation;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSampleLocationEXT
{
	public float x;
	public float y;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSampleLocationsInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSampleCountFlags sampleLocationsPerPixel;
	public Vector2ui sampleLocationGridSize;
	public uint sampleLocationsCount;
	public unsafe VkSampleLocationEXT* pSampleLocations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAttachmentSampleLocationsEXT
{
	public uint attachmentIndex;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassSampleLocationsEXT
{
	public uint subpassIndex;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassSampleLocationsBeginInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint attachmentInitialSampleLocationsCount;
	public unsafe VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
	public uint postSubpassSampleLocationsCount;
	public unsafe VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineSampleLocationsStateCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 sampleLocationsEnable;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSampleCountFlags sampleLocationSampleCounts;
	public Vector2ui maxSampleLocationGridSize;
	public float sampleLocationCoordinateRange_0;
	public float sampleLocationCoordinateRange_1;
	public uint sampleLocationSubPixelBits;
	public VkBool32 variableSampleLocations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMultisamplePropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public Vector2ui maxSampleLocationGridSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSamplerReductionModeCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSamplerReductionMode reductionMode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 advancedBlendCoherentOperations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMultiDrawFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 multiDraw;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint advancedBlendMaxColorAttachments;
	public VkBool32 advancedBlendIndependentBlend;
	public VkBool32 advancedBlendNonPremultipliedSrcColor;
	public VkBool32 advancedBlendNonPremultipliedDstColor;
	public VkBool32 advancedBlendCorrelatedOverlap;
	public VkBool32 advancedBlendAllOperations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 srcPremultiplied;
	public VkBool32 dstPremultiplied;
	public VkBlendOverlapEXT blendOverlap;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceInlineUniformBlockFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceInlineUniformBlockProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxInlineUniformBlockSize;
	public uint maxPerStageDescriptorInlineUniformBlocks;
	public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint maxDescriptorSetInlineUniformBlocks;
	public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkWriteDescriptorSetInlineUniformBlock
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint dataSize;
	public unsafe void* pData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxInlineUniformBlockBindings;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineCoverageModulationStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCoverageModulationStateCreateFlagsNV flags;
	public VkCoverageModulationModeNV coverageModulationMode;
	public VkBool32 coverageModulationTableEnable;
	public uint coverageModulationTableCount;
	public unsafe float* pCoverageModulationTable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageFormatListCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint viewFormatCount;
	public unsafe VkFormat* pViewFormats;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkValidationCacheCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkValidationCacheCreateFlagsEXT flags;
	public nuint initialDataSize;
	public unsafe void* pInitialData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkShaderModuleValidationCacheCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkValidationCacheEXT validationCache;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMaintenance3Properties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxPerSetDescriptors;
	public ulong maxMemoryAllocationSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMaintenance4Features
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 maintenance4;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMaintenance4Properties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong maxBufferSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetLayoutSupport
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 supported;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderDrawParametersFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderDrawParameters;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderFloat16Int8Features
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFloatControlsProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkShaderFloatControlsIndependence denormBehaviorIndependence;
	public VkShaderFloatControlsIndependence roundingModeIndependence;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 shaderDenormPreserveFloat16;
	public VkBool32 shaderDenormPreserveFloat32;
	public VkBool32 shaderDenormPreserveFloat64;
	public VkBool32 shaderDenormFlushToZeroFloat16;
	public VkBool32 shaderDenormFlushToZeroFloat32;
	public VkBool32 shaderDenormFlushToZeroFloat64;
	public VkBool32 shaderRoundingModeRTEFloat16;
	public VkBool32 shaderRoundingModeRTEFloat32;
	public VkBool32 shaderRoundingModeRTEFloat64;
	public VkBool32 shaderRoundingModeRTZFloat16;
	public VkBool32 shaderRoundingModeRTZFloat32;
	public VkBool32 shaderRoundingModeRTZFloat64;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceHostQueryResetFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 hostQueryReset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkNativeBufferUsage2ANDROID
{
	public ulong consumer;
	public ulong producer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkNativeBufferANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe void* handle;
	public int stride;
	public int format;
	public int usage;
	public VkNativeBufferUsage2ANDROID usage2;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSwapchainImageCreateInfoANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSwapchainImageUsageFlagsANDROID usage;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePresentationPropertiesANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 sharedImage;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkShaderResourceUsageAMD
{
	public uint numUsedVgprs;
	public uint numUsedSgprs;
	public uint ldsSizePerLocalWorkGroup;
	public nuint ldsUsageSizeInBytes;
	public nuint scratchMemUsageInBytes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkShaderStatisticsInfoAMD
{
	public VkShaderStageFlags shaderStageMask;
	public VkShaderResourceUsageAMD resourceUsage;
	public uint numPhysicalVgprs;
	public uint numPhysicalSgprs;
	public uint numAvailableVgprs;
	public uint numAvailableSgprs;
	public uint computeWorkGroupSize_0;
	public uint computeWorkGroupSize_1;
	public uint computeWorkGroupSize_2;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceQueueGlobalPriorityCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkQueueGlobalPriorityKHR globalPriority;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 globalPriorityQuery;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint priorityCount;
	public VkQueueGlobalPriorityKHR priorities_0;
	public VkQueueGlobalPriorityKHR priorities_1;
	public VkQueueGlobalPriorityKHR priorities_2;
	public VkQueueGlobalPriorityKHR priorities_3;
	public VkQueueGlobalPriorityKHR priorities_4;
	public VkQueueGlobalPriorityKHR priorities_5;
	public VkQueueGlobalPriorityKHR priorities_6;
	public VkQueueGlobalPriorityKHR priorities_7;
	public VkQueueGlobalPriorityKHR priorities_8;
	public VkQueueGlobalPriorityKHR priorities_9;
	public VkQueueGlobalPriorityKHR priorities_10;
	public VkQueueGlobalPriorityKHR priorities_11;
	public VkQueueGlobalPriorityKHR priorities_12;
	public VkQueueGlobalPriorityKHR priorities_13;
	public VkQueueGlobalPriorityKHR priorities_14;
	public VkQueueGlobalPriorityKHR priorities_15;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDebugUtilsObjectNameInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkObjectType objectType;
	public ulong objectHandle;
	public unsafe byte* pObjectName;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDebugUtilsObjectTagInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkObjectType objectType;
	public ulong objectHandle;
	public ulong tagName;
	public nuint tagSize;
	public unsafe void* pTag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDebugUtilsLabelEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe byte* pLabelName;
	public float color_0;
	public float color_1;
	public float color_2;
	public float color_3;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDebugUtilsMessengerCallbackDataEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
	public unsafe byte* pMessageIdName;
	public int messageIdNumber;
	public unsafe byte* pMessage;
	public uint queueLabelCount;
	public unsafe VkDebugUtilsLabelEXT* pQueueLabels;
	public uint cmdBufLabelCount;
	public unsafe VkDebugUtilsLabelEXT* pCmdBufLabels;
	public uint objectCount;
	public unsafe VkDebugUtilsObjectNameInfoEXT* pObjects;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 deviceMemoryReport;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceMemoryReportCallbackDataEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceMemoryReportFlagsEXT flags;
	public VkDeviceMemoryReportEventTypeEXT type;
	public ulong memoryObjectId;
	public ulong size;
	public VkObjectType objectType;
	public ulong objectHandle;
	public uint heapIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportMemoryHostPointerInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkExternalMemoryHandleTypeFlags handleType;
	public unsafe void* pHostPointer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryHostPointerPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint memoryTypeBits;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong minImportedHostPointerAlignment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public float primitiveOverestimationSize;
	public float maxExtraPrimitiveOverestimationSize;
	public float extraPrimitiveOverestimationSizeGranularity;
	public VkBool32 primitiveUnderestimation;
	public VkBool32 conservativePointAndLineRasterization;
	public VkBool32 degenerateTrianglesRasterized;
	public VkBool32 degenerateLinesRasterized;
	public VkBool32 fullyCoveredFragmentShaderInputVariable;
	public VkBool32 conservativeRasterizationPostDepthCoverage;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCalibratedTimestampInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkTimeDomainEXT timeDomain;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderCorePropertiesAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint shaderEngineCount;
	public uint shaderArraysPerEngineCount;
	public uint computeUnitsPerShaderArray;
	public uint simdPerComputeUnit;
	public uint wavefrontsPerSimd;
	public uint wavefrontSize;
	public uint sgprsPerSimd;
	public uint minSgprAllocation;
	public uint maxSgprAllocation;
	public uint sgprAllocationGranularity;
	public uint vgprsPerSimd;
	public uint minVgprAllocation;
	public uint maxVgprAllocation;
	public uint vgprAllocationGranularity;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderCoreProperties2AMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
	public uint activeComputeUnitCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
	public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
	public float extraPrimitiveOverestimationSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDescriptorIndexingFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 shaderSampledImageArrayNonUniformIndexing;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageImageArrayNonUniformIndexing;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUpdateUnusedWhilePending;
	public VkBool32 descriptorBindingPartiallyBound;
	public VkBool32 descriptorBindingVariableDescriptorCount;
	public VkBool32 runtimeDescriptorArray;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDescriptorIndexingProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint maxPerStageUpdateAfterBindResources;
	public uint maxDescriptorSetUpdateAfterBindSamplers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindSampledImages;
	public uint maxDescriptorSetUpdateAfterBindStorageImages;
	public uint maxDescriptorSetUpdateAfterBindInputAttachments;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint bindingCount;
	public unsafe VkDescriptorBindingFlags* pBindingFlags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint descriptorSetCount;
	public unsafe uint* pDescriptorCounts;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxVariableDescriptorCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAttachmentDescription2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAttachmentDescriptionFlags flags;
	public VkFormat format;
	public VkSampleCountFlags samples;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkAttachmentLoadOp stencilLoadOp;
	public VkAttachmentStoreOp stencilStoreOp;
	public VkImageLayout initialLayout;
	public VkImageLayout finalLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAttachmentReference2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint attachment;
	public VkImageLayout layout;
	public VkImageAspectFlags aspectMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassDescription2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint viewMask;
	public uint inputAttachmentCount;
	public unsafe VkAttachmentReference2* pInputAttachments;
	public uint colorAttachmentCount;
	public unsafe VkAttachmentReference2* pColorAttachments;
	public unsafe VkAttachmentReference2* pResolveAttachments;
	public unsafe VkAttachmentReference2* pDepthStencilAttachment;
	public uint preserveAttachmentCount;
	public unsafe uint* pPreserveAttachments;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassDependency2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint srcSubpass;
	public uint dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
	public int viewOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassCreateInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint attachmentCount;
	public unsafe VkAttachmentDescription2* pAttachments;
	public uint subpassCount;
	public unsafe VkSubpassDescription2* pSubpasses;
	public uint dependencyCount;
	public unsafe VkSubpassDependency2* pDependencies;
	public uint correlatedViewMaskCount;
	public unsafe uint* pCorrelatedViewMasks;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassBeginInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSubpassContents contents;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassEndInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceTimelineSemaphoreFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 timelineSemaphore;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceTimelineSemaphoreProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong maxTimelineSemaphoreValueDifference;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSemaphoreTypeCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphoreType semaphoreType;
	public ulong initialValue;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkTimelineSemaphoreSubmitInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint waitSemaphoreValueCount;
	public unsafe ulong* pWaitSemaphoreValues;
	public uint signalSemaphoreValueCount;
	public unsafe ulong* pSignalSemaphoreValues;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSemaphoreWaitInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphoreWaitFlags flags;
	public uint semaphoreCount;
	public unsafe VkSemaphore* pSemaphores;
	public unsafe ulong* pValues;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSemaphoreSignalInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphore semaphore;
	public ulong value;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVertexInputBindingDivisorDescriptionEXT
{
	public uint binding;
	public uint divisor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint vertexBindingDivisorCount;
	public unsafe VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxVertexAttribDivisor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint pciDomain;
	public uint pciBus;
	public uint pciDevice;
	public uint pciFunction;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportAndroidHardwareBufferInfoANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe IntPtr* buffer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAndroidHardwareBufferUsageANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong androidHardwareBufferUsage;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAndroidHardwareBufferPropertiesANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong allocationSize;
	public uint memoryTypeBits;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryGetAndroidHardwareBufferInfoANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceMemory memory;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAndroidHardwareBufferFormatPropertiesANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormat format;
	public ulong externalFormat;
	public VkFormatFeatureFlags formatFeatures;
	public VkComponentMapping samplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
	public VkSamplerYcbcrRange suggestedYcbcrRange;
	public VkChromaLocation suggestedXChromaOffset;
	public VkChromaLocation suggestedYChromaOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 conditionalRenderingEnable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkExternalFormatANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong externalFormat;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevice8BitStorageFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 storageBuffer8BitAccess;
	public VkBool32 uniformAndStorageBuffer8BitAccess;
	public VkBool32 storagePushConstant8;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 conditionalRendering;
	public VkBool32 inheritedConditionalRendering;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 vulkanMemoryModel;
	public VkBool32 vulkanMemoryModelDeviceScope;
	public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderAtomicInt64Features
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderBufferInt64Atomics;
	public VkBool32 shaderSharedInt64Atomics;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderBufferFloat32Atomics;
	public VkBool32 shaderBufferFloat32AtomicAdd;
	public VkBool32 shaderBufferFloat64Atomics;
	public VkBool32 shaderBufferFloat64AtomicAdd;
	public VkBool32 shaderSharedFloat32Atomics;
	public VkBool32 shaderSharedFloat32AtomicAdd;
	public VkBool32 shaderSharedFloat64Atomics;
	public VkBool32 shaderSharedFloat64AtomicAdd;
	public VkBool32 shaderImageFloat32Atomics;
	public VkBool32 shaderImageFloat32AtomicAdd;
	public VkBool32 sparseImageFloat32Atomics;
	public VkBool32 sparseImageFloat32AtomicAdd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderBufferFloat16Atomics;
	public VkBool32 shaderBufferFloat16AtomicAdd;
	public VkBool32 shaderBufferFloat16AtomicMinMax;
	public VkBool32 shaderBufferFloat32AtomicMinMax;
	public VkBool32 shaderBufferFloat64AtomicMinMax;
	public VkBool32 shaderSharedFloat16Atomics;
	public VkBool32 shaderSharedFloat16AtomicAdd;
	public VkBool32 shaderSharedFloat16AtomicMinMax;
	public VkBool32 shaderSharedFloat32AtomicMinMax;
	public VkBool32 shaderSharedFloat64AtomicMinMax;
	public VkBool32 shaderImageFloat32AtomicMinMax;
	public VkBool32 sparseImageFloat32AtomicMinMax;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 vertexAttributeInstanceRateDivisor;
	public VkBool32 vertexAttributeInstanceRateZeroDivisor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueueFamilyCheckpointPropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineStageFlags checkpointExecutionStageMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCheckpointDataNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineStageFlags stage;
	public unsafe void* pCheckpointMarker;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDepthStencilResolveProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkResolveModeFlags supportedDepthResolveModes;
	public VkResolveModeFlags supportedStencilResolveModes;
	public VkBool32 independentResolveNone;
	public VkBool32 independentResolve;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassDescriptionDepthStencilResolve
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkResolveModeFlags depthResolveMode;
	public VkResolveModeFlags stencilResolveMode;
	public unsafe VkAttachmentReference2* pDepthStencilResolveAttachment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageViewASTCDecodeModeEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormat decodeMode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceASTCDecodeFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 decodeModeSharedExponent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 transformFeedback;
	public VkBool32 geometryStreams;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxTransformFeedbackStreams;
	public uint maxTransformFeedbackBuffers;
	public ulong maxTransformFeedbackBufferSize;
	public uint maxTransformFeedbackStreamDataSize;
	public uint maxTransformFeedbackBufferDataSize;
	public uint maxTransformFeedbackBufferDataStride;
	public VkBool32 transformFeedbackQueries;
	public VkBool32 transformFeedbackStreamsLinesTriangles;
	public VkBool32 transformFeedbackRasterizationStreamSelect;
	public VkBool32 transformFeedbackDraw;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
	public uint rasterizationStream;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 representativeFragmentTest;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 representativeFragmentTestEnable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExclusiveScissorFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 exclusiveScissor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint exclusiveScissorCount;
	public unsafe VkRect2D* pExclusiveScissors;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 cornerSampledImage;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 computeDerivativeGroupQuads;
	public VkBool32 computeDerivativeGroupLinear;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 fragmentShaderBarycentric;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 imageFootprint;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 dedicatedAllocationImageAliasing;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkShadingRatePaletteNV
{
	public uint shadingRatePaletteEntryCount;
	public unsafe VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shadingRateImageEnable;
	public uint viewportCount;
	public unsafe VkShadingRatePaletteNV* pShadingRatePalettes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShadingRateImageFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shadingRateImage;
	public VkBool32 shadingRateCoarseSampleOrder;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public Vector2ui shadingRateTexelSize;
	public uint shadingRatePaletteSize;
	public uint shadingRateMaxCoarseSamples;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 invocationMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCoarseSampleLocationNV
{
	public uint pixelX;
	public uint pixelY;
	public uint sample;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCoarseSampleOrderCustomNV
{
	public VkShadingRatePaletteEntryNV shadingRate;
	public uint sampleCount;
	public uint sampleLocationCount;
	public unsafe VkCoarseSampleLocationNV* pSampleLocations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkCoarseSampleOrderTypeNV sampleOrderType;
	public uint customSampleOrderCount;
	public unsafe VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMeshShaderFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 taskShader;
	public VkBool32 meshShader;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMeshShaderPropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxDrawMeshTasksCount;
	public uint maxTaskWorkGroupInvocations;
	public uint maxTaskWorkGroupSize_0;
	public uint maxTaskWorkGroupSize_1;
	public uint maxTaskWorkGroupSize_2;
	public uint maxTaskTotalMemorySize;
	public uint maxTaskOutputCount;
	public uint maxMeshWorkGroupInvocations;
	public uint maxMeshWorkGroupSize_0;
	public uint maxMeshWorkGroupSize_1;
	public uint maxMeshWorkGroupSize_2;
	public uint maxMeshTotalMemorySize;
	public uint maxMeshOutputVertices;
	public uint maxMeshOutputPrimitives;
	public uint maxMeshMultiviewViewCount;
	public uint meshOutputPerVertexGranularity;
	public uint meshOutputPerPrimitiveGranularity;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDrawMeshTasksIndirectCommandNV
{
	public uint taskCount;
	public uint firstTask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRayTracingShaderGroupCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRayTracingShaderGroupTypeKHR type;
	public uint generalShader;
	public uint closestHitShader;
	public uint anyHitShader;
	public uint intersectionShader;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRayTracingShaderGroupCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRayTracingShaderGroupTypeKHR type;
	public uint generalShader;
	public uint closestHitShader;
	public uint anyHitShader;
	public uint intersectionShader;
	public unsafe void* pShaderGroupCaptureReplayHandle;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRayTracingPipelineCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCreateFlags flags;
	public uint stageCount;
	public unsafe VkPipelineShaderStageCreateInfo* pStages;
	public uint groupCount;
	public unsafe VkRayTracingShaderGroupCreateInfoNV* pGroups;
	public uint maxRecursionDepth;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int basePipelineIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRayTracingPipelineCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCreateFlags flags;
	public uint stageCount;
	public unsafe VkPipelineShaderStageCreateInfo* pStages;
	public uint groupCount;
	public unsafe VkRayTracingShaderGroupCreateInfoKHR* pGroups;
	public uint maxPipelineRayRecursionDepth;
	public unsafe VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
	public unsafe VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
	public unsafe VkPipelineDynamicStateCreateInfo* pDynamicState;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int basePipelineIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGeometryTrianglesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBuffer vertexData;
	public ulong vertexOffset;
	public uint vertexCount;
	public ulong vertexStride;
	public VkFormat vertexFormat;
	public VkBuffer indexData;
	public ulong indexOffset;
	public uint indexCount;
	public VkIndexType indexType;
	public VkBuffer transformData;
	public ulong transformOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGeometryAABBNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBuffer aabbData;
	public uint numAABBs;
	public uint stride;
	public ulong offset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGeometryDataNV
{
	public VkGeometryTrianglesNV triangles;
	public VkGeometryAABBNV aabbs;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGeometryNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkGeometryTypeKHR geometryType;
	public VkGeometryDataNV geometry;
	public VkGeometryFlagsKHR flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccelerationStructureTypeKHR type;
	public VkBuildAccelerationStructureFlagsKHR flags;
	public uint instanceCount;
	public uint geometryCount;
	public unsafe VkGeometryNV* pGeometries;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong compactedSize;
	public VkAccelerationStructureInfoNV info;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBindAccelerationStructureMemoryInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccelerationStructureNV accelerationStructure;
	public VkDeviceMemory memory;
	public ulong memoryOffset;
	public uint deviceIndexCount;
	public unsafe uint* pDeviceIndices;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkWriteDescriptorSetAccelerationStructureKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint accelerationStructureCount;
	public unsafe VkAccelerationStructureKHR* pAccelerationStructures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkWriteDescriptorSetAccelerationStructureNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint accelerationStructureCount;
	public unsafe VkAccelerationStructureNV* pAccelerationStructures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureMemoryRequirementsInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccelerationStructureMemoryRequirementsTypeNV type;
	public VkAccelerationStructureNV accelerationStructure;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 accelerationStructure;
	public VkBool32 accelerationStructureCaptureReplay;
	public VkBool32 accelerationStructureIndirectBuild;
	public VkBool32 accelerationStructureHostCommands;
	public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 rayTracingPipeline;
	public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;
	public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
	public VkBool32 rayTracingPipelineTraceRaysIndirect;
	public VkBool32 rayTraversalPrimitiveCulling;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRayQueryFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 rayQuery;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong maxGeometryCount;
	public ulong maxInstanceCount;
	public ulong maxPrimitiveCount;
	public uint maxPerStageDescriptorAccelerationStructures;
	public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
	public uint maxDescriptorSetAccelerationStructures;
	public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;
	public uint minAccelerationStructureScratchOffsetAlignment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint shaderGroupHandleSize;
	public uint maxRayRecursionDepth;
	public uint maxShaderGroupStride;
	public uint shaderGroupBaseAlignment;
	public uint shaderGroupHandleCaptureReplaySize;
	public uint maxRayDispatchInvocationCount;
	public uint shaderGroupHandleAlignment;
	public uint maxRayHitAttributeSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRayTracingPropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint shaderGroupHandleSize;
	public uint maxRecursionDepth;
	public uint maxShaderGroupStride;
	public uint shaderGroupBaseAlignment;
	public ulong maxGeometryCount;
	public ulong maxInstanceCount;
	public ulong maxTriangleCount;
	public uint maxDescriptorSetAccelerationStructures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkStridedDeviceAddressRegionKHR
{
	public IntPtr deviceAddress;
	public ulong stride;
	public ulong size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkTraceRaysIndirectCommandKHR
{
	public uint width;
	public uint height;
	public uint depth;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDrmFormatModifierPropertiesListEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint drmFormatModifierCount;
	public unsafe VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDrmFormatModifierPropertiesEXT
{
	public ulong drmFormatModifier;
	public uint drmFormatModifierPlaneCount;
	public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong drmFormatModifier;
	public VkSharingMode sharingMode;
	public uint queueFamilyIndexCount;
	public unsafe uint* pQueueFamilyIndices;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageDrmFormatModifierListCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint drmFormatModifierCount;
	public unsafe ulong* pDrmFormatModifiers;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong drmFormatModifier;
	public uint drmFormatModifierPlaneCount;
	public unsafe VkSubresourceLayout* pPlaneLayouts;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageDrmFormatModifierPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong drmFormatModifier;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageStencilUsageCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageUsageFlags stencilUsage;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceMemoryOverallocationCreateInfoAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 fragmentDensityMap;
	public VkBool32 fragmentDensityMapDynamic;
	public VkBool32 fragmentDensityMapNonSubsampledImages;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 fragmentDensityMapDeferred;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 fragmentDensityMapOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public Vector2ui minFragmentDensityTexelSize;
	public Vector2ui maxFragmentDensityTexelSize;
	public VkBool32 fragmentDensityInvocations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 subsampledLoads;
	public VkBool32 subsampledCoarseReconstructionEarlyAccess;
	public uint maxSubsampledArrayLayers;
	public uint maxDescriptorSetSubsampledSamplers;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public Vector2ui fragmentDensityOffsetGranularity;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAttachmentReference fragmentDensityMapAttachment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint fragmentDensityOffsetCount;
	public unsafe Vector2i* pFragmentDensityOffsets;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceScalarBlockLayoutFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 scalarBlockLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceProtectedCapabilitiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 supportsProtected;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 uniformBufferStandardLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 depthClipEnable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
	public VkBool32 depthClipEnable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe fixed ulong heapBudget[Vulkan.VK_MAX_MEMORY_HEAPS];
	public unsafe fixed ulong heapUsage[Vulkan.VK_MAX_MEMORY_HEAPS];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 memoryPriority;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryPriorityAllocateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public float priority;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 pageableDeviceLocalMemory;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceBufferDeviceAddressFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferDeviceAddressInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBuffer buffer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferOpaqueCaptureAddressCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong opaqueCaptureAddress;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferDeviceAddressCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public IntPtr deviceAddress;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageViewType imageViewType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 filterCubic;
	public VkBool32 filterCubicMinmax;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceImagelessFramebufferFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 imagelessFramebuffer;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFramebufferAttachmentsCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint attachmentImageInfoCount;
	public unsafe VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFramebufferAttachmentImageInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageCreateFlags flags;
	public VkImageUsageFlags usage;
	public uint width;
	public uint height;
	public uint layerCount;
	public uint viewFormatCount;
	public unsafe VkFormat* pViewFormats;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassAttachmentBeginInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint attachmentCount;
	public unsafe VkImageView* pAttachments;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 textureCompressionASTC_HDR;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 cooperativeMatrix;
	public VkBool32 cooperativeMatrixRobustBufferAccess;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkShaderStageFlags cooperativeMatrixSupportedStages;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCooperativeMatrixPropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint MSize;
	public uint NSize;
	public uint KSize;
	public VkComponentTypeNV AType;
	public VkComponentTypeNV BType;
	public VkComponentTypeNV CType;
	public VkComponentTypeNV DType;
	public VkScopeNV scope;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 ycbcrImageArrays;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageViewHandleInfoNVX
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageView imageView;
	public VkDescriptorType descriptorType;
	public VkSampler sampler;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageViewAddressPropertiesNVX
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public IntPtr deviceAddress;
	public ulong size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPresentFrameTokenGGP
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public IntPtr frameToken;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineCreationFeedback
{
	public VkPipelineCreationFeedbackFlags flags;
	public ulong duration;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineCreationFeedbackCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe VkPipelineCreationFeedback* pPipelineCreationFeedback;
	public uint pipelineStageCreationFeedbackCount;
	public unsafe VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceFullScreenExclusiveInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFullScreenExclusiveEXT fullScreenExclusive;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public IntPtr hmonitor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 fullScreenExclusiveSupported;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePerformanceQueryFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 performanceCounterQueryPools;
	public VkBool32 performanceCounterMultipleQueryPools;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePerformanceQueryPropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 allowCommandBufferQueryCopies;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPerformanceCounterKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPerformanceCounterUnitKHR unit;
	public VkPerformanceCounterScopeKHR scope;
	public VkPerformanceCounterStorageKHR storage;
	public unsafe fixed byte uuid[Vulkan.VK_UUID_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPerformanceCounterDescriptionKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPerformanceCounterDescriptionFlagsKHR flags;
	public unsafe fixed byte name[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public unsafe fixed byte category[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public unsafe fixed byte description[Vulkan.VK_MAX_DESCRIPTION_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueryPoolPerformanceCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint queueFamilyIndex;
	public uint counterIndexCount;
	public unsafe uint* pCounterIndices;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAcquireProfilingLockInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAcquireProfilingLockFlagsKHR flags;
	public ulong timeout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPerformanceQuerySubmitInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint counterPassIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkHeadlessSurfaceCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkHeadlessSurfaceCreateFlagsEXT flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 coverageReductionMode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineCoverageReductionStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCoverageReductionStateCreateFlagsNV flags;
	public VkCoverageReductionModeNV coverageReductionMode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFramebufferMixedSamplesCombinationNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkCoverageReductionModeNV coverageReductionMode;
	public VkSampleCountFlags rasterizationSamples;
	public VkSampleCountFlags depthStencilSamples;
	public VkSampleCountFlags colorSamples;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderIntegerFunctions2;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPerformanceValueINTEL
{
	public VkPerformanceValueTypeINTEL type;
	public VkPerformanceValueDataINTEL data;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkInitializePerformanceApiInfoINTEL
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe void* pUserData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueryPoolPerformanceQueryCreateInfoINTEL
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPerformanceMarkerInfoINTEL
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong marker;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPerformanceStreamMarkerInfoINTEL
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint marker;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPerformanceOverrideInfoINTEL
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPerformanceOverrideTypeINTEL type;
	public VkBool32 enable;
	public ulong parameter;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPerformanceConfigurationAcquireInfoINTEL
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPerformanceConfigurationTypeINTEL type;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderClockFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderSubgroupClock;
	public VkBool32 shaderDeviceClock;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 indexTypeUint8;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint shaderSMCount;
	public uint shaderWarpsPerSM;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderSMBuiltins;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 fragmentShaderSampleInterlock;
	public VkBool32 fragmentShaderPixelInterlock;
	public VkBool32 fragmentShaderShadingRateInterlock;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 separateDepthStencilLayouts;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAttachmentReferenceStencilLayout
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageLayout stencilLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 primitiveTopologyListRestart;
	public VkBool32 primitiveTopologyPatchListRestart;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAttachmentDescriptionStencilLayout
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageLayout stencilInitialLayout;
	public VkImageLayout stencilFinalLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 pipelineExecutableInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipeline pipeline;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineExecutablePropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkShaderStageFlags stages;
	public unsafe fixed byte name[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public unsafe fixed byte description[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public uint subgroupSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineExecutableInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipeline pipeline;
	public uint executableIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineExecutableStatisticKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe fixed byte name[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public unsafe fixed byte description[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public VkPipelineExecutableStatisticFormatKHR format;
	public VkPipelineExecutableStatisticValueKHR value;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineExecutableInternalRepresentationKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe fixed byte name[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public unsafe fixed byte description[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public VkBool32 isText;
	public nuint dataSize;
	public unsafe void* pData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderDemoteToHelperInvocation;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 texelBufferAlignment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public ulong uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSubgroupSizeControlFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSubgroupSizeControlProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint minSubgroupSize;
	public uint maxSubgroupSize;
	public uint maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint requiredSubgroupSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRenderPass renderPass;
	public uint subpass;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxSubpassShadingWorkgroupSizeAspectRatio;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong opaqueCaptureAddress;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceMemory memory;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 rectangularLines;
	public VkBool32 bresenhamLines;
	public VkBool32 smoothLines;
	public VkBool32 stippledRectangularLines;
	public VkBool32 stippledBresenhamLines;
	public VkBool32 stippledSmoothLines;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceLineRasterizationPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint lineSubPixelPrecisionBits;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRasterizationLineStateCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkLineRasterizationModeEXT lineRasterizationMode;
	public VkBool32 stippledLineEnable;
	public uint lineStippleFactor;
	public ushort lineStipplePattern;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePipelineCreationCacheControlFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 pipelineCreationCacheControl;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVulkan11Features
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 storageBuffer16BitAccess;
	public VkBool32 uniformAndStorageBuffer16BitAccess;
	public VkBool32 storagePushConstant16;
	public VkBool32 storageInputOutput16;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
	public VkBool32 protectedMemory;
	public VkBool32 samplerYcbcrConversion;
	public VkBool32 shaderDrawParameters;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVulkan11Properties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe fixed byte deviceUUID[Vulkan.VK_UUID_SIZE];
	public unsafe fixed byte driverUUID[Vulkan.VK_UUID_SIZE];
	public unsafe fixed byte deviceLUID[Vulkan.VK_LUID_SIZE];
	public uint deviceNodeMask;
	public VkBool32 deviceLUIDValid;
	public uint subgroupSize;
	public VkShaderStageFlags subgroupSupportedStages;
	public VkSubgroupFeatureFlags subgroupSupportedOperations;
	public VkBool32 subgroupQuadOperationsInAllStages;
	public VkPointClippingBehavior pointClippingBehavior;
	public uint maxMultiviewViewCount;
	public uint maxMultiviewInstanceIndex;
	public VkBool32 protectedNoFault;
	public uint maxPerSetDescriptors;
	public ulong maxMemoryAllocationSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVulkan12Features
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 samplerMirrorClampToEdge;
	public VkBool32 drawIndirectCount;
	public VkBool32 storageBuffer8BitAccess;
	public VkBool32 uniformAndStorageBuffer8BitAccess;
	public VkBool32 storagePushConstant8;
	public VkBool32 shaderBufferInt64Atomics;
	public VkBool32 shaderSharedInt64Atomics;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
	public VkBool32 descriptorIndexing;
	public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 shaderSampledImageArrayNonUniformIndexing;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageImageArrayNonUniformIndexing;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUpdateUnusedWhilePending;
	public VkBool32 descriptorBindingPartiallyBound;
	public VkBool32 descriptorBindingVariableDescriptorCount;
	public VkBool32 runtimeDescriptorArray;
	public VkBool32 samplerFilterMinmax;
	public VkBool32 scalarBlockLayout;
	public VkBool32 imagelessFramebuffer;
	public VkBool32 uniformBufferStandardLayout;
	public VkBool32 shaderSubgroupExtendedTypes;
	public VkBool32 separateDepthStencilLayouts;
	public VkBool32 hostQueryReset;
	public VkBool32 timelineSemaphore;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
	public VkBool32 vulkanMemoryModel;
	public VkBool32 vulkanMemoryModelDeviceScope;
	public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
	public VkBool32 shaderOutputViewportIndex;
	public VkBool32 shaderOutputLayer;
	public VkBool32 subgroupBroadcastDynamicId;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVulkan12Properties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDriverId driverID;
	public unsafe fixed byte driverName[Vulkan.VK_MAX_DRIVER_NAME_SIZE];
	public unsafe fixed byte driverInfo[Vulkan.VK_MAX_DRIVER_INFO_SIZE];
	public VkConformanceVersion conformanceVersion;
	public VkShaderFloatControlsIndependence denormBehaviorIndependence;
	public VkShaderFloatControlsIndependence roundingModeIndependence;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 shaderDenormPreserveFloat16;
	public VkBool32 shaderDenormPreserveFloat32;
	public VkBool32 shaderDenormPreserveFloat64;
	public VkBool32 shaderDenormFlushToZeroFloat16;
	public VkBool32 shaderDenormFlushToZeroFloat32;
	public VkBool32 shaderDenormFlushToZeroFloat64;
	public VkBool32 shaderRoundingModeRTEFloat16;
	public VkBool32 shaderRoundingModeRTEFloat32;
	public VkBool32 shaderRoundingModeRTEFloat64;
	public VkBool32 shaderRoundingModeRTZFloat16;
	public VkBool32 shaderRoundingModeRTZFloat32;
	public VkBool32 shaderRoundingModeRTZFloat64;
	public uint maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint maxPerStageUpdateAfterBindResources;
	public uint maxDescriptorSetUpdateAfterBindSamplers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint maxDescriptorSetUpdateAfterBindSampledImages;
	public uint maxDescriptorSetUpdateAfterBindStorageImages;
	public uint maxDescriptorSetUpdateAfterBindInputAttachments;
	public VkResolveModeFlags supportedDepthResolveModes;
	public VkResolveModeFlags supportedStencilResolveModes;
	public VkBool32 independentResolveNone;
	public VkBool32 independentResolve;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
	public ulong maxTimelineSemaphoreValueDifference;
	public VkSampleCountFlags framebufferIntegerColorSampleCounts;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVulkan13Features
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 robustImageAccess;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
	public VkBool32 pipelineCreationCacheControl;
	public VkBool32 privateData;
	public VkBool32 shaderDemoteToHelperInvocation;
	public VkBool32 shaderTerminateInvocation;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
	public VkBool32 synchronization2;
	public VkBool32 textureCompressionASTC_HDR;
	public VkBool32 shaderZeroInitializeWorkgroupMemory;
	public VkBool32 dynamicRendering;
	public VkBool32 shaderIntegerDotProduct;
	public VkBool32 maintenance4;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVulkan13Properties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint minSubgroupSize;
	public uint maxSubgroupSize;
	public uint maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
	public uint maxInlineUniformBlockSize;
	public uint maxPerStageDescriptorInlineUniformBlocks;
	public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint maxDescriptorSetInlineUniformBlocks;
	public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
	public uint maxInlineUniformTotalSize;
	public VkBool32 integerDotProduct8BitUnsignedAccelerated;
	public VkBool32 integerDotProduct8BitSignedAccelerated;
	public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProduct16BitUnsignedAccelerated;
	public VkBool32 integerDotProduct16BitSignedAccelerated;
	public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct32BitUnsignedAccelerated;
	public VkBool32 integerDotProduct32BitSignedAccelerated;
	public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct64BitUnsignedAccelerated;
	public VkBool32 integerDotProduct64BitSignedAccelerated;
	public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
	public ulong storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public ulong uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
	public ulong maxBufferSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineCompilerControlCreateInfoAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 deviceCoherentMemory;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceToolProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe fixed byte name[Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
	public unsafe fixed byte version[Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
	public VkToolPurposeFlags purposes;
	public unsafe fixed byte description[Vulkan.VK_MAX_DESCRIPTION_SIZE];
	public unsafe fixed byte layer[Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSamplerCustomBorderColorCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkClearColorValue customBorderColor;
	public VkFormat format;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxCustomBorderColorSamplers;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 customBorderColors;
	public VkBool32 customBorderColorWithoutFormat;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkComponentMapping components;
	public VkBool32 srgb;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 borderColorSwizzle;
	public VkBool32 borderColorSwizzleFromImage;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureGeometryTrianglesDataKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormat vertexFormat;
	public VkDeviceOrHostAddressConstKHR vertexData;
	public ulong vertexStride;
	public uint maxVertex;
	public VkIndexType indexType;
	public VkDeviceOrHostAddressConstKHR indexData;
	public VkDeviceOrHostAddressConstKHR transformData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureGeometryAabbsDataKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceOrHostAddressConstKHR data;
	public ulong stride;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureGeometryInstancesDataKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 arrayOfPointers;
	public VkDeviceOrHostAddressConstKHR data;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureGeometryKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkGeometryTypeKHR geometryType;
	public VkAccelerationStructureGeometryDataKHR geometry;
	public VkGeometryFlagsKHR flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureBuildGeometryInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccelerationStructureTypeKHR type;
	public VkBuildAccelerationStructureFlagsKHR flags;
	public VkBuildAccelerationStructureModeKHR mode;
	public VkAccelerationStructureKHR srcAccelerationStructure;
	public VkAccelerationStructureKHR dstAccelerationStructure;
	public uint geometryCount;
	public unsafe VkAccelerationStructureGeometryKHR* pGeometries;
	public unsafe VkAccelerationStructureGeometryKHR** ppGeometries;
	public VkDeviceOrHostAddressKHR scratchData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureBuildRangeInfoKHR
{
	public uint primitiveCount;
	public uint primitiveOffset;
	public uint firstVertex;
	public uint transformOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccelerationStructureCreateFlagsKHR createFlags;
	public VkBuffer buffer;
	public ulong offset;
	public ulong size;
	public VkAccelerationStructureTypeKHR type;
	public IntPtr deviceAddress;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAabbPositionsKHR
{
	public float minX;
	public float minY;
	public float minZ;
	public float maxX;
	public float maxY;
	public float maxZ;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureInstanceKHR
{
	public VkTransformMatrixKHR transform;
	public uint instanceCustomIndex;
	public uint mask;
	public uint instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public ulong accelerationStructureReference;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureDeviceAddressInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccelerationStructureKHR accelerationStructure;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureVersionInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe byte* pVersionData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyAccelerationStructureInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccelerationStructureKHR src;
	public VkAccelerationStructureKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyAccelerationStructureToMemoryInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkAccelerationStructureKHR src;
	public VkDeviceOrHostAddressKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyMemoryToAccelerationStructureInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceOrHostAddressConstKHR src;
	public VkAccelerationStructureKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxPipelineRayPayloadSize;
	public uint maxPipelineRayHitAttributeSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineLibraryCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint libraryCount;
	public unsafe VkPipeline* pLibraries;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 extendedDynamicState;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 extendedDynamicState2;
	public VkBool32 extendedDynamicState2LogicOp;
	public VkBool32 extendedDynamicState2PatchControlPoints;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderPassTransformBeginInfoQCOM
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSurfaceTransformFlagsKHR transform;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyCommandTransformInfoQCOM
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSurfaceTransformFlagsKHR transform;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSurfaceTransformFlagsKHR transform;
	public VkRect2D renderArea;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 diagnosticsConfig;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDeviceDiagnosticsConfigCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceDiagnosticsConfigFlagsNV flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderZeroInitializeWorkgroupMemory;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderSubgroupUniformControlFlow;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRobustness2FeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 robustBufferAccess2;
	public VkBool32 robustImageAccess2;
	public VkBool32 nullDescriptor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRobustness2PropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong robustStorageBufferAccessSizeAlignment;
	public ulong robustUniformBufferAccessSizeAlignment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceImageRobustnessFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 robustImageAccess;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 workgroupMemoryExplicitLayout;
	public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;
	public VkBool32 workgroupMemoryExplicitLayout8BitAccess;
	public VkBool32 workgroupMemoryExplicitLayout16BitAccess;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePortabilitySubsetFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 constantAlphaColorBlendFactors;
	public VkBool32 events;
	public VkBool32 imageViewFormatReinterpretation;
	public VkBool32 imageViewFormatSwizzle;
	public VkBool32 imageView2DOn3DImage;
	public VkBool32 multisampleArrayImage;
	public VkBool32 mutableComparisonSamplers;
	public VkBool32 pointPolygons;
	public VkBool32 samplerMipLodBias;
	public VkBool32 separateStencilMaskRef;
	public VkBool32 shaderSampleRateInterpolationFunctions;
	public VkBool32 tessellationIsolines;
	public VkBool32 tessellationPointMode;
	public VkBool32 triangleFans;
	public VkBool32 vertexAttributeAccessBeyondStride;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePortabilitySubsetPropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint minVertexInputBindingStrideAlignment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevice4444FormatsFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 formatA4R4G4B4;
	public VkBool32 formatA4B4G4R4;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 subpassShading;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferCopy2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong srcOffset;
	public ulong dstOffset;
	public ulong size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageCopy2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public Vector3i srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public Vector3i dstOffset;
	public Vector3ui extent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageBlit2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public Vector3i srcOffsets_0;
	public Vector3i srcOffsets_1;
	public VkImageSubresourceLayers dstSubresource;
	public Vector3i dstOffsets_0;
	public Vector3i dstOffsets_1;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferImageCopy2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong bufferOffset;
	public uint bufferRowLength;
	public uint bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public Vector3i imageOffset;
	public Vector3ui imageExtent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageResolve2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public Vector3i srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public Vector3i dstOffset;
	public Vector3ui extent;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyBufferInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBuffer srcBuffer;
	public VkBuffer dstBuffer;
	public uint regionCount;
	public unsafe VkBufferCopy2* pRegions;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyImageInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public unsafe VkImageCopy2* pRegions;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBlitImageInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public unsafe VkImageBlit2* pRegions;
	public VkFilter filter;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyBufferToImageInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBuffer srcBuffer;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public unsafe VkBufferImageCopy2* pRegions;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCopyImageToBufferInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkBuffer dstBuffer;
	public uint regionCount;
	public unsafe VkBufferImageCopy2* pRegions;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkResolveImageInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint regionCount;
	public unsafe VkImageResolve2* pRegions;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderImageInt64Atomics;
	public VkBool32 sparseImageInt64Atomics;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFragmentShadingRateAttachmentInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe VkAttachmentReference2* pFragmentShadingRateAttachment;
	public Vector2ui shadingRateAttachmentTexelSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public Vector2ui fragmentSize;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 pipelineFragmentShadingRate;
	public VkBool32 primitiveFragmentShadingRate;
	public VkBool32 attachmentFragmentShadingRate;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public Vector2ui minFragmentShadingRateAttachmentTexelSize;
	public Vector2ui maxFragmentShadingRateAttachmentTexelSize;
	public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
	public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;
	public VkBool32 layeredShadingRateAttachments;
	public VkBool32 fragmentShadingRateNonTrivialCombinerOps;
	public Vector2ui maxFragmentSize;
	public uint maxFragmentSizeAspectRatio;
	public uint maxFragmentShadingRateCoverageSamples;
	public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;
	public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;
	public VkBool32 fragmentShadingRateWithSampleMask;
	public VkBool32 fragmentShadingRateWithShaderSampleMask;
	public VkBool32 fragmentShadingRateWithConservativeRasterization;
	public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;
	public VkBool32 fragmentShadingRateWithCustomSampleLocations;
	public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentShadingRateKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSampleCountFlags sampleCounts;
	public Vector2ui fragmentSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderTerminateInvocationFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderTerminateInvocation;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 fragmentShadingRateEnums;
	public VkBool32 supersampleFragmentShadingRates;
	public VkBool32 noInvocationFragmentShadingRates;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSampleCountFlags maxFragmentShadingRateInvocationCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFragmentShadingRateTypeNV shadingRateType;
	public VkFragmentShadingRateNV shadingRate;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureBuildSizesInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public ulong accelerationStructureSize;
	public ulong updateScratchSize;
	public ulong buildScratchSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 image2DViewOf3D;
	public VkBool32 sampler2DViewOf3D;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 mutableDescriptorType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMutableDescriptorTypeListVALVE
{
	public uint descriptorTypeCount;
	public unsafe VkDescriptorType* pDescriptorTypes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMutableDescriptorTypeCreateInfoVALVE
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint mutableDescriptorTypeListCount;
	public unsafe VkMutableDescriptorTypeListVALVE* pMutableDescriptorTypeLists;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDepthClipControlFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 depthClipControl;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineViewportDepthClipControlCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 negativeOneToOne;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 vertexInputDynamicState;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 externalMemoryRDMA;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVertexInputBindingDescription2EXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint binding;
	public uint stride;
	public VkVertexInputRate inputRate;
	public uint divisor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVertexInputAttributeDescription2EXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint location;
	public uint binding;
	public VkFormat format;
	public uint offset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 colorWriteEnable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineColorWriteCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint attachmentCount;
	public unsafe VkBool32* pColorWriteEnables;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryBarrier2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageMemoryBarrier2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public VkImageLayout oldLayout;
	public VkImageLayout newLayout;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkImage image;
	public VkImageSubresourceRange subresourceRange;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferMemoryBarrier2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public uint srcQueueFamilyIndex;
	public uint dstQueueFamilyIndex;
	public VkBuffer buffer;
	public ulong offset;
	public ulong size;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDependencyInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDependencyFlags dependencyFlags;
	public uint memoryBarrierCount;
	public unsafe VkMemoryBarrier2* pMemoryBarriers;
	public uint bufferMemoryBarrierCount;
	public unsafe VkBufferMemoryBarrier2* pBufferMemoryBarriers;
	public uint imageMemoryBarrierCount;
	public unsafe VkImageMemoryBarrier2* pImageMemoryBarriers;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSemaphoreSubmitInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSemaphore semaphore;
	public ulong value;
	public VkPipelineStageFlags2 stageMask;
	public uint deviceIndex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandBufferSubmitInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkCommandBuffer commandBuffer;
	public uint deviceMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSubmitInfo2
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkSubmitFlags flags;
	public uint waitSemaphoreInfoCount;
	public unsafe VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
	public uint commandBufferInfoCount;
	public unsafe VkCommandBufferSubmitInfo* pCommandBufferInfos;
	public uint signalSemaphoreInfoCount;
	public unsafe VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueueFamilyCheckpointProperties2NV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineStageFlags2 checkpointExecutionStageMask;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCheckpointData2NV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkPipelineStageFlags2 stage;
	public unsafe void* pCheckpointMarker;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceSynchronization2Features
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 synchronization2;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 primitivesGeneratedQuery;
	public VkBool32 primitivesGeneratedQueryWithRasterizerDiscard;
	public VkBool32 primitivesGeneratedQueryWithNonZeroStreams;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoQueueFamilyProperties2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoCodecOperationFlagsKHR videoCodecOperations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkQueueFamilyQueryResultStatusProperties2KHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 supported;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoProfilesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint profileCount;
	public unsafe VkVideoProfileKHR* pProfiles;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceVideoFormatInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageUsageFlags imageUsage;
	public unsafe VkVideoProfilesKHR* pVideoProfiles;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoFormatPropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormat format;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoProfileKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoCodecOperationFlagsKHR videoCodecOperation;
	public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;
	public VkVideoComponentBitDepthFlagsKHR lumaBitDepth;
	public VkVideoComponentBitDepthFlagsKHR chromaBitDepth;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoCapabilitiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoCapabilityFlagsKHR capabilityFlags;
	public ulong minBitstreamBufferOffsetAlignment;
	public ulong minBitstreamBufferSizeAlignment;
	public Vector2ui videoPictureExtentGranularity;
	public Vector2ui minExtent;
	public Vector2ui maxExtent;
	public uint maxReferencePicturesSlotsCount;
	public uint maxReferencePicturesActiveCount;
	public VkExtensionProperties stdHeaderVersion;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoGetMemoryPropertiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint memoryBindIndex;
	public unsafe VkMemoryRequirements2* pMemoryRequirements;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoBindMemoryKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint memoryBindIndex;
	public VkDeviceMemory memory;
	public ulong memoryOffset;
	public ulong memorySize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoPictureResourceKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public Vector2i codedOffset;
	public Vector2ui codedExtent;
	public uint baseArrayLayer;
	public VkImageView imageViewBinding;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoReferenceSlotKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public sbyte slotIndex;
	public unsafe VkVideoPictureResourceKHR* pPictureResource;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeCapabilitiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoDecodeCapabilityFlagsKHR flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoDecodeFlagsKHR flags;
	public VkBuffer srcBuffer;
	public ulong srcBufferOffset;
	public ulong srcBufferRange;
	public VkVideoPictureResourceKHR dstPictureResource;
	public unsafe VkVideoReferenceSlotKHR* pSetupReferenceSlot;
	public uint referenceSlotCount;
	public unsafe VkVideoReferenceSlotKHR* pReferenceSlots;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH264ProfileEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public StdVideoH264ProfileIdc stdProfileIdc;
	public VkVideoDecodeH264PictureLayoutFlagsEXT pictureLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH264CapabilitiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public StdVideoH264Level maxLevel;
	public Vector2i fieldOffsetGranularity;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH264SessionParametersAddInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint spsStdCount;
	public unsafe IntPtr* pSpsStd;
	public uint ppsStdCount;
	public unsafe StdVideoH264PictureParameterSet* pPpsStd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH264SessionParametersCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxSpsStdCount;
	public uint maxPpsStdCount;
	public unsafe VkVideoDecodeH264SessionParametersAddInfoEXT* pParametersAddInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH264PictureInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe StdVideoDecodeH264PictureInfo* pStdPictureInfo;
	public uint slicesCount;
	public unsafe uint* pSlicesDataOffsets;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH264DpbSlotInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe StdVideoDecodeH264ReferenceInfo* pStdReferenceInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH264MvcEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe StdVideoDecodeH264Mvc* pStdMvc;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH265ProfileEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public StdVideoH265ProfileIdc stdProfileIdc;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH265CapabilitiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public StdVideoH265Level maxLevel;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH265SessionParametersAddInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint vpsStdCount;
	public unsafe StdVideoH265VideoParameterSet* pVpsStd;
	public uint spsStdCount;
	public unsafe StdVideoH265SequenceParameterSet* pSpsStd;
	public uint ppsStdCount;
	public unsafe StdVideoH265PictureParameterSet* pPpsStd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH265SessionParametersCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxVpsStdCount;
	public uint maxSpsStdCount;
	public uint maxPpsStdCount;
	public unsafe VkVideoDecodeH265SessionParametersAddInfoEXT* pParametersAddInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH265PictureInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe StdVideoDecodeH265PictureInfo* pStdPictureInfo;
	public uint slicesCount;
	public unsafe uint* pSlicesDataOffsets;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoDecodeH265DpbSlotInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe StdVideoDecodeH265ReferenceInfo* pStdReferenceInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoSessionCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint queueFamilyIndex;
	public VkVideoSessionCreateFlagsKHR flags;
	public unsafe VkVideoProfileKHR* pVideoProfile;
	public VkFormat pictureFormat;
	public Vector2ui maxCodedExtent;
	public VkFormat referencePicturesFormat;
	public uint maxReferencePicturesSlotsCount;
	public uint maxReferencePicturesActiveCount;
	public unsafe VkExtensionProperties* pStdHeaderVersion;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoSessionParametersCreateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoSessionParametersKHR videoSessionParametersTemplate;
	public VkVideoSessionKHR videoSession;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoSessionParametersUpdateInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint updateSequenceCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoBeginCodingInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoBeginCodingFlagsKHR flags;
	public VkVideoCodingQualityPresetFlagsKHR codecQualityPreset;
	public VkVideoSessionKHR videoSession;
	public VkVideoSessionParametersKHR videoSessionParameters;
	public uint referenceSlotCount;
	public unsafe VkVideoReferenceSlotKHR* pReferenceSlots;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEndCodingInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoEndCodingFlagsKHR flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoCodingControlInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoCodingControlFlagsKHR flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoEncodeFlagsKHR flags;
	public uint qualityLevel;
	public VkBuffer dstBitstreamBuffer;
	public ulong dstBitstreamBufferOffset;
	public ulong dstBitstreamBufferMaxRange;
	public VkVideoPictureResourceKHR srcPictureResource;
	public unsafe VkVideoReferenceSlotKHR* pSetupReferenceSlot;
	public uint referenceSlotCount;
	public unsafe VkVideoReferenceSlotKHR* pReferenceSlots;
	public uint precedingExternallyEncodedBytes;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeRateControlInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoEncodeRateControlFlagsKHR flags;
	public VkVideoEncodeRateControlModeFlagsKHR rateControlMode;
	public byte layerCount;
	public unsafe VkVideoEncodeRateControlLayerInfoKHR* pLayerConfigs;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeRateControlLayerInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint averageBitrate;
	public uint maxBitrate;
	public uint frameRateNumerator;
	public uint frameRateDenominator;
	public uint virtualBufferSizeInMs;
	public uint initialVirtualBufferSizeInMs;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeCapabilitiesKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoEncodeCapabilityFlagsKHR flags;
	public VkVideoEncodeRateControlModeFlagsKHR rateControlModes;
	public byte rateControlLayerCount;
	public byte qualityLevelCount;
	public Vector2ui inputImageDataFillAlignment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264CapabilitiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoEncodeH264CapabilityFlagsEXT flags;
	public VkVideoEncodeH264InputModeFlagsEXT inputModeFlags;
	public VkVideoEncodeH264OutputModeFlagsEXT outputModeFlags;
	public byte maxPPictureL0ReferenceCount;
	public byte maxBPictureL0ReferenceCount;
	public byte maxL1ReferenceCount;
	public VkBool32 motionVectorsOverPicBoundariesFlag;
	public uint maxBytesPerPicDenom;
	public uint maxBitsPerMbDenom;
	public uint log2MaxMvLengthHorizontal;
	public uint log2MaxMvLengthVertical;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264SessionParametersAddInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint spsStdCount;
	public unsafe IntPtr* pSpsStd;
	public uint ppsStdCount;
	public unsafe StdVideoH264PictureParameterSet* pPpsStd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264SessionParametersCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxSpsStdCount;
	public uint maxPpsStdCount;
	public unsafe VkVideoEncodeH264SessionParametersAddInfoEXT* pParametersAddInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264DpbSlotInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public sbyte slotIndex;
	public unsafe StdVideoEncodeH264ReferenceInfo* pStdReferenceInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264VclFrameInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe VkVideoEncodeH264ReferenceListsEXT* pReferenceFinalLists;
	public uint naluSliceEntryCount;
	public unsafe VkVideoEncodeH264NaluSliceEXT* pNaluSliceEntries;
	public unsafe StdVideoEncodeH264PictureInfo* pCurrentPictureInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264ReferenceListsEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public byte referenceList0EntryCount;
	public unsafe VkVideoEncodeH264DpbSlotInfoEXT* pReferenceList0Entries;
	public byte referenceList1EntryCount;
	public unsafe VkVideoEncodeH264DpbSlotInfoEXT* pReferenceList1Entries;
	public unsafe StdVideoEncodeH264RefMemMgmtCtrlOperations* pMemMgmtCtrlOperations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264EmitPictureParametersEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public byte spsId;
	public VkBool32 emitSpsEnable;
	public uint ppsIdEntryCount;
	public unsafe byte* ppsIdEntries;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264ProfileEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public StdVideoH264ProfileIdc stdProfileIdc;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264NaluSliceEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint mbCount;
	public unsafe VkVideoEncodeH264ReferenceListsEXT* pReferenceFinalLists;
	public unsafe StdVideoEncodeH264SliceHeader* pSliceHeaderStd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264RateControlInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint gopFrameCount;
	public uint idrPeriod;
	public uint consecutiveBFrameCount;
	public VkVideoEncodeH264RateControlStructureFlagsEXT rateControlStructure;
	public byte temporalLayerCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264QpEXT
{
	public int qpI;
	public int qpP;
	public int qpB;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264FrameSizeEXT
{
	public uint frameISize;
	public uint framePSize;
	public uint frameBSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH264RateControlLayerInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public byte temporalLayerId;
	public VkBool32 useInitialRcQp;
	public VkVideoEncodeH264QpEXT initialRcQp;
	public VkBool32 useMinQp;
	public VkVideoEncodeH264QpEXT minQp;
	public VkBool32 useMaxQp;
	public VkVideoEncodeH264QpEXT maxQp;
	public VkBool32 useMaxFrameSize;
	public VkVideoEncodeH264FrameSizeEXT maxFrameSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265CapabilitiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkVideoEncodeH265CapabilityFlagsEXT flags;
	public VkVideoEncodeH265InputModeFlagsEXT inputModeFlags;
	public VkVideoEncodeH265OutputModeFlagsEXT outputModeFlags;
	public VkVideoEncodeH265CtbSizeFlagsEXT ctbSizes;
	public VkVideoEncodeH265TransformBlockSizeFlagsEXT transformBlockSizes;
	public byte maxPPictureL0ReferenceCount;
	public byte maxBPictureL0ReferenceCount;
	public byte maxL1ReferenceCount;
	public byte maxSubLayersCount;
	public byte minLog2MinLumaCodingBlockSizeMinus3;
	public byte maxLog2MinLumaCodingBlockSizeMinus3;
	public byte minLog2MinLumaTransformBlockSizeMinus2;
	public byte maxLog2MinLumaTransformBlockSizeMinus2;
	public byte minMaxTransformHierarchyDepthInter;
	public byte maxMaxTransformHierarchyDepthInter;
	public byte minMaxTransformHierarchyDepthIntra;
	public byte maxMaxTransformHierarchyDepthIntra;
	public byte maxDiffCuQpDeltaDepth;
	public byte minMaxNumMergeCand;
	public byte maxMaxNumMergeCand;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265SessionParametersAddInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint vpsStdCount;
	public unsafe StdVideoH265VideoParameterSet* pVpsStd;
	public uint spsStdCount;
	public unsafe StdVideoH265SequenceParameterSet* pSpsStd;
	public uint ppsStdCount;
	public unsafe StdVideoH265PictureParameterSet* pPpsStd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265SessionParametersCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxVpsStdCount;
	public uint maxSpsStdCount;
	public uint maxPpsStdCount;
	public unsafe VkVideoEncodeH265SessionParametersAddInfoEXT* pParametersAddInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265VclFrameInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public unsafe VkVideoEncodeH265ReferenceListsEXT* pReferenceFinalLists;
	public uint naluSliceSegmentEntryCount;
	public unsafe VkVideoEncodeH265NaluSliceSegmentEXT* pNaluSliceSegmentEntries;
	public unsafe StdVideoEncodeH265PictureInfo* pCurrentPictureInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265EmitPictureParametersEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public byte vpsId;
	public byte spsId;
	public VkBool32 emitVpsEnable;
	public VkBool32 emitSpsEnable;
	public uint ppsIdEntryCount;
	public unsafe byte* ppsIdEntries;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265NaluSliceSegmentEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint ctbCount;
	public unsafe VkVideoEncodeH265ReferenceListsEXT* pReferenceFinalLists;
	public unsafe StdVideoEncodeH265SliceSegmentHeader* pSliceSegmentHeaderStd;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265RateControlInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint gopFrameCount;
	public uint idrPeriod;
	public uint consecutiveBFrameCount;
	public VkVideoEncodeH265RateControlStructureFlagsEXT rateControlStructure;
	public byte subLayerCount;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265QpEXT
{
	public int qpI;
	public int qpP;
	public int qpB;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265FrameSizeEXT
{
	public uint frameISize;
	public uint framePSize;
	public uint frameBSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265RateControlLayerInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public byte temporalId;
	public VkBool32 useInitialRcQp;
	public VkVideoEncodeH265QpEXT initialRcQp;
	public VkBool32 useMinQp;
	public VkVideoEncodeH265QpEXT minQp;
	public VkBool32 useMaxQp;
	public VkVideoEncodeH265QpEXT maxQp;
	public VkBool32 useMaxFrameSize;
	public VkVideoEncodeH265FrameSizeEXT maxFrameSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265ProfileEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public StdVideoH265ProfileIdc stdProfileIdc;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265DpbSlotInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public sbyte slotIndex;
	public unsafe StdVideoEncodeH265ReferenceInfo* pStdReferenceInfo;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkVideoEncodeH265ReferenceListsEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public byte referenceList0EntryCount;
	public unsafe VkVideoEncodeH265DpbSlotInfoEXT* pReferenceList0Entries;
	public byte referenceList1EntryCount;
	public unsafe VkVideoEncodeH265DpbSlotInfoEXT* pReferenceList1Entries;
	public unsafe StdVideoEncodeH265ReferenceModifications* pReferenceModifications;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 inheritedViewportScissor2D;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandBufferInheritanceViewportScissorInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 viewportScissor2D;
	public uint viewportDepthCount;
	public unsafe VkViewport* pViewportDepths;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 ycbcr2plane444Formats;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 provokingVertexLast;
	public VkBool32 transformFeedbackPreservesProvokingVertex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 provokingVertexModePerPipeline;
	public VkBool32 transformFeedbackPreservesTriangleFanProvokingVertex;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkProvokingVertexModeEXT provokingVertexMode;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCuModuleCreateInfoNVX
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public nuint dataSize;
	public unsafe void* pData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCuFunctionCreateInfoNVX
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkCuModuleNVX module;
	public unsafe byte* pName;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCuLaunchInfoNVX
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkCuFunctionNVX function;
	public uint gridDimX;
	public uint gridDimY;
	public uint gridDimZ;
	public uint blockDimX;
	public uint blockDimY;
	public uint blockDimZ;
	public uint sharedMemBytes;
	public nuint paramCount;
	public unsafe void* pParams;
	public nuint extraCount;
	public unsafe void* pExtras;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderIntegerDotProductFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 shaderIntegerDotProduct;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 integerDotProduct8BitUnsignedAccelerated;
	public VkBool32 integerDotProduct8BitSignedAccelerated;
	public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProduct16BitUnsignedAccelerated;
	public VkBool32 integerDotProduct16BitSignedAccelerated;
	public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct32BitUnsignedAccelerated;
	public VkBool32 integerDotProduct32BitSignedAccelerated;
	public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct64BitUnsignedAccelerated;
	public VkBool32 integerDotProduct64BitSignedAccelerated;
	public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDrmPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 hasPrimary;
	public VkBool32 hasRender;
	public long primaryMajor;
	public long primaryMinor;
	public long renderMajor;
	public long renderMinor;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 rayTracingMotionBlur;
	public VkBool32 rayTracingMotionBlurPipelineTraceRaysIndirect;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureGeometryMotionTrianglesDataNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceOrHostAddressConstKHR vertexData;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureMotionInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint maxInstances;
	public VkAccelerationStructureMotionInfoFlagsNV flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSRTDataNV
{
	public float sx;
	public float a;
	public float b;
	public float pvx;
	public float sy;
	public float c;
	public float pvy;
	public float sz;
	public float pvz;
	public float qx;
	public float qy;
	public float qz;
	public float qw;
	public float tx;
	public float ty;
	public float tz;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureSRTMotionInstanceNV
{
	public VkSRTDataNV transformT0;
	public VkSRTDataNV transformT1;
	public uint instanceCustomIndex;
	public uint mask;
	public uint instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public ulong accelerationStructureReference;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureMatrixMotionInstanceNV
{
	public VkTransformMatrixKHR transformT0;
	public VkTransformMatrixKHR transformT1;
	public uint instanceCustomIndex;
	public uint mask;
	public uint instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public ulong accelerationStructureReference;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAccelerationStructureMotionInstanceNV
{
	public VkAccelerationStructureMotionInstanceTypeNV type;
	public VkAccelerationStructureMotionInstanceFlagsNV flags;
	public VkAccelerationStructureMotionInstanceDataNV data;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMemoryGetRemoteAddressInfoNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlags handleType;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImportMemoryBufferCollectionFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBufferCollectionFUCHSIA collection;
	public uint index;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferCollectionImageCreateInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBufferCollectionFUCHSIA collection;
	public uint index;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferCollectionBufferCreateInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBufferCollectionFUCHSIA collection;
	public uint index;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferCollectionCreateInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public IntPtr collectionToken;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferCollectionPropertiesFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint memoryTypeBits;
	public uint bufferCount;
	public uint createInfoIndex;
	public ulong sysmemPixelFormat;
	public VkFormatFeatureFlags formatFeatures;
	public VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex;
	public VkComponentMapping samplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
	public VkSamplerYcbcrRange suggestedYcbcrRange;
	public VkChromaLocation suggestedXChromaOffset;
	public VkChromaLocation suggestedYChromaOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferConstraintsInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBufferCreateInfo createInfo;
	public VkFormatFeatureFlags requiredFormatFeatures;
	public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkSysmemColorSpaceFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint colorSpace;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageFormatConstraintsInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageCreateInfo imageCreateInfo;
	public VkFormatFeatureFlags requiredFormatFeatures;
	public VkImageFormatConstraintsFlagsFUCHSIA flags;
	public ulong sysmemPixelFormat;
	public uint colorSpaceCount;
	public unsafe VkSysmemColorSpaceFUCHSIA* pColorSpaces;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageConstraintsInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint formatConstraintsCount;
	public unsafe VkImageFormatConstraintsInfoFUCHSIA* pFormatConstraints;
	public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
	public VkImageConstraintsInfoFlagsFUCHSIA flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkBufferCollectionConstraintsInfoFUCHSIA
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint minBufferCount;
	public uint maxBufferCount;
	public uint minBufferCountForCamping;
	public uint minBufferCountForDedicatedSlack;
	public uint minBufferCountForSharedSlack;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 formatRgba10x6WithoutYCbCrSampler;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkFormatProperties3
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormatFeatureFlags2 linearTilingFeatures;
	public VkFormatFeatureFlags2 optimalTilingFeatures;
	public VkFormatFeatureFlags2 bufferFeatures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDrmFormatModifierPropertiesList2EXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint drmFormatModifierCount;
	public unsafe VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDrmFormatModifierProperties2EXT
{
	public ulong drmFormatModifier;
	public uint drmFormatModifierPlaneCount;
	public VkFormatFeatureFlags2 drmFormatModifierTilingFeatures;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAndroidHardwareBufferFormatProperties2ANDROID
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkFormat format;
	public ulong externalFormat;
	public VkFormatFeatureFlags2 formatFeatures;
	public VkComponentMapping samplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
	public VkSamplerYcbcrRange suggestedYcbcrRange;
	public VkChromaLocation suggestedXChromaOffset;
	public VkChromaLocation suggestedYChromaOffset;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPipelineRenderingCreateInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint viewMask;
	public uint colorAttachmentCount;
	public unsafe VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderingInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRenderingFlags flags;
	public VkRect2D renderArea;
	public uint layerCount;
	public uint viewMask;
	public uint colorAttachmentCount;
	public unsafe VkRenderingAttachmentInfo* pColorAttachments;
	public unsafe VkRenderingAttachmentInfo* pDepthAttachment;
	public unsafe VkRenderingAttachmentInfo* pStencilAttachment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderingAttachmentInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
	public VkResolveModeFlags resolveMode;
	public VkImageView resolveImageView;
	public VkImageLayout resolveImageLayout;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkClearValue clearValue;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
	public Vector2ui shadingRateAttachmentTexelSize;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDynamicRenderingFeatures
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 dynamicRendering;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkCommandBufferInheritanceRenderingInfo
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkRenderingFlags flags;
	public uint viewMask;
	public uint colorAttachmentCount;
	public unsafe VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
	public VkSampleCountFlags rasterizationSamples;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkAttachmentSampleCountInfoAMD
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public uint colorAttachmentCount;
	public unsafe VkSampleCountFlags* pColorAttachmentSamples;
	public VkSampleCountFlags depthStencilAttachmentSamples;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkMultiviewPerViewAttributesInfoNVX
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 perViewAttributes;
	public VkBool32 perViewAttributesPositionXOnly;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 minLod;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkImageViewMinLodCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public float minLod;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 rasterizationOrderColorAttachmentAccess;
	public VkBool32 rasterizationOrderDepthAttachmentAccess;
	public VkBool32 rasterizationOrderStencilAttachmentAccess;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 linearColorAttachment;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 graphicsPipelineLibrary;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 graphicsPipelineLibraryFastLinking;
	public VkBool32 graphicsPipelineLibraryIndependentInterpolationDecoration;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkGraphicsPipelineLibraryCreateInfoEXT
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkGraphicsPipelineLibraryFlagsEXT flags;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkBool32 descriptorSetHostMapping;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetBindingReferenceVALVE
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public VkDescriptorSetLayout descriptorSetLayout;
	public uint binding;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
	public VkStructureType sType;
	public unsafe void* pNext;
	public nuint descriptorOffset;
	public uint descriptorSize;
}

