using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Fireburst
{
	public sealed unsafe class VkStringArray : IDisposable
	{
		private readonly VkString[] data;
		private bool disposed;

		public VkStringArray(params string[] array) : this(array.Length)
		{
			for (int i = 0; i < array.Length; i++) this[i] = array[i];
		}

		public VkStringArray(IEnumerable<string> array)
		{
			var list = array.ToList();
			
			Length = (uint)list.Count;
			Pointer = Marshal.AllocHGlobal((int)(sizeof(IntPtr) * Length));
			data = new VkString[Length];
			
			for (int i = 0; i < list.Count; i++) this[i] = list[i];
		}

		private VkStringArray(int length)
		{
			Length = (uint)length;
			Pointer = Marshal.AllocHGlobal(sizeof(IntPtr) * length);
			data = new VkString[length];
		}

		public readonly uint Length;
		public readonly IntPtr Pointer;

		~VkStringArray()
		{
			DisposeInt();
		}

		public void Dispose()
		{
			DisposeInt();
			GC.SuppressFinalize(this);
		}

		private void DisposeInt()
		{
			if (disposed) return;

			Marshal.FreeHGlobal(Pointer);
			disposed = true;
		}

		public VkString this[int index]
		{
			get
			{
				if (index < 0 || index >= Length) throw new IndexOutOfRangeException();

				return data[index];
			}
			set
			{
				if (index < 0 || index >= Length) throw new IndexOutOfRangeException();

				data[index] = value;
				((byte**)Pointer)[index] = value;
			}
		}

		public static implicit operator byte**(VkStringArray arr) => (byte**)arr.Pointer;
	}
}