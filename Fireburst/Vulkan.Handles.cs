﻿using System;
using System.Runtime.InteropServices;
namespace Fireburst {

									public partial struct VkInstance : IEquatable<VkInstance>
									{
										public readonly ulong Handle;
										public VkInstance(ulong handle) { Handle = handle; }
										public static VkInstance Null => new(0);
										public static implicit operator VkInstance(ulong handle) => new(handle);
										public static bool operator ==(VkInstance left, VkInstance right) => left.Handle == right.Handle;
										public static bool operator !=(VkInstance left, VkInstance right) => left.Handle != right.Handle;
										public static bool operator ==(VkInstance left, ulong right) => left.Handle == right;
										public static bool operator !=(VkInstance left, ulong right) => left.Handle != right;
										public bool Equals(ref VkInstance other) => Handle == other.Handle;
										public bool Equals(VkInstance other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkInstance handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkInstance [0x{Handle:X}]";
									}

									public partial struct VkPhysicalDevice : IEquatable<VkPhysicalDevice>
									{
										public readonly ulong Handle;
										public VkPhysicalDevice(ulong handle) { Handle = handle; }
										public static VkPhysicalDevice Null => new(0);
										public static implicit operator VkPhysicalDevice(ulong handle) => new(handle);
										public static bool operator ==(VkPhysicalDevice left, VkPhysicalDevice right) => left.Handle == right.Handle;
										public static bool operator !=(VkPhysicalDevice left, VkPhysicalDevice right) => left.Handle != right.Handle;
										public static bool operator ==(VkPhysicalDevice left, ulong right) => left.Handle == right;
										public static bool operator !=(VkPhysicalDevice left, ulong right) => left.Handle != right;
										public bool Equals(ref VkPhysicalDevice other) => Handle == other.Handle;
										public bool Equals(VkPhysicalDevice other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkPhysicalDevice handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkPhysicalDevice [0x{Handle:X}]";
									}

									public partial struct VkDevice : IEquatable<VkDevice>
									{
										public readonly ulong Handle;
										public VkDevice(ulong handle) { Handle = handle; }
										public static VkDevice Null => new(0);
										public static implicit operator VkDevice(ulong handle) => new(handle);
										public static bool operator ==(VkDevice left, VkDevice right) => left.Handle == right.Handle;
										public static bool operator !=(VkDevice left, VkDevice right) => left.Handle != right.Handle;
										public static bool operator ==(VkDevice left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDevice left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDevice other) => Handle == other.Handle;
										public bool Equals(VkDevice other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDevice handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDevice [0x{Handle:X}]";
									}

									public partial struct VkQueue : IEquatable<VkQueue>
									{
										public readonly ulong Handle;
										public VkQueue(ulong handle) { Handle = handle; }
										public static VkQueue Null => new(0);
										public static implicit operator VkQueue(ulong handle) => new(handle);
										public static bool operator ==(VkQueue left, VkQueue right) => left.Handle == right.Handle;
										public static bool operator !=(VkQueue left, VkQueue right) => left.Handle != right.Handle;
										public static bool operator ==(VkQueue left, ulong right) => left.Handle == right;
										public static bool operator !=(VkQueue left, ulong right) => left.Handle != right;
										public bool Equals(ref VkQueue other) => Handle == other.Handle;
										public bool Equals(VkQueue other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkQueue handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkQueue [0x{Handle:X}]";
									}

									public partial struct VkCommandBuffer : IEquatable<VkCommandBuffer>
									{
										public readonly ulong Handle;
										public VkCommandBuffer(ulong handle) { Handle = handle; }
										public static VkCommandBuffer Null => new(0);
										public static implicit operator VkCommandBuffer(ulong handle) => new(handle);
										public static bool operator ==(VkCommandBuffer left, VkCommandBuffer right) => left.Handle == right.Handle;
										public static bool operator !=(VkCommandBuffer left, VkCommandBuffer right) => left.Handle != right.Handle;
										public static bool operator ==(VkCommandBuffer left, ulong right) => left.Handle == right;
										public static bool operator !=(VkCommandBuffer left, ulong right) => left.Handle != right;
										public bool Equals(ref VkCommandBuffer other) => Handle == other.Handle;
										public bool Equals(VkCommandBuffer other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkCommandBuffer handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkCommandBuffer [0x{Handle:X}]";
									}

