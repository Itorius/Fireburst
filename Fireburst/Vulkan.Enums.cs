using System;

namespace Fireburst
{
	public enum VkImageLayout
	{
		Undefined = 0,
		General = 1,
		ColorAttachmentOptimal = 2,
		DepthStencilAttachmentOptimal = 3,
		DepthStencilReadOnlyOptimal = 4,
		ShaderReadOnlyOptimal = 5,
		TransferSrcOptimal = 6,
		TransferDstOptimal = 7,
		Preinitialized = 8,
		PresentSrcKHR = 1000001002,
		SharedPresentKHR = 1000111000,
		ShadingRateOptimalNV = 1000164003,
		FragmentDensityMapOptimalEXT = 1000218000,
		ReadOnlyOptimalKHR = 1000314000,
		AttachmentOptimalKHR = 1000314001,
	}

	public enum VkAttachmentLoadOp
	{
		Load = 0,
		Clear = 1,
		DontCare = 2,
	}

	public enum VkAttachmentStoreOp
	{
		Store = 0,
		DontCare = 1,
		NoneQcom = 1000301000,
	}

	public enum VkImageType
	{
		Image1D = 0,
		Image2D = 1,
		Image3D = 2,
	}

	public enum VkImageTiling
	{
		Optimal = 0,
		Linear = 1,
		DrmFormatModifierEXT = 1000158000,
	}

	public enum VkImageViewType
	{
		Image1D = 0,
		Image2D = 1,
		Image3D = 2,
		ImageCube = 3,
		Image1DArray = 4,
		Image2DArray = 5,
		ImageCubeArray = 6,
	}

	public enum VkCommandBufferLevel
	{
		Primary = 0,
		Secondary = 1,
	}

	public enum VkComponentSwizzle
	{
		Identity = 0,
		Zero = 1,
		One = 2,
		R = 3,
		G = 4,
		B = 5,
		A = 6,
	}

	public enum VkDescriptorType
	{
		Sampler = 0,
		CombinedImageSampler = 1,
		SampledImage = 2,
		StorageImage = 3,
		UniformTexelBuffer = 4,
		StorageTexelBuffer = 5,
		UniformBuffer = 6,
		StorageBuffer = 7,
		UniformBufferDynamic = 8,
		StorageBufferDynamic = 9,
		InputAttachment = 10,
		InlineUniformBlockEXT = 1000138000,
		AccelerationStructureKHR = 1000150000,
		AccelerationStructureNV = 1000165000,
		MutableValve = 1000351000,
	}

	public enum VkQueryType
	{
		Occlusion = 0,
		PipelineStatistics = 1,
		Timestamp = 2,
		Reserved8 = 1000023008,
		Reserved4 = 1000024004,
		TransformFeedbackStreamEXT = 1000028004,
		PerformanceQueryKHR = 1000116000,
		AccelerationStructureCompactedSizeKHR = 1000150000,
		AccelerationStructureSerializationSizeKHR = 1000150001,
		AccelerationStructureCompactedSizeNV = 1000165000,
		PerformanceQueryINTEL = 1000210000,
	}

	public enum VkBorderColor
	{
		FloatTransparentBlack = 0,
		IntTransparentBlack = 1,
		FloatOpaqueBlack = 2,
		IntOpaqueBlack = 3,
		FloatOpaqueWhite = 4,
		IntOpaqueWhite = 5,
		FloatCustomEXT = 1000287003,
		IntCustomEXT = 1000287004,
	}

	public enum VkPipelineBindPoint
	{
		Graphics = 0,
		Compute = 1,
	}

	public enum VkPipelineCacheHeaderVersion
	{
		One = 1,
	}

	public enum VkPrimitiveTopology
	{
		PointList = 0,
		LineList = 1,
		LineStrip = 2,
		TriangleList = 3,
		TriangleStrip = 4,
		TriangleFan = 5,
		LineListWithAdjacency = 6,
		LineStripWithAdjacency = 7,
		TriangleListWithAdjacency = 8,
		TriangleStripWithAdjacency = 9,
		PatchList = 10,
	}

	public enum VkSharingMode
	{
		Exclusive = 0,
		Concurrent = 1,
	}

	public enum VkIndexType
	{
		Uint16 = 0,
		Uint32 = 1,
		Uint8EXT = 1000265000,
	}

	public enum VkFilter
	{
		Nearest = 0,
		Linear = 1,
		CubicImg = 1000015000,
	}

	public enum VkSamplerMipmapMode
	{
		Nearest = 0,
		Linear = 1,
	}

	public enum VkSamplerAddressMode
	{
		Repeat = 0,
		MirroredRepeat = 1,
		ClampToEdge = 2,
		ClampToBorder = 3,
	}

	public enum VkCompareOp
	{
		Never = 0,
		Less = 1,
		Equal = 2,
		LessOrEqual = 3,
		Greater = 4,
		NotEqual = 5,
		GreaterOrEqual = 6,
		Always = 7,
	}

	public enum VkPolygonMode
	{
		Fill = 0,
		Line = 1,
		Point = 2,
		FillRectangleNV = 1000153000,
	}

	public enum VkFrontFace
	{
		CounterClockwise = 0,
		Clockwise = 1,
	}

	public enum VkBlendFactor
	{
		Zero = 0,
		One = 1,
		SrcColor = 2,
		OneMinusSrcColor = 3,
		DstColor = 4,
		OneMinusDstColor = 5,
		SrcAlpha = 6,
		OneMinusSrcAlpha = 7,
		DstAlpha = 8,
		OneMinusDstAlpha = 9,
		ConstantColor = 10,
		OneMinusConstantColor = 11,
		ConstantAlpha = 12,
		OneMinusConstantAlpha = 13,
		SrcAlphaSaturate = 14,
		Src1Color = 15,
		OneMinusSrc1Color = 16,
		Src1Alpha = 17,
		OneMinusSrc1Alpha = 18,
	}

	public enum VkBlendOp
	{
		Add = 0,
		Subtract = 1,
		ReverseSubtract = 2,
		Min = 3,
		Max = 4,
		ZeroEXT = 1000148000,
		SrcEXT = 1000148001,
		DstEXT = 1000148002,
		SrcOverEXT = 1000148003,
		DstOverEXT = 1000148004,
		SrcInEXT = 1000148005,
		DstInEXT = 1000148006,
		SrcOutEXT = 1000148007,
		DstOutEXT = 1000148008,
		SrcAtopEXT = 1000148009,
		DstAtopEXT = 1000148010,
		XorEXT = 1000148011,
		MultiplyEXT = 1000148012,
		ScreenEXT = 1000148013,
		OverlayEXT = 1000148014,
		DarkenEXT = 1000148015,
		LightenEXT = 1000148016,
		ColordodgeEXT = 1000148017,
		ColorburnEXT = 1000148018,
		HardlightEXT = 1000148019,
		SoftlightEXT = 1000148020,
		DifferenceEXT = 1000148021,
		ExclusionEXT = 1000148022,
		InvertEXT = 1000148023,
		InvertRgbEXT = 1000148024,
		LineardodgeEXT = 1000148025,
		LinearburnEXT = 1000148026,
		VividlightEXT = 1000148027,
		LinearlightEXT = 1000148028,
		PinlightEXT = 1000148029,
		HardmixEXT = 1000148030,
		HslHueEXT = 1000148031,
		HslSaturationEXT = 1000148032,
		HslColorEXT = 1000148033,
		HslLuminosityEXT = 1000148034,
		PlusEXT = 1000148035,
		PlusClampedEXT = 1000148036,
		PlusClampedAlphaEXT = 1000148037,
		PlusDarkerEXT = 1000148038,
		MinusEXT = 1000148039,
		MinusClampedEXT = 1000148040,
		ContrastEXT = 1000148041,
		InvertOvgEXT = 1000148042,
		RedEXT = 1000148043,
		GreenEXT = 1000148044,
		BlueEXT = 1000148045,
	}

