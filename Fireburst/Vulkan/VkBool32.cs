using System;
using System.Runtime.InteropServices;

namespace Fireburst;

[StructLayout(LayoutKind.Sequential, Size = 4)]
public readonly struct VkBool32 : IEquatable<VkBool32>
{
	private readonly int value;

	public VkBool32(bool value) => this.value = value ? 1 : 0;

	public bool Equals(VkBool32 other) => value == other.value;

	public override bool Equals(object? obj) => obj is VkBool32 rawBool && Equals(rawBool);

	public override int GetHashCode() => value;

	public static bool operator ==(VkBool32 a, VkBool32 b) => a.Equals(b);

	public static bool operator !=(VkBool32 a, VkBool32 b) => !a.Equals(b);

	public static implicit operator bool(VkBool32 value) => value.value != 0;

	public static implicit operator VkBool32(bool value) => new(value);

	public override string ToString() => value != 0 ? "True" : "False";
}