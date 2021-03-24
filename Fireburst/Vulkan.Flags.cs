using System;

namespace Fireburst
{
	[Flags]
	public enum VkPipelineCacheCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkQueueFlags
	{
		None = 0,
		Graphics = 1,
		Compute = 2,
		Transfer = 4,
		SparseBinding = 8,
		Reserved6KHR = 1000023064,
		Reserved5KHR = 1000024032,
	}

	[Flags]
	public enum VkCullModeFlags
	{
		None = 0,
		Front = 1,
		Back = 2,
		FrontAndBack = 0x00000003,
	}

	[Flags]
	public enum VkRenderPassCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkDeviceQueueCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkMemoryPropertyFlags
	{
		None = 0,
		DeviceLocal = 1,
		HostVisible = 2,
		HostCoherent = 4,
		HostCached = 8,
		LazilyAllocated = 16,
		DeviceCoherentAMD = 1000229064,
		DeviceUncachedAMD = 1000229128,
	}

	[Flags]
	public enum VkMemoryHeapFlags
	{
		None = 0,
		DeviceLocal = 1,
		Reserved2KHR = 1000308004,
	}

	[Flags]
	public enum VkAccessFlags
	{
		None = 0,
		IndirectCommandRead = 1,
		IndexRead = 2,
		VertexAttributeRead = 4,
		UniformRead = 8,
		InputAttachmentRead = 16,
		ShaderRead = 32,
		ShaderWrite = 64,
		ColorAttachmentRead = 128,
		ColorAttachmentWrite = 256,
		DepthStencilAttachmentRead = 512,
		DepthStencilAttachmentWrite = 1024,
		TransferRead = 2048,
		TransferWrite = 4096,
		HostRead = 8192,
		HostWrite = 16384,
		MemoryRead = 32768,
		MemoryWrite = 65536,
		TransformFeedbackWriteEXT = 1033582432,
		TransformFeedbackCounterReadEXT = 1067136864,
		TransformFeedbackCounterWriteEXT = 1134245728,
		ConditionalRenderingReadEXT = 1001129576,
		ColorAttachmentReadNoncoherentEXT = 1000672288,
		AccelerationStructureReadKHR = 1002247152,
		AccelerationStructureWriteKHR = 1004344304,
		ShadingRateImageReadNV = 1008552608,
		FragmentDensityMapReadEXT = 1016995216,
		CommandPreprocessReadNV = 1000408072,
		CommandPreprocessWriteNV = 1000539144,
	}

	[Flags]
	public enum VkBufferUsageFlags
	{
		None = 0,
		TransferSrc = 1,
		TransferDst = 2,
		UniformTexelBuffer = 4,
		StorageTexelBuffer = 8,
		UniformBuffer = 16,
		StorageBuffer = 32,
		IndexBuffer = 64,
		VertexBuffer = 128,
		IndirectBuffer = 256,
		Reserved15KHR = 1000055768,
		Reserved16KHR = 1000088536,
		Reserved13KHR = 1000032192,
		Reserved14KHR = 1000040384,
		TransformFeedbackBufferEXT = 1000030048,
		TransformFeedbackCounterBufferEXT = 1000032096,
		ConditionalRenderingEXT = 1000081512,
		AccelerationStructureBuildInputReadOnlyKHR = 1000674288,
		AccelerationStructureStorageKHR = 1001198576,
		ShaderBindingTableKHR = 1000348024,
		Reserved18Qcom = 1000434144,
	}

	[Flags]
	public enum VkBufferCreateFlags
	{
		None = 0,
		SparseBinding = 1,
		SparseResidency = 2,
		SparseAliased = 4,
		Reserved5NV = 1000371032,
	}

	[Flags]
	public enum VkShaderStageFlags
	{
		None = 0,
		Vertex = 1,
		TessellationControl = 2,
		TessellationEvaluation = 4,
		Geometry = 8,
		Fragment = 16,
		Compute = 32,
		AllGraphics = 0x0000001F,
		All = 0x7FFFFFFF,
		RaygenKHR = 1000347256,
		AnyHitKHR = 1000347512,
		ClosestHitKHR = 1000348024,
		MissKHR = 1000349048,
		IntersectionKHR = 1000351096,
		CallableKHR = 1000355192,
		TaskNV = 1000202064,
		MeshNV = 1000202128,
	}