	public enum VkStencilOp
	{
		Keep = 0,
		Zero = 1,
		Replace = 2,
		IncrementAndClamp = 3,
		DecrementAndClamp = 4,
		Invert = 5,
		IncrementAndWrap = 6,
		DecrementAndWrap = 7,
	}

	public enum VkLogicOp
	{
		Clear = 0,
		And = 1,
		AndReverse = 2,
		Copy = 3,
		AndInverted = 4,
		NoOp = 5,
		Xor = 6,
		Or = 7,
		Nor = 8,
		Equivalent = 9,
		Invert = 10,
		OrReverse = 11,
		CopyInverted = 12,
		OrInverted = 13,
		Nand = 14,
		Set = 15,
	}

	public enum VkInternalAllocationType
	{
		Executable = 0,
	}

	public enum VkSystemAllocationScope
	{
		Command = 0,
		Object = 1,
		Cache = 2,
		Device = 3,
		Instance = 4,
	}

	public enum VkPhysicalDeviceType
	{
		Other = 0,
		IntegratedGpu = 1,
		DiscreteGpu = 2,
		VirtualGpu = 3,
		Cpu = 4,
	}

	public enum VkVertexInputRate
	{
		Vertex = 0,
		Instance = 1,
	}

	public enum VkFormat
	{
		Undefined = 0,
		R4g4UnormPack8 = 1,
		R4g4b4a4UnormPack16 = 2,
		B4g4r4a4UnormPack16 = 3,
		R5g6b5UnormPack16 = 4,
		B5g6r5UnormPack16 = 5,
		R5g5b5a1UnormPack16 = 6,
		B5g5r5a1UnormPack16 = 7,
		A1r5g5b5UnormPack16 = 8,
		R8Unorm = 9,
		R8Snorm = 10,
		R8Uscaled = 11,
		R8Sscaled = 12,
		R8Uint = 13,
		R8Sint = 14,
		R8Srgb = 15,
		R8g8Unorm = 16,
		R8g8Snorm = 17,
		R8g8Uscaled = 18,
		R8g8Sscaled = 19,
		R8g8Uint = 20,
		R8g8Sint = 21,
		R8g8Srgb = 22,
		R8g8b8Unorm = 23,
		R8g8b8Snorm = 24,
		R8g8b8Uscaled = 25,
		R8g8b8Sscaled = 26,
		R8g8b8Uint = 27,
		R8g8b8Sint = 28,
		R8g8b8Srgb = 29,
		B8g8r8Unorm = 30,
		B8g8r8Snorm = 31,
		B8g8r8Uscaled = 32,
		B8g8r8Sscaled = 33,
		B8g8r8Uint = 34,
		B8g8r8Sint = 35,
		B8g8r8Srgb = 36,
		R8g8b8a8Unorm = 37,
		R8g8b8a8Snorm = 38,
		R8g8b8a8Uscaled = 39,
		R8g8b8a8Sscaled = 40,
		R8g8b8a8Uint = 41,
		R8g8b8a8Sint = 42,
		R8g8b8a8Srgb = 43,
		B8g8r8a8Unorm = 44,
		B8g8r8a8Snorm = 45,
		B8g8r8a8Uscaled = 46,
		B8g8r8a8Sscaled = 47,
		B8g8r8a8Uint = 48,
		B8g8r8a8Sint = 49,
		B8g8r8a8Srgb = 50,
		A8b8g8r8UnormPack32 = 51,
		A8b8g8r8SnormPack32 = 52,
		A8b8g8r8UscaledPack32 = 53,
		A8b8g8r8SscaledPack32 = 54,
		A8b8g8r8UintPack32 = 55,
		A8b8g8r8SintPack32 = 56,
		A8b8g8r8SrgbPack32 = 57,
		A2r10g10b10UnormPack32 = 58,
		A2r10g10b10SnormPack32 = 59,
		A2r10g10b10UscaledPack32 = 60,
		A2r10g10b10SscaledPack32 = 61,
		A2r10g10b10UintPack32 = 62,
		A2r10g10b10SintPack32 = 63,
		A2b10g10r10UnormPack32 = 64,
		A2b10g10r10SnormPack32 = 65,
		A2b10g10r10UscaledPack32 = 66,
		A2b10g10r10SscaledPack32 = 67,
		A2b10g10r10UintPack32 = 68,
		A2b10g10r10SintPack32 = 69,
		R16Unorm = 70,
		R16Snorm = 71,
		R16Uscaled = 72,
		R16Sscaled = 73,
		R16Uint = 74,
		R16Sint = 75,
		R16Sfloat = 76,
		R16g16Unorm = 77,
		R16g16Snorm = 78,
		R16g16Uscaled = 79,
		R16g16Sscaled = 80,
		R16g16Uint = 81,
		R16g16Sint = 82,
		R16g16Sfloat = 83,
		R16g16b16Unorm = 84,
		R16g16b16Snorm = 85,
		R16g16b16Uscaled = 86,
		R16g16b16Sscaled = 87,
		R16g16b16Uint = 88,
		R16g16b16Sint = 89,
		R16g16b16Sfloat = 90,
		R16g16b16a16Unorm = 91,
		R16g16b16a16Snorm = 92,
		R16g16b16a16Uscaled = 93,
		R16g16b16a16Sscaled = 94,
		R16g16b16a16Uint = 95,
		R16g16b16a16Sint = 96,
		R16g16b16a16Sfloat = 97,
		R32Uint = 98,
		R32Sint = 99,
		R32Sfloat = 100,
		R32g32Uint = 101,
		R32g32Sint = 102,
		R32g32Sfloat = 103,
		R32g32b32Uint = 104,
		R32g32b32Sint = 105,
		R32g32b32Sfloat = 106,
		R32g32b32a32Uint = 107,
		R32g32b32a32Sint = 108,
		R32g32b32a32Sfloat = 109,
		R64Uint = 110,
		R64Sint = 111,
		R64Sfloat = 112,
		R64g64Uint = 113,
		R64g64Sint = 114,
		R64g64Sfloat = 115,
		R64g64b64Uint = 116,
		R64g64b64Sint = 117,
		R64g64b64Sfloat = 118,
		R64g64b64a64Uint = 119,
		R64g64b64a64Sint = 120,
		R64g64b64a64Sfloat = 121,
		B10g11r11UfloatPack32 = 122,
		E5b9g9r9UfloatPack32 = 123,
		D16Unorm = 124,
		X8D24UnormPack32 = 125,
		D32Sfloat = 126,
		S8Uint = 127,
		D16UnormS8Uint = 128,
		D24UnormS8Uint = 129,
		D32SfloatS8Uint = 130,
		Bc1RgbUnormBlock = 131,
		Bc1RgbSrgbBlock = 132,
		Bc1RgbaUnormBlock = 133,
		Bc1RgbaSrgbBlock = 134,
		Bc2UnormBlock = 135,
		Bc2SrgbBlock = 136,
		Bc3UnormBlock = 137,
		Bc3SrgbBlock = 138,
		Bc4UnormBlock = 139,
		Bc4SnormBlock = 140,
		Bc5UnormBlock = 141,
		Bc5SnormBlock = 142,
		Bc6hUfloatBlock = 143,
		Bc6hSfloatBlock = 144,
		Bc7UnormBlock = 145,
		Bc7SrgbBlock = 146,
		Etc2R8g8b8UnormBlock = 147,
		Etc2R8g8b8SrgbBlock = 148,
		Etc2R8g8b8a1UnormBlock = 149,
		Etc2R8g8b8a1SrgbBlock = 150,
		Etc2R8g8b8a8UnormBlock = 151,
		Etc2R8g8b8a8SrgbBlock = 152,
		EacR11UnormBlock = 153,
		EacR11SnormBlock = 154,
		EacR11g11UnormBlock = 155,
		EacR11g11SnormBlock = 156,
		Astc4x4UnormBlock = 157,
		Astc4x4SrgbBlock = 158,
		Astc5x4UnormBlock = 159,
		Astc5x4SrgbBlock = 160,
		Astc5x5UnormBlock = 161,
		Astc5x5SrgbBlock = 162,
		Astc6x5UnormBlock = 163,
		Astc6x5SrgbBlock = 164,
		Astc6x6UnormBlock = 165,
		Astc6x6SrgbBlock = 166,
		Astc8x5UnormBlock = 167,
		Astc8x5SrgbBlock = 168,
		Astc8x6UnormBlock = 169,
		Astc8x6SrgbBlock = 170,
		Astc8x8UnormBlock = 171,
		Astc8x8SrgbBlock = 172,
		Astc10x5UnormBlock = 173,
		Astc10x5SrgbBlock = 174,
		Astc10x6UnormBlock = 175,
		Astc10x6SrgbBlock = 176,
		Astc10x8UnormBlock = 177,
		Astc10x8SrgbBlock = 178,
		Astc10x10UnormBlock = 179,
		Astc10x10SrgbBlock = 180,
		Astc12x10UnormBlock = 181,
		Astc12x10SrgbBlock = 182,
		Astc12x12UnormBlock = 183,
		Astc12x12SrgbBlock = 184,
		Pvrtc12bppUnormBlockImg = 1000054000,
		Pvrtc14bppUnormBlockImg = 1000054001,
		Pvrtc22bppUnormBlockImg = 1000054002,
		Pvrtc24bppUnormBlockImg = 1000054003,
		Pvrtc12bppSrgbBlockImg = 1000054004,
		Pvrtc14bppSrgbBlockImg = 1000054005,
		Pvrtc22bppSrgbBlockImg = 1000054006,
		Pvrtc24bppSrgbBlockImg = 1000054007,
		A4r4g4b4UnormPack16EXT = 1000340000,
		A4b4g4r4UnormPack16EXT = 1000340001,
	}

