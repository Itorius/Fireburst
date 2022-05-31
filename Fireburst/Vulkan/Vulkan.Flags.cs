// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable PartialTypeWithSinglePart

using System;

namespace Fireburst;
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
	VideoDecodeKHR = 1000024032,
	VideoEncodeKHR = 1000299064,
	Reserved7Qcom = 1000439128,
	Reserved8NV = 1000464256,
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
	RdmaCapableNV = 1000371256,
}

[Flags]
public enum VkMemoryHeapFlags
{
	None = 0,
	DeviceLocal = 1,
	Reserved2KHR = 1000298004,
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
	FragmentDensityMapReadEXT = 1016995216,
	FragmentShadingRateAttachmentReadKHR = 1008614608,
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
	VideoDecodeSrcKHR = 1000032192,
	VideoDecodeDstKHR = 1000040384,
	TransformFeedbackBufferEXT = 1000030048,
	TransformFeedbackCounterBufferEXT = 1000032096,
	ConditionalRenderingEXT = 1000081512,
	AccelerationStructureBuildInputReadOnlyKHR = 1000674288,
	AccelerationStructureStorageKHR = 1001198576,
	ShaderBindingTableKHR = 1000348024,
	Reserved18Qcom = 1000434144,
	VideoEncodeDstKHR = 1000331768,
	VideoEncodeSrcKHR = 1000364536,
	Reserved21AMD = 1002413152,
	Reserved22AMD = 1004510304,
	Reserved23NV = 1008784608,
	Reserved24NV = 1017173216,
}