	[Flags]
	public enum VkImageUsageFlags
	{
		None = 0,
		TransferSrc = 1,
		TransferDst = 2,
		Sampled = 4,
		Storage = 8,
		ColorAttachment = 16,
		DepthStencilAttachment = 32,
		TransientAttachment = 64,
		InputAttachment = 128,
		Reserved13KHR = 1000031192,
		Reserved14KHR = 1000039384,
		Reserved15KHR = 1000055768,
		Reserved10KHR = 1000025024,
		Reserved11KHR = 1000026048,
		Reserved12KHR = 1000028096,
		ShadingRateImageNV = 1000164256,
		Reserved16Qcom = 1000237536,
		Reserved17Qcom = 1000303072,
		FragmentDensityMapEXT = 1000218512,
	}

	[Flags]
	public enum VkImageCreateFlags
	{
		None = 0,
		SparseBinding = 1,
		SparseResidency = 2,
		SparseAliased = 4,
		MutableFormat = 8,
		CubeCompatible = 16,
		CornerSampledNV = 1000058192,
		SampleLocationsCompatibleDepthEXT = 1000147096,
		SubsampledEXT = 1000234384,
		Reserved15NV = 1000403768,
	}

	[Flags]
	public enum VkImageViewCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkSamplerCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkPipelineCreateFlags
	{
		None = 0,
		DisableOptimization = 1,
		AllowDerivatives = 2,
		Derivative = 4,
		RayTracingNoNullAnyHitShadersKHR = 1000363384,
		RayTracingNoNullClosestHitShadersKHR = 1000379768,
		RayTracingNoNullMissShadersKHR = 1000412536,
		RayTracingNoNullIntersectionShadersKHR = 1000478072,
		RayTracingSkipTrianglesKHR = 1000351096,
		RayTracingSkipAabbsKHR = 1000355192,
		RayTracingShaderGroupHandleCaptureReplayKHR = 1000871288,
		DeferCompileNV = 1000165032,
		CaptureStatisticsKHR = 1000269064,
		CaptureInternalRepresentationsKHR = 1000269128,
		IndirectBindableNV = 1000539144,
		LibraryKHR = 1000292048,
		FailOnPipelineCompileRequiredEXT = 1000297256,
		EarlyReturnOnFailureEXT = 1000297512,
		Reserved20NV = 1001375576,
	}

	[Flags]
	public enum VkPipelineShaderStageCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkColorComponentFlags
	{
		None = 0,
		R = 1,
		G = 2,
		B = 4,
		A = 8,
		All = R | G | B | A
	}

	[Flags]
	public enum VkFenceCreateFlags
	{
		None = 0,
		Signaled = 1,
	}

	[Flags]
	public enum VkFormatFeatureFlags
	{
		None = 0,
		SampledImage = 1,
		StorageImage = 2,
		StorageImageAtomic = 4,
		UniformTexelBuffer = 8,
		StorageTexelBuffer = 16,
		StorageTexelBufferAtomic = 32,
		VertexBuffer = 64,
		ColorAttachment = 128,
		ColorAttachmentBlend = 256,
		DepthStencilAttachment = 512,
		BlitSrc = 1024,
		BlitDst = 2048,
		SampledImageFilterLinear = 4096,
		SampledImageFilterCubicImg = 1000023192,
		Reserved27KHR = 1134240728,
		Reserved28KHR = 1268458456,
		Reserved25KHR = 1033578432,
		Reserved26KHR = 1067132864,
		AccelerationStructureVertexBufferKHR = 1537020912,
		FragmentDensityMapEXT = 1016995216,
		FragmentShadingRateAttachmentKHR = 2073967824,
	}

	[Flags]
	public enum VkQueryControlFlags
	{
		None = 0,
		Precise = 1,
	}

	[Flags]
	public enum VkQueryResultFlags
	{
		None = 0,
		_64 = 1,
		Wait = 2,
		WithAvailability = 4,
		Partial = 8,
	}

