using System.IO;
using System.Text;
using System.Xml;

namespace FireburstGenerator
{
	public class HandleGenerator : IGenerator
	{
		public void Generate(XmlDocument xml, string outputDir)
		{
			StringBuilder code = new StringBuilder();

			code.AppendLine("using System;");
			code.AppendLine("using System.Runtime.InteropServices;");
			code.AppendLine("namespace Fireburst {");

			XmlNodeList itemRefList = xml.GetElementsByTagName("type");
			foreach (XmlElement xn in itemRefList)
			{
				if (xn.GetAttributeNode("category") is not { Value: "handle" }) continue;

				var xmlNode = xn.GetElementsByTagName("name")[0];
				if (xmlNode == null) continue;
				string name = xmlNode.InnerText;

				string template = $@"
									public partial struct {name} : IEquatable<{name}>
									{{
										public readonly ulong Handle;
										public {name}(ulong handle) {{ Handle = handle; }}
										public static {name} Null => new(0);
										public static implicit operator {name}(ulong handle) => new(handle);
										public static bool operator ==({name} left, {name} right) => left.Handle == right.Handle;
										public static bool operator !=({name} left, {name} right) => left.Handle != right.Handle;
										public static bool operator ==({name} left, ulong right) => left.Handle == right;
										public static bool operator !=({name} left, ulong right) => left.Handle != right;
										public bool Equals(ref {name} other) => Handle == other.Handle;
										public bool Equals({name} other) => Handle == other.Handle;
										public override bool Equals(object obj) => obj is {name} handle && Equals(ref handle);
										public override int GetHashCode() => Handle.GetHashCode();
										private string DebuggerDisplay => $""{name} [0x{{Handle:X}}]"";
									}}";

				code.AppendLine(template);
			}

			code.Append('}');

			File.WriteAllText(outputDir + "Vulkan.Handles.cs", code.ToString(), Encoding.UTF8);
		}
	}
}