	public enum VkStructureType
	{
		ApplicationInfo = 0,
		InstanceCreateInfo = 1,
		DeviceQueueCreateInfo = 2,
		DeviceCreateInfo = 3,
		SubmitInfo = 4,
		MemoryAllocateInfo = 5,
		MappedMemoryRange = 6,
		BindSparseInfo = 7,
		FenceCreateInfo = 8,
		SemaphoreCreateInfo = 9,
		EventCreateInfo = 10,
		QueryPoolCreateInfo = 11,
		BufferCreateInfo = 12,
		BufferViewCreateInfo = 13,
		ImageCreateInfo = 14,
		ImageViewCreateInfo = 15,
		ShaderModuleCreateInfo = 16,
		PipelineCacheCreateInfo = 17,
		PipelineShaderStageCreateInfo = 18,
		PipelineVertexInputStateCreateInfo = 19,
		PipelineInputAssemblyStateCreateInfo = 20,
		PipelineTessellationStateCreateInfo = 21,
		PipelineViewportStateCreateInfo = 22,
		PipelineRasterizationStateCreateInfo = 23,
		PipelineMultisampleStateCreateInfo = 24,
		PipelineDepthStencilStateCreateInfo = 25,
		PipelineColorBlendStateCreateInfo = 26,
		PipelineDynamicStateCreateInfo = 27,
		GraphicsPipelineCreateInfo = 28,
		ComputePipelineCreateInfo = 29,
		PipelineLayoutCreateInfo = 30,
		SamplerCreateInfo = 31,
		DescriptorSetLayoutCreateInfo = 32,
		DescriptorPoolCreateInfo = 33,
		DescriptorSetAllocateInfo = 34,
		WriteDescriptorSet = 35,
		CopyDescriptorSet = 36,
		FramebufferCreateInfo = 37,
		RenderPassCreateInfo = 38,
		CommandPoolCreateInfo = 39,
		CommandBufferAllocateInfo = 40,
		CommandBufferInheritanceInfo = 41,
		CommandBufferBeginInfo = 42,
		RenderPassBeginInfo = 43,
		BufferMemoryBarrier = 44,
		ImageMemoryBarrier = 45,
		MemoryBarrier = 46,
		LoaderInstanceCreateInfo = 47,
		LoaderDeviceCreateInfo = 48,
		SwapchainCreateInfoKHR = 1000001000,
		PresentInfoKHR = 1000001001,
		DisplayModeCreateInfoKHR = 1000002000,
		DisplaySurfaceCreateInfoKHR = 1000002001,
		DisplayPresentInfoKHR = 1000003000,
		XlibSurfaceCreateInfoKHR = 1000004000,
		XcbSurfaceCreateInfoKHR = 1000005000,
		WaylandSurfaceCreateInfoKHR = 1000006000,
		AndroidSurfaceCreateInfoKHR = 1000008000,
		Win32SurfaceCreateInfoKHR = 1000009000,
		NativeBufferAndroid = 1000010000,
		SwapchainImageCreateInfoAndroid = 1000010001,
		PhysicalDevicePresentationPropertiesAndroid = 1000010002,
		DebugReportCallbackCreateInfoEXT = 1000011000,
		PipelineRasterizationStateRasterizationOrderAMD = 1000018000,
		DebugMarkerObjectNameInfoEXT = 1000022000,
		DebugMarkerObjectTagInfoEXT = 1000022001,
		DebugMarkerMarkerInfoEXT = 1000022002,
		DedicatedAllocationImageCreateInfoNV = 1000026000,
		DedicatedAllocationBufferCreateInfoNV = 1000026001,
		DedicatedAllocationMemoryAllocateInfoNV = 1000026002,
		PhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,
		PhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,
		PipelineRasterizationStateStreamCreateInfoEXT = 1000028002,
		ImageViewHandleInfoNVX = 1000030000,
		ImageViewAddressPropertiesNVX = 1000030001,
		TextureLodGatherFormatPropertiesAMD = 1000041000,
		StreamDescriptorSurfaceCreateInfoGgp = 1000049000,
		PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,
		ExternalMemoryImageCreateInfoNV = 1000056000,
		ExportMemoryAllocateInfoNV = 1000056001,
		ImportMemoryWin32HandleInfoNV = 1000057000,
		ExportMemoryWin32HandleInfoNV = 1000057001,
		Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,
		DeviceGroupPresentCapabilitiesKHR = 1000060007,
		ImageSwapchainCreateInfoKHR = 1000060008,
		BindImageMemorySwapchainInfoKHR = 1000060009,
		AcquireNextImageInfoKHR = 1000060010,
		DeviceGroupPresentInfoKHR = 1000060011,
		DeviceGroupSwapchainCreateInfoKHR = 1000060012,
		ValidationEXT = 1000061000,
		ViSurfaceCreateInfoNn = 1000062000,
		PhysicalDeviceTextureCompressionAstcHdrFeaturesEXT = 1000066000,
		ImageViewAstcDecodeModeEXT = 1000067000,
		PhysicalDeviceAstcDecodeFeaturesEXT = 1000067001,
		ImportMemoryWin32HandleInfoKHR = 1000073000,
		ExportMemoryWin32HandleInfoKHR = 1000073001,
		MemoryWin32HandlePropertiesKHR = 1000073002,
		MemoryGetWin32HandleInfoKHR = 1000073003,
		ImportMemoryFdInfoKHR = 1000074000,
		MemoryFdPropertiesKHR = 1000074001,
		MemoryGetFdInfoKHR = 1000074002,
		Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,
		ImportSemaphoreWin32HandleInfoKHR = 1000078000,
		ExportSemaphoreWin32HandleInfoKHR = 1000078001,
		D3d12FenceSubmitInfoKHR = 1000078002,
		SemaphoreGetWin32HandleInfoKHR = 1000078003,
		ImportSemaphoreFdInfoKHR = 1000079000,
		SemaphoreGetFdInfoKHR = 1000079001,
		PhysicalDevicePushDescriptorPropertiesKHR = 1000080000,
		CommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,
		PhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,
		ConditionalRenderingBeginInfoEXT = 1000081002,
		PresentRegionsKHR = 1000084000,
		PipelineViewportWScalingStateCreateInfoNV = 1000087000,
		SurfaceCapabilities2EXT = 1000090000,
		DisplayPowerInfoEXT = 1000091000,
		DeviceEventInfoEXT = 1000091001,
		DisplayEventInfoEXT = 1000091002,
		SwapchainCounterCreateInfoEXT = 1000091003,
		PresentTimesInfoGoogle = 1000092000,
		PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX = 1000097000,
		PipelineViewportSwizzleStateCreateInfoNV = 1000098000,
		PhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,
		PipelineDiscardRectangleStateCreateInfoEXT = 1000099001,
		PhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,
		PipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,
		PhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,
		PipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,
		HdrMetadataEXT = 1000105000,
		SharedPresentSurfaceCapabilitiesKHR = 1000111000,
		ImportFenceWin32HandleInfoKHR = 1000114000,
		ExportFenceWin32HandleInfoKHR = 1000114001,
		FenceGetWin32HandleInfoKHR = 1000114002,
		ImportFenceFdInfoKHR = 1000115000,
		FenceGetFdInfoKHR = 1000115001,
		PhysicalDevicePerformanceQueryFeaturesKHR = 1000116000,
		PhysicalDevicePerformanceQueryPropertiesKHR = 1000116001,
		QueryPoolPerformanceCreateInfoKHR = 1000116002,
		PerformanceQuerySubmitInfoKHR = 1000116003,
		AcquireProfilingLockInfoKHR = 1000116004,
		PerformanceCounterKHR = 1000116005,
		PerformanceCounterDescriptionKHR = 1000116006,
		PhysicalDeviceSurfaceInfo2KHR = 1000119000,
		SurfaceCapabilities2KHR = 1000119001,
		SurfaceFormat2KHR = 1000119002,
		DisplayProperties2KHR = 1000121000,
		DisplayPlaneProperties2KHR = 1000121001,
		DisplayModeProperties2KHR = 1000121002,
		DisplayPlaneInfo2KHR = 1000121003,
		DisplayPlaneCapabilities2KHR = 1000121004,
		IosSurfaceCreateInfoMvk = 1000122000,
		MacosSurfaceCreateInfoMvk = 1000123000,
		DebugUtilsObjectNameInfoEXT = 1000128000,
		DebugUtilsObjectTagInfoEXT = 1000128001,
		DebugUtilsLabelEXT = 1000128002,
		DebugUtilsMessengerCallbackDataEXT = 1000128003,
		DebugUtilsMessengerCreateInfoEXT = 1000128004,
		AndroidHardwareBufferUsageAndroid = 1000129000,
		AndroidHardwareBufferPropertiesAndroid = 1000129001,
		AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
		ImportAndroidHardwareBufferInfoAndroid = 1000129003,
		MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
		ExternalFormatAndroid = 1000129005,
		PhysicalDeviceInlineUniformBlockFeaturesEXT = 1000138000,
		PhysicalDeviceInlineUniformBlockPropertiesEXT = 1000138001,
		WriteDescriptorSetInlineUniformBlockEXT = 1000138002,
		DescriptorPoolInlineUniformBlockCreateInfoEXT = 1000138003,
		SampleLocationsInfoEXT = 1000143000,
		RenderPassSampleLocationsBeginInfoEXT = 1000143001,
		PipelineSampleLocationsStateCreateInfoEXT = 1000143002,
		PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,
		MultisamplePropertiesEXT = 1000143004,
		PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,
		PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,
		PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,
		PipelineCoverageToColorStateCreateInfoNV = 1000149000,
		WriteDescriptorSetAccelerationStructureKHR = 1000150007,
		AccelerationStructureBuildGeometryInfoKHR = 1000150000,
		AccelerationStructureDeviceAddressInfoKHR = 1000150002,
		AccelerationStructureGeometryAabbsDataKHR = 1000150003,
		AccelerationStructureGeometryInstancesDataKHR = 1000150004,
		AccelerationStructureGeometryTrianglesDataKHR = 1000150005,
		AccelerationStructureGeometryKHR = 1000150006,
		AccelerationStructureVersionInfoKHR = 1000150009,
		CopyAccelerationStructureInfoKHR = 1000150010,
		CopyAccelerationStructureToMemoryInfoKHR = 1000150011,
		CopyMemoryToAccelerationStructureInfoKHR = 1000150012,
		PhysicalDeviceAccelerationStructureFeaturesKHR = 1000150013,
		PhysicalDeviceAccelerationStructurePropertiesKHR = 1000150014,
		AccelerationStructureCreateInfoKHR = 1000150017,
		AccelerationStructureBuildSizesInfoKHR = 1000150020,
		PhysicalDeviceRayTracingPipelineFeaturesKHR = 1000347000,
		PhysicalDeviceRayTracingPipelinePropertiesKHR = 1000347001,
		PhysicalDeviceRayQueryFeaturesKHR = 1000348013,
		PipelineCoverageModulationStateCreateInfoNV = 1000152000,
		PhysicalDeviceShaderSmBuiltinsFeaturesNV = 1000154000,
		PhysicalDeviceShaderSmBuiltinsPropertiesNV = 1000154001,
		DrmFormatModifierPropertiesListEXT = 1000158000,
		PhysicalDeviceImageDrmFormatModifierInfoEXT = 1000158002,
		ImageDrmFormatModifierListCreateInfoEXT = 1000158003,
		ImageDrmFormatModifierExplicitCreateInfoEXT = 1000158004,
		ImageDrmFormatModifierPropertiesEXT = 1000158005,
		ValidationCacheCreateInfoEXT = 1000160000,
		ShaderModuleValidationCacheCreateInfoEXT = 1000160001,
		PhysicalDevicePortabilitySubsetFeaturesKHR = 1000163000,
		PhysicalDevicePortabilitySubsetPropertiesKHR = 1000163001,
		PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,
		PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,
		PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,
		PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,
		RayTracingPipelineCreateInfoNV = 1000165000,
		AccelerationStructureCreateInfoNV = 1000165001,
		GeometryNV = 1000165003,
		GeometryTrianglesNV = 1000165004,
		GeometryAabbNV = 1000165005,
		BindAccelerationStructureMemoryInfoNV = 1000165006,
		WriteDescriptorSetAccelerationStructureNV = 1000165007,
		AccelerationStructureMemoryRequirementsInfoNV = 1000165008,
		PhysicalDeviceRayTracingPropertiesNV = 1000165009,
		RayTracingShaderGroupCreateInfoNV = 1000165011,
		AccelerationStructureInfoNV = 1000165012,
		PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,
		PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,
		PhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,
		FilterCubicImageViewImageFormatPropertiesEXT = 1000170001,
		DeviceQueueGlobalPriorityCreateInfoEXT = 1000174000,
		ImportMemoryHostPointerInfoEXT = 1000178000,
		MemoryHostPointerPropertiesEXT = 1000178001,
		PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,
		PhysicalDeviceShaderClockFeaturesKHR = 1000181000,
		PipelineCompilerControlCreateInfoAMD = 1000183000,
		CalibratedTimestampInfoEXT = 1000184000,
		PhysicalDeviceShaderCorePropertiesAMD = 1000185000,
		DeviceMemoryOverallocationCreateInfoAMD = 1000189000,
		PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,
		PipelineVertexInputDivisorStateCreateInfoEXT = 1000190001,
		PhysicalDeviceVertexAttributeDivisorFeaturesEXT = 1000190002,
		PresentFrameTokenGgp = 1000191000,
		PipelineCreationFeedbackCreateInfoEXT = 1000192000,
		PhysicalDeviceComputeShaderDerivativesFeaturesNV = 1000201000,
		PhysicalDeviceMeshShaderFeaturesNV = 1000202000,
		PhysicalDeviceMeshShaderPropertiesNV = 1000202001,
		PhysicalDeviceFragmentShaderBarycentricFeaturesNV = 1000203000,
		PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,
		PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,
		PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,
		CheckpointDataNV = 1000206000,
		QueueFamilyCheckpointPropertiesNV = 1000206001,
		PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL = 1000209000,
		QueryPoolPerformanceQueryCreateInfoINTEL = 1000210000,
		InitializePerformanceApiInfoINTEL = 1000210001,
		PerformanceMarkerInfoINTEL = 1000210002,
		PerformanceStreamMarkerInfoINTEL = 1000210003,
		PerformanceOverrideInfoINTEL = 1000210004,
		PerformanceConfigurationAcquireInfoINTEL = 1000210005,
		PhysicalDevicePciBusInfoPropertiesEXT = 1000212000,
		DisplayNativeHdrSurfaceCapabilitiesAMD = 1000213000,
		SwapchainDisplayNativeHdrCreateInfoAMD = 1000213001,
		ImagepipeSurfaceCreateInfoFuchsia = 1000214000,
		PhysicalDeviceShaderTerminateInvocationFeaturesKHR = 1000215000,
		MetalSurfaceCreateInfoEXT = 1000217000,
		PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,
		PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,
		RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,
		PhysicalDeviceSubgroupSizeControlPropertiesEXT = 1000225000,
		PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT = 1000225001,
		PhysicalDeviceSubgroupSizeControlFeaturesEXT = 1000225002,
		FragmentShadingRateAttachmentInfoKHR = 1000226000,
		PipelineFragmentShadingRateStateCreateInfoKHR = 1000226001,
		PhysicalDeviceFragmentShadingRatePropertiesKHR = 1000226002,
		PhysicalDeviceFragmentShadingRateFeaturesKHR = 1000226003,
		PhysicalDeviceFragmentShadingRateKHR = 1000226004,
		PhysicalDeviceShaderCoreProperties2AMD = 1000227000,
		PhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,
		PhysicalDeviceShaderImageAtomicInt64FeaturesEXT = 1000234000,
		PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,
		PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,
		MemoryPriorityAllocateInfoEXT = 1000238001,
		SurfaceProtectedCapabilitiesKHR = 1000239000,
		PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,
		PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,
		BufferDeviceAddressCreateInfoEXT = 1000244002,
		PhysicalDeviceToolPropertiesEXT = 1000245000,
		ValidationFeaturesEXT = 1000247000,
		PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,
		CooperativeMatrixPropertiesNV = 1000249001,
		PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,
		PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,
		PipelineCoverageReductionStateCreateInfoNV = 1000250001,
		FramebufferMixedSamplesCombinationNV = 1000250002,
		PhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,
		PhysicalDeviceYcbcrImageArraysFeaturesEXT = 1000252000,
		SurfaceFullScreenExclusiveInfoEXT = 1000255000,
		SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,
		SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,
		HeadlessSurfaceCreateInfoEXT = 1000256000,
		PhysicalDeviceLineRasterizationFeaturesEXT = 1000259000,
		PipelineRasterizationLineStateCreateInfoEXT = 1000259001,
		PhysicalDeviceLineRasterizationPropertiesEXT = 1000259002,
		PhysicalDeviceShaderAtomicFloatFeaturesEXT = 1000260000,
		PhysicalDeviceIndexTypeUint8FeaturesEXT = 1000265000,
		PhysicalDeviceExtendedDynamicStateFeaturesEXT = 1000267000,
		PhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,
		PipelineInfoKHR = 1000269001,
		PipelineExecutablePropertiesKHR = 1000269002,
		PipelineExecutableInfoKHR = 1000269003,
		PipelineExecutableStatisticKHR = 1000269004,
		PipelineExecutableInternalRepresentationKHR = 1000269005,
		PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT = 1000276000,
		PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,
		GraphicsShaderGroupCreateInfoNV = 1000277001,
		GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,
		IndirectCommandsLayoutTokenNV = 1000277003,
		IndirectCommandsLayoutCreateInfoNV = 1000277004,
		GeneratedCommandsInfoNV = 1000277005,
		GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,
		PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,
		PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,
		PhysicalDeviceTexelBufferAlignmentPropertiesEXT = 1000281001,
		CommandBufferInheritanceRenderPassTransformInfoQcom = 1000282000,
		RenderPassTransformBeginInfoQcom = 1000282001,
		PhysicalDeviceDeviceMemoryReportFeaturesEXT = 1000284000,
		DeviceDeviceMemoryReportCreateInfoEXT = 1000284001,
		DeviceMemoryReportCallbackDataEXT = 1000284002,
		PhysicalDeviceRobustness2FeaturesEXT = 1000286000,
		PhysicalDeviceRobustness2PropertiesEXT = 1000286001,
		SamplerCustomBorderColorCreateInfoEXT = 1000287000,
		PhysicalDeviceCustomBorderColorPropertiesEXT = 1000287001,
		PhysicalDeviceCustomBorderColorFeaturesEXT = 1000287002,
		PipelineLibraryCreateInfoKHR = 1000290000,
		PhysicalDevicePrivateDataFeaturesEXT = 1000295000,
		DevicePrivateDataCreateInfoEXT = 1000295001,
		PrivateDataSlotCreateInfoEXT = 1000295002,
		PhysicalDevicePipelineCreationCacheControlFeaturesEXT = 1000297000,
		PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,
		DeviceDiagnosticsConfigCreateInfoNV = 1000300001,
		ReservedQcom = 1000309000,
		MemoryBarrier2KHR = 1000314000,
		BufferMemoryBarrier2KHR = 1000314001,
		ImageMemoryBarrier2KHR = 1000314002,
		DependencyInfoKHR = 1000314003,
		SubmitInfo2KHR = 1000314004,
		SemaphoreSubmitInfoKHR = 1000314005,
		CommandBufferSubmitInfoKHR = 1000314006,
		PhysicalDeviceSynchronization2FeaturesKHR = 1000314007,
		QueueFamilyCheckpointProperties2NV = 1000314008,
		CheckpointData2NV = 1000314009,
		PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR = 1000325000,
		PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,
		PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,
		PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,
		PhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,
		PhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,
		CopyCommandTransformInfoQcom = 1000333000,
		PhysicalDeviceImageRobustnessFeaturesEXT = 1000335000,
		PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR = 1000336000,
		CopyBufferInfo2KHR = 1000337000,
		CopyImageInfo2KHR = 1000337001,
		CopyBufferToImageInfo2KHR = 1000337002,
		CopyImageToBufferInfo2KHR = 1000337003,
		BlitImageInfo2KHR = 1000337004,
		ResolveImageInfo2KHR = 1000337005,
		BufferCopy2KHR = 1000337006,
		ImageCopy2KHR = 1000337007,
		ImageBlit2KHR = 1000337008,
		BufferImageCopy2KHR = 1000337009,
		ImageResolve2KHR = 1000337010,
		PhysicalDevice4444FormatsFeaturesEXT = 1000340000,
		DirectfbSurfaceCreateInfoEXT = 1000346000,
		PhysicalDeviceMutableDescriptorTypeFeaturesValve = 1000351000,
		MutableDescriptorTypeCreateInfoValve = 1000351002,
		ImportMemoryZirconHandleInfoFuchsia = 1000364000,
		MemoryZirconHandlePropertiesFuchsia = 1000364001,
		MemoryGetZirconHandleInfoFuchsia = 1000364002,
		ImportSemaphoreZirconHandleInfoFuchsia = 1000365000,
		SemaphoreGetZirconHandleInfoFuchsia = 1000365001,
		ScreenSurfaceCreateInfoQnx = 1000378000,
	}