	[Flags]
	public enum VkCommandBufferUsageFlags
	{
		None = 0,
		OneTimeSubmit = 1,
		RenderPassContinue = 2,
		SimultaneousUse = 4,
	}

	[Flags]
	public enum VkQueryPipelineStatisticFlags
	{
		None = 0,
		InputAssemblyVertices = 1,
		InputAssemblyPrimitives = 2,
		VertexShaderInvocations = 4,
		GeometryShaderInvocations = 8,
		GeometryShaderPrimitives = 16,
		ClippingInvocations = 32,
		ClippingPrimitives = 64,
		FragmentShaderInvocations = 128,
		TessellationControlShaderPatches = 256,
		TessellationEvaluationShaderInvocations = 512,
		ComputeShaderInvocations = 1024,
	}

	[Flags]
	public enum VkImageAspectFlags
	{
		None = 0,
		Color = 1,
		Depth = 2,
		Stencil = 4,
		Metadata = 8,
		MemoryPlane0EXT = 1000158128,
		MemoryPlane1EXT = 1000158256,
		MemoryPlane2EXT = 1000158512,
		MemoryPlane3EXT = 1000159024,
	}

	[Flags]
	public enum VkSparseImageFormatFlags
	{
		None = 0,
		SingleMiptail = 1,
		AlignedMipSize = 2,
		NonstandardBlockSize = 4,
	}

	[Flags]
	public enum VkSparseMemoryBindFlags
	{
		None = 0,
		Metadata = 1,
	}

	[Flags]
	public enum VkPipelineStageFlags
	{
		None = 0,
		TopOfPipe = 1,
		DrawIndirect = 2,
		VertexInput = 4,
		VertexShader = 8,
		TessellationControlShader = 16,
		TessellationEvaluationShader = 32,
		GeometryShader = 64,
		FragmentShader = 128,
		EarlyFragmentTests = 256,
		LateFragmentTests = 512,
		ColorAttachmentOutput = 1024,
		ComputeShader = 2048,
		Transfer = 4096,
		BottomOfPipe = 8192,
		Host = 16384,
		AllGraphics = 32768,
		AllCommands = 65536,
		TransformFeedbackEXT = 1016805216,
		ConditionalRenderingEXT = 1000343144,
		AccelerationStructureBuildKHR = 1033704432,
		RayTracingShaderKHR = 1002444152,
		ShadingRateImageNV = 1004358304,
		TaskShaderNV = 1000726288,
		MeshShaderNV = 1001250576,
		FragmentDensityProcessEXT = 1008606608,
		CommandPreprocessNV = 1000408072,
	}

	[Flags]
	public enum VkCommandPoolCreateFlags
	{
		None = 0,
		Transient = 1,
		ResetCommandBuffer = 2,
	}

	[Flags]
	public enum VkCommandPoolResetFlags
	{
		None = 0,
		ReleaseResources = 1,
	}

	[Flags]
	public enum VkCommandBufferResetFlags
	{
		None = 0,
		ReleaseResources = 1,
	}

	[Flags]
	public enum VkSampleCountFlags
	{
		None = 0,
		Count1 = 1,
		Count2 = 2,
		Count4 = 4,
		Count8 = 8,
		Count16 = 16,
		Count32 = 32,
		Count64 = 64,
	}

	[Flags]
	public enum VkAttachmentDescriptionFlags
	{
		None = 0,
		MayAlias = 1,
	}

	[Flags]
	public enum VkStencilFaceFlags
	{
		None = 0,
		Front = 1,
		Back = 2,
		FrontAndBack = 0x00000003,
	}

	[Flags]
	public enum VkDescriptorPoolCreateFlags
	{
		None = 0,
		FreeDescriptorSet = 1,
		HostOnlyValve = 1000351004,
	}

	[Flags]
	public enum VkDependencyFlags
	{
		None = 0,
		ByRegion = 1,
	}

	[Flags]
	public enum VkSemaphoreWaitFlags
	{
		None = 0,
		Any = 1,
	}

