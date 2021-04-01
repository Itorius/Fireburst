using System.Runtime.InteropServices;

namespace Fireburst
{
	[StructLayout(LayoutKind.Sequential)]
	// VkOffset2D
	public readonly struct Vector2i
	{
		public static readonly Vector2i Zero = new(0, 0);

		public readonly int x;
		public readonly int y;

		public Vector2i(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	//VkOffset3D
	public readonly struct Vector3i
	{
		public static readonly Vector3i Zero = new(0, 0, 0);

		public readonly int x;
		public readonly int y;
		public readonly int z;

		public Vector3i(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	// Vector2ui
	public struct Vector2ui
	{
		public static readonly Vector2ui Zero = new(0, 0);

		public uint width;
		public uint height;

		public Vector2ui(uint width, uint height)
		{
			this.width = width;
			this.height = height;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	// Vector3ui
	public readonly struct Vector3ui
	{
		public static readonly Vector3ui Zero = new(0, 0, 0);

		public readonly uint width;
		public readonly uint height;
		public readonly uint depth;

		public Vector3ui(uint width, uint height, uint depth)
		{
			this.width = width;
			this.height = height;
			this.depth = depth;
		}

		public Vector3ui(int width, int height, int depth)
		{
			this.width = (uint)width;
			this.height = (uint)height;
			this.depth = (uint)depth;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct VkTransformMatrixKHR
	{
		[FieldOffset(0)] public unsafe fixed float matrix[3 * 4];

		public unsafe VkTransformMatrixKHR(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34)
		{
			matrix[0] = m11;
			matrix[1] = m12;
			matrix[2] = m13;
			matrix[3] = m14;
			matrix[4] = m21;
			matrix[5] = m22;
			matrix[6] = m23;
			matrix[7] = m24;
			matrix[8] = m31;
			matrix[9] = m32;
			matrix[10] = m33;
			matrix[11] = m34;
		}
	}
}