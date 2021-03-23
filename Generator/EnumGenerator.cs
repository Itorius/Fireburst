using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FireburstGenerator
{
	public class EnumGenerator : IGenerator
	{
		private static readonly Dictionary<string, string> KnownNames = new()
		{
			{ "VK_STENCIL_FRONT_AND_BACK", "FrontAndBack" },
			{ "VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO", "MemoryAllocateFlagsInfo" },

			// VkSampleCountFlagBits
			{ "VK_SAMPLE_COUNT_1_BIT", "Count1" },
			{ "VK_SAMPLE_COUNT_2_BIT", "Count2" },
			{ "VK_SAMPLE_COUNT_4_BIT", "Count4" },
			{ "VK_SAMPLE_COUNT_8_BIT", "Count8" },
			{ "VK_SAMPLE_COUNT_16_BIT", "Count16" },
			{ "VK_SAMPLE_COUNT_32_BIT", "Count32" },
			{ "VK_SAMPLE_COUNT_64_BIT", "Count64" },

			// VkImageType
			{ "VK_IMAGE_TYPE_1D", "Image1D" },
			{ "VK_IMAGE_TYPE_2D", "Image2D" },
			{ "VK_IMAGE_TYPE_3D", "Image3D" },

			// VkImageViewType
			{ "VK_IMAGE_VIEW_TYPE_1D", "Image1D" },
			{ "VK_IMAGE_VIEW_TYPE_2D", "Image2D" },
			{ "VK_IMAGE_VIEW_TYPE_3D", "Image3D" },
			{ "VK_IMAGE_VIEW_TYPE_CUBE", "ImageCube" },
			{ "VK_IMAGE_VIEW_TYPE_1D_ARRAY", "Image1DArray" },
			{ "VK_IMAGE_VIEW_TYPE_2D_ARRAY", "Image2DArray" },
			{ "VK_IMAGE_VIEW_TYPE_CUBE_ARRAY", "ImageCubeArray" },

			// VkColorSpaceKHR
			{ "VK_COLOR_SPACE_SRGB_NONLINEAR_KHR", "SrgbNonLinearKHR" },
			{ "VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT", "DisplayP3NonLinearEXT" },
			{ "VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT", "DciP3NonLinearEXT" },
			{ "VK_COLOR_SPACE_BT709_NONLINEAR_EXT", "Bt709NonLinearEXT" },
			{ "VK_COLOR_SPACE_DOLBYVISION_EXT", "DolbyVisionEXT" },
			{ "VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT", "AdobeRgbLinearEXT" },
			{ "VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT", "AdobeRgbNonLinearEXT" },
			{ "VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT", "ExtendedSrgbNonLinearEXT" },
			{ "VK_COLORSPACE_SRGB_NONLINEAR_KHR", "SrgbNonLinearKHR" },

			// VkShadingRatePaletteEntryNV
			{ "VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV", "SixteenInvocationsPerPixel" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV", "EightInvocationsPerPixel" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV", "FourInvocationsPerPixel" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV", "TwoInvocationsPerPixel" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV", "OneInvocationPerPixel" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV", "OneInvocationPer2x1Pixels" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV", "OneInvocationPer1x2Pixels" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV", "OneInvocationPer2x2Pixels" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV", "OneInvocationPer4x2Pixels" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV", "OneInvocationPer2x4Pixels" },
			{ "VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV", "OneInvocationPer4x4Pixels" },

			// VkFragmentShadingRateNV
			{ "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV", "OneInvocationPerPixel" },
			{ "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV", "OneInvocationPer1x2Pixels" },
			{ "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV", "OneInvocationPer2x1Pixels" },
			{ "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV", "OneInvocationPer2x2Pixels" },
			{ "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV", "OneInvocationPer2x4Pixels" },
			{ "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV", "OneInvocationPer4x2Pixels" },
			{ "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV", "OneInvocationPer4x4Pixels" },
			{ "VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV", "TwoInvocationsPerPixel" },
			{ "VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV", "FourInvocationsPerPixel" },
			{ "VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV", "EightInvocationsPerPixel" },
			{ "VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV", "SixteenInvocationsPerPixel" },
			{ "VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV", "NoInvocations" },

			// VkDriverId
			{ "VK_DRIVER_ID_GOOGLE_SWIFTSHADER", "GoogleSwiftShader" },
			{ "VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR", "GoogleSwiftShaderKHR" },
			{ "VK_DRIVER_ID_MESA_LLVMPIPE", "MesaLLVMPipe" },

			// VkGeometryTypeNV
			{ "VK_GEOMETRY_TYPE_TRIANGLES_NV", "Triangles" },
			{ "VK_GEOMETRY_TYPE_AABBS_NVX", "AABBs" },

			// VkCopyAccelerationStructureModeNV
			{ "VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV", "Clone" },
			{ "VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV", "Compact" },

			// VkAccelerationStructureTypeNV
			{ "VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV", "TopLevel" },
			{ "VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV", "BottomLevel" },

			// VkAccelerationStructureMemoryRequirementsTypeNV
			{ "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV", "Object" },
			{ "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV", "BuildScratch" },
			{ "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV", "UpdateScratch" },

			// VkRayTracingShaderGroupTypeNV
			{ "VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV", "General" },
			{ "VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV", "TrianglesHitGroup" },
			{ "VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV", "ProceduralHitGroup" },

			// VkPerformanceCounterScopeKHR
			{ "VK_QUERY_SCOPE_COMMAND_BUFFER_KHR", "QueryScopeCommandBufferKHR" },
			{ "VK_QUERY_SCOPE_RENDER_PASS_KHR", "QueryScopeRenderPassKHR" },
			{ "VK_QUERY_SCOPE_COMMAND_KHR", "QueryScopeCommandKHR" },

			// VkPerformanceConfigurationTypeINTEL
			{ "VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL", "CommandQueueMetricsDiscoveryActivatedIntel" }
		};

		private static readonly Dictionary<string, string> KnownPrefixes = new()
		{
			{ "VkResult", "VK" },
			{ "VkViewportCoordinateSwizzleNV", "VK_VIEWPORT_COORDINATE_SWIZZLE" },
			{ "VkCoverageModulationModeNV", "VK_COVERAGE_MODULATION_MODE" },
			{ "VkShadingRatePaletteEntryNV", "VK_SHADING_RATE_PALETTE_ENTRY" },
			{ "VkCoarseSampleOrderTypeNV", "VK_COARSE_SAMPLE_ORDER_TYPE" },
			{ "VkCopyAccelerationStructureModeNVX", "VK_COPY_ACCELERATION_STRUCTURE_MODE" },
			{ "VkPipelineStageFlags2KHR", "VK_PIPELINE_STAGE_2" },
			{ "VkAccessFlags2KHR", "VK_ACCESS_2" }
		};

		private static readonly HashSet<string> PreserveCaps = new(StringComparer.OrdinalIgnoreCase)
		{
			"khr",
			"khx",
			"ext",
			"nv",
			"nvx",
			"amd",
			"intel"
		};

		private static readonly HashSet<string> IgnoredParts = new(StringComparer.OrdinalIgnoreCase)
		{
			"flags",
			"bit"
		};

		private static readonly HashSet<string> IgnoredExtensions = new()
		{
			"EXT", "NV", "KHR"
		};

		private static readonly Regex PrefixRegex = new(@"(?<=[a-z])(?=[A-Z])", RegexOptions.Compiled);

		public static string GetPrefix(string typeName)
		{
			if (KnownPrefixes.TryGetValue(typeName, out string knownValue)) return knownValue;

			string[] parts = PrefixRegex.Split(typeName);

			for (int i = 0; i < parts.Length; i++)
			{
				bool isNotLast = i + 1 < parts.Length;
				if (parts[i] == "Flag" ||
				    parts[i] == "Flags" ||
				    parts[i] == "KHR" ||
				    parts[i] == "AMD" ||
				    parts[i] == "EXT" ||
				    parts[i] == "Type" && isNotLast && parts[i + 1] == "NV" ||
				    parts[i] == "Type" && isNotLast && parts[i + 1] == "NVX" ||
				    parts[i] == "Scope" && isNotLast && parts[i + 1] == "NV" ||
				    parts[i] == "Mode" && isNotLast && parts[i + 1] == "NV" ||
				    parts[i] == "Mode" && isNotLast && parts[i + 1] == "INTEL" ||
				    parts[i] == "Type" && isNotLast && parts[i + 1] == "INTEL"
				)
				{
					parts = parts.Take(i).ToArray();
					break;
				}
			}

			return string.Join("_", parts.Select(s => s.ToUpper()));
		}

		private static string GetName(string value, string enumPrefix)
		{
			if (KnownNames.TryGetValue(value, out string knownName)) return knownName;
			if (value.IndexOf(enumPrefix) != 0) return value;

			foreach (string extension in IgnoredExtensions)
			{
				if (value.EndsWith(extension))
				{
					value = value[..^extension.Length];
					break;
				}
			}

			string[] parts = value[enumPrefix.Length..].Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

			StringBuilder builder = new();
			foreach (string part in parts)
			{
				if (IgnoredParts.Contains(part)) continue;

				if (PreserveCaps.Contains(part))
				{
					builder.Append(part);
					continue;
				}

				builder.Append(char.ToUpper(part[0]));
				for (int i = 1; i < part.Length; i++) builder.Append(char.ToLower(part[i]));
			}

			string prettyName = builder.ToString();
			return char.IsNumber(prettyName[0]) ? "_" + prettyName : prettyName;
		}

		public void Generate(Registry registry, string outputDir)
		{
			registry.Enums.RemoveAt(0);
			var grouped = registry.Enums.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.ToList());

			GenerateEnums(outputDir, grouped["enum"]);
			GenerateFlags(outputDir, grouped["bitmask"]);

			CodeWriter writer = new("Fireburst", "System");

			foreach (Type type in registry.Types.Type.Where(x => x.Category == "bitmask" || x.Category == "enum"))
			{
				if (type.Alias != null)
				{
					Utility.TypeMap.Add(type.Name, type.Alias);
					continue;
				}

				if (type.ElementName != null)
				{
					if (Utility.TypeMap.ContainsValue(type.ElementName)) continue;

					string name = type.ElementName;

					writer.WriteLine("[Flags]");

					string orig = name;
					name = name.Replace("FlagBits", "Flags");
					Utility.TypeMap.Add(orig, name);

					writer.WriteLine($"public enum {name}");
					writer.WriteLine("{");
					writer.Indent();

					writer.WriteLine("None = 0");

					writer.Unindent();
					writer.WriteLine("}");
					writer.WriteLine();
				}
			}

			File.WriteAllText(outputDir + "Vulkan.EmptyEnums.cs", writer.ToString());
		}

		private static void GenerateFlags(string outputDir, IEnumerable<Enum> enums)
		{
			CodeWriter writer = new("Fireburst", "System");

			foreach (Enum @enum in enums)
			{
				string name = @enum.Name;

				writer.WriteLine("[Flags]");

				string orig = name;
				name = name.Replace("FlagBits", "Flags");
				Utility.TypeMap.Add(orig, name);

				string prefix = GetPrefix(name);

				writer.WriteLine(@enum.Bitwidth == 64 ? $"public enum {name} : long" : $"public enum {name}");
				writer.WriteLine("{");
				writer.Indent();

				if (@enum.Members.Count == 0)
				{
					writer.WriteLine("None = 0");
				}
				else
				{
					if (@enum.Members.All(x => x.Value != "0")) writer.WriteLine("None = 0,");

					foreach (EnumMember member in @enum.Members)
					{
						if (member.Alias != null) continue;

						string val = member.Bitpos != null ? (1L << int.Parse(member.Bitpos)).ToString() : member.Value;

						writer.WriteLine($"{GetName(member.Name, prefix)} = {val},");
					}

					if (name == "VkColorComponentFlags")
					{
						writer.WriteLine("All = R | G | B | A");
					}
				}

				writer.Unindent();
				writer.WriteLine("}");
				writer.WriteLine();
			}

			File.WriteAllText(outputDir + "Vulkan.Flags.cs", writer.ToString());
		}

		private static void GenerateEnums(string outputDir, IEnumerable<Enum> enums)
		{
			CodeWriter writer = new("Fireburst", "System");

			foreach (Enum @enum in enums)
			{
				string name = @enum.Name;
				string prefix = GetPrefix(name);

				writer.WriteLine(@enum.Bitwidth == 64 ? $"public enum {name} : long" : $"public enum {name}");
				writer.WriteLine("{");
				writer.Indent();

				if (@enum.Members.Count == 0)
				{
					writer.WriteLine("None = 0");
				}
				else
				{
					foreach (EnumMember member in @enum.Members)
					{
						if (member.Alias != null) continue;

						string val = member.Bitpos != null ? (1L << int.Parse(member.Bitpos)).ToString() : member.Value;

						writer.WriteLine($"{GetName(member.Name, prefix)} = {val},");
					}
				}

				writer.Unindent();
				writer.WriteLine("}");
				writer.WriteLine();
			}

			File.WriteAllText(outputDir + "Vulkan.Enums.cs", writer.ToString());
		}
	}
}