	public enum VkSubpassContents
	{
		Inline = 0,
		SecondaryCommandBuffers = 1,
	}

	public enum VkResult
	{
		Success = 0,
		NotReady = 1,
		Timeout = 2,
		EventSet = 3,
		EventReset = 4,
		Incomplete = 5,
		ErrorOutOfHostMemory = -1,
		ErrorOutOfDeviceMemory = -2,
		ErrorInitializationFailed = -3,
		ErrorDeviceLost = -4,
		ErrorMemoryMapFailed = -5,
		ErrorLayerNotPresent = -6,
		ErrorExtensionNotPresent = -7,
		ErrorFeatureNotPresent = -8,
		ErrorIncompatibleDriver = -9,
		ErrorTooManyObjects = -10,
		ErrorFormatNotSupported = -11,
		ErrorFragmentedPool = -12,
		ErrorUnknown = -13,
		ErrorSurfaceLostKHR = -1000000000,
		ErrorNativeWindowInUseKHR = -1000000001,
		SuboptimalKHR = 1000001003,
		ErrorOutOfDateKHR = -1000001004,
		ErrorIncompatibleDisplayKHR = -1000003001,
		ErrorValidationFailedEXT = -1000011001,
		ErrorInvalidShaderNV = -1000012000,
		ErrorInvalidDrmFormatModifierPlaneLayoutEXT = -1000158000,
		ErrorNotPermittedEXT = -1000174001,
		ErrorFullScreenExclusiveModeLostEXT = -1000255000,
		ThreadIdleKHR = 1000268000,
		ThreadDoneKHR = 1000268001,
		OperationDeferredKHR = 1000268002,
		OperationNotDeferredKHR = 1000268003,
		PipelineCompileRequiredEXT = 1000297000,
	}