									public partial struct VkDeviceMemory : IEquatable<VkDeviceMemory>
									{
										public readonly ulong Handle;
										public VkDeviceMemory(ulong handle) { Handle = handle; }
										public static VkDeviceMemory Null => new(0);
										public static implicit operator VkDeviceMemory(ulong handle) => new(handle);
										public static bool operator ==(VkDeviceMemory left, VkDeviceMemory right) => left.Handle == right.Handle;
										public static bool operator !=(VkDeviceMemory left, VkDeviceMemory right) => left.Handle != right.Handle;
										public static bool operator ==(VkDeviceMemory left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDeviceMemory left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDeviceMemory other) => Handle == other.Handle;
										public bool Equals(VkDeviceMemory other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDeviceMemory handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDeviceMemory [0x{Handle:X}]";
									}

									public partial struct VkCommandPool : IEquatable<VkCommandPool>
									{
										public readonly ulong Handle;
										public VkCommandPool(ulong handle) { Handle = handle; }
										public static VkCommandPool Null => new(0);
										public static implicit operator VkCommandPool(ulong handle) => new(handle);
										public static bool operator ==(VkCommandPool left, VkCommandPool right) => left.Handle == right.Handle;
										public static bool operator !=(VkCommandPool left, VkCommandPool right) => left.Handle != right.Handle;
										public static bool operator ==(VkCommandPool left, ulong right) => left.Handle == right;
										public static bool operator !=(VkCommandPool left, ulong right) => left.Handle != right;
										public bool Equals(ref VkCommandPool other) => Handle == other.Handle;
										public bool Equals(VkCommandPool other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkCommandPool handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkCommandPool [0x{Handle:X}]";
									}

									public partial struct VkBuffer : IEquatable<VkBuffer>
									{
										public readonly ulong Handle;
										public VkBuffer(ulong handle) { Handle = handle; }
										public static VkBuffer Null => new(0);
										public static implicit operator VkBuffer(ulong handle) => new(handle);
										public static bool operator ==(VkBuffer left, VkBuffer right) => left.Handle == right.Handle;
										public static bool operator !=(VkBuffer left, VkBuffer right) => left.Handle != right.Handle;
										public static bool operator ==(VkBuffer left, ulong right) => left.Handle == right;
										public static bool operator !=(VkBuffer left, ulong right) => left.Handle != right;
										public bool Equals(ref VkBuffer other) => Handle == other.Handle;
										public bool Equals(VkBuffer other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkBuffer handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkBuffer [0x{Handle:X}]";
									}

									public partial struct VkBufferView : IEquatable<VkBufferView>
									{
										public readonly ulong Handle;
										public VkBufferView(ulong handle) { Handle = handle; }
										public static VkBufferView Null => new(0);
										public static implicit operator VkBufferView(ulong handle) => new(handle);
										public static bool operator ==(VkBufferView left, VkBufferView right) => left.Handle == right.Handle;
										public static bool operator !=(VkBufferView left, VkBufferView right) => left.Handle != right.Handle;
										public static bool operator ==(VkBufferView left, ulong right) => left.Handle == right;
										public static bool operator !=(VkBufferView left, ulong right) => left.Handle != right;
										public bool Equals(ref VkBufferView other) => Handle == other.Handle;
										public bool Equals(VkBufferView other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkBufferView handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkBufferView [0x{Handle:X}]";
									}

									public partial struct VkImage : IEquatable<VkImage>
									{
										public readonly ulong Handle;
										public VkImage(ulong handle) { Handle = handle; }
										public static VkImage Null => new(0);
										public static implicit operator VkImage(ulong handle) => new(handle);
										public static bool operator ==(VkImage left, VkImage right) => left.Handle == right.Handle;
										public static bool operator !=(VkImage left, VkImage right) => left.Handle != right.Handle;
										public static bool operator ==(VkImage left, ulong right) => left.Handle == right;
										public static bool operator !=(VkImage left, ulong right) => left.Handle != right;
										public bool Equals(ref VkImage other) => Handle == other.Handle;
										public bool Equals(VkImage other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkImage handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkImage [0x{Handle:X}]";
									}

