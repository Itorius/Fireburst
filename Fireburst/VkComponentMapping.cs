namespace Fireburst
{
	public readonly struct VkComponentMapping
	{
		public readonly VkComponentSwizzle r, g, b, a;

		public static readonly VkComponentMapping Identity = new(VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity);
		public static readonly VkComponentMapping RGBA = new(VkComponentSwizzle.R, VkComponentSwizzle.G, VkComponentSwizzle.B, VkComponentSwizzle.A);

		public VkComponentMapping(VkComponentSwizzle r, VkComponentSwizzle g, VkComponentSwizzle b, VkComponentSwizzle a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}
	}
}