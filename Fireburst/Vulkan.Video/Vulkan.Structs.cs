// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable PartialTypeWithSinglePart

using System;
using System.Runtime.InteropServices;

namespace Fireburst;
[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH264SpsVuiFlags
{
	public uint aspect_ratio_info_present_flag;
	public uint overscan_info_present_flag;
	public uint overscan_appropriate_flag;
	public uint video_signal_type_present_flag;
	public uint video_full_range_flag;
	public uint color_description_present_flag;
	public uint chroma_loc_info_present_flag;
	public uint timing_info_present_flag;
	public uint fixed_frame_rate_flag;
	public uint bitstream_restriction_flag;
	public uint nal_hrd_parameters_present_flag;
	public uint vcl_hrd_parameters_present_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH264HrdParameters
{
	public byte cpb_cnt_minus1;
	public byte bit_rate_scale;
	public byte cpb_size_scale;
	public unsafe fixed uint bit_rate_value_minus1[Vulkan.STD_VIDEO_H264_CPB_CNT_LIST_SIZE];
	public unsafe fixed uint cpb_size_value_minus1[Vulkan.STD_VIDEO_H264_CPB_CNT_LIST_SIZE];
	public unsafe fixed byte cbr_flag[Vulkan.STD_VIDEO_H264_CPB_CNT_LIST_SIZE];
	public uint initial_cpb_removal_delay_length_minus1;
	public uint cpb_removal_delay_length_minus1;
	public uint dpb_output_delay_length_minus1;
	public uint time_offset_length;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH264SequenceParameterSetVui
{
	public StdVideoH264SpsVuiFlags flags;
	public StdVideoH264AspectRatioIdc aspect_ratio_idc;
	public ushort sar_width;
	public ushort sar_height;
	public byte video_format;
	public byte color_primaries;
	public byte transfer_characteristics;
	public byte matrix_coefficients;
	public uint num_units_in_tick;
	public uint time_scale;
	public unsafe StdVideoH264HrdParameters* pHrdParameters;
	public byte max_num_reorder_frames;
	public byte max_dec_frame_buffering;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH264SpsFlags
{
	public uint constraint_set0_flag;
	public uint constraint_set1_flag;
	public uint constraint_set2_flag;
	public uint constraint_set3_flag;
	public uint constraint_set4_flag;
	public uint constraint_set5_flag;
	public uint direct_8x8_inference_flag;
	public uint mb_adaptive_frame_field_flag;
	public uint frame_mbs_only_flag;
	public uint delta_pic_order_always_zero_flag;
	public uint separate_colour_plane_flag;
	public uint gaps_in_frame_num_value_allowed_flag;
	public uint qpprime_y_zero_transform_bypass_flag;
	public uint frame_cropping_flag;
	public uint seq_scaling_matrix_present_flag;
	public uint vui_parameters_present_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH264ScalingLists
{
	public byte scaling_list_present_mask;
	public byte use_default_scaling_matrix_mask;
	public unsafe fixed byte ScalingList4x4[Vulkan.STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS];
	public unsafe fixed byte ScalingList8x8[Vulkan.STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH264SequenceParameterSet
{
	public StdVideoH264SpsFlags flags;
	public StdVideoH264ProfileIdc profile_idc;
	public StdVideoH264Level level_idc;
	public byte seq_parameter_set_id;
	public StdVideoH264ChromaFormatIdc chroma_format_idc;
	public byte bit_depth_luma_minus8;
	public byte bit_depth_chroma_minus8;
	public byte log2_max_frame_num_minus4;
	public StdVideoH264PocType pic_order_cnt_type;
	public byte log2_max_pic_order_cnt_lsb_minus4;
	public int offset_for_non_ref_pic;
	public int offset_for_top_to_bottom_field;
	public byte num_ref_frames_in_pic_order_cnt_cycle;
	public byte max_num_ref_frames;
	public uint pic_width_in_mbs_minus1;
	public uint pic_height_in_map_units_minus1;
	public uint frame_crop_left_offset;
	public uint frame_crop_right_offset;
	public uint frame_crop_top_offset;
	public uint frame_crop_bottom_offset;
	public unsafe int* pOffsetForRefFrame;
	public unsafe StdVideoH264ScalingLists* pScalingLists;
	public unsafe StdVideoH264SequenceParameterSetVui* pSequenceParameterSetVui;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH264PpsFlags
{
	public uint transform_8x8_mode_flag;
	public uint redundant_pic_cnt_present_flag;
	public uint constrained_intra_pred_flag;
	public uint deblocking_filter_control_present_flag;
	public uint weighted_bipred_idc_flag;
	public uint weighted_pred_flag;
	public uint pic_order_present_flag;
	public uint entropy_coding_mode_flag;
	public uint pic_scaling_matrix_present_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH264PictureParameterSet
{
	public StdVideoH264PpsFlags flags;
	public byte seq_parameter_set_id;
	public byte pic_parameter_set_id;
	public byte num_ref_idx_l0_default_active_minus1;
	public byte num_ref_idx_l1_default_active_minus1;
	public StdVideoH264WeightedBipredIdc weighted_bipred_idc;
	public sbyte pic_init_qp_minus26;
	public sbyte pic_init_qs_minus26;
	public sbyte chroma_qp_index_offset;
	public sbyte second_chroma_qp_index_offset;
	public unsafe StdVideoH264ScalingLists* pScalingLists;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH264PictureInfoFlags
{
	public uint field_pic_flag;
	public uint is_intra;
	public uint IdrPicFlag;
	public uint bottom_field_flag;
	public uint is_reference;
	public uint complementary_field_pair;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH264PictureInfo
{
	public StdVideoDecodeH264PictureInfoFlags flags;
	public byte seq_parameter_set_id;
	public byte pic_parameter_set_id;
	public ushort reserved;
	public ushort frame_num;
	public ushort idr_pic_id;
	public unsafe fixed int PicOrderCnt[Vulkan.STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH264ReferenceInfoFlags
{
	public uint top_field_flag;
	public uint bottom_field_flag;
	public uint used_for_long_term_reference;
	public uint is_non_existing;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH264ReferenceInfo
{
	public StdVideoDecodeH264ReferenceInfoFlags flags;
	public ushort FrameNum;
	public ushort reserved;
	public int PicOrderCnt_0;
	public int PicOrderCnt_1;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH264MvcElementFlags
{
	public uint non_idr;
	public uint anchor_pic;
	public uint inter_view;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH264MvcElement
{
	public StdVideoDecodeH264MvcElementFlags flags;
	public ushort viewOrderIndex;
	public ushort viewId;
	public ushort temporalId;
	public ushort priorityId;
	public ushort numOfAnchorRefsInL0;
	public unsafe fixed ushort viewIdOfAnchorRefsInL0[Vulkan.STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE];
	public ushort numOfAnchorRefsInL1;
	public unsafe fixed ushort viewIdOfAnchorRefsInL1[Vulkan.STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE];
	public ushort numOfNonAnchorRefsInL0;
	public unsafe fixed ushort viewIdOfNonAnchorRefsInL0[Vulkan.STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE];
	public ushort numOfNonAnchorRefsInL1;
	public unsafe fixed ushort viewIdOfNonAnchorRefsInL1[Vulkan.STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH264Mvc
{
	public uint viewId0;
	public uint mvcElementCount;
	public unsafe StdVideoDecodeH264MvcElement* pMvcElements;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264WeightTableFlags
{
	public uint luma_weight_l0_flag;
	public uint chroma_weight_l0_flag;
	public uint luma_weight_l1_flag;
	public uint chroma_weight_l1_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264WeightTable
{
	public StdVideoEncodeH264WeightTableFlags flags;
	public byte luma_log2_weight_denom;
	public byte chroma_log2_weight_denom;
	public unsafe fixed sbyte luma_weight_l0[Vulkan.STD_VIDEO_H264_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte luma_offset_l0[Vulkan.STD_VIDEO_H264_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte chroma_weight_l0[Vulkan.STD_VIDEO_H264_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte chroma_offset_l0[Vulkan.STD_VIDEO_H264_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte luma_weight_l1[Vulkan.STD_VIDEO_H264_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte luma_offset_l1[Vulkan.STD_VIDEO_H264_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte chroma_weight_l1[Vulkan.STD_VIDEO_H264_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte chroma_offset_l1[Vulkan.STD_VIDEO_H264_MAX_NUM_LIST_REF];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264SliceHeaderFlags
{
	public uint direct_spatial_mv_pred_flag;
	public uint num_ref_idx_active_override_flag;
	public uint no_output_of_prior_pics_flag;
	public uint adaptive_ref_pic_marking_mode_flag;
	public uint no_prior_references_available_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264PictureInfoFlags
{
	public uint idr_flag;
	public uint is_reference_flag;
	public uint used_for_long_term_reference;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264ReferenceInfoFlags
{
	public uint used_for_long_term_reference;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264RefMgmtFlags
{
	public uint ref_pic_list_modification_l0_flag;
	public uint ref_pic_list_modification_l1_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264RefListModEntry
{
	public StdVideoH264ModificationOfPicNumsIdc modification_of_pic_nums_idc;
	public ushort abs_diff_pic_num_minus1;
	public ushort long_term_pic_num;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264RefPicMarkingEntry
{
	public StdVideoH264MemMgmtControlOp operation;
	public ushort difference_of_pic_nums_minus1;
	public ushort long_term_pic_num;
	public ushort long_term_frame_idx;
	public ushort max_long_term_frame_idx_plus1;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264RefMemMgmtCtrlOperations
{
	public StdVideoEncodeH264RefMgmtFlags flags;
	public byte refList0ModOpCount;
	public unsafe StdVideoEncodeH264RefListModEntry* pRefList0ModOperations;
	public byte refList1ModOpCount;
	public unsafe StdVideoEncodeH264RefListModEntry* pRefList1ModOperations;
	public byte refPicMarkingOpCount;
	public unsafe StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264PictureInfo
{
	public StdVideoEncodeH264PictureInfoFlags flags;
	public byte seq_parameter_set_id;
	public byte pic_parameter_set_id;
	public StdVideoH264PictureType pictureType;
	public uint frame_num;
	public int PicOrderCnt;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264ReferenceInfo
{
	public StdVideoEncodeH264ReferenceInfoFlags flags;
	public uint FrameNum;
	public int PicOrderCnt;
	public ushort long_term_pic_num;
	public ushort long_term_frame_idx;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH264SliceHeader
{
	public StdVideoEncodeH264SliceHeaderFlags flags;
	public uint first_mb_in_slice;
	public StdVideoH264SliceType slice_type;
	public ushort idr_pic_id;
	public byte num_ref_idx_l0_active_minus1;
	public byte num_ref_idx_l1_active_minus1;
	public StdVideoH264CabacInitIdc cabac_init_idc;
	public StdVideoH264DisableDeblockingFilterIdc disable_deblocking_filter_idc;
	public sbyte slice_alpha_c0_offset_div2;
	public sbyte slice_beta_offset_div2;
	public unsafe StdVideoEncodeH264WeightTable* pWeightTable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265DecPicBufMgr
{
	public unsafe fixed uint max_latency_increase_plus1[Vulkan.STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE];
	public unsafe fixed byte max_dec_pic_buffering_minus1[Vulkan.STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE];
	public unsafe fixed byte max_num_reorder_pics[Vulkan.STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265SubLayerHrdParameters
{
	public unsafe fixed uint bit_rate_value_minus1[Vulkan.STD_VIDEO_H265_CPB_CNT_LIST_SIZE];
	public unsafe fixed uint cpb_size_value_minus1[Vulkan.STD_VIDEO_H265_CPB_CNT_LIST_SIZE];
	public unsafe fixed uint cpb_size_du_value_minus1[Vulkan.STD_VIDEO_H265_CPB_CNT_LIST_SIZE];
	public unsafe fixed uint bit_rate_du_value_minus1[Vulkan.STD_VIDEO_H265_CPB_CNT_LIST_SIZE];
	public uint cbr_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265HrdFlags
{
	public uint nal_hrd_parameters_present_flag;
	public uint vcl_hrd_parameters_present_flag;
	public uint sub_pic_hrd_params_present_flag;
	public uint sub_pic_cpb_params_in_pic_timing_sei_flag;
	public uint fixed_pic_rate_general_flag;
	public uint fixed_pic_rate_within_cvs_flag;
	public uint low_delay_hrd_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265HrdParameters
{
	public StdVideoH265HrdFlags flags;
	public byte tick_divisor_minus2;
	public byte du_cpb_removal_delay_increment_length_minus1;
	public byte dpb_output_delay_du_length_minus1;
	public byte bit_rate_scale;
	public byte cpb_size_scale;
	public byte cpb_size_du_scale;
	public byte initial_cpb_removal_delay_length_minus1;
	public byte au_cpb_removal_delay_length_minus1;
	public byte dpb_output_delay_length_minus1;
	public unsafe fixed byte cpb_cnt_minus1[Vulkan.STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE];
	public unsafe fixed ushort elemental_duration_in_tc_minus1[Vulkan.STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE];
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersNal_0;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersNal_1;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersNal_2;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersNal_3;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersNal_4;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersNal_5;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersNal_6;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersVcl_0;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersVcl_1;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersVcl_2;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersVcl_3;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersVcl_4;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersVcl_5;
	public StdVideoH265SubLayerHrdParameters pSubLayerHrdParametersVcl_6;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265VpsFlags
{
	public uint vps_temporal_id_nesting_flag;
	public uint vps_sub_layer_ordering_info_present_flag;
	public uint vps_timing_info_present_flag;
	public uint vps_poc_proportional_to_timing_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265VideoParameterSet
{
	public StdVideoH265VpsFlags flags;
	public byte vps_video_parameter_set_id;
	public byte vps_max_sub_layers_minus1;
	public uint vps_num_units_in_tick;
	public uint vps_time_scale;
	public uint vps_num_ticks_poc_diff_one_minus1;
	public unsafe StdVideoH265DecPicBufMgr* pDecPicBufMgr;
	public unsafe StdVideoH265HrdParameters* pHrdParameters;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265ScalingLists
{
	public unsafe fixed byte ScalingList4x4[Vulkan.STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS];
	public unsafe fixed byte ScalingList8x8[Vulkan.STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS];
	public unsafe fixed byte ScalingList16x16[Vulkan.STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS];
	public unsafe fixed byte ScalingList32x32[Vulkan.STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS];
	public unsafe fixed byte ScalingListDCCoef16x16[Vulkan.STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS];
	public unsafe fixed byte ScalingListDCCoef32x32[Vulkan.STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265SpsVuiFlags
{
	public uint aspect_ratio_info_present_flag;
	public uint overscan_info_present_flag;
	public uint overscan_appropriate_flag;
	public uint video_signal_type_present_flag;
	public uint video_full_range_flag;
	public uint colour_description_present_flag;
	public uint chroma_loc_info_present_flag;
	public uint neutral_chroma_indication_flag;
	public uint field_seq_flag;
	public uint frame_field_info_present_flag;
	public uint default_display_window_flag;
	public uint vui_timing_info_present_flag;
	public uint vui_poc_proportional_to_timing_flag;
	public uint vui_hrd_parameters_present_flag;
	public uint bitstream_restriction_flag;
	public uint tiles_fixed_structure_flag;
	public uint motion_vectors_over_pic_boundaries_flag;
	public uint restricted_ref_pic_lists_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265SequenceParameterSetVui
{
	public StdVideoH265SpsVuiFlags flags;
	public byte aspect_ratio_idc;
	public ushort sar_width;
	public ushort sar_height;
	public byte video_format;
	public byte colour_primaries;
	public byte transfer_characteristics;
	public byte matrix_coeffs;
	public byte chroma_sample_loc_type_top_field;
	public byte chroma_sample_loc_type_bottom_field;
	public ushort def_disp_win_left_offset;
	public ushort def_disp_win_right_offset;
	public ushort def_disp_win_top_offset;
	public ushort def_disp_win_bottom_offset;
	public uint vui_num_units_in_tick;
	public uint vui_time_scale;
	public uint vui_num_ticks_poc_diff_one_minus1;
	public unsafe StdVideoH265HrdParameters* pHrdParameters;
	public ushort min_spatial_segmentation_idc;
	public byte max_bytes_per_pic_denom;
	public byte max_bits_per_min_cu_denom;
	public byte log2_max_mv_length_horizontal;
	public byte log2_max_mv_length_vertical;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265PredictorPaletteEntries
{
	public unsafe fixed ushort PredictorPaletteEntries[Vulkan.STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265SpsFlags
{
	public uint sps_temporal_id_nesting_flag;
	public uint separate_colour_plane_flag;
	public uint scaling_list_enabled_flag;
	public uint sps_scaling_list_data_present_flag;
	public uint amp_enabled_flag;
	public uint sample_adaptive_offset_enabled_flag;
	public uint pcm_enabled_flag;
	public uint pcm_loop_filter_disabled_flag;
	public uint long_term_ref_pics_present_flag;
	public uint sps_temporal_mvp_enabled_flag;
	public uint strong_intra_smoothing_enabled_flag;
	public uint vui_parameters_present_flag;
	public uint sps_extension_present_flag;
	public uint sps_range_extension_flag;
	public uint transform_skip_rotation_enabled_flag;
	public uint transform_skip_context_enabled_flag;
	public uint implicit_rdpcm_enabled_flag;
	public uint explicit_rdpcm_enabled_flag;
	public uint extended_precision_processing_flag;
	public uint intra_smoothing_disabled_flag;
	public uint high_precision_offsets_enabled_flag;
	public uint persistent_rice_adaptation_enabled_flag;
	public uint cabac_bypass_alignment_enabled_flag;
	public uint sps_scc_extension_flag;
	public uint sps_curr_pic_ref_enabled_flag;
	public uint palette_mode_enabled_flag;
	public uint sps_palette_predictor_initializer_present_flag;
	public uint intra_boundary_filtering_disabled_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265SequenceParameterSet
{
	public StdVideoH265SpsFlags flags;
	public StdVideoH265ProfileIdc profile_idc;
	public StdVideoH265Level level_idc;
	public uint pic_width_in_luma_samples;
	public uint pic_height_in_luma_samples;
	public byte sps_video_parameter_set_id;
	public byte sps_max_sub_layers_minus1;
	public byte sps_seq_parameter_set_id;
	public byte chroma_format_idc;
	public byte bit_depth_luma_minus8;
	public byte bit_depth_chroma_minus8;
	public byte log2_max_pic_order_cnt_lsb_minus4;
	public unsafe fixed byte sps_max_dec_pic_buffering_minus1[Vulkan.STD_VIDEO_H265_SPS_MAX_SUB_LAYERS];
	public byte log2_min_luma_coding_block_size_minus3;
	public byte log2_diff_max_min_luma_coding_block_size;
	public byte log2_min_luma_transform_block_size_minus2;
	public byte log2_diff_max_min_luma_transform_block_size;
	public byte max_transform_hierarchy_depth_inter;
	public byte max_transform_hierarchy_depth_intra;
	public byte num_short_term_ref_pic_sets;
	public byte num_long_term_ref_pics_sps;
	public byte pcm_sample_bit_depth_luma_minus1;
	public byte pcm_sample_bit_depth_chroma_minus1;
	public byte log2_min_pcm_luma_coding_block_size_minus3;
	public byte log2_diff_max_min_pcm_luma_coding_block_size;
	public uint conf_win_left_offset;
	public uint conf_win_right_offset;
	public uint conf_win_top_offset;
	public uint conf_win_bottom_offset;
	public unsafe StdVideoH265DecPicBufMgr* pDecPicBufMgr;
	public unsafe StdVideoH265ScalingLists* pScalingLists;
	public unsafe StdVideoH265SequenceParameterSetVui* pSequenceParameterSetVui;
	public byte palette_max_size;
	public byte delta_palette_max_predictor_size;
	public byte motion_vector_resolution_control_idc;
	public byte sps_num_palette_predictor_initializer_minus1;
	public unsafe StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265PpsFlags
{
	public uint dependent_slice_segments_enabled_flag;
	public uint output_flag_present_flag;
	public uint sign_data_hiding_enabled_flag;
	public uint cabac_init_present_flag;
	public uint constrained_intra_pred_flag;
	public uint transform_skip_enabled_flag;
	public uint cu_qp_delta_enabled_flag;
	public uint pps_slice_chroma_qp_offsets_present_flag;
	public uint weighted_pred_flag;
	public uint weighted_bipred_flag;
	public uint transquant_bypass_enabled_flag;
	public uint tiles_enabled_flag;
	public uint entropy_coding_sync_enabled_flag;
	public uint uniform_spacing_flag;
	public uint loop_filter_across_tiles_enabled_flag;
	public uint pps_loop_filter_across_slices_enabled_flag;
	public uint deblocking_filter_control_present_flag;
	public uint deblocking_filter_override_enabled_flag;
	public uint pps_deblocking_filter_disabled_flag;
	public uint pps_scaling_list_data_present_flag;
	public uint lists_modification_present_flag;
	public uint slice_segment_header_extension_present_flag;
	public uint pps_extension_present_flag;
	public uint cross_component_prediction_enabled_flag;
	public uint chroma_qp_offset_list_enabled_flag;
	public uint pps_curr_pic_ref_enabled_flag;
	public uint residual_adaptive_colour_transform_enabled_flag;
	public uint pps_slice_act_qp_offsets_present_flag;
	public uint pps_palette_predictor_initializer_present_flag;
	public uint monochrome_palette_flag;
	public uint pps_range_extension_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoH265PictureParameterSet
{
	public StdVideoH265PpsFlags flags;
	public byte pps_pic_parameter_set_id;
	public byte pps_seq_parameter_set_id;
	public byte num_extra_slice_header_bits;
	public byte num_ref_idx_l0_default_active_minus1;
	public byte num_ref_idx_l1_default_active_minus1;
	public sbyte init_qp_minus26;
	public byte diff_cu_qp_delta_depth;
	public sbyte pps_cb_qp_offset;
	public sbyte pps_cr_qp_offset;
	public byte num_tile_columns_minus1;
	public byte num_tile_rows_minus1;
	public unsafe fixed ushort column_width_minus1[Vulkan.STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE];
	public unsafe fixed ushort row_height_minus1[Vulkan.STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE];
	public sbyte pps_beta_offset_div2;
	public sbyte pps_tc_offset_div2;
	public byte log2_parallel_merge_level_minus2;
	public unsafe StdVideoH265ScalingLists* pScalingLists;
	public byte log2_max_transform_skip_block_size_minus2;
	public byte diff_cu_chroma_qp_offset_depth;
	public byte chroma_qp_offset_list_len_minus1;
	public unsafe fixed sbyte cb_qp_offset_list[Vulkan.STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE];
	public unsafe fixed sbyte cr_qp_offset_list[Vulkan.STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE];
	public byte log2_sao_offset_scale_luma;
	public byte log2_sao_offset_scale_chroma;
	public sbyte pps_act_y_qp_offset_plus5;
	public sbyte pps_act_cb_qp_offset_plus5;
	public sbyte pps_act_cr_qp_offset_plus5;
	public byte pps_num_palette_predictor_initializer;
	public byte luma_bit_depth_entry_minus8;
	public byte chroma_bit_depth_entry_minus8;
	public unsafe StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH265PictureInfoFlags
{
	public uint IrapPicFlag;
	public uint IdrPicFlag;
	public uint IsReference;
	public uint short_term_ref_pic_set_sps_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH265PictureInfo
{
	public StdVideoDecodeH265PictureInfoFlags flags;
	public byte sps_video_parameter_set_id;
	public byte pps_seq_parameter_set_id;
	public byte pps_pic_parameter_set_id;
	public byte num_short_term_ref_pic_sets;
	public int PicOrderCntVal;
	public ushort NumBitsForSTRefPicSetInSlice;
	public byte NumDeltaPocsOfRefRpsIdx;
	public unsafe fixed byte RefPicSetStCurrBefore[Vulkan.STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];
	public unsafe fixed byte RefPicSetStCurrAfter[Vulkan.STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];
	public unsafe fixed byte RefPicSetLtCurr[Vulkan.STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH265ReferenceInfoFlags
{
	public uint used_for_long_term_reference;
	public uint unused_for_reference;
	public uint is_non_existing;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoDecodeH265ReferenceInfo
{
	public StdVideoDecodeH265ReferenceInfoFlags flags;
	public int PicOrderCntVal;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265WeightTableFlags
{
	public ushort luma_weight_l0_flag;
	public ushort chroma_weight_l0_flag;
	public ushort luma_weight_l1_flag;
	public ushort chroma_weight_l1_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265WeightTable
{
	public StdVideoEncodeH265WeightTableFlags flags;
	public byte luma_log2_weight_denom;
	public sbyte delta_chroma_log2_weight_denom;
	public unsafe fixed sbyte delta_luma_weight_l0[Vulkan.STD_VIDEO_H265_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte luma_offset_l0[Vulkan.STD_VIDEO_H265_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte delta_chroma_weight_l0[Vulkan.STD_VIDEO_H265_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte delta_chroma_offset_l0[Vulkan.STD_VIDEO_H265_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte delta_luma_weight_l1[Vulkan.STD_VIDEO_H265_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte luma_offset_l1[Vulkan.STD_VIDEO_H265_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte delta_chroma_weight_l1[Vulkan.STD_VIDEO_H265_MAX_NUM_LIST_REF];
	public unsafe fixed sbyte delta_chroma_offset_l1[Vulkan.STD_VIDEO_H265_MAX_NUM_LIST_REF];
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265SliceSegmentHeaderFlags
{
	public uint first_slice_segment_in_pic_flag;
	public uint no_output_of_prior_pics_flag;
	public uint dependent_slice_segment_flag;
	public uint pic_output_flag;
	public uint short_term_ref_pic_set_sps_flag;
	public uint slice_temporal_mvp_enable_flag;
	public uint slice_sao_luma_flag;
	public uint slice_sao_chroma_flag;
	public uint num_ref_idx_active_override_flag;
	public uint mvd_l1_zero_flag;
	public uint cabac_init_flag;
	public uint slice_deblocking_filter_disable_flag;
	public uint collocated_from_l0_flag;
	public uint slice_loop_filter_across_slices_enabled_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265SliceSegmentHeader
{
	public StdVideoEncodeH265SliceSegmentHeaderFlags flags;
	public StdVideoH265SliceType slice_type;
	public byte num_short_term_ref_pic_sets;
	public uint slice_segment_address;
	public byte short_term_ref_pic_set_idx;
	public byte num_long_term_sps;
	public byte num_long_term_pics;
	public byte collocated_ref_idx;
	public byte num_ref_idx_l0_active_minus1;
	public byte num_ref_idx_l1_active_minus1;
	public byte MaxNumMergeCand;
	public sbyte slice_cb_qp_offset;
	public sbyte slice_cr_qp_offset;
	public sbyte slice_beta_offset_div2;
	public sbyte slice_tc_offset_div2;
	public sbyte slice_act_y_qp_offset;
	public sbyte slice_act_cb_qp_offset;
	public sbyte slice_act_cr_qp_offset;
	public unsafe StdVideoEncodeH265WeightTable* pWeightTable;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265ReferenceModificationFlags
{
	public uint ref_pic_list_modification_flag_l0;
	public uint ref_pic_list_modification_flag_l1;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265ReferenceModifications
{
	public StdVideoEncodeH265ReferenceModificationFlags flags;
	public byte referenceList0ModificationsCount;
	public unsafe byte* pReferenceList0Modifications;
	public byte referenceList1ModificationsCount;
	public unsafe byte* pReferenceList1Modifications;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265PictureInfoFlags
{
	public uint is_reference_flag;
	public uint IrapPicFlag;
	public uint long_term_flag;
	public uint discardable_flag;
	public uint cross_layer_bla_flag;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265PictureInfo
{
	public StdVideoEncodeH265PictureInfoFlags flags;
	public StdVideoH265PictureType PictureType;
	public byte sps_video_parameter_set_id;
	public byte pps_seq_parameter_set_id;
	public byte pps_pic_parameter_set_id;
	public int PicOrderCntVal;
	public byte TemporalId;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265ReferenceInfoFlags
{
	public uint used_for_long_term_reference;
	public uint unused_for_reference;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct StdVideoEncodeH265ReferenceInfo
{
	public StdVideoEncodeH265ReferenceInfoFlags flags;
	public int PicOrderCntVal;
	public byte TemporalId;
}

