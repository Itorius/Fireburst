using System;

namespace Fireburst
{
	public struct VkRect2D : IEquatable<VkRect2D>
	{
		public Vector2i offset;
		public Vector2ui extent;

		public static readonly VkRect2D Zero = new(Vector2i.Zero, Vector2ui.Zero);

		public VkRect2D(Vector2i offset, Vector2ui extent)
		{
			this.offset = offset;
			this.extent = extent;
		}

		public VkRect2D(Vector2ui extent)
		{
			offset = default;
			this.extent = extent;
		}

		public VkRect2D(int x, int y, uint width, uint height)
		{
			offset = new Vector2i(x, y);
			extent = new Vector2ui(width, height);
		}

		public VkRect2D(int x, int y, int width, int height)
		{
			offset = new Vector2i(x, y);
			extent = new Vector2ui((uint)width, (uint)height);
		}

		public VkRect2D(uint width, uint height)
		{
			offset = default;
			extent = new Vector2ui(width, height);
		}

		public VkRect2D(int width, int height)
		{
			offset = default;
			extent = new Vector2ui((uint)width, (uint)height);
		}

		public override bool Equals(object? obj) => obj is VkRect2D other && Equals(other);

		public bool Equals(VkRect2D other) => offset.Equals(other.offset) && extent.Equals(other.extent);

		public override int GetHashCode()
		{
			unchecked
			{
				int hashCode = offset.GetHashCode();
				hashCode = (hashCode * 397) ^ extent.GetHashCode();
				return hashCode;
			}
		}

		public override string ToString() => $"{{Offset={offset},Extent={extent}}}";

		public static bool operator ==(VkRect2D a, VkRect2D b) => a.Equals(b);

		public static bool operator !=(VkRect2D a, VkRect2D b) => !a.Equals(b);
	}
}