	public enum VkDynamicState
	{
		Viewport = 0,
		Scissor = 1,
		LineWidth = 2,
		DepthBias = 3,
		BlendConstants = 4,
		DepthBounds = 5,
		StencilCompareMask = 6,
		StencilWriteMask = 7,
		StencilReference = 8,
		ViewportWScalingNV = 1000087000,
		DiscardRectangleEXT = 1000099000,
		SampleLocationsEXT = 1000143000,
		RayTracingPipelineStackSizeKHR = 1000347000,
		ViewportShadingRatePaletteNV = 1000164004,
		ViewportCoarseSampleOrderNV = 1000164006,
		ExclusiveScissorNV = 1000205001,
		FragmentShadingRateKHR = 1000226000,
		LineStippleEXT = 1000259000,
		CullModeEXT = 1000267000,
		FrontFaceEXT = 1000267001,
		PrimitiveTopologyEXT = 1000267002,
		ViewportWithCountEXT = 1000267003,
		ScissorWithCountEXT = 1000267004,
		VertexInputBindingStrideEXT = 1000267005,
		DepthTestEnableEXT = 1000267006,
		DepthWriteEnableEXT = 1000267007,
		DepthCompareOpEXT = 1000267008,
		DepthBoundsTestEnableEXT = 1000267009,
		StencilTestEnableEXT = 1000267010,
		StencilOpEXT = 1000267011,
	}

