using System;

namespace Fireburst;

public readonly struct VkVersion : IEquatable<VkVersion>, IComparable<VkVersion>
{
	private readonly uint value;

	public static readonly VkVersion Version_1_0 = new(1, 0, 0);
	public static readonly VkVersion Version_1_1 = new(1, 1, 0);
	public static readonly VkVersion Version_1_2 = new(1, 2, 0);

	public VkVersion(uint value)
	{
		this.value = value;
	}

	public VkVersion(uint major, uint minor, uint patch)
	{
		value = (major << 22) | (minor << 12) | patch;
	}

	public uint Major => value >> 22;

	public uint Minor => (value >> 12) & 0x3ff;

	public uint Patch => value & 0xfff;

	public static implicit operator uint(VkVersion version)
	{
		return version.value;
	}

	public override string ToString() => $"{Major}.{Minor}.{Patch}";

	public bool Equals(VkVersion other) => value == other.value;
	public int CompareTo(VkVersion other) => value.CompareTo(other.value);

	public override bool Equals(object obj)
	{
		return obj is VkVersion version && Equals(version);
	}
}