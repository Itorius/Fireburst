using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace FireburstGenerator
{
	public class StructGenerator : IGenerator
	{
		private static List<string> IgnoredStructs = new()
		{
			"VkAllocationCallbacks",
			"VkDebugReportCallbackCreateInfoEXT",
			"VkDebugUtilsMessengerCreateInfoEXT",
			"VkDeviceDeviceMemoryReportCreateInfoEXT",
			"VkViewport",
			"VkRect2D",
			"VkComponentMapping"
		};

		public static readonly Dictionary<string, string> Remapping = new()
		{
			{ "VkExtent2D", "Vector2ui" },
			{ "VkExtent3D", "Vector3ui" },
			{ "VkOffset2D", "Vector2i" },
			{ "VkOffset3D", "Vector3i" }
		};

		private record Struct(string name, bool union, List<StructMember> members);

		private record StructMember(string name, string type, int pointer);

		public void Generate(XmlDocument xml, string outputDir)
		{
			StringBuilder code = new StringBuilder();

			code.AppendLine("// ReSharper disable FieldCanBeMadeReadOnly.Global");
			code.AppendLine("using System;");
			code.AppendLine("using System.Runtime.InteropServices;");
			code.AppendLine("namespace Fireburst {");

			foreach (var (name, union, members) in GetStructs(xml).Concat(GetUnions(xml)))
			{
				if (union)
				{
					code.AppendLine("[StructLayout(LayoutKind.Explicit)]");
					code.AppendLine($"public struct {name} {{");

					foreach (var (mName, type, pointer) in members)
					{
						code.AppendLine("[FieldOffset(0)]");

						if (pointer> 0)
							code.AppendLine($"public unsafe {type}{new string('*', pointer)} {mName};");
						else
							code.AppendLine($"public {type} {mName};");
					}

					code.AppendLine("}");
				}
				else
				{
					code.AppendLine("[StructLayout(LayoutKind.Sequential)]");
					code.AppendLine($"public struct {name} {{");

					foreach (var (mName, type, pointer) in members)
					{
						if (pointer > 0)
							code.AppendLine($"public unsafe {type}{new string('*', pointer)} {mName};");
						else
							code.AppendLine($"public {type} {mName};");
					}

					code.AppendLine("}");
				}
			}

			code.Append('}');

			File.WriteAllText(outputDir + "Vulkan.Structs.cs", code.ToString(), Encoding.UTF8);
		}

		private static IEnumerable<Struct> GetStructs(XmlDocument xml)
		{
			XmlNodeList itemRefList = xml.GetElementsByTagName("type");
			foreach (XmlElement element in itemRefList)
			{
				if (element.GetAttributeNode("category") is not { Value: "struct" }) continue;

				string n = element.GetAttribute("name");
				if (element.HasAttribute("alias"))
				{
					Remapping.Add(n, element.GetAttribute("alias"));

					continue;
				}

				List<StructMember> members = new List<StructMember>();
				if (IgnoredStructs.Contains(n) || Remapping.ContainsKey(n))
					continue;

				Struct @struct = new Struct(n, false, members);

				foreach (XmlElement member in element.GetElementsByTagName("member"))
				{
					string name = member["name"].InnerText;
					if (name == "object") name = "@object";

					members.Add(new StructMember(name, Utility.ResolveType(member["type"].InnerText), member.InnerText.Count(x => x == '*')));
				}

				yield return @struct;
			}
		}

		private static IEnumerable<Struct> GetUnions(XmlDocument xml)
		{
			XmlNodeList itemRefList = xml.GetElementsByTagName("type");
			foreach (XmlElement xn in itemRefList)
			{
				if (xn.GetAttributeNode("category") is not { Value: "union" }) continue;

				List<StructMember> members = new List<StructMember>();
				string n = xn.GetAttribute("name");
				Struct @struct = new Struct(n, true, members);
				if (IgnoredStructs.Contains(n) || Remapping.ContainsKey(n))
					continue;

				foreach (XmlElement member in xn.GetElementsByTagName("member"))
				{
					string name = member["name"].InnerText;
					if (name == "object") name = "@object";

					members.Add(new StructMember(name, Utility.ResolveType(member["type"].InnerText), member.InnerText.Count(x => x == '*')));
				}

				yield return @struct;
			}
		}
	}
}