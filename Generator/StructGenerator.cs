using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FireburstGenerator;

public class StructGenerator : IGenerator
{
	private static readonly HashSet<string> IgnoredStructs = new()
	{
		"VkAllocationCallbacks",
		"VkDebugReportCallbackCreateInfoEXT",
		"VkDebugUtilsMessengerCreateInfoEXT",
		"VkDeviceDeviceMemoryReportCreateInfoEXT",
		"VkViewport",
		"VkRect2D",
		"VkComponentMapping",
		"VkTransformMatrixKHR",
		"VkClearColorValue",
		"VkClearValue"
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
						writer.WriteLine($"public unsafe fixed {memberType} {member.Name}[Vulkan.{member.Enum}];");
						continue;
					}

					ulong length = 0;
					if (member.Enum != null)
					{
						if (ConstantGenerator.Constants.TryGetValue(member.Enum, out object? value) && ulong.TryParse(value.ToString(), out ulong kek))
						{
							length = kek;
						}
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