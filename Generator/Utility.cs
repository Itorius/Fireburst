using System.Collections.Generic;

namespace FireburstGenerator;

public static class Utility
{
	public static Dictionary<string, string> TypeMap = new()
	{
		{ "VkExtent2D", "Vector2ui" },
		{ "VkExtent3D", "Vector3ui" },
		{ "VkOffset2D", "Vector2i" },
		{ "VkOffset3D", "Vector3i" }
	};

	private static List<string> PointerTypes = new()
	{
		"ANativeWindow",
		"wl_display",
		"wl_surface",
		"HINSTANCE",
		"HWND",
		"HMONITOR",
		"Display",
		"Window",
		"xcb_connection_t",
		"xcb_window_t",
		"IDirectFB",
		"IDirectFBSurface",
		"zx_handle_t",
		"GgpStreamDescriptor",
		"HANDLE",
		"DWORD",
		"SECURITY_ATTRIBUTES",
		"LPCWSTR",
		"CAMetalLayer",
		"AHardwareBuffer",
		"GgpFrameToken",
		"xcb_visualid_t",
		"VisualID",
		"RROutput",
		"_screen_context",
		"_screen_window",
		"StdVideoH264SequenceParameterSet"
	};

	public static string ResolveType(string orig)
	{
		if (PointerTypes.Contains(orig)) return "IntPtr";
		if (TypeMap.TryGetValue(orig, out string v)) return v;

		return orig switch
		{
			"PFN_vkVoidFunction" => "IntPtr",
			"char" => "byte",
			"size_t" => "nuint",
			"int8_t" => "sbyte",
			"int16_t" => "short",
			"int32_t" => "int",
			"int64_t" => "long",
			"uint8_t" => "byte",
			"uint16_t" => "ushort",
			"uint32_t" => "uint",
			"uint64_t" => "ulong",
			"VkDeviceSize" => "ulong",
			"VkSampleMask" => "uint",
			"VkDeviceAddress" => "IntPtr",
			"VkRemoteAddressNV" =>"IntPtr",
			_ => orig
		};
	}

	public static string JoinStrings(this IEnumerable<string> strings, string separator = ", ")
	{
		return System.Linq.Enumerable.Aggregate(strings, (x, y) => x + separator + y);
	}
}