	[Flags]
	public enum VkDisplayPlaneAlphaFlagsKHR
	{
		None = 0,
		Opaque = 1,
		Global = 2,
		PerPixel = 4,
		PerPixelPremultiplied = 8,
	}

	[Flags]
	public enum VkCompositeAlphaFlagsKHR
	{
		None = 0,
		Opaque = 1,
		PreMultiplied = 2,
		PostMultiplied = 4,
		Inherit = 8,
	}

	[Flags]
	public enum VkSurfaceTransformFlagsKHR
	{
		None = 0,
		Identity = 1,
		Rotate90 = 2,
		Rotate180 = 4,
		Rotate270 = 8,
		HorizontalMirror = 16,
		HorizontalMirrorRotate90 = 32,
		HorizontalMirrorRotate180 = 64,
		HorizontalMirrorRotate270 = 128,
		Inherit = 256,
	}

	[Flags]
	public enum VkSwapchainImageUsageFlagsANDROID
	{
		None = 0,
		SharedAndroid = 1,
	}

	[Flags]
	public enum VkDebugReportFlagsEXT
	{
		None = 0,
		Information = 1,
		Warning = 2,
		PerformanceWarning = 4,
		Error = 8,
		Debug = 16,
	}

	[Flags]
	public enum VkExternalMemoryHandleTypeFlagsNV
	{
		None = 0,
		OpaqueWin32 = 1,
		OpaqueWin32Kmt = 2,
		D3d11Image = 4,
		D3d11ImageKmt = 8,
	}

	[Flags]
	public enum VkExternalMemoryFeatureFlagsNV
	{
		None = 0,
		DedicatedOnly = 1,
		Exportable = 2,
		Importable = 4,
	}

	[Flags]
	public enum VkSubgroupFeatureFlags
	{
		None = 0,
		Basic = 1,
		Vote = 2,
		Arithmetic = 4,
		Ballot = 8,
		Shuffle = 16,
		ShuffleRelative = 32,
		Clustered = 64,
		Quad = 128,
		PartitionedNV = 1000198256,
	}

	[Flags]
	public enum VkIndirectCommandsLayoutUsageFlagsNV
	{
		None = 0,
		ExplicitPreprocess = 1,
		IndexedSequences = 2,
		UnorderedSequences = 4,
	}

	[Flags]
	public enum VkIndirectStateFlagsNV
	{
		None = 0,
		FlagFrontface = 1,
	}

	[Flags]
	public enum VkPrivateDataSlotCreateFlagsEXT
	{
		None = 0
	}

	[Flags]
	public enum VkDescriptorSetLayoutCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkExternalMemoryHandleTypeFlags
	{
		None = 0,
		OpaqueFd = 1,
		OpaqueWin32 = 2,
		OpaqueWin32Kmt = 4,
		D3d11Texture = 8,
		D3d11TextureKmt = 16,
		D3d12Heap = 32,
		D3d12Resource = 64,
		DmaBufEXT = 1000125512,
		AndroidHardwareBufferAndroid = 1000130024,
		HostAllocationEXT = 1000178128,
		HostMappedForeignMemoryEXT = 1000178256,
		ZirconVmoFuchsia = 1000366048,
	}

	[Flags]
	public enum VkExternalMemoryFeatureFlags
	{
		None = 0,
		DedicatedOnly = 1,
		Exportable = 2,
		Importable = 4,
	}

	[Flags]
	public enum VkExternalSemaphoreHandleTypeFlags
	{
		None = 0,
		OpaqueFd = 1,
		OpaqueWin32 = 2,
		OpaqueWin32Kmt = 4,
		D3d12Fence = 8,
		SyncFd = 16,
		ZirconEventFuchsia = 1000365128,
		Reserved5NV = 1000374032,
		Reserved6NV = 1000374064,
	}

	[Flags]
	public enum VkExternalSemaphoreFeatureFlags
	{
		None = 0,
		Exportable = 1,
		Importable = 2,
	}

	[Flags]
	public enum VkSemaphoreImportFlags
	{
		None = 0,
		Temporary = 1,
	}