	public enum VkDescriptorUpdateTemplateType
	{
		DescriptorSet = 0,
	}

	public enum VkObjectType
	{
		Unknown = 0,
		Instance = 1,
		PhysicalDevice = 2,
		Device = 3,
		Queue = 4,
		Semaphore = 5,
		CommandBuffer = 6,
		Fence = 7,
		DeviceMemory = 8,
		Buffer = 9,
		Image = 10,
		Event = 11,
		QueryPool = 12,
		BufferView = 13,
		ImageView = 14,
		ShaderModule = 15,
		PipelineCache = 16,
		PipelineLayout = 17,
		RenderPass = 18,
		Pipeline = 19,
		DescriptorSetLayout = 20,
		Sampler = 21,
		DescriptorPool = 22,
		DescriptorSet = 23,
		Framebuffer = 24,
		CommandPool = 25,
		SurfaceKHR = 1000000000,
		SwapchainKHR = 1000001000,
		DisplayKHR = 1000002000,
		DisplayModeKHR = 1000002001,
		DebugReportCallbackEXT = 1000011000,
		DebugUtilsMessengerEXT = 1000128000,
		AccelerationStructureKHR = 1000150000,
		ValidationCacheEXT = 1000160000,
		AccelerationStructureNV = 1000165000,
		PerformanceConfigurationINTEL = 1000210000,
		DeferredOperationKHR = 1000268000,
		IndirectCommandsLayoutNV = 1000277000,
		PrivateDataSlotEXT = 1000295000,
	}

