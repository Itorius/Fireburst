using System;
namespace Fireburst {
public enum VkImageLayout {
Undefined = 0,
General = 1,
ColorAttachmentOptimal = 2,
DepthStencilAttachmentOptimal = 3,
DepthStencilReadOnlyOptimal = 4,
ShaderReadOnlyOptimal = 5,
TransferSrcOptimal = 6,
TransferDstOptimal = 7,
Preinitialized = 8,
}
public enum VkAttachmentLoadOp {
Load = 0,
Clear = 1,
DontCare = 2,
}
public enum VkAttachmentStoreOp {
Store = 0,
DontCare = 1,
}
public enum VkImageType {
Image1D = 0,
Image2D = 1,
Image3D = 2,
}
public enum VkImageTiling {
Optimal = 0,
Linear = 1,
}
public enum VkImageViewType {
Image1D = 0,
Image2D = 1,
Image3D = 2,
ImageCube = 3,
Image1DArray = 4,
Image2DArray = 5,
ImageCubeArray = 6,
}
public enum VkCommandBufferLevel {
Primary = 0,
Secondary = 1,
}
public enum VkComponentSwizzle {
Identity = 0,
Zero = 1,
One = 2,
R = 3,
G = 4,
B = 5,
A = 6,
}
public enum VkDescriptorType {
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
}
public enum VkQueryType {
Occlusion = 0,
PipelineStatistics = 1,
Timestamp = 2,
}
public enum VkBorderColor {
FloatTransparentBlack = 0,
IntTransparentBlack = 1,
FloatOpaqueBlack = 2,
IntOpaqueBlack = 3,
FloatOpaqueWhite = 4,
IntOpaqueWhite = 5,
}
public enum VkPipelineBindPoint {
Graphics = 0,
Compute = 1,
}
public enum VkPipelineCacheHeaderVersion {
One = 1,
}
[Flags]
public enum VkPipelineCacheCreateFlags {
None = 0
}
public enum VkPrimitiveTopology {
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
public enum VkSharingMode {
Exclusive = 0,
Concurrent = 1,
}
public enum VkIndexType {
Uint16 = 0,
Uint32 = 1,
}
public enum VkFilter {
Nearest = 0,
Linear = 1,
}
public enum VkSamplerMipmapMode {
Nearest = 0,
Linear = 1,
}
public enum VkSamplerAddressMode {
Repeat = 0,
MirroredRepeat = 1,
ClampToEdge = 2,
ClampToBorder = 3,
}
public enum VkCompareOp {
Never = 0,
Less = 1,
Equal = 2,
LessOrEqual = 3,
Greater = 4,
NotEqual = 5,
GreaterOrEqual = 6,
Always = 7,
}
public enum VkPolygonMode {
Fill = 0,
Line = 1,
Point = 2,
}
public enum VkFrontFace {
CounterClockwise = 0,
Clockwise = 1,
}
public enum VkBlendFactor {
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
public enum VkBlendOp {
Add = 0,
Subtract = 1,
ReverseSubtract = 2,
Min = 3,
Max = 4,
}
public enum VkStencilOp {
Keep = 0,
Zero = 1,
Replace = 2,
IncrementAndClamp = 3,
DecrementAndClamp = 4,
Invert = 5,
IncrementAndWrap = 6,
DecrementAndWrap = 7,
}
public enum VkLogicOp {
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
public enum VkInternalAllocationType {
Executable = 0,
}
public enum VkSystemAllocationScope {
Command = 0,
Object = 1,
Cache = 2,
Device = 3,
Instance = 4,
}
public enum VkPhysicalDeviceType {
Other = 0,
IntegratedGpu = 1,
DiscreteGpu = 2,
VirtualGpu = 3,
Cpu = 4,
}
public enum VkVertexInputRate {
Vertex = 0,
Instance = 1,
}
public enum VkFormat {
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
}
public enum VkStructureType {
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
}
public enum VkSubpassContents {
Inline = 0,
SecondaryCommandBuffers = 1,
}
public enum VkResult {
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
}
public enum VkDynamicState {
Viewport = 0,
Scissor = 1,
LineWidth = 2,
DepthBias = 3,
BlendConstants = 4,
DepthBounds = 5,
StencilCompareMask = 6,
StencilWriteMask = 7,
StencilReference = 8,
}
public enum VkDescriptorUpdateTemplateType {
DescriptorSet = 0,
}
public enum VkObjectType {
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
}
[Flags]
public enum VkQueueFlags {
GraphicsBit = 1,
ComputeBit = 2,
TransferBit = 4,
SparseBindingBit = 8,
}
[Flags]
public enum VkCullModeFlags {
None = 0,
FrontBit = 1,
BackBit = 2,
FrontAndBack = 0x00000003,
}
[Flags]
public enum VkRenderPassCreateFlags {
None = 0
}
[Flags]
public enum VkDeviceQueueCreateFlags {
None = 0
}
[Flags]
public enum VkMemoryPropertyFlags {
DeviceLocalBit = 1,
HostVisibleBit = 2,
HostCoherentBit = 4,
HostCachedBit = 8,
LazilyAllocatedBit = 16,
}
[Flags]
public enum VkMemoryHeapFlags {
DeviceLocalBit = 1,
}
[Flags]
public enum VkAccessFlags {
IndirectCommandReadBit = 1,
IndexReadBit = 2,
VertexAttributeReadBit = 4,
UniformReadBit = 8,
InputAttachmentReadBit = 16,
ShaderReadBit = 32,
ShaderWriteBit = 64,
ColorAttachmentReadBit = 128,
ColorAttachmentWriteBit = 256,
DepthStencilAttachmentReadBit = 512,
DepthStencilAttachmentWriteBit = 1024,
TransferReadBit = 2048,
TransferWriteBit = 4096,
HostReadBit = 8192,
HostWriteBit = 16384,
MemoryReadBit = 32768,
MemoryWriteBit = 65536,
}
[Flags]
public enum VkBufferUsageFlags {
TransferSrcBit = 1,
TransferDstBit = 2,
UniformTexelBufferBit = 4,
StorageTexelBufferBit = 8,
UniformBufferBit = 16,
StorageBufferBit = 32,
IndexBufferBit = 64,
VertexBufferBit = 128,
IndirectBufferBit = 256,
}
[Flags]
public enum VkBufferCreateFlags {
SparseBindingBit = 1,
SparseResidencyBit = 2,
SparseAliasedBit = 4,
}
[Flags]
public enum VkShaderStageFlags {
VertexBit = 1,
TessellationControlBit = 2,
TessellationEvaluationBit = 4,
GeometryBit = 8,
FragmentBit = 16,
ComputeBit = 32,
AllGraphics = 0x0000001F,
All = 0x7FFFFFFF,
}
[Flags]
public enum VkImageUsageFlags {
TransferSrcBit = 1,
TransferDstBit = 2,
SampledBit = 4,
StorageBit = 8,
ColorAttachmentBit = 16,
DepthStencilAttachmentBit = 32,
TransientAttachmentBit = 64,
InputAttachmentBit = 128,
}
[Flags]
public enum VkImageCreateFlags {
SparseBindingBit = 1,
SparseResidencyBit = 2,
SparseAliasedBit = 4,
MutableFormatBit = 8,
CubeCompatibleBit = 16,
}
[Flags]
public enum VkImageViewCreateFlags {
None = 0
}
[Flags]
public enum VkSamplerCreateFlags {
None = 0
}
[Flags]
public enum VkPipelineCreateFlags {
DisableOptimizationBit = 1,
AllowDerivativesBit = 2,
DerivativeBit = 4,
}
[Flags]
public enum VkPipelineShaderStageCreateFlags {
None = 0
}
[Flags]
public enum VkColorComponentFlags {
RBit = 1,
GBit = 2,
BBit = 4,
ABit = 8,
}
[Flags]
public enum VkFenceCreateFlags {
SignaledBit = 1,
}
[Flags]
public enum VkFormatFeatureFlags {
SampledImageBit = 1,
StorageImageBit = 2,
StorageImageAtomicBit = 4,
UniformTexelBufferBit = 8,
StorageTexelBufferBit = 16,
StorageTexelBufferAtomicBit = 32,
VertexBufferBit = 64,
ColorAttachmentBit = 128,
ColorAttachmentBlendBit = 256,
DepthStencilAttachmentBit = 512,
BlitSrcBit = 1024,
BlitDstBit = 2048,
SampledImageFilterLinearBit = 4096,
}
[Flags]
public enum VkQueryControlFlags {
PreciseBit = 1,
}
[Flags]
public enum VkQueryResultFlags {
_64Bit = 1,
WaitBit = 2,
WithAvailabilityBit = 4,
PartialBit = 8,
}
[Flags]
public enum VkCommandBufferUsageFlags {
OneTimeSubmitBit = 1,
RenderPassContinueBit = 2,
SimultaneousUseBit = 4,
}
[Flags]
public enum VkQueryPipelineStatisticFlags {
InputAssemblyVerticesBit = 1,
InputAssemblyPrimitivesBit = 2,
VertexShaderInvocationsBit = 4,
GeometryShaderInvocationsBit = 8,
GeometryShaderPrimitivesBit = 16,
ClippingInvocationsBit = 32,
ClippingPrimitivesBit = 64,
FragmentShaderInvocationsBit = 128,
TessellationControlShaderPatchesBit = 256,
TessellationEvaluationShaderInvocationsBit = 512,
ComputeShaderInvocationsBit = 1024,
}
[Flags]
public enum VkImageAspectFlags {
ColorBit = 1,
DepthBit = 2,
StencilBit = 4,
MetadataBit = 8,
}
[Flags]
public enum VkSparseImageFormatFlags {
SingleMiptailBit = 1,
AlignedMipSizeBit = 2,
NonstandardBlockSizeBit = 4,
}
[Flags]
public enum VkSparseMemoryBindFlags {
MetadataBit = 1,
}
[Flags]
public enum VkPipelineStageFlags {
TopOfPipeBit = 1,
DrawIndirectBit = 2,
VertexInputBit = 4,
VertexShaderBit = 8,
TessellationControlShaderBit = 16,
TessellationEvaluationShaderBit = 32,
GeometryShaderBit = 64,
FragmentShaderBit = 128,
EarlyFragmentTestsBit = 256,
LateFragmentTestsBit = 512,
ColorAttachmentOutputBit = 1024,
ComputeShaderBit = 2048,
TransferBit = 4096,
BottomOfPipeBit = 8192,
HostBit = 16384,
AllGraphicsBit = 32768,
AllCommandsBit = 65536,
}
[Flags]
public enum VkCommandPoolCreateFlags {
TransientBit = 1,
ResetCommandBufferBit = 2,
}
[Flags]
public enum VkCommandPoolResetFlags {
ReleaseResourcesBit = 1,
}
[Flags]
public enum VkCommandBufferResetFlags {
ReleaseResourcesBit = 1,
}
[Flags]
public enum VkSampleCountFlags {
Count1 = 1,
Count2 = 2,
Count4 = 4,
Count8 = 8,
Count16 = 16,
Count32 = 32,
Count64 = 64,
}
[Flags]
public enum VkAttachmentDescriptionFlags {
MayAliasBit = 1,
}
[Flags]
public enum VkStencilFaceFlags {
FrontBit = 1,
BackBit = 2,
FrontAndBack = 0x00000003,
}
[Flags]
public enum VkDescriptorPoolCreateFlags {
FreeDescriptorSetBit = 1,
}
[Flags]
public enum VkDependencyFlags {
ByRegionBit = 1,
}
public enum VkSemaphoreType {
Binary = 0,
Timeline = 1,
}
[Flags]
public enum VkSemaphoreWaitFlags {
AnyBit = 1,
}
public enum VkPresentModeKHR {
Immediate = 0,
Mailbox = 1,
Fifo = 2,
FifoRelaxed = 3,
}
public enum VkColorSpaceKHR {
SrgbNonLinearKHR = 0,
}
[Flags]
public enum VkDisplayPlaneAlphaFlagsKHR {
OpaqueBit = 1,
GlobalBit = 2,
PerPixelBit = 4,
PerPixelPremultipliedBit = 8,
}
[Flags]
public enum VkCompositeAlphaFlagsKHR {
OpaqueBit = 1,
PreMultipliedBit = 2,
PostMultipliedBit = 4,
InheritBit = 8,
}
[Flags]
public enum VkSurfaceTransformFlagsKHR {
IdentityBit = 1,
Rotate90Bit = 2,
Rotate180Bit = 4,
Rotate270Bit = 8,
HorizontalMirrorBit = 16,
HorizontalMirrorRotate90Bit = 32,
HorizontalMirrorRotate180Bit = 64,
HorizontalMirrorRotate270Bit = 128,
InheritBit = 256,
}
[Flags]
public enum VkSwapchainImageUsageFlagsANDROID {
SharedBitAndroid = 1,
}
public enum VkTimeDomainEXT {
Device = 0,
ClockMonotonic = 1,
ClockMonotonicRaw = 2,
QueryPerformanceCounter = 3,
}
[Flags]
public enum VkDebugReportFlagsEXT {
InformationBit = 1,
WarningBit = 2,
PerformanceWarningBit = 4,
ErrorBit = 8,
DebugBit = 16,
}
public enum VkDebugReportObjectTypeEXT {
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
}
public enum VkDeviceMemoryReportEventTypeEXT {
Allocate = 0,
Free = 1,
Import = 2,
Unimport = 3,
AllocationFailed = 4,
}
public enum VkRasterizationOrderAMD {
StrictAMD = 0,
RelaxedAMD = 1,
}
[Flags]
public enum VkExternalMemoryHandleTypeFlagsNV {
OpaqueWin32Bit = 1,
OpaqueWin32KmtBit = 2,
D3d11ImageBit = 4,
D3d11ImageKmtBit = 8,
}
[Flags]
public enum VkExternalMemoryFeatureFlagsNV {
DedicatedOnlyBit = 1,
ExportableBit = 2,
ImportableBit = 4,
}
public enum VkValidationCheckEXT {
All = 0,
Shaders = 1,
}
public enum VkValidationFeatureEnableEXT {
GpuAssisted = 0,
GpuAssistedReserveBindingSlot = 1,
BestPractices = 2,
DebugPrintf = 3,
SynchronizationValidation = 4,
}
public enum VkValidationFeatureDisableEXT {
All = 0,
Shaders = 1,
ThreadSafety = 2,
ApiParameters = 3,
ObjectLifetimes = 4,
CoreChecks = 5,
UniqueHandles = 6,
}
[Flags]
public enum VkSubgroupFeatureFlags {
BasicBit = 1,
VoteBit = 2,
ArithmeticBit = 4,
BallotBit = 8,
ShuffleBit = 16,
ShuffleRelativeBit = 32,
ClusteredBit = 64,
QuadBit = 128,
}
[Flags]
public enum VkIndirectCommandsLayoutUsageFlagsNV {
ExplicitPreprocessBit = 1,
IndexedSequencesBit = 2,
UnorderedSequencesBit = 4,
}
[Flags]
public enum VkIndirectStateFlagsNV {
FlagFrontfaceBit = 1,
}
public enum VkIndirectCommandsTokenTypeNV {
TypeShaderGroup = 0,
TypeStateFlags = 1,
TypeIndexBuffer = 2,
TypeVertexBuffer = 3,
TypePushConstant = 4,
TypeDrawIndexed = 5,
TypeDraw = 6,
TypeDrawTasks = 7,
}
[Flags]
public enum VkPrivateDataSlotCreateFlagsEXT {
None = 0
}
[Flags]
public enum VkDescriptorSetLayoutCreateFlags {
None = 0
}
[Flags]
public enum VkExternalMemoryHandleTypeFlags {
OpaqueFdBit = 1,
OpaqueWin32Bit = 2,
OpaqueWin32KmtBit = 4,
D3d11TextureBit = 8,
D3d11TextureKmtBit = 16,
D3d12HeapBit = 32,
D3d12ResourceBit = 64,
}
[Flags]
public enum VkExternalMemoryFeatureFlags {
DedicatedOnlyBit = 1,
ExportableBit = 2,
ImportableBit = 4,
}
[Flags]
public enum VkExternalSemaphoreHandleTypeFlags {
OpaqueFdBit = 1,
OpaqueWin32Bit = 2,
OpaqueWin32KmtBit = 4,
D3d12FenceBit = 8,
SyncFdBit = 16,
}
[Flags]
public enum VkExternalSemaphoreFeatureFlags {
ExportableBit = 1,
ImportableBit = 2,
}
[Flags]
public enum VkSemaphoreImportFlags {
TemporaryBit = 1,
}
[Flags]
public enum VkExternalFenceHandleTypeFlags {
OpaqueFdBit = 1,
OpaqueWin32Bit = 2,
OpaqueWin32KmtBit = 4,
SyncFdBit = 8,
}
[Flags]
public enum VkExternalFenceFeatureFlags {
ExportableBit = 1,
ImportableBit = 2,
}
[Flags]
public enum VkFenceImportFlags {
TemporaryBit = 1,
}
[Flags]
public enum VkSurfaceCounterFlagsEXT {
VblankBit = 1,
}
public enum VkDisplayPowerStateEXT {
Off = 0,
Suspend = 1,
On = 2,
}
public enum VkDeviceEventTypeEXT {
DisplayHotplug = 0,
}
public enum VkDisplayEventTypeEXT {
FirstPixelOut = 0,
}
[Flags]
public enum VkPeerMemoryFeatureFlags {
CopySrcBit = 1,
CopyDstBit = 2,
GenericSrcBit = 4,
GenericDstBit = 8,
}
[Flags]
public enum VkMemoryAllocateFlags {
DeviceMaskBit = 1,
}
[Flags]
public enum VkDeviceGroupPresentModeFlagsKHR {
LocalBit = 1,
RemoteBit = 2,
SumBit = 4,
LocalMultiDeviceBit = 8,
}
[Flags]
public enum VkSwapchainCreateFlagsKHR {
None = 0
}
public enum VkViewportCoordinateSwizzleNV {
PositiveX = 0,
NegativeX = 1,
PositiveY = 2,
NegativeY = 3,
PositiveZ = 4,
NegativeZ = 5,
PositiveW = 6,
NegativeW = 7,
}
public enum VkDiscardRectangleModeEXT {
Inclusive = 0,
Exclusive = 1,
}
[Flags]
public enum VkSubpassDescriptionFlags {
None = 0
}
public enum VkPointClippingBehavior {
AllClipPlanes = 0,
UserClipPlanesOnly = 1,
}
public enum VkSamplerReductionMode {
WeightedAverage = 0,
Min = 1,
Max = 2,
}
public enum VkTessellationDomainOrigin {
UpperLeft = 0,
LowerLeft = 1,
}
public enum VkSamplerYcbcrModelConversion {
RgbIdentity = 0,
YcbcrIdentity = 1,
Ycbcr709 = 2,
Ycbcr601 = 3,
Ycbcr2020 = 4,
}
public enum VkSamplerYcbcrRange {
ItuFull = 0,
ItuNarrow = 1,
}
public enum VkChromaLocation {
CositedEven = 0,
Midpoint = 1,
}
public enum VkBlendOverlapEXT {
Uncorrelated = 0,
Disjoint = 1,
Conjoint = 2,
}
public enum VkCoverageModulationModeNV {
None = 0,
Rgb = 1,
Alpha = 2,
Rgba = 3,
}
public enum VkCoverageReductionModeNV {
ModeMerge = 0,
ModeTruncate = 1,
}
public enum VkValidationCacheHeaderVersionEXT {
One = 1,
}
public enum VkShaderInfoTypeAMD {
StatisticsAMD = 0,
BinaryAMD = 1,
DisassemblyAMD = 2,
}
public enum VkQueueGlobalPriorityEXT {
Low = 128,
Medium = 256,
High = 512,
Realtime = 1024,
}
[Flags]
public enum VkDebugUtilsMessageSeverityFlagsEXT {
VerboseBit = 1,
InfoBit = 16,
WarningBit = 256,
ErrorBit = 4096,
}
[Flags]
public enum VkDebugUtilsMessageTypeFlagsEXT {
GeneralBit = 1,
ValidationBit = 2,
PerformanceBit = 4,
}
public enum VkConservativeRasterizationModeEXT {
Disabled = 0,
Overestimate = 1,
Underestimate = 2,
}
[Flags]
public enum VkDescriptorBindingFlags {
UpdateAfterBindBit = 1,
UpdateUnusedWhilePendingBit = 2,
PartiallyBoundBit = 4,
VariableDescriptorCountBit = 8,
}
public enum VkVendorId {
Viv = 0x10001,
Vsi = 0x10002,
Kazan = 0x10003,
Codeplay = 0x10004,
Mesa = 0x10005,
Pocl = 0x10006,
}
public enum VkDriverId {
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
[Flags]
public enum VkConditionalRenderingFlagsEXT {
InvertedBit = 1,
}
[Flags]
public enum VkResolveModeFlags {
None = 0,
SampleZeroBit = 1,
AverageBit = 2,
MinBit = 4,
MaxBit = 8,
}
public enum VkShadingRatePaletteEntryNV {
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
public enum VkCoarseSampleOrderTypeNV {
Default = 0,
Custom = 1,
PixelMajor = 2,
SampleMajor = 3,
}
[Flags]
public enum VkGeometryInstanceFlagsKHR {
TriangleFacingCullDisableBit = 1,
TriangleFrontCounterclockwiseBit = 2,
ForceOpaqueBit = 4,
ForceNoOpaqueBit = 8,
}
[Flags]
public enum VkGeometryFlagsKHR {
OpaqueBit = 1,
NoDuplicateAnyHitInvocationBit = 2,
}
[Flags]
public enum VkBuildAccelerationStructureFlagsKHR {
AllowUpdateBit = 1,
AllowCompactionBit = 2,
PreferFastTraceBit = 4,
PreferFastBuildBit = 8,
LowMemoryBit = 16,
}
[Flags]
public enum VkAccelerationStructureCreateFlagsKHR {
DeviceAddressCaptureReplayBit = 1,
}
public enum VkCopyAccelerationStructureModeKHR {
Clone = 0,
Compact = 1,
Serialize = 2,
Deserialize = 3,
}
public enum VkBuildAccelerationStructureModeKHR {
Build = 0,
Update = 1,
}
public enum VkAccelerationStructureTypeKHR {
TopLevel = 0,
BottomLevel = 1,
Generic = 2,
}
public enum VkGeometryTypeKHR {
Triangles = 0,
Aabbs = 1,
Instances = 2,
}
public enum VkAccelerationStructureMemoryRequirementsTypeNV {
Object = 0,
BuildScratch = 1,
UpdateScratch = 2,
}
public enum VkAccelerationStructureBuildTypeKHR {
Host = 0,
Device = 1,
HostOrDevice = 2,
}
public enum VkRayTracingShaderGroupTypeKHR {
General = 0,
TrianglesHitGroup = 1,
ProceduralHitGroup = 2,
}
public enum VkAccelerationStructureCompatibilityKHR {
Compatible = 0,
Incompatible = 1,
}
public enum VkShaderGroupShaderKHR {
General = 0,
ClosestHit = 1,
AnyHit = 2,
Intersection = 3,
}
public enum VkMemoryOverallocationBehaviorAMD {
DefaultAMD = 0,
AllowedAMD = 1,
DisallowedAMD = 2,
}
[Flags]
public enum VkFramebufferCreateFlags {
None = 0
}
public enum VkScopeNV {
ScopeDevice = 1,
ScopeWorkgroup = 2,
ScopeSubgroup = 3,
ScopeQueueFamily = 5,
}
public enum VkComponentTypeNV {
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
[Flags]
public enum VkDeviceDiagnosticsConfigFlagsNV {
EnableShaderDebugInfoBit = 1,
EnableResourceTrackingBit = 2,
EnableAutomaticCheckpointsBit = 4,
}
[Flags]
public enum VkPipelineCreationFeedbackFlagsEXT {
ValidBit = 1,
ApplicationPipelineCacheHitBit = 2,
BasePipelineAccelerationBit = 4,
}
public enum VkFullScreenExclusiveEXT {
Default = 0,
Allowed = 1,
Disallowed = 2,
ApplicationControlled = 3,
}
public enum VkPerformanceCounterScopeKHR {
CommandBuffer = 0,
RenderPass = 1,
Command = 2,
}
public enum VkPerformanceCounterUnitKHR {
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
public enum VkPerformanceCounterStorageKHR {
Int32 = 0,
Int64 = 1,
Uint32 = 2,
Uint64 = 3,
Float32 = 4,
Float64 = 5,
}
[Flags]
public enum VkPerformanceCounterDescriptionFlagsKHR {
PerformanceImpactingBit = 1,
ConcurrentlyImpactedBit = 2,
}
[Flags]
public enum VkAcquireProfilingLockFlagsKHR {
None = 0
}
[Flags]
public enum VkShaderCorePropertiesFlagsAMD {
None = 0
}
public enum VkPerformanceConfigurationTypeINTEL {
CommandQueueMetricsDiscoveryActivatedIntel = 0,
}
public enum VkQueryPoolSamplingModeINTEL {
ModeManualINTEL = 0,
}
public enum VkPerformanceOverrideTypeINTEL {
TypeNullHardwareINTEL = 0,
TypeFlushGpuCachesINTEL = 1,
}
public enum VkPerformanceParameterTypeINTEL {
TypeHwCountersSupportedINTEL = 0,
TypeStreamMarkerValidBitsINTEL = 1,
}
public enum VkPerformanceValueTypeINTEL {
TypeUint32INTEL = 0,
TypeUint64INTEL = 1,
TypeFloatINTEL = 2,
TypeBoolINTEL = 3,
TypeStringINTEL = 4,
}
public enum VkShaderFloatControlsIndependence {
_32BitOnly = 0,
All = 1,
None = 2,
}
public enum VkPipelineExecutableStatisticFormatKHR {
Bool32 = 0,
Int64 = 1,
Uint64 = 2,
Float64 = 3,
}
public enum VkLineRasterizationModeEXT {
Default = 0,
Rectangular = 1,
Bresenham = 2,
RectangularSmooth = 3,
}
[Flags]
public enum VkShaderModuleCreateFlags {
None = 0
}
[Flags]
public enum VkPipelineCompilerControlFlagsAMD {
None = 0
}
[Flags]
public enum VkToolPurposeFlagsEXT {
ValidationBit = 1,
ProfilingBit = 2,
TracingBit = 4,
AdditionalFeaturesBit = 8,
ModifyingFeaturesBit = 16,
}
public enum VkFragmentShadingRateCombinerOpKHR {
Keep = 0,
Replace = 1,
Min = 2,
Max = 3,
Mul = 4,
}
public enum VkFragmentShadingRateNV {
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
public enum VkFragmentShadingRateTypeNV {
TypeFragmentSize = 0,
TypeEnums = 1,
}
[Flags]
public enum VkAccessFlags2KHR :long {
None = 0,
IndirectCommandReadBit = 1,
IndexReadBit = 2,
VertexAttributeReadBit = 4,
UniformReadBit = 8,
InputAttachmentReadBit = 16,
ShaderReadBit = 32,
ShaderWriteBit = 64,
ColorAttachmentReadBit = 128,
ColorAttachmentWriteBit = 256,
DepthStencilAttachmentReadBit = 512,
DepthStencilAttachmentWriteBit = 1024,
TransferReadBit = 2048,
TransferWriteBit = 4096,
HostReadBit = 8192,
HostWriteBit = 16384,
MemoryReadBit = 32768,
MemoryWriteBit = 65536,
ShaderSampledReadBit = 4294967296,
ShaderStorageReadBit = 8589934592,
ShaderStorageWriteBit = 17179869184,
}
[Flags]
public enum VkPipelineStageFlags2KHR :long {
None = 0,
TopOfPipeBit = 1,
DrawIndirectBit = 2,
VertexInputBit = 4,
VertexShaderBit = 8,
TessellationControlShaderBit = 16,
TessellationEvaluationShaderBit = 32,
GeometryShaderBit = 64,
FragmentShaderBit = 128,
EarlyFragmentTestsBit = 256,
LateFragmentTestsBit = 512,
ColorAttachmentOutputBit = 1024,
ComputeShaderBit = 2048,
AllTransferBit = 4096,
BottomOfPipeBit = 8192,
HostBit = 16384,
AllGraphicsBit = 32768,
AllCommandsBit = 65536,
CopyBit = 4294967296,
ResolveBit = 8589934592,
BlitBit = 17179869184,
ClearBit = 34359738368,
IndexInputBit = 68719476736,
VertexAttributeInputBit = 137438953472,
PreRasterizationShadersBit = 274877906944,
}
[Flags]
public enum VkSubmitFlagsKHR {
ProtectedBit = 1,
}
[Flags]
public enum VkEventCreateFlags {
None = 0
}
[Flags]
public enum VkQueryPoolCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineLayoutCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineDepthStencilStateCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineDynamicStateCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineColorBlendStateCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineMultisampleStateCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineRasterizationStateCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineViewportStateCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineTessellationStateCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineInputAssemblyStateCreateFlags {
None = 0,
}
[Flags]
public enum VkPipelineVertexInputStateCreateFlags {
None = 0,
}
[Flags]
public enum VkBufferViewCreateFlags {
None = 0,
}
[Flags]
public enum VkInstanceCreateFlags {
None = 0,
}
[Flags]
public enum VkDeviceCreateFlags {
None = 0,
}
[Flags]
public enum VkSemaphoreCreateFlags {
None = 0,
}
[Flags]
public enum VkMemoryMapFlags {
None = 0,
}
[Flags]
public enum VkDescriptorPoolResetFlags {
None = 0,
}
[Flags]
public enum VkDescriptorUpdateTemplateCreateFlags {
None = 0,
}
[Flags]
public enum VkDisplayModeCreateFlagsKHR {
None = 0,
}
[Flags]
public enum VkDisplaySurfaceCreateFlagsKHR {
None = 0,
}
[Flags]
public enum VkAndroidSurfaceCreateFlagsKHR {
None = 0,
}
[Flags]
public enum VkViSurfaceCreateFlagsNN {
None = 0,
}
[Flags]
public enum VkWaylandSurfaceCreateFlagsKHR {
None = 0,
}
[Flags]
public enum VkWin32SurfaceCreateFlagsKHR {
None = 0,
}
[Flags]
public enum VkXlibSurfaceCreateFlagsKHR {
None = 0,
}
[Flags]
public enum VkXcbSurfaceCreateFlagsKHR {
None = 0,
}
[Flags]
public enum VkDirectFBSurfaceCreateFlagsEXT {
None = 0,
}
[Flags]
public enum VkIOSSurfaceCreateFlagsMVK {
None = 0,
}
[Flags]
public enum VkMacOSSurfaceCreateFlagsMVK {
None = 0,
}
[Flags]
public enum VkMetalSurfaceCreateFlagsEXT {
None = 0,
}
[Flags]
public enum VkImagePipeSurfaceCreateFlagsFUCHSIA {
None = 0,
}
[Flags]
public enum VkStreamDescriptorSurfaceCreateFlagsGGP {
None = 0,
}
[Flags]
public enum VkHeadlessSurfaceCreateFlagsEXT {
None = 0,
}
[Flags]
public enum VkCommandPoolTrimFlags {
None = 0,
}
[Flags]
public enum VkPipelineViewportSwizzleStateCreateFlagsNV {
None = 0,
}
[Flags]
public enum VkPipelineDiscardRectangleStateCreateFlagsEXT {
None = 0,
}
[Flags]
public enum VkPipelineCoverageToColorStateCreateFlagsNV {
None = 0,
}
[Flags]
public enum VkPipelineCoverageModulationStateCreateFlagsNV {
None = 0,
}
[Flags]
public enum VkPipelineCoverageReductionStateCreateFlagsNV {
None = 0,
}
[Flags]
public enum VkValidationCacheCreateFlagsEXT {
None = 0,
}
[Flags]
public enum VkDebugUtilsMessengerCreateFlagsEXT {
None = 0,
}
[Flags]
public enum VkDebugUtilsMessengerCallbackDataFlagsEXT {
None = 0,
}
[Flags]
public enum VkDeviceMemoryReportFlagsEXT {
None = 0,
}
[Flags]
public enum VkPipelineRasterizationConservativeStateCreateFlagsEXT {
None = 0,
}
[Flags]
public enum VkPipelineRasterizationStateStreamCreateFlagsEXT {
None = 0,
}
[Flags]
public enum VkPipelineRasterizationDepthClipStateCreateFlagsEXT {
None = 0,
}
}