[Flags]
public enum VkBufferCreateFlags
{
	None = 0,
	SparseBinding = 1,
	SparseResidency = 2,
	SparseAliased = 4,
	Reserved5AMD = 1000316032,
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
	SubpassShadingHuawei = 1000385384,
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
	VideoDecodeDstKHR = 1000025024,
	VideoDecodeSrcKHR = 1000026048,
	VideoDecodeDpbKHR = 1000028096,
	Reserved16Qcom = 1000237536,
	Reserved17Qcom = 1000303072,
	FragmentDensityMapEXT = 1000218512,
	FragmentShadingRateAttachmentKHR = 1000226256,
	Reserved22EXT = 1004464304,
	VideoEncodeDstKHR = 1000307192,
	VideoEncodeSrcKHR = 1000315384,
	VideoEncodeDpbKHR = 1000331768,
	Reserved19EXT = 1000863288,
	InvocationMaskHuawei = 1000632144,
	Reserved20Qcom = 1001488576,
	Reserved21Qcom = 1002537152,
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
	Reserved16AMD = 1000381536,
	Reserved18EXT = 1000638144,
	_2dViewCompatibleEXT = 1000524072,
	FragmentDensityMapOffsetQcom = 1000457768,
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
	RenderingFragmentShadingRateAttachmentKHR = 1002141152,
	RenderingFragmentDensityMapAttachmentEXT = 1004238304,
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
	RetainLinkTimeOptimizationInfoEXT = 1008708608,
	LinkTimeOptimizationEXT = 1000321024,
	RayTracingAllowMotionNV = 1001375576,
	Reserved24NV = 1017173216,
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
public enum VkSemaphoreCreateFlags
{
	None = 0
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
	VideoDecodeOutputKHR = 1033578432,
	VideoDecodeDpbKHR = 1067132864,
	AccelerationStructureVertexBufferKHR = 1537020912,
	FragmentDensityMapEXT = 1016995216,
	FragmentShadingRateAttachmentKHR = 2073967824,
	VideoEncodeInputKHR = 1134516728,
	VideoEncodeDpbKHR = 1268734456,
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
	WithStatusKHR = 1000023016,
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
	TaskShaderNV = 1000726288,
	MeshShaderNV = 1001250576,
	FragmentDensityProcessEXT = 1008606608,
	FragmentShadingRateAttachmentKHR = 1004420304,
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
	Reserved1Coreavi = 1000443002,
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
public enum VkPrivateDataSlotCreateFlags
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
	RdmaAddressNV = 1000375096,
	Reserved13NV = 1000382192,
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
	Reserved5NV = 1000373032,
	Reserved6NV = 1000373064,
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
	TriangleFlipFacing = 2,
	ForceOpaque = 4,
	ForceNoOpaque = 8,
	Reserved4NV = 1000396016,
	Reserved5NV = 1000396032,
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
	MotionNV = 1000327032,
	Reserved6NV = 1000396064,
	Reserved7NV = 1000396128,
}

[Flags]
public enum VkAccelerationStructureCreateFlagsKHR
{
	None = 0,
	DeviceAddressCaptureReplay = 1,
	MotionNV = 1000327004,
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
public enum VkPipelineCreationFeedbackFlags
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
public enum VkToolPurposeFlags
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
public enum VkAccessFlags2 : long
{
	VK_ACCESS_2_NONE = 0,
	VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT = 1,
	VK_ACCESS_2_INDEX_READ_BIT = 2,
	VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT = 4,
	VK_ACCESS_2_UNIFORM_READ_BIT = 8,
	VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT = 16,
	VK_ACCESS_2_SHADER_READ_BIT = 32,
	VK_ACCESS_2_SHADER_WRITE_BIT = 64,
	VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT = 128,
	VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT = 256,
	VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT = 512,
	VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = 1024,
	VK_ACCESS_2_TRANSFER_READ_BIT = 2048,
	VK_ACCESS_2_TRANSFER_WRITE_BIT = 4096,
	VK_ACCESS_2_HOST_READ_BIT = 8192,
	VK_ACCESS_2_HOST_WRITE_BIT = 16384,
	VK_ACCESS_2_MEMORY_READ_BIT = 32768,
	VK_ACCESS_2_MEMORY_WRITE_BIT = 65536,
	VK_ACCESS_2_SHADER_SAMPLED_READ_BIT = 4294967296,
	VK_ACCESS_2_SHADER_STORAGE_READ_BIT = 8589934592,
	VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT = 17179869184,
	VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR = 1000024008,
	VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR = 1000024016,
	VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR = 1000299032,
	VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR = 1000299064,
	VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = 1033868432,
	VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = 1067422864,
	VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = 1134531728,
	VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT = 1001362576,
	VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV = 1000445072,
	VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV = 1000576144,
	VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 1008702608,
	VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR = 1002411152,
	VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = 1004508304,
	VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = 1017091216,
	VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = 1000838288,
	VK_ACCESS_2_RESERVED_41_BIT_AMD = 1000316512,
	VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI = 1000370128,
	VK_ACCESS_2_RESERVED_387_BIT_KHR = 1000386256,
	VK_ACCESS_2_RESERVED_44_BIT_NV = 1000400096,
	VK_ACCESS_2_RESERVED_45_BIT_NV = 1000404192,
	VK_ACCESS_2_RESERVED_42_BIT_NV = 1000465024,
	VK_ACCESS_2_RESERVED_43_BIT_NV = 1000466048,
}

[Flags]
public enum VkPipelineStageFlags2 : long
{
	VK_PIPELINE_STAGE_2_NONE = 0,
	VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT = 1,
	VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT = 2,
	VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT = 4,
	VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT = 8,
	VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT = 16,
	VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT = 32,
	VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT = 64,
	VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT = 128,
	VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT = 256,
	VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT = 512,
	VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT = 1024,
	VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT = 2048,
	VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT = 4096,
	VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT = 8192,
	VK_PIPELINE_STAGE_2_HOST_BIT = 16384,
	VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT = 32768,
	VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT = 65536,
	VK_PIPELINE_STAGE_2_COPY_BIT = 4294967296,
	VK_PIPELINE_STAGE_2_RESOLVE_BIT = 8589934592,
	VK_PIPELINE_STAGE_2_BLIT_BIT = 17179869184,
	VK_PIPELINE_STAGE_2_CLEAR_BIT = 34359738368,
	VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT = 68719476736,
	VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT = 137438953472,
	VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT = 274877906944,
	VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR = 1067132864,
	VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR = 1134516728,
	VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT = 1017091216,
	VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 1000576144,
	VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV = 1000445072,
	VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 1004508304,
	VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 1033868432,
	VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR = 1002411152,
	VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 1008702608,
	VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV = 1000838288,
	VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV = 1001362576,
	VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI = 1000369128,
	VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI = 1000370256,
	VK_PIPELINE_STAGE_2_RESERVED_387_BIT_KHR = 1268821456,
	VK_PIPELINE_STAGE_2_RESERVED_30_BIT_NV = 2074137824,
	VK_PIPELINE_STAGE_2_RESERVED_29_BIT_NV = 1537334912,
}

[Flags]
public enum VkSubmitFlags
{
	None = 0,
	Protected = 1,
}

[Flags]
public enum VkEventCreateFlags
{
	None = 0
}

[Flags]
public enum VkPipelineLayoutCreateFlags
{
	None = 0
}

[Flags]
public enum VkPipelineColorBlendStateCreateFlags
{
	None = 0
}

[Flags]
public enum VkPipelineDepthStencilStateCreateFlags
{
	None = 0
}

[Flags]
public enum VkGraphicsPipelineLibraryFlagsEXT
{
	None = 0,
	VertexInputInterface = 1,
	PreRasterizationShaders = 2,
	FragmentShader = 4,
	FragmentOutputInterface = 8,
}

[Flags]
public enum VkVideoCodecOperationFlagsKHR
{
	Invalid = 0,
	EncodeH264EXT = 1000103536,
	EncodeH265EXT = 1000170072,
	DecodeH264EXT = 1000040001,
	DecodeH265EXT = 1000187002,
}

[Flags]
public enum VkVideoChromaSubsamplingFlagsKHR
{
	Invalid = 0,
	Monochrome = 1,
	_420 = 2,
	_422 = 4,
	_444 = 8,
}

[Flags]
public enum VkVideoComponentBitDepthFlagsKHR
{
	Invalid = 0,
	_8 = 1,
	_10 = 4,
	_12 = 16,
}

[Flags]
public enum VkVideoCapabilityFlagsKHR
{
	None = 0,
	ProtectedContent = 1,
	SeparateReferenceImages = 2,
}

[Flags]
public enum VkVideoSessionCreateFlagsKHR
{
	Default = 0,
	ProtectedContent = 1,
}

[Flags]
public enum VkVideoCodingQualityPresetFlagsKHR
{
	None = 0,
	Normal = 1,
	Power = 2,
	Quality = 4,
}

[Flags]
public enum VkVideoDecodeH264PictureLayoutFlagsEXT
{
	VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_EXT = 0,
	VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_EXT = 1,
	VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_EXT = 2,
}

[Flags]
public enum VkVideoCodingControlFlagsKHR
{
	Default = 0,
	Reset = 1,
}

[Flags]
public enum VkVideoDecodeCapabilityFlagsKHR
{
	Default = 0,
	DpbAndOutputCoincide = 1,
	DpbAndOutputDistinct = 2,
}

[Flags]
public enum VkVideoDecodeFlagsKHR
{
	Default = 0,
	Reserved0 = 1,
}

[Flags]
public enum VkVideoEncodeFlagsKHR
{
	Default = 0,
	Reserved0 = 1,
}

[Flags]
public enum VkVideoEncodeCapabilityFlagsKHR
{
	Default = 0,
	PrecedingExternallyEncodedBytes = 1,
}

[Flags]
public enum VkVideoEncodeRateControlFlagsKHR
{
	Default = 0,
	Reserved0 = 1,
}

[Flags]
public enum VkVideoEncodeRateControlModeFlagsKHR
{
	None = 0,
	Cbr = 1,
	Vbr = 2,
}

[Flags]
public enum VkVideoEncodeH264CapabilityFlagsEXT
{
	None = 0,
	VK_VIDEO_ENCODE_H264_CAPABILITY_DIRECT_8X8_INFERENCE_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H264_CAPABILITY_SEPARATE_COLOUR_PLANE_BIT_EXT = 2,
	VK_VIDEO_ENCODE_H264_CAPABILITY_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_BIT_EXT = 4,
	VK_VIDEO_ENCODE_H264_CAPABILITY_SCALING_LISTS_BIT_EXT = 8,
	VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_EXT = 16,
	VK_VIDEO_ENCODE_H264_CAPABILITY_CHROMA_QP_OFFSET_BIT_EXT = 32,
	VK_VIDEO_ENCODE_H264_CAPABILITY_SECOND_CHROMA_QP_OFFSET_BIT_EXT = 64,
	VK_VIDEO_ENCODE_H264_CAPABILITY_PIC_INIT_QP_MINUS26_BIT_EXT = 128,
	VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_PRED_BIT_EXT = 256,
	VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_BIPRED_EXPLICIT_BIT_EXT = 512,
	VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_BIPRED_IMPLICIT_BIT_EXT = 1024,
	VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_PRED_NO_TABLE_BIT_EXT = 2048,
	VK_VIDEO_ENCODE_H264_CAPABILITY_TRANSFORM_8X8_BIT_EXT = 4096,
	VK_VIDEO_ENCODE_H264_CAPABILITY_CABAC_BIT_EXT = 8192,
	VK_VIDEO_ENCODE_H264_CAPABILITY_CAVLC_BIT_EXT = 16384,
	VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_DISABLED_BIT_EXT = 32768,
	VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_ENABLED_BIT_EXT = 65536,
	VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_PARTIAL_BIT_EXT = 131072,
	VK_VIDEO_ENCODE_H264_CAPABILITY_DISABLE_DIRECT_SPATIAL_MV_PRED_BIT_EXT = 262144,
	VK_VIDEO_ENCODE_H264_CAPABILITY_MULTIPLE_SLICE_PER_FRAME_BIT_EXT = 524288,
	VK_VIDEO_ENCODE_H264_CAPABILITY_SLICE_MB_COUNT_BIT_EXT = 1048576,
	VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_EXT = 2097152,
	VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT = 4194304,
}

[Flags]
public enum VkVideoEncodeH264InputModeFlagsEXT
{
	None = 0,
	VK_VIDEO_ENCODE_H264_INPUT_MODE_FRAME_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H264_INPUT_MODE_SLICE_BIT_EXT = 2,
	VK_VIDEO_ENCODE_H264_INPUT_MODE_NON_VCL_BIT_EXT = 4,
}

[Flags]
public enum VkVideoEncodeH264OutputModeFlagsEXT
{
	None = 0,
	VK_VIDEO_ENCODE_H264_OUTPUT_MODE_FRAME_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H264_OUTPUT_MODE_SLICE_BIT_EXT = 2,
	VK_VIDEO_ENCODE_H264_OUTPUT_MODE_NON_VCL_BIT_EXT = 4,
}

[Flags]
public enum VkVideoEncodeH264RateControlStructureFlagsEXT
{
	VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_UNKNOWN_EXT = 0,
	VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_FLAT_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_DYADIC_BIT_EXT = 2,
}

[Flags]
public enum VkImageFormatConstraintsFlagsFUCHSIA
{
	None = 0
}

[Flags]
public enum VkImageConstraintsInfoFlagsFUCHSIA
{
	None = 0,
	CpuReadRarelyFuchsia = 1,
	CpuReadOftenFuchsia = 2,
	CpuWriteRarelyFuchsia = 4,
	CpuWriteOftenFuchsia = 8,
	ProtectedOptionalFuchsia = 16,
}

[Flags]
public enum VkFormatFeatureFlags2 : long
{
	None = 0,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT = 1,
	VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT = 2,
	VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT = 4,
	VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT = 8,
	VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT = 16,
	VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 32,
	VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT = 64,
	VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT = 128,
	VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT = 256,
	VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT = 512,
	VK_FORMAT_FEATURE_2_BLIT_SRC_BIT = 1024,
	VK_FORMAT_FEATURE_2_BLIT_DST_BIT = 2048,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT = 4096,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT = 8192,
	VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT = 16384,
	VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT = 32768,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT = 65536,
	VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT = 131072,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = 262144,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = 524288,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = 1048576,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 2097152,
	VK_FORMAT_FEATURE_2_DISJOINT_BIT = 4194304,
	VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT = 8388608,
	VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT = 2147483648,
	VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT = 4294967296,
	VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT = 8589934592,
	VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR = 1033578432,
	VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR = 1067132864,
	VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = 1537020912,
	VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT = 1016995216,
	VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 2073967824,
	VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR = 1134516728,
	VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR = 1268734456,
	VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV = 1000430064,
	VK_FORMAT_FEATURE_2_RESERVED_34_BIT_QCOM = 1000440004,
	VK_FORMAT_FEATURE_2_RESERVED_35_BIT_QCOM = 1000440008,
	VK_FORMAT_FEATURE_2_RESERVED_36_BIT_QCOM = 1000440016,
	VK_FORMAT_FEATURE_2_RESERVED_37_BIT_QCOM = 1000440032,
	VK_FORMAT_FEATURE_2_RESERVED_39_BIT_EXT = 1000460128,
	VK_FORMAT_FEATURE_2_RESERVED_40_BIT_NV = 1000464256,
	VK_FORMAT_FEATURE_2_RESERVED_41_BIT_NV = 1000464512,
	VK_FORMAT_FEATURE_2_RESERVED_42_BIT_NV = 1000465024,
	VK_FORMAT_FEATURE_2_RESERVED_43_BIT_NV = 1000466048,
}

[Flags]
public enum VkRenderingFlags
{
	None = 0,
	ContentsSecondaryCommandBuffers = 1,
	Suspending = 2,
	Resuming = 4,
	Reserved3EXT = 1000465008,
}

[Flags]
public enum VkVideoEncodeH265CapabilityFlagsEXT
{
	None = 0,
	VK_VIDEO_ENCODE_H265_CAPABILITY_SEPARATE_COLOUR_PLANE_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H265_CAPABILITY_SCALING_LISTS_BIT_EXT = 2,
	VK_VIDEO_ENCODE_H265_CAPABILITY_SAMPLE_ADAPTIVE_OFFSET_ENABLED_BIT_EXT = 4,
	VK_VIDEO_ENCODE_H265_CAPABILITY_PCM_ENABLE_BIT_EXT = 8,
	VK_VIDEO_ENCODE_H265_CAPABILITY_SPS_TEMPORAL_MVP_ENABLED_BIT_EXT = 16,
	VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT = 32,
	VK_VIDEO_ENCODE_H265_CAPABILITY_INIT_QP_MINUS26_BIT_EXT = 64,
	VK_VIDEO_ENCODE_H265_CAPABILITY_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXT = 128,
	VK_VIDEO_ENCODE_H265_CAPABILITY_SIGN_DATA_HIDING_ENABLED_BIT_EXT = 256,
	VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSFORM_SKIP_ENABLED_BIT_EXT = 512,
	VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSFORM_SKIP_DISABLED_BIT_EXT = 1024,
	VK_VIDEO_ENCODE_H265_CAPABILITY_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_BIT_EXT = 2048,
	VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_PRED_BIT_EXT = 4096,
	VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_BIPRED_BIT_EXT = 8192,
	VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_PRED_NO_TABLE_BIT_EXT = 16384,
	VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSQUANT_BYPASS_ENABLED_BIT_EXT = 32768,
	VK_VIDEO_ENCODE_H265_CAPABILITY_ENTROPY_CODING_SYNC_ENABLED_BIT_EXT = 65536,
	VK_VIDEO_ENCODE_H265_CAPABILITY_DEBLOCKING_FILTER_OVERRIDE_ENABLED_BIT_EXT = 131072,
	VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILE_PER_FRAME_BIT_EXT = 262144,
	VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_PER_TILE_BIT_EXT = 524288,
	VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILE_PER_SLICE_BIT_EXT = 1048576,
	VK_VIDEO_ENCODE_H265_CAPABILITY_SLICE_SEGMENT_CTB_COUNT_BIT_EXT = 2097152,
	VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXT = 4194304,
	VK_VIDEO_ENCODE_H265_CAPABILITY_DEPENDENT_SLICE_SEGMENT_BIT_EXT = 8388608,
	VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT = 16777216,
	VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT = 33554432,
}

[Flags]
public enum VkVideoEncodeH265InputModeFlagsEXT
{
	None = 0,
	VK_VIDEO_ENCODE_H265_INPUT_MODE_FRAME_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H265_INPUT_MODE_SLICE_SEGMENT_BIT_EXT = 2,
	VK_VIDEO_ENCODE_H265_INPUT_MODE_NON_VCL_BIT_EXT = 4,
}

[Flags]
public enum VkVideoEncodeH265OutputModeFlagsEXT
{
	None = 0,
	VK_VIDEO_ENCODE_H265_OUTPUT_MODE_FRAME_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H265_OUTPUT_MODE_SLICE_SEGMENT_BIT_EXT = 2,
	VK_VIDEO_ENCODE_H265_OUTPUT_MODE_NON_VCL_BIT_EXT = 4,
}

[Flags]
public enum VkVideoEncodeH265RateControlStructureFlagsEXT
{
	VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_UNKNOWN_EXT = 0,
	VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_FLAT_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_DYADIC_BIT_EXT = 2,
}

[Flags]
public enum VkVideoEncodeH265CtbSizeFlagsEXT
{
	None = 0,
	VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_EXT = 2,
	VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_EXT = 4,
}

[Flags]
public enum VkVideoEncodeH265TransformBlockSizeFlagsEXT
{
	None = 0,
	VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_EXT = 1,
	VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_EXT = 2,
	VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_EXT = 4,
	VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_EXT = 8,
}

[Flags]
public enum VkInstanceCreateFlags
{
	None = 0
}

