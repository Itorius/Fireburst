using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FireburstGenerator
{
	public class StructGenerator : IGenerator
	{
		private static class Constants
		{
			public const ulong VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256;
			public const ulong VK_MAX_EXTENSION_NAME_SIZE = 256;
			public const ulong VK_MAX_DESCRIPTION_SIZE = 256;

			public const ulong VK_UUID_SIZE = 16;
			public const ulong VK_LUID_SIZE = 8;

			public const ulong VK_MAX_MEMORY_TYPES = 32;
			public const ulong VK_MAX_MEMORY_HEAPS = 16;

			public const float VK_LOD_CLAMP_NONE = 1000.0f;

			public const ulong VK_REMAINING_MIP_LEVELS = ~0U;
			public const ulong VK_REMAINING_ARRAY_LAYERS = ~0U;
			public const ulong VK_WHOLE_SIZE = ~0U;
			public const ulong VK_ATTACHMENT_UNUSED = ~0U;
			public const ulong VK_TRUE = 1;
			public const ulong VK_FALSE = 0;
			public const ulong VK_QUEUE_FAMILY_IGNORED = ~0U;
			public const ulong VK_QUEUE_FAMILY_EXTERNAL = ~0U - 1;
			public const ulong VK_QUEUE_FAMILY_FOREIGN_EXT = ~0U - 2;
			public const ulong VK_SUBPASS_EXTERNAL = ~0U;
			public const ulong VK_MAX_DEVICE_GROUP_SIZE = 32;
			public const ulong VK_MAX_DRIVER_NAME_SIZE = 256;
			public const ulong VK_MAX_DRIVER_INFO_SIZE = 256;
			public const ulong VK_SHADER_UNUSED_KHR = ~0U;
		}

		private static readonly HashSet<string> IgnoredStructs = new()
		{
			"VkAllocationCallbacks",
			"VkDebugReportCallbackCreateInfoEXT",
			"VkDebugUtilsMessengerCreateInfoEXT",
			"VkDeviceDeviceMemoryReportCreateInfoEXT",
			"VkViewport",
			"VkRect2D",
			"VkComponentMapping",
			"VkTransformMatrixKHR"
		};

		private static readonly HashSet<string> ValidFixedBufferTypes = new()
		{
			"bool", "byte", "char", "short", "int", "long", "sbyte", "ushort", "uint", "ulong", "float", "double"
		};

		public void Generate(Registry registry, string outputDir)
		{
			GenerateStructs(registry, outputDir);

			GenerateUnions(registry, outputDir);
		}

		private static void GenerateUnions(Registry registry, string outputDir)
		{
			CodeWriter writer = new("Fireburst", "System", "System.Runtime.InteropServices");

			foreach (Type type in registry.Types.Type.Where(x => x.Category == "union"))
			{
				if (type.Alias != null)
				{
					Utility.TypeMap.Add(type.Name, type.Alias);

					continue;
				}

				if (IgnoredStructs.Contains(type.Name) || Utility.TypeMap.ContainsKey(type.Name))
					continue;

				writer.WriteLine("[StructLayout(LayoutKind.Explicit)]");
				writer.WriteLine($"public partial struct {type.Name}");
				writer.WriteLine("{");
				writer.Indent();

				foreach (Member member in type.Member)
				{
					writer.WriteLine("[FieldOffset(0)]");
					writer.WriteLine(member.Type == "void" ? $"public unsafe {Utility.ResolveType(member.Type)}* {member.Name};" : $"public {Utility.ResolveType(member.Type)} {member.Name};");
				}

				writer.Unindent();
				writer.WriteLine("}");
				writer.WriteLine();
			}

			File.WriteAllText(outputDir + "Vulkan.Unions.cs", writer.ToString());
		}

		private static void GenerateStructs(Registry registry, string outputDir)
		{
			CodeWriter writer = new("Fireburst", "System", "System.Runtime.InteropServices");

			foreach (Type type in registry.Types.Type.Where(x => x.Category == "struct"))
			{
				if (type.Alias != null)
				{
					Utility.TypeMap.Add(type.Name, type.Alias);

					continue;
				}

				if (IgnoredStructs.Contains(type.Name) || Utility.TypeMap.ContainsKey(type.Name))
					continue;

				writer.WriteLine("[StructLayout(LayoutKind.Sequential)]");
				writer.WriteLine($"public partial struct {type.Name}");
				writer.WriteLine("{");
				writer.Indent();

				foreach (Member member in type.Member)
				{
					if (member.Name == "object") member.Name = "@object";

					int count = 0;
					foreach (char c in member.Name)
					{
						if (c == 'p') count++;
						else
						{
							if (char.IsLower(c)) count = 0;
							break;
						}
					}

					string memberType = Utility.ResolveType(member.Type);
					if (member.Text != null && (member.Text.Contains('[') || member.Text.Contains(']')))
					{
						if (ValidFixedBufferTypes.Contains(memberType) && member.Enum != null)
						{
							writer.WriteLine($"public unsafe fixed {memberType} {member.Name}[Constants.{member.Enum}];");
							continue;
						}

						ulong length = 0;
						if (member.Enum != null)
						{
							var fieldInfo = typeof(Constants).GetField(member.Enum);
							length = (ulong)fieldInfo.GetValue(null);
						}
						else length = ulong.Parse(member.Text[1..^1]);

						for (nuint i = 0; i < length; i++)
						{
							writer.WriteLine($"public {memberType} {member.Name}_{i};");
						}

						continue;
					}

					if (count <= 0 && member.Text != null && member.Text.Contains('*')) count = 1;

					writer.WriteLine(count > 0 ? $"public unsafe {memberType}{new string('*', count)} {member.Name};" : $"public {memberType} {member.Name};");
				}

				writer.Unindent();
				writer.WriteLine("}");
				writer.WriteLine();
			}

			File.WriteAllText(outputDir + "Vulkan.Structs.cs", writer.ToString());
		}
	}
}