using System.Numerics;

namespace Fireburst
{
	public struct VkViewport
	{
		public float x, y, width, height, minDepth, maxDepth;

		public VkViewport(float width, float height)
		{
			x = 0.0f;
			y = 0.0f;
			this.width = width;
			this.height = height;
			minDepth = 0.0f;
			maxDepth = 1.0f;
		}

		public VkViewport(float x, float y, float width, float height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
			minDepth = 0.0f;
			maxDepth = 1.0f;
		}

		public VkViewport(float x, float y, float width, float height, float minDepth, float maxDepth)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
			this.minDepth = minDepth;
			this.maxDepth = maxDepth;
		}

		public VkViewport(VkRect2D bounds)
		{
			x = bounds.offset.x;
			y = bounds.offset.y;
			width = bounds.extent.width;
			height = bounds.extent.height;
			minDepth = 0.0f;
			maxDepth = 1.0f;
		}

		public VkViewport(Vector4 bounds)
		{
			x = bounds.X;
			y = bounds.Y;
			width = bounds.Z;
			height = bounds.W;

			minDepth = 0.0f;
			maxDepth = 1.0f;
		}

		public override bool Equals(object? obj) => obj is VkViewport other && Equals(other);

		public bool Equals(VkViewport other)
		{
			return
				x == other.x &&
				y == other.y &&
				width == other.width &&
				height == other.height &&
				minDepth == other.minDepth &&
				maxDepth == other.maxDepth;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hashCode = x.GetHashCode();
				hashCode = (hashCode * 397) ^ y.GetHashCode();
				hashCode = (hashCode * 397) ^ width.GetHashCode();
				hashCode = (hashCode * 397) ^ height.GetHashCode();
				hashCode = (hashCode * 397) ^ minDepth.GetHashCode();
				hashCode = (hashCode * 397) ^ maxDepth.GetHashCode();
				return hashCode;
			}
		}

		public override readonly string ToString() => $"{{X={x},Y={y},Width={width},Height={height},MinDepth={minDepth},MaxDepth={maxDepth}}}";

		public static bool operator ==(VkViewport a, VkViewport b) => a.Equals(b);

		public static bool operator !=(VkViewport a, VkViewport b) => !a.Equals(b);
	}
}