	public enum VkSemaphoreType
	{
		Binary = 0,
		Timeline = 1,
	}

	public enum VkPresentModeKHR
	{
		Immediate = 0,
		Mailbox = 1,
		Fifo = 2,
		FifoRelaxed = 3,
		SharedDemandRefreshKHR = 1000111000,
		SharedContinuousRefreshKHR = 1000111001,
	}

	public enum VkColorSpaceKHR
	{
		SrgbNonLinearKHR = 0,
		DisplayP3NonLinearEXT = 1000104001,
		ExtendedSrgbLinearEXT = 1000104002,
		DisplayP3LinearEXT = 1000104003,
		DciP3NonLinearEXT = 1000104004,
		Bt709LinearEXT = 1000104005,
		Bt709NonLinearEXT = 1000104006,
		Bt2020LinearEXT = 1000104007,
		Hdr10St2084EXT = 1000104008,
		DolbyVisionEXT = 1000104009,
		Hdr10HlgEXT = 1000104010,
		AdobeRgbLinearEXT = 1000104011,
		AdobeRgbNonLinearEXT = 1000104012,
		PassThroughEXT = 1000104013,
		ExtendedSrgbNonLinearEXT = 1000104014,
		DisplayNativeAMD = 1000213000,
	}

	public enum VkTimeDomainEXT
	{
		Device = 0,
		ClockMonotonic = 1,
		ClockMonotonicRaw = 2,
		QueryPerformanceCounter = 3,
	}

	public enum VkDebugReportObjectTypeEXT
	{
		Unknown = 0,
		Instance = 1,
		PhysicalDevice = 2,
		Device = 3,
		Queue = 4,
		Semaphore = 5,
		CommandBuffer = 6,
		Fence = 7,
		DeviceMemory = 8,
		Buffer = 9,
		Image = 10,
		Event = 11,
		QueryPool = 12,
		BufferView = 13,
		ImageView = 14,
		ShaderModule = 15,
		PipelineCache = 16,
		PipelineLayout = 17,
		RenderPass = 18,
		Pipeline = 19,
		DescriptorSetLayout = 20,
		Sampler = 21,
		DescriptorPool = 22,
		DescriptorSet = 23,
		Framebuffer = 24,
		CommandPool = 25,
		SurfaceKHR = 26,
		SwapchainKHR = 27,
		DebugReportCallbackEXT = 28,
		DisplayKHR = 29,
		DisplayModeKHR = 30,
		ValidationCacheEXT = 33,
		AccelerationStructureKHREXT = 1000150000,
		SamplerYcbcrConversionEXT = 1000156000,
		AccelerationStructureNVEXT = 1000165000,
	}

	public enum VkDeviceMemoryReportEventTypeEXT
	{
		Allocate = 0,
		Free = 1,
		Import = 2,
		Unimport = 3,
		AllocationFailed = 4,
	}

	public enum VkRasterizationOrderAMD
	{
		StrictAMD = 0,
		RelaxedAMD = 1,
	}

	public enum VkValidationCheckEXT
	{
		All = 0,
		Shaders = 1,
	}

	public enum VkValidationFeatureEnableEXT
	{
		GpuAssisted = 0,
		GpuAssistedReserveBindingSlot = 1,
		BestPractices = 2,
		DebugPrintf = 3,
		SynchronizationValidation = 4,
	}

	public enum VkValidationFeatureDisableEXT
	{
		All = 0,
		Shaders = 1,
		ThreadSafety = 2,
		ApiParameters = 3,
		ObjectLifetimes = 4,
		CoreChecks = 5,
		UniqueHandles = 6,
	}

	public enum VkIndirectCommandsTokenTypeNV
	{
		TypeShaderGroup = 0,
		TypeState = 1,
		TypeIndexBuffer = 2,
		TypeVertexBuffer = 3,
		TypePushConstant = 4,
		TypeDrawIndexed = 5,
		TypeDraw = 6,
		TypeDrawTasks = 7,
	}

	public enum VkDisplayPowerStateEXT
	{
		Off = 0,
		Suspend = 1,
		On = 2,
	}

	public enum VkDeviceEventTypeEXT
	{
		DisplayHotplug = 0,
	}

	public enum VkDisplayEventTypeEXT
	{
		FirstPixelOut = 0,
	}

	public enum VkViewportCoordinateSwizzleNV
	{
		PositiveX = 0,
		NegativeX = 1,
		PositiveY = 2,
		NegativeY = 3,
		PositiveZ = 4,
		NegativeZ = 5,
		PositiveW = 6,
		NegativeW = 7,
	}

	public enum VkDiscardRectangleModeEXT
	{
		Inclusive = 0,
		Exclusive = 1,
	}

	public enum VkPointClippingBehavior
	{
		AllClipPlanes = 0,
		UserClipPlanesOnly = 1,
	}

	public enum VkSamplerReductionMode
	{
		WeightedAverage = 0,
		Min = 1,
		Max = 2,
	}

	public enum VkTessellationDomainOrigin
	{
		UpperLeft = 0,
		LowerLeft = 1,
	}

	public enum VkSamplerYcbcrModelConversion
	{
		RgbIdentity = 0,
		YcbcrIdentity = 1,
		Ycbcr709 = 2,
		Ycbcr601 = 3,
		Ycbcr2020 = 4,
	}

	public enum VkSamplerYcbcrRange
	{
		ItuFull = 0,
		ItuNarrow = 1,
	}

	public enum VkChromaLocation
	{
		CositedEven = 0,
		Midpoint = 1,
	}

	public enum VkBlendOverlapEXT
	{
		Uncorrelated = 0,
		Disjoint = 1,
		Conjoint = 2,
	}

	public enum VkCoverageModulationModeNV
	{
		None = 0,
		Rgb = 1,
		Alpha = 2,
		Rgba = 3,
	}

	public enum VkCoverageReductionModeNV
	{
		ModeMerge = 0,
		ModeTruncate = 1,
	}

	public enum VkValidationCacheHeaderVersionEXT
	{
		One = 1,
	}

	public enum VkShaderInfoTypeAMD
	{
		StatisticsAMD = 0,
		BinaryAMD = 1,
		DisassemblyAMD = 2,
	}