									public partial struct VkImageView : IEquatable<VkImageView>
									{
										public readonly ulong Handle;
										public VkImageView(ulong handle) { Handle = handle; }
										public static VkImageView Null => new(0);
										public static implicit operator VkImageView(ulong handle) => new(handle);
										public static bool operator ==(VkImageView left, VkImageView right) => left.Handle == right.Handle;
										public static bool operator !=(VkImageView left, VkImageView right) => left.Handle != right.Handle;
										public static bool operator ==(VkImageView left, ulong right) => left.Handle == right;
										public static bool operator !=(VkImageView left, ulong right) => left.Handle != right;
										public bool Equals(ref VkImageView other) => Handle == other.Handle;
										public bool Equals(VkImageView other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkImageView handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkImageView [0x{Handle:X}]";
									}

									public partial struct VkShaderModule : IEquatable<VkShaderModule>
									{
										public readonly ulong Handle;
										public VkShaderModule(ulong handle) { Handle = handle; }
										public static VkShaderModule Null => new(0);
										public static implicit operator VkShaderModule(ulong handle) => new(handle);
										public static bool operator ==(VkShaderModule left, VkShaderModule right) => left.Handle == right.Handle;
										public static bool operator !=(VkShaderModule left, VkShaderModule right) => left.Handle != right.Handle;
										public static bool operator ==(VkShaderModule left, ulong right) => left.Handle == right;
										public static bool operator !=(VkShaderModule left, ulong right) => left.Handle != right;
										public bool Equals(ref VkShaderModule other) => Handle == other.Handle;
										public bool Equals(VkShaderModule other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkShaderModule handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkShaderModule [0x{Handle:X}]";
									}

									public partial struct VkPipeline : IEquatable<VkPipeline>
									{
										public readonly ulong Handle;
										public VkPipeline(ulong handle) { Handle = handle; }
										public static VkPipeline Null => new(0);
										public static implicit operator VkPipeline(ulong handle) => new(handle);
										public static bool operator ==(VkPipeline left, VkPipeline right) => left.Handle == right.Handle;
										public static bool operator !=(VkPipeline left, VkPipeline right) => left.Handle != right.Handle;
										public static bool operator ==(VkPipeline left, ulong right) => left.Handle == right;
										public static bool operator !=(VkPipeline left, ulong right) => left.Handle != right;
										public bool Equals(ref VkPipeline other) => Handle == other.Handle;
										public bool Equals(VkPipeline other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkPipeline handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkPipeline [0x{Handle:X}]";
									}

									public partial struct VkPipelineLayout : IEquatable<VkPipelineLayout>
									{
										public readonly ulong Handle;
										public VkPipelineLayout(ulong handle) { Handle = handle; }
										public static VkPipelineLayout Null => new(0);
										public static implicit operator VkPipelineLayout(ulong handle) => new(handle);
										public static bool operator ==(VkPipelineLayout left, VkPipelineLayout right) => left.Handle == right.Handle;
										public static bool operator !=(VkPipelineLayout left, VkPipelineLayout right) => left.Handle != right.Handle;
										public static bool operator ==(VkPipelineLayout left, ulong right) => left.Handle == right;
										public static bool operator !=(VkPipelineLayout left, ulong right) => left.Handle != right;
										public bool Equals(ref VkPipelineLayout other) => Handle == other.Handle;
										public bool Equals(VkPipelineLayout other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkPipelineLayout handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkPipelineLayout [0x{Handle:X}]";
									}

									public partial struct VkSampler : IEquatable<VkSampler>
									{
										public readonly ulong Handle;
										public VkSampler(ulong handle) { Handle = handle; }
										public static VkSampler Null => new(0);
										public static implicit operator VkSampler(ulong handle) => new(handle);
										public static bool operator ==(VkSampler left, VkSampler right) => left.Handle == right.Handle;
										public static bool operator !=(VkSampler left, VkSampler right) => left.Handle != right.Handle;
										public static bool operator ==(VkSampler left, ulong right) => left.Handle == right;
										public static bool operator !=(VkSampler left, ulong right) => left.Handle != right;
										public bool Equals(ref VkSampler other) => Handle == other.Handle;
										public bool Equals(VkSampler other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkSampler handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkSampler [0x{Handle:X}]";
									}

