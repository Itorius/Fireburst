using System;

namespace Fireburst;

public struct VmaAllocator : IEquatable<VmaAllocator>
{
	public readonly IntPtr Handle;
	public bool IsNull => Handle == IntPtr.Zero;

	public VmaAllocator(IntPtr handle)
	{
		Handle = handle;
	}

	public static VmaAllocator Null => new(IntPtr.Zero);
	public static bool operator ==(VmaAllocator left, VmaAllocator right) => left.Handle == right.Handle;
	public static bool operator !=(VmaAllocator left, VmaAllocator right) => left.Handle != right.Handle;
	public bool Equals(ref VmaAllocator other) => Handle == other.Handle;
	public bool Equals(VmaAllocator other) => Handle == other.Handle;
	public override bool Equals(object obj) => obj is VmaAllocator handle && Equals(ref handle);
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"VmaAllocator [0x{Handle:X}]";
}

public struct VmaAllocation : IEquatable<VmaAllocation>
{
	public readonly IntPtr Handle;
	public bool IsNull => Handle == IntPtr.Zero;

	public VmaAllocation(IntPtr handle)
	{
		Handle = handle;
	}

	public static VmaAllocation Null => new(IntPtr.Zero);
	public static bool operator ==(VmaAllocation left, VmaAllocation right) => left.Handle == right.Handle;
	public static bool operator !=(VmaAllocation left, VmaAllocation right) => left.Handle != right.Handle;
	public bool Equals(ref VmaAllocation other) => Handle == other.Handle;
	public bool Equals(VmaAllocation other) => Handle == other.Handle;
	public override bool Equals(object obj) => obj is VmaAllocation handle && Equals(ref handle);
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"VmaAllocation [0x{Handle:X}]";
}