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
	public readonly struct Vector2ui
	{
		public static readonly Vector2ui Zero = new(0, 0);

		public readonly uint width;
		public readonly uint height;

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
}