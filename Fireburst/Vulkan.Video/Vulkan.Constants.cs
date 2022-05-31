// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable PartialTypeWithSinglePart

using System;

namespace Fireburst;

public static unsafe partial class Vulkan
{
	public const ulong STD_VIDEO_H264_CPB_CNT_LIST_SIZE = 32;
	public const ulong STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS = 6;
	public const ulong STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS = 16;
	public const ulong STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS = 2;
	public const ulong STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS = 64;
	public const ulong STD_VIDEO_H264_MAX_NUM_LIST_REF = 32;
	public const ulong STD_VIDEO_H264_MAX_CHROMA_PLANES = 2;
	public static VkVersion VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_SPEC_VERSION = new(0, 9, 6);
	public const string VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_EXTENSION_NAME = "VK_STD_vulkan_video_codec_h264_decode";
	public const ulong STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE = 15;
	public const ulong STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE = 2;
	public static VkVersion VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_SPEC_VERSION = new(0, 9, 6);
	public const string VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_EXTENSION_NAME = "VK_STD_vulkan_video_codec_h264_encode";
	public const ulong STD_VIDEO_H265_CPB_CNT_LIST_SIZE = 32;
	public const ulong STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE = 7;
	public const ulong STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS = 6;
	public const ulong STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS = 16;
	public const ulong STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS = 6;
	public const ulong STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS = 64;
	public const ulong STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS = 6;
	public const ulong STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS = 64;
	public const ulong STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS = 2;
	public const ulong STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS = 64;
	public const ulong STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE = 6;
	public const ulong STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE = 19;
	public const ulong STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE = 21;
	public const ulong STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE = 3;
	public const ulong STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE = 128;
	public const ulong STD_VIDEO_H265_MAX_NUM_LIST_REF = 15;
	public const ulong STD_VIDEO_H265_MAX_CHROMA_PLANES = 2;
	public const ulong STD_VIDEO_H265_SPS_MAX_SUB_LAYERS = 8;
	public static VkVersion VK_STD_VULKAN_VIDEO_CODEC_H265_DECODE_SPEC_VERSION = new(0, 9, 6);
	public const string VK_STD_VULKAN_VIDEO_CODEC_H265_DECODE_EXTENSION_NAME = "VK_STD_vulkan_video_codec_h265_decode";
	public const ulong STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE = 8;
	public static VkVersion VK_STD_VULKAN_VIDEO_CODEC_H265_ENCODE_SPEC_VERSION = new(0, 9, 6);
	public const string VK_STD_VULKAN_VIDEO_CODEC_H265_ENCODE_EXTENSION_NAME = "VK_STD_vulkan_video_codec_h265_encode";
}