	[Flags]
	public enum VkExternalFenceHandleTypeFlags
	{
		None = 0,
		OpaqueFd = 1,
		OpaqueWin32 = 2,
		OpaqueWin32Kmt = 4,
		SyncFd = 8,
		Reserved4NV = 1000373016,
		Reserved5NV = 1000373032,
	}

	[Flags]
	public enum VkExternalFenceFeatureFlags
	{
		None = 0,
		Exportable = 1,
		Importable = 2,
	}

	[Flags]
	public enum VkFenceImportFlags
	{
		None = 0,
		Temporary = 1,
	}

	[Flags]
	public enum VkSurfaceCounterFlagsEXT
	{
		None = 0,
		Vblank = 1,
	}

	[Flags]
	public enum VkPeerMemoryFeatureFlags
	{
		None = 0,
		CopySrc = 1,
		CopyDst = 2,
		GenericSrc = 4,
		GenericDst = 8,
	}

	[Flags]
	public enum VkMemoryAllocateFlags
	{
		None = 0,
		DeviceMask = 1,
	}

	[Flags]
	public enum VkDeviceGroupPresentModeFlagsKHR
	{
		None = 0,
		Local = 1,
		Remote = 2,
		Sum = 4,
		LocalMultiDevice = 8,
	}

	[Flags]
	public enum VkSwapchainCreateFlagsKHR
	{
		None = 0
	}

	[Flags]
	public enum VkSubpassDescriptionFlags
	{
		None = 0
	}

	[Flags]
	public enum VkDebugUtilsMessageSeverityFlagsEXT
	{
		None = 0,
		Verbose = 1,
		Info = 16,
		Warning = 256,
		Error = 4096,
	}

	[Flags]
	public enum VkDebugUtilsMessageTypeFlagsEXT
	{
		None = 0,
		General = 1,
		Validation = 2,
		Performance = 4,
	}

	[Flags]
	public enum VkDescriptorBindingFlags
	{
		None = 0,
		UpdateAfterBind = 1,
		UpdateUnusedWhilePending = 2,
		PartiallyBound = 4,
		VariableDescriptorCount = 8,
		Reserved4Qcom = 1000368016,
	}

	[Flags]
	public enum VkConditionalRenderingFlagsEXT
	{
		None = 0,
		Inverted = 1,
	}

	[Flags]
	public enum VkResolveModeFlags
	{
		None = 0,
		SampleZero = 1,
		Average = 2,
		Min = 4,
		Max = 8,
	}

	[Flags]
	public enum VkGeometryInstanceFlagsKHR
	{
		None = 0,
		TriangleFacingCullDisable = 1,
		TriangleFrontCounterclockwise = 2,
		ForceOpaque = 4,
		ForceNoOpaque = 8,
	}

	[Flags]
	public enum VkGeometryFlagsKHR
	{
		None = 0,
		Opaque = 1,
		NoDuplicateAnyHitInvocation = 2,
	}

	[Flags]
	public enum VkBuildAccelerationStructureFlagsKHR
	{
		None = 0,
		AllowUpdate = 1,
		AllowCompaction = 2,
		PreferFastTrace = 4,
		PreferFastBuild = 8,
		LowMemory = 16,
		Reserved5NV = 1000327032,
	}

	[Flags]
	public enum VkAccelerationStructureCreateFlagsKHR
	{
		None = 0,
		DeviceAddressCaptureReplay = 1,
		Reserved2NV = 1000327004,
	}

	[Flags]
	public enum VkFramebufferCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkDeviceDiagnosticsConfigFlagsNV
	{
		None = 0,
		EnableShaderDebugInfo = 1,
		EnableResourceTracking = 2,
		EnableAutomaticCheckpoints = 4,
	}

	[Flags]
	public enum VkPipelineCreationFeedbackFlagsEXT
	{
		None = 0,
		Valid = 1,
		ApplicationPipelineCacheHit = 2,
		BasePipelineAcceleration = 4,
	}

	[Flags]
	public enum VkPerformanceCounterDescriptionFlagsKHR
	{
		None = 0,
		PerformanceImpacting = 1,
		ConcurrentlyImpacted = 2,
	}

