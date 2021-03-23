using System;
using System.Diagnostics;
using System.Text;

namespace Fireburst
{
	public static unsafe class VulkanUtility
	{
		internal static int GetMaxByteCount(string? value)
		{
			return value == null ? 0 : Encoding.UTF8.GetMaxByteCount(value.Length + 1);
		}

		public static string GetString(byte* ptr)
		{
			int length = 0;
			while (length < 4096 && ptr[length] != 0)
			{
				length++;
			}

			return Encoding.UTF8.GetString(ptr, length);
		}

		internal static void StringToPointer(string? value, byte* dstPointer, int maxByteCount)
		{
			if (value == null)
				return;

			int destBytesWritten;
			fixed (char* srcPointer = value)
			{
				destBytesWritten = Encoding.UTF8.GetBytes(srcPointer, value.Length, dstPointer, maxByteCount);
			}

			dstPointer[destBytesWritten] = 0; // Null-terminator.
		}

		[DebuggerHidden]
		[DebuggerStepThrough]
		public static void CheckResult(this VkResult result)
		{
			if (result != VkResult.Success)
			{
				throw new Exception($"Vulkan exception {result}");
			}
		}

		public static string GetExtensionName(this VkExtensionProperties properties)
		{
			return GetString(properties.extensionName);
		}

		public static string GetLayerName(this VkLayerProperties properties)
		{
			return GetString(properties.layerName);
		}

		public static string GetDeviceName(this VkPhysicalDeviceProperties properties)
		{
			return GetString(properties.deviceName);
		}

		public static string GetDescription(this VkLayerProperties properties)
		{
			return GetString(properties.description);
		}

		public static VkMemoryType GetMemoryType(this VkPhysicalDeviceMemoryProperties memoryProperties, uint index)
		{
			return (&memoryProperties.memoryTypes_0)[index];
		}

		public static uint IndexOf(this VkPhysicalDeviceMemoryProperties memoryProperties, int memoryTypeBits, VkMemoryPropertyFlags properties)
		{
			uint count = memoryProperties.memoryTypeCount;
			for (uint i = 0; i < count; i++)
			{
				if ((memoryTypeBits & 1) == 1 && (memoryProperties.GetMemoryType(i).propertyFlags & properties) == properties)
				{
					return i;
				}

				memoryTypeBits >>= 1;
			}

			return uint.MaxValue;
		}
	}
}