	public enum VkQueueGlobalPriorityEXT
	{
		Low = 128,
		Medium = 256,
		High = 512,
		Realtime = 1024,
	}

	public enum VkConservativeRasterizationModeEXT
	{
		Disabled = 0,
		Overestimate = 1,
		Underestimate = 2,
	}

	public enum VkVendorId
	{
		Viv = 0x10001,
		Vsi = 0x10002,
		Kazan = 0x10003,
		Codeplay = 0x10004,
		Mesa = 0x10005,
		Pocl = 0x10006,
	}

	public enum VkDriverId
	{
		AMDProprietary = 1,
		AMDOpenSource = 2,
		MesaRadv = 3,
		NvidiaProprietary = 4,
		INTELProprietaryWindows = 5,
		INTELOpenSourceMesa = 6,
		ImaginationProprietary = 7,
		QualcommProprietary = 8,
		ArmProprietary = 9,
		GoogleSwiftShader = 10,
		GgpProprietary = 11,
		BroadcomProprietary = 12,
		MesaLLVMPipe = 13,
		Moltenvk = 14,
	}

	public enum VkShadingRatePaletteEntryNV
	{
		NoInvocations = 0,
		SixteenInvocationsPerPixel = 1,
		EightInvocationsPerPixel = 2,
		FourInvocationsPerPixel = 3,
		TwoInvocationsPerPixel = 4,
		OneInvocationPerPixel = 5,
		OneInvocationPer2x1Pixels = 6,
		OneInvocationPer1x2Pixels = 7,
		OneInvocationPer2x2Pixels = 8,
		OneInvocationPer4x2Pixels = 9,
		OneInvocationPer2x4Pixels = 10,
		OneInvocationPer4x4Pixels = 11,
	}

	public enum VkCoarseSampleOrderTypeNV
	{
		Default = 0,
		Custom = 1,
		PixelMajor = 2,
		SampleMajor = 3,
	}

	public enum VkCopyAccelerationStructureModeKHR
	{
		Clone = 0,
		Compact = 1,
		Serialize = 2,
		Deserialize = 3,
	}

	public enum VkBuildAccelerationStructureModeKHR
	{
		Build = 0,
		Update = 1,
	}

	public enum VkAccelerationStructureTypeKHR
	{
		TopLevel = 0,
		BottomLevel = 1,
		Generic = 2,
	}

	public enum VkGeometryTypeKHR
	{
		Triangles = 0,
		Aabbs = 1,
		Instances = 2,
	}

	public enum VkAccelerationStructureMemoryRequirementsTypeNV
	{
		Object = 0,
		BuildScratch = 1,
		UpdateScratch = 2,
	}

	public enum VkAccelerationStructureBuildTypeKHR
	{
		Host = 0,
		Device = 1,
		HostOrDevice = 2,
	}

	public enum VkRayTracingShaderGroupTypeKHR
	{
		General = 0,
		TrianglesHitGroup = 1,
		ProceduralHitGroup = 2,
	}

	public enum VkAccelerationStructureCompatibilityKHR
	{
		Compatible = 0,
		Incompatible = 1,
	}

	public enum VkShaderGroupShaderKHR
	{
		General = 0,
		ClosestHit = 1,
		AnyHit = 2,
		Intersection = 3,
	}

	public enum VkMemoryOverallocationBehaviorAMD
	{
		DefaultAMD = 0,
		AllowedAMD = 1,
		DisallowedAMD = 2,
	}

	public enum VkScopeNV
	{
		ScopeDevice = 1,
		ScopeWorkgroup = 2,
		ScopeSubgroup = 3,
		ScopeQueueFamily = 5,
	}

	public enum VkComponentTypeNV
	{
		TypeFloat16 = 0,
		TypeFloat32 = 1,
		TypeFloat64 = 2,
		TypeSint8 = 3,
		TypeSint16 = 4,
		TypeSint32 = 5,
		TypeSint64 = 6,
		TypeUint8 = 7,
		TypeUint16 = 8,
		TypeUint32 = 9,
		TypeUint64 = 10,
	}

	public enum VkFullScreenExclusiveEXT
	{
		Default = 0,
		Allowed = 1,
		Disallowed = 2,
		ApplicationControlled = 3,
	}

	public enum VkPerformanceCounterScopeKHR
	{
		CommandBuffer = 0,
		RenderPass = 1,
		Command = 2,
	}

	public enum VkPerformanceCounterUnitKHR
	{
		Generic = 0,
		Percentage = 1,
		Nanoseconds = 2,
		Bytes = 3,
		BytesPerSecond = 4,
		Kelvin = 5,
		Watts = 6,
		Volts = 7,
		Amps = 8,
		Hertz = 9,
		Cycles = 10,
	}

	public enum VkPerformanceCounterStorageKHR
	{
		Int32 = 0,
		Int64 = 1,
		Uint32 = 2,
		Uint64 = 3,
		Float32 = 4,
		Float64 = 5,
	}

	public enum VkPerformanceConfigurationTypeINTEL
	{
		CommandQueueMetricsDiscoveryActivatedIntel = 0,
	}

	public enum VkQueryPoolSamplingModeINTEL
	{
		ModeManualINTEL = 0,
	}

	public enum VkPerformanceOverrideTypeINTEL
	{
		TypeNullHardwareINTEL = 0,
		TypeFlushGpuCachesINTEL = 1,
	}

	public enum VkPerformanceParameterTypeINTEL
	{
		TypeHwCountersSupportedINTEL = 0,
		TypeStreamMarkerValidBitsINTEL = 1,
	}

	public enum VkPerformanceValueTypeINTEL
	{
		TypeUint32INTEL = 0,
		TypeUint64INTEL = 1,
		TypeFloatINTEL = 2,
		TypeBoolINTEL = 3,
		TypeStringINTEL = 4,
	}

	public enum VkShaderFloatControlsIndependence
	{
		_32Only = 0,
		All = 1,
		None = 2,
	}

	public enum VkPipelineExecutableStatisticFormatKHR
	{
		Bool32 = 0,
		Int64 = 1,
		Uint64 = 2,
		Float64 = 3,
	}

	public enum VkLineRasterizationModeEXT
	{
		Default = 0,
		Rectangular = 1,
		Bresenham = 2,
		RectangularSmooth = 3,
	}

	public enum VkFragmentShadingRateCombinerOpKHR
	{
		Keep = 0,
		Replace = 1,
		Min = 2,
		Max = 3,
		Mul = 4,
	}

	public enum VkFragmentShadingRateNV
	{
		OneInvocationPerPixel = 0,
		OneInvocationPer1x2Pixels = 1,
		OneInvocationPer2x1Pixels = 4,
		OneInvocationPer2x2Pixels = 5,
		OneInvocationPer2x4Pixels = 6,
		OneInvocationPer4x2Pixels = 9,
		OneInvocationPer4x4Pixels = 10,
		TwoInvocationsPerPixel = 11,
		FourInvocationsPerPixel = 12,
		EightInvocationsPerPixel = 13,
		SixteenInvocationsPerPixel = 14,
		NoInvocations = 15,
	}

	public enum VkFragmentShadingRateTypeNV
	{
		TypeFragmentSize = 0,
		TypeEnums = 1,
	}

}