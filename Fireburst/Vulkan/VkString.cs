using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Fireburst;

public sealed class VkString : IDisposable
{
	private static List<VkString> strings = new();

	private GCHandle handle;

	public int Size { get; private set; }

	public VkString(string? str, bool keepAlive = false)
	{
		if (str == null) return;

		byte[] data = Encoding.UTF8.GetBytes(str + '\0');

		handle = GCHandle.Alloc(data, GCHandleType.Pinned);

		if (keepAlive) strings.Add(this);

		Size = data.Length;
	}

	~VkString() => Dispose(false);

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (Size == 0) return;

		if (strings.Contains(this)) strings.Remove(this);
		handle.Free();
		Size = 0;
	}

	public unsafe byte* Pointer
	{
		get
		{
			if (Size == 0) return (byte*)0;

			return (byte*)handle.AddrOfPinnedObject().ToPointer();
		}
	}

	private unsafe string GetString() => Size == 0 ? "null" : Encoding.UTF8.GetString(Pointer, Size);

	public static unsafe implicit operator byte*(VkString value) => value.Pointer;

	public static unsafe implicit operator IntPtr(VkString value) => new(value.Pointer);

	public static implicit operator VkString(string str) => new(str);

	public static implicit operator string(VkString str) => str.GetString();
}