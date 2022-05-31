using System;
using System.Runtime.InteropServices;

namespace Fireburst;

public struct VmaAllocatorT
{
	public IntPtr Handle;
}

public struct VmaPoolT
{
	public IntPtr Handle;
}

public struct VmaAllocationT
{
	public IntPtr Handle;
}

public struct VmaDefragmentationContextT
{
	public IntPtr Handle;
}

[StructLayout(LayoutKind.Sequential, Size = 24)]
public struct VmaDeviceMemoryCallbacks
{
	public IntPtr pfnAllocate;
	public IntPtr pfnFree;
	public IntPtr pUserData;
}

[StructLayout(LayoutKind.Sequential, Size = 176)]
public struct VmaVulkanFunctions
{
	public IntPtr vkGetPhysicalDeviceProperties;
	public IntPtr vkGetPhysicalDeviceMemoryProperties;
	public IntPtr vkAllocateMemory;
	public IntPtr vkFreeMemory;
	public IntPtr vkMapMemory;
	public IntPtr vkUnmapMemory;
	public IntPtr vkFlushMappedMemoryRanges;
	public IntPtr vkInvalidateMappedMemoryRanges;
	public IntPtr vkBindBufferMemory;
	public IntPtr vkBindImageMemory;
	public IntPtr vkGetBufferMemoryRequirements;
	public IntPtr vkGetImageMemoryRequirements;
	public IntPtr vkCreateBuffer;
	public IntPtr vkDestroyBuffer;
	public IntPtr vkCreateImage;
	public IntPtr vkDestroyImage;
	public IntPtr vkCmdCopyBuffer;
	public IntPtr vkGetBufferMemoryRequirements2KHR;
	public IntPtr vkGetImageMemoryRequirements2KHR;
	public IntPtr vkBindBufferMemory2KHR;
	public IntPtr vkBindImageMemory2KHR;
	public IntPtr vkGetPhysicalDeviceMemoryProperties2KHR;
}

[StructLayout(LayoutKind.Sequential, Size = 16)]
public struct VmaRecordSettings
{
	public uint flags;
	public IntPtr pFilePath;
}

[StructLayout(LayoutKind.Sequential, Size = 96)]
public struct VmaAllocatorCreateInfo
{
	public uint flags;
	public VkPhysicalDevice physicalDevice;
	public VkDevice device;
	public ulong preferredLargeHeapBlockSize;
	public IntPtr pAllocationCallbacks;
	public IntPtr pDeviceMemoryCallbacks;
	public uint frameInUseCount;
	public IntPtr pHeapSizeLimit;
	public IntPtr pVulkanFunctions;
	public IntPtr pRecordSettings;
	public VkInstance instance;
	public VkVersion vulkanApiVersion;
}

[StructLayout(LayoutKind.Sequential, Size = 24)]
public struct VmaAllocatorInfo
{
	public VkInstance instance;
	public VkPhysicalDevice physicalDevice;
	public VkDevice device;
}

[StructLayout(LayoutKind.Sequential, Size = 80)]
public struct VmaStatInfo
{
	public uint blockCount;
	public uint allocationCount;
	public uint unusedRangeCount;
	public ulong usedBytes;
	public ulong unusedBytes;
	public ulong allocationSizeMin;
	public ulong allocationSizeAvg;
	public ulong allocationSizeMax;
	public ulong unusedRangeSizeMin;
	public ulong unusedRangeSizeAvg;
	public ulong unusedRangeSizeMax;
}

[StructLayout(LayoutKind.Sequential, Size = 3920)]
public struct VmaStats
{
	public unsafe fixed byte memoryType[2560];
	public unsafe fixed byte memoryHeap[1280];
	public VmaStatInfo total;
}

[StructLayout(LayoutKind.Sequential, Size = 32)]
public struct VmaBudget
{
	public ulong blockBytes;
	public ulong allocationBytes;
	public ulong usage;
	public ulong budget;
}

[StructLayout(LayoutKind.Sequential, Size = 48)]
public struct VmaAllocationCreateInfo
{
	public VmaAllocationCreateFlags flags;
	public VmaMemoryUsage usage;
	public VkMemoryPropertyFlags requiredFlags;
	public VkMemoryPropertyFlags preferredFlags;
	public uint memoryTypeBits;
	public IntPtr pool;
	public IntPtr pUserData;
	public float priority;
}

[StructLayout(LayoutKind.Sequential, Size = 40)]
public struct VmaPoolCreateInfo
{
	public uint memoryTypeIndex;
	public uint flags;
	public ulong blockSize;
	public ulong minBlockCount;
	public ulong maxBlockCount;
	public uint frameInUseCount;
	public float priority;
}

[StructLayout(LayoutKind.Sequential, Size = 48)]
public struct VmaPoolStats
{
	public ulong size;
	public ulong unusedSize;
	public ulong allocationCount;
	public ulong unusedRangeCount;
	public ulong unusedRangeSizeMax;
	public ulong blockCount;
}

[StructLayout(LayoutKind.Sequential, Size = 48)]
public struct VmaAllocationInfo
{
	public uint memoryType;
	public IntPtr deviceMemory;
	public ulong offset;
	public ulong size;
	public IntPtr pMappedData;
	public IntPtr pUserData;
}

[StructLayout(LayoutKind.Sequential, Size = 80)]
public struct VmaDefragmentationInfo2
{
	public uint flags;
	public uint allocationCount;
	public IntPtr pAllocations;
	public IntPtr pAllocationsChanged;
	public uint poolCount;
	public IntPtr pPools;
	public ulong maxCpuBytesToMove;
	public uint maxCpuAllocationsToMove;
	public ulong maxGpuBytesToMove;
	public uint maxGpuAllocationsToMove;
	public IntPtr commandBuffer;
}

[StructLayout(LayoutKind.Sequential, Size = 24)]
public struct VmaDefragmentationPassMoveInfo
{
	public IntPtr allocation;
	public IntPtr memory;
	public ulong offset;
}

[StructLayout(LayoutKind.Sequential, Size = 16)]
public struct VmaDefragmentationPassInfo
{
	public uint moveCount;
	public IntPtr pMoves;
}

[StructLayout(LayoutKind.Sequential, Size = 16)]
public struct VmaDefragmentationInfo
{
	public ulong maxBytesToMove;
	public uint maxAllocationsToMove;
}

[StructLayout(LayoutKind.Sequential, Size = 24)]
public struct VmaDefragmentationStats
{
	public ulong bytesMoved;
	public ulong bytesFreed;
	public uint allocationsMoved;
	public uint deviceMemoryBlocksFreed;
}