	[Flags]
	public enum VkAcquireProfilingLockFlagsKHR
	{
		None = 0
	}

	[Flags]
	public enum VkShaderCorePropertiesFlagsAMD
	{
		None = 0
	}

	[Flags]
	public enum VkShaderModuleCreateFlags
	{
		None = 0
	}

	[Flags]
	public enum VkPipelineCompilerControlFlagsAMD
	{
		None = 0
	}

	[Flags]
	public enum VkToolPurposeFlagsEXT
	{
		None = 0,
		Validation = 1,
		Profiling = 2,
		Tracing = 4,
		AdditionalFeatures = 8,
		ModifyingFeatures = 16,
		DebugReportingEXT = 1000245032,
		DebugMarkersEXT = 1000245064,
	}

	[Flags]
	public enum VkAccessFlags2KHR : long
	{
		None = 0,
		IndirectCommandRead = 1,
		IndexRead = 2,
		VertexAttributeRead = 4,
		UniformRead = 8,
		InputAttachmentRead = 16,
		ShaderRead = 32,
		ShaderWrite = 64,
		ColorAttachmentRead = 128,
		ColorAttachmentWrite = 256,
		DepthStencilAttachmentRead = 512,
		DepthStencilAttachmentWrite = 1024,
		TransferRead = 2048,
		TransferWrite = 4096,
		HostRead = 8192,
		HostWrite = 16384,
		MemoryRead = 32768,
		MemoryWrite = 65536,
		ShaderSampledRead = 4294967296,
		ShaderStorageRead = 8589934592,
		ShaderStorageWrite = 17179869184,
		ReservedRead35KHR = 1000023008,
		ReservedWrite36KHR = 1000023016,
		ReservedRead37KHR = 1000024032,
		ReservedWrite38KHR = 1000024064,
		TransformFeedbackWriteEXT = 1033868432,
		TransformFeedbackCounterReadEXT = 1067422864,
		TransformFeedbackCounterWriteEXT = 1134531728,
		ConditionalRenderingReadEXT = 1001362576,
		CommandPreprocessReadNV = 1000445072,
		CommandPreprocessWriteNV = 1000576144,
		FragmentShadingRateAttachmentReadKHR = 1008702608,
		AccelerationStructureReadKHR = 1002411152,
		AccelerationStructureWriteKHR = 1004508304,
		FragmentDensityMapReadEXT = 1017091216,
		ColorAttachmentReadNoncoherentEXT = 1000838288,
	}

	[Flags]
	public enum VkPipelineStageFlags2KHR : long
	{
		None = 0,
		TopOfPipe = 1,
		DrawIndirect = 2,
		VertexInput = 4,
		VertexShader = 8,
		TessellationControlShader = 16,
		TessellationEvaluationShader = 32,
		GeometryShader = 64,
		FragmentShader = 128,
		EarlyFragmentTests = 256,
		LateFragmentTests = 512,
		ColorAttachmentOutput = 1024,
		ComputeShader = 2048,
		AllTransfer = 4096,
		BottomOfPipe = 8192,
		Host = 16384,
		AllGraphics = 32768,
		AllCommands = 65536,
		Copy = 4294967296,
		Resolve = 8589934592,
		Blit = 17179869184,
		Clear = 34359738368,
		IndexInput = 68719476736,
		VertexAttributeInput = 137438953472,
		PreRasterizationShaders = 274877906944,
		Reserved26KHR = 1067131864,
		Reserved27KHR = 1134241728,
		TransformFeedbackEXT = 1017091216,
		ConditionalRenderingEXT = 1000576144,
		CommandPreprocessNV = 1000445072,
		FragmentShadingRateAttachmentKHR = 1004508304,
		AccelerationStructureBuildKHR = 1033868432,
		RayTracingShaderKHR = 1002411152,
		FragmentDensityProcessEXT = 1008702608,
		TaskShaderNV = 1000838288,
		MeshShaderNV = 1001362576,
	}

	[Flags]
	public enum VkSubmitFlagsKHR
	{
		None = 0,
		Protected = 1,
	}

	[Flags]
	public enum VkEventCreateFlags
	{
		None = 0
	}

}