									public partial struct VkDescriptorSet : IEquatable<VkDescriptorSet>
									{
										public readonly ulong Handle;
										public VkDescriptorSet(ulong handle) { Handle = handle; }
										public static VkDescriptorSet Null => new(0);
										public static implicit operator VkDescriptorSet(ulong handle) => new(handle);
										public static bool operator ==(VkDescriptorSet left, VkDescriptorSet right) => left.Handle == right.Handle;
										public static bool operator !=(VkDescriptorSet left, VkDescriptorSet right) => left.Handle != right.Handle;
										public static bool operator ==(VkDescriptorSet left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDescriptorSet left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDescriptorSet other) => Handle == other.Handle;
										public bool Equals(VkDescriptorSet other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDescriptorSet handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDescriptorSet [0x{Handle:X}]";
									}

									public partial struct VkDescriptorSetLayout : IEquatable<VkDescriptorSetLayout>
									{
										public readonly ulong Handle;
										public VkDescriptorSetLayout(ulong handle) { Handle = handle; }
										public static VkDescriptorSetLayout Null => new(0);
										public static implicit operator VkDescriptorSetLayout(ulong handle) => new(handle);
										public static bool operator ==(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Handle == right.Handle;
										public static bool operator !=(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Handle != right.Handle;
										public static bool operator ==(VkDescriptorSetLayout left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDescriptorSetLayout left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDescriptorSetLayout other) => Handle == other.Handle;
										public bool Equals(VkDescriptorSetLayout other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDescriptorSetLayout handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDescriptorSetLayout [0x{Handle:X}]";
									}

									public partial struct VkDescriptorPool : IEquatable<VkDescriptorPool>
									{
										public readonly ulong Handle;
										public VkDescriptorPool(ulong handle) { Handle = handle; }
										public static VkDescriptorPool Null => new(0);
										public static implicit operator VkDescriptorPool(ulong handle) => new(handle);
										public static bool operator ==(VkDescriptorPool left, VkDescriptorPool right) => left.Handle == right.Handle;
										public static bool operator !=(VkDescriptorPool left, VkDescriptorPool right) => left.Handle != right.Handle;
										public static bool operator ==(VkDescriptorPool left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDescriptorPool left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDescriptorPool other) => Handle == other.Handle;
										public bool Equals(VkDescriptorPool other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDescriptorPool handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDescriptorPool [0x{Handle:X}]";
									}

									public partial struct VkFence : IEquatable<VkFence>
									{
										public readonly ulong Handle;
										public VkFence(ulong handle) { Handle = handle; }
										public static VkFence Null => new(0);
										public static implicit operator VkFence(ulong handle) => new(handle);
										public static bool operator ==(VkFence left, VkFence right) => left.Handle == right.Handle;
										public static bool operator !=(VkFence left, VkFence right) => left.Handle != right.Handle;
										public static bool operator ==(VkFence left, ulong right) => left.Handle == right;
										public static bool operator !=(VkFence left, ulong right) => left.Handle != right;
										public bool Equals(ref VkFence other) => Handle == other.Handle;
										public bool Equals(VkFence other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkFence handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkFence [0x{Handle:X}]";
									}

									public partial struct VkSemaphore : IEquatable<VkSemaphore>
									{
										public readonly ulong Handle;
										public VkSemaphore(ulong handle) { Handle = handle; }
										public static VkSemaphore Null => new(0);
										public static implicit operator VkSemaphore(ulong handle) => new(handle);
										public static bool operator ==(VkSemaphore left, VkSemaphore right) => left.Handle == right.Handle;
										public static bool operator !=(VkSemaphore left, VkSemaphore right) => left.Handle != right.Handle;
										public static bool operator ==(VkSemaphore left, ulong right) => left.Handle == right;
										public static bool operator !=(VkSemaphore left, ulong right) => left.Handle != right;
										public bool Equals(ref VkSemaphore other) => Handle == other.Handle;
										public bool Equals(VkSemaphore other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkSemaphore handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkSemaphore [0x{Handle:X}]";
									}

									public partial struct VkEvent : IEquatable<VkEvent>
									{
										public readonly ulong Handle;
										public VkEvent(ulong handle) { Handle = handle; }
										public static VkEvent Null => new(0);
										public static implicit operator VkEvent(ulong handle) => new(handle);
										public static bool operator ==(VkEvent left, VkEvent right) => left.Handle == right.Handle;
										public static bool operator !=(VkEvent left, VkEvent right) => left.Handle != right.Handle;
										public static bool operator ==(VkEvent left, ulong right) => left.Handle == right;
										public static bool operator !=(VkEvent left, ulong right) => left.Handle != right;
										public bool Equals(ref VkEvent other) => Handle == other.Handle;
										public bool Equals(VkEvent other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkEvent handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkEvent [0x{Handle:X}]";
									}

									public partial struct VkQueryPool : IEquatable<VkQueryPool>
									{
										public readonly ulong Handle;
										public VkQueryPool(ulong handle) { Handle = handle; }
										public static VkQueryPool Null => new(0);
										public static implicit operator VkQueryPool(ulong handle) => new(handle);
										public static bool operator ==(VkQueryPool left, VkQueryPool right) => left.Handle == right.Handle;
										public static bool operator !=(VkQueryPool left, VkQueryPool right) => left.Handle != right.Handle;
										public static bool operator ==(VkQueryPool left, ulong right) => left.Handle == right;
										public static bool operator !=(VkQueryPool left, ulong right) => left.Handle != right;
										public bool Equals(ref VkQueryPool other) => Handle == other.Handle;
										public bool Equals(VkQueryPool other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkQueryPool handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkQueryPool [0x{Handle:X}]";
									}

									public partial struct VkFramebuffer : IEquatable<VkFramebuffer>
									{
										public readonly ulong Handle;
										public VkFramebuffer(ulong handle) { Handle = handle; }
										public static VkFramebuffer Null => new(0);
										public static implicit operator VkFramebuffer(ulong handle) => new(handle);
										public static bool operator ==(VkFramebuffer left, VkFramebuffer right) => left.Handle == right.Handle;
										public static bool operator !=(VkFramebuffer left, VkFramebuffer right) => left.Handle != right.Handle;
										public static bool operator ==(VkFramebuffer left, ulong right) => left.Handle == right;
										public static bool operator !=(VkFramebuffer left, ulong right) => left.Handle != right;
										public bool Equals(ref VkFramebuffer other) => Handle == other.Handle;
										public bool Equals(VkFramebuffer other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkFramebuffer handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkFramebuffer [0x{Handle:X}]";
									}

									public partial struct VkRenderPass : IEquatable<VkRenderPass>
									{
										public readonly ulong Handle;
										public VkRenderPass(ulong handle) { Handle = handle; }
										public static VkRenderPass Null => new(0);
										public static implicit operator VkRenderPass(ulong handle) => new(handle);
										public static bool operator ==(VkRenderPass left, VkRenderPass right) => left.Handle == right.Handle;
										public static bool operator !=(VkRenderPass left, VkRenderPass right) => left.Handle != right.Handle;
										public static bool operator ==(VkRenderPass left, ulong right) => left.Handle == right;
										public static bool operator !=(VkRenderPass left, ulong right) => left.Handle != right;
										public bool Equals(ref VkRenderPass other) => Handle == other.Handle;
										public bool Equals(VkRenderPass other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkRenderPass handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkRenderPass [0x{Handle:X}]";
									}

									public partial struct VkPipelineCache : IEquatable<VkPipelineCache>
									{
										public readonly ulong Handle;
										public VkPipelineCache(ulong handle) { Handle = handle; }
										public static VkPipelineCache Null => new(0);
										public static implicit operator VkPipelineCache(ulong handle) => new(handle);
										public static bool operator ==(VkPipelineCache left, VkPipelineCache right) => left.Handle == right.Handle;
										public static bool operator !=(VkPipelineCache left, VkPipelineCache right) => left.Handle != right.Handle;
										public static bool operator ==(VkPipelineCache left, ulong right) => left.Handle == right;
										public static bool operator !=(VkPipelineCache left, ulong right) => left.Handle != right;
										public bool Equals(ref VkPipelineCache other) => Handle == other.Handle;
										public bool Equals(VkPipelineCache other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkPipelineCache handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkPipelineCache [0x{Handle:X}]";
									}

									public partial struct VkIndirectCommandsLayoutNV : IEquatable<VkIndirectCommandsLayoutNV>
									{
										public readonly ulong Handle;
										public VkIndirectCommandsLayoutNV(ulong handle) { Handle = handle; }
										public static VkIndirectCommandsLayoutNV Null => new(0);
										public static implicit operator VkIndirectCommandsLayoutNV(ulong handle) => new(handle);
										public static bool operator ==(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Handle == right.Handle;
										public static bool operator !=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Handle != right.Handle;
										public static bool operator ==(VkIndirectCommandsLayoutNV left, ulong right) => left.Handle == right;
										public static bool operator !=(VkIndirectCommandsLayoutNV left, ulong right) => left.Handle != right;
										public bool Equals(ref VkIndirectCommandsLayoutNV other) => Handle == other.Handle;
										public bool Equals(VkIndirectCommandsLayoutNV other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkIndirectCommandsLayoutNV handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkIndirectCommandsLayoutNV [0x{Handle:X}]";
									}

									public partial struct VkDescriptorUpdateTemplate : IEquatable<VkDescriptorUpdateTemplate>
									{
										public readonly ulong Handle;
										public VkDescriptorUpdateTemplate(ulong handle) { Handle = handle; }
										public static VkDescriptorUpdateTemplate Null => new(0);
										public static implicit operator VkDescriptorUpdateTemplate(ulong handle) => new(handle);
										public static bool operator ==(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Handle == right.Handle;
										public static bool operator !=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Handle != right.Handle;
										public static bool operator ==(VkDescriptorUpdateTemplate left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDescriptorUpdateTemplate left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDescriptorUpdateTemplate other) => Handle == other.Handle;
										public bool Equals(VkDescriptorUpdateTemplate other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDescriptorUpdateTemplate handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDescriptorUpdateTemplate [0x{Handle:X}]";
									}

									public partial struct VkSamplerYcbcrConversion : IEquatable<VkSamplerYcbcrConversion>
									{
										public readonly ulong Handle;
										public VkSamplerYcbcrConversion(ulong handle) { Handle = handle; }
										public static VkSamplerYcbcrConversion Null => new(0);
										public static implicit operator VkSamplerYcbcrConversion(ulong handle) => new(handle);
										public static bool operator ==(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Handle == right.Handle;
										public static bool operator !=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Handle != right.Handle;
										public static bool operator ==(VkSamplerYcbcrConversion left, ulong right) => left.Handle == right;
										public static bool operator !=(VkSamplerYcbcrConversion left, ulong right) => left.Handle != right;
										public bool Equals(ref VkSamplerYcbcrConversion other) => Handle == other.Handle;
										public bool Equals(VkSamplerYcbcrConversion other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkSamplerYcbcrConversion handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkSamplerYcbcrConversion [0x{Handle:X}]";
									}

									public partial struct VkValidationCacheEXT : IEquatable<VkValidationCacheEXT>
									{
										public readonly ulong Handle;
										public VkValidationCacheEXT(ulong handle) { Handle = handle; }
										public static VkValidationCacheEXT Null => new(0);
										public static implicit operator VkValidationCacheEXT(ulong handle) => new(handle);
										public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Handle == right.Handle;
										public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Handle != right.Handle;
										public static bool operator ==(VkValidationCacheEXT left, ulong right) => left.Handle == right;
										public static bool operator !=(VkValidationCacheEXT left, ulong right) => left.Handle != right;
										public bool Equals(ref VkValidationCacheEXT other) => Handle == other.Handle;
										public bool Equals(VkValidationCacheEXT other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkValidationCacheEXT handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkValidationCacheEXT [0x{Handle:X}]";
									}

									public partial struct VkAccelerationStructureKHR : IEquatable<VkAccelerationStructureKHR>
									{
										public readonly ulong Handle;
										public VkAccelerationStructureKHR(ulong handle) { Handle = handle; }
										public static VkAccelerationStructureKHR Null => new(0);
										public static implicit operator VkAccelerationStructureKHR(ulong handle) => new(handle);
										public static bool operator ==(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Handle == right.Handle;
										public static bool operator !=(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Handle != right.Handle;
										public static bool operator ==(VkAccelerationStructureKHR left, ulong right) => left.Handle == right;
										public static bool operator !=(VkAccelerationStructureKHR left, ulong right) => left.Handle != right;
										public bool Equals(ref VkAccelerationStructureKHR other) => Handle == other.Handle;
										public bool Equals(VkAccelerationStructureKHR other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkAccelerationStructureKHR handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkAccelerationStructureKHR [0x{Handle:X}]";
									}

									public partial struct VkAccelerationStructureNV : IEquatable<VkAccelerationStructureNV>
									{
										public readonly ulong Handle;
										public VkAccelerationStructureNV(ulong handle) { Handle = handle; }
										public static VkAccelerationStructureNV Null => new(0);
										public static implicit operator VkAccelerationStructureNV(ulong handle) => new(handle);
										public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Handle == right.Handle;
										public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Handle != right.Handle;
										public static bool operator ==(VkAccelerationStructureNV left, ulong right) => left.Handle == right;
										public static bool operator !=(VkAccelerationStructureNV left, ulong right) => left.Handle != right;
										public bool Equals(ref VkAccelerationStructureNV other) => Handle == other.Handle;
										public bool Equals(VkAccelerationStructureNV other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkAccelerationStructureNV handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkAccelerationStructureNV [0x{Handle:X}]";
									}

									public partial struct VkPerformanceConfigurationINTEL : IEquatable<VkPerformanceConfigurationINTEL>
									{
										public readonly ulong Handle;
										public VkPerformanceConfigurationINTEL(ulong handle) { Handle = handle; }
										public static VkPerformanceConfigurationINTEL Null => new(0);
										public static implicit operator VkPerformanceConfigurationINTEL(ulong handle) => new(handle);
										public static bool operator ==(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Handle == right.Handle;
										public static bool operator !=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Handle != right.Handle;
										public static bool operator ==(VkPerformanceConfigurationINTEL left, ulong right) => left.Handle == right;
										public static bool operator !=(VkPerformanceConfigurationINTEL left, ulong right) => left.Handle != right;
										public bool Equals(ref VkPerformanceConfigurationINTEL other) => Handle == other.Handle;
										public bool Equals(VkPerformanceConfigurationINTEL other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkPerformanceConfigurationINTEL handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkPerformanceConfigurationINTEL [0x{Handle:X}]";
									}

									public partial struct VkDeferredOperationKHR : IEquatable<VkDeferredOperationKHR>
									{
										public readonly ulong Handle;
										public VkDeferredOperationKHR(ulong handle) { Handle = handle; }
										public static VkDeferredOperationKHR Null => new(0);
										public static implicit operator VkDeferredOperationKHR(ulong handle) => new(handle);
										public static bool operator ==(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Handle == right.Handle;
										public static bool operator !=(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Handle != right.Handle;
										public static bool operator ==(VkDeferredOperationKHR left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDeferredOperationKHR left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDeferredOperationKHR other) => Handle == other.Handle;
										public bool Equals(VkDeferredOperationKHR other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDeferredOperationKHR handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDeferredOperationKHR [0x{Handle:X}]";
									}

									public partial struct VkPrivateDataSlotEXT : IEquatable<VkPrivateDataSlotEXT>
									{
										public readonly ulong Handle;
										public VkPrivateDataSlotEXT(ulong handle) { Handle = handle; }
										public static VkPrivateDataSlotEXT Null => new(0);
										public static implicit operator VkPrivateDataSlotEXT(ulong handle) => new(handle);
										public static bool operator ==(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Handle == right.Handle;
										public static bool operator !=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Handle != right.Handle;
										public static bool operator ==(VkPrivateDataSlotEXT left, ulong right) => left.Handle == right;
										public static bool operator !=(VkPrivateDataSlotEXT left, ulong right) => left.Handle != right;
										public bool Equals(ref VkPrivateDataSlotEXT other) => Handle == other.Handle;
										public bool Equals(VkPrivateDataSlotEXT other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkPrivateDataSlotEXT handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkPrivateDataSlotEXT [0x{Handle:X}]";
									}

									public partial struct VkDisplayKHR : IEquatable<VkDisplayKHR>
									{
										public readonly ulong Handle;
										public VkDisplayKHR(ulong handle) { Handle = handle; }
										public static VkDisplayKHR Null => new(0);
										public static implicit operator VkDisplayKHR(ulong handle) => new(handle);
										public static bool operator ==(VkDisplayKHR left, VkDisplayKHR right) => left.Handle == right.Handle;
										public static bool operator !=(VkDisplayKHR left, VkDisplayKHR right) => left.Handle != right.Handle;
										public static bool operator ==(VkDisplayKHR left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDisplayKHR left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDisplayKHR other) => Handle == other.Handle;
										public bool Equals(VkDisplayKHR other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDisplayKHR handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDisplayKHR [0x{Handle:X}]";
									}

									public partial struct VkDisplayModeKHR : IEquatable<VkDisplayModeKHR>
									{
										public readonly ulong Handle;
										public VkDisplayModeKHR(ulong handle) { Handle = handle; }
										public static VkDisplayModeKHR Null => new(0);
										public static implicit operator VkDisplayModeKHR(ulong handle) => new(handle);
										public static bool operator ==(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Handle == right.Handle;
										public static bool operator !=(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Handle != right.Handle;
										public static bool operator ==(VkDisplayModeKHR left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDisplayModeKHR left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDisplayModeKHR other) => Handle == other.Handle;
										public bool Equals(VkDisplayModeKHR other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDisplayModeKHR handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDisplayModeKHR [0x{Handle:X}]";
									}

									public partial struct VkSurfaceKHR : IEquatable<VkSurfaceKHR>
									{
										public readonly ulong Handle;
										public VkSurfaceKHR(ulong handle) { Handle = handle; }
										public static VkSurfaceKHR Null => new(0);
										public static implicit operator VkSurfaceKHR(ulong handle) => new(handle);
										public static bool operator ==(VkSurfaceKHR left, VkSurfaceKHR right) => left.Handle == right.Handle;
										public static bool operator !=(VkSurfaceKHR left, VkSurfaceKHR right) => left.Handle != right.Handle;
										public static bool operator ==(VkSurfaceKHR left, ulong right) => left.Handle == right;
										public static bool operator !=(VkSurfaceKHR left, ulong right) => left.Handle != right;
										public bool Equals(ref VkSurfaceKHR other) => Handle == other.Handle;
										public bool Equals(VkSurfaceKHR other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkSurfaceKHR handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkSurfaceKHR [0x{Handle:X}]";
									}

									public partial struct VkSwapchainKHR : IEquatable<VkSwapchainKHR>
									{
										public readonly ulong Handle;
										public VkSwapchainKHR(ulong handle) { Handle = handle; }
										public static VkSwapchainKHR Null => new(0);
										public static implicit operator VkSwapchainKHR(ulong handle) => new(handle);
										public static bool operator ==(VkSwapchainKHR left, VkSwapchainKHR right) => left.Handle == right.Handle;
										public static bool operator !=(VkSwapchainKHR left, VkSwapchainKHR right) => left.Handle != right.Handle;
										public static bool operator ==(VkSwapchainKHR left, ulong right) => left.Handle == right;
										public static bool operator !=(VkSwapchainKHR left, ulong right) => left.Handle != right;
										public bool Equals(ref VkSwapchainKHR other) => Handle == other.Handle;
										public bool Equals(VkSwapchainKHR other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkSwapchainKHR handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkSwapchainKHR [0x{Handle:X}]";
									}

									public partial struct VkDebugReportCallbackEXT : IEquatable<VkDebugReportCallbackEXT>
									{
										public readonly ulong Handle;
										public VkDebugReportCallbackEXT(ulong handle) { Handle = handle; }
										public static VkDebugReportCallbackEXT Null => new(0);
										public static implicit operator VkDebugReportCallbackEXT(ulong handle) => new(handle);
										public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Handle == right.Handle;
										public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Handle != right.Handle;
										public static bool operator ==(VkDebugReportCallbackEXT left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDebugReportCallbackEXT left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDebugReportCallbackEXT other) => Handle == other.Handle;
										public bool Equals(VkDebugReportCallbackEXT other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDebugReportCallbackEXT handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDebugReportCallbackEXT [0x{Handle:X}]";
									}

									public partial struct VkDebugUtilsMessengerEXT : IEquatable<VkDebugUtilsMessengerEXT>
									{
										public readonly ulong Handle;
										public VkDebugUtilsMessengerEXT(ulong handle) { Handle = handle; }
										public static VkDebugUtilsMessengerEXT Null => new(0);
										public static implicit operator VkDebugUtilsMessengerEXT(ulong handle) => new(handle);
										public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Handle == right.Handle;
										public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Handle != right.Handle;
										public static bool operator ==(VkDebugUtilsMessengerEXT left, ulong right) => left.Handle == right;
										public static bool operator !=(VkDebugUtilsMessengerEXT left, ulong right) => left.Handle != right;
										public bool Equals(ref VkDebugUtilsMessengerEXT other) => Handle == other.Handle;
										public bool Equals(VkDebugUtilsMessengerEXT other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is VkDebugUtilsMessengerEXT handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $"VkDebugUtilsMessengerEXT [0x{Handle:X}]";
									}
}