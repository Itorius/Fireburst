using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

// ReSharper disable PossibleNullReferenceException

namespace FireburstGenerator
{
	public class CommandGenerator : IGenerator
	{
		public int Priority()
		{
			return -1000;
		}

		private record Parameter(string name, string type, bool pointer)
		{
			public string TypeString() => pointer ? type + "*" : type;
		}

		private record Command(string name, string returnType, List<Parameter> parameters);

		public void Generate(XmlDocument xml, string outputDir)
		{
			StringBuilder code = new StringBuilder();

			code.AppendLine("// ReSharper disable UnassignedField.Global");
			code.AppendLine("using System;");
			code.AppendLine("namespace Fireburst {");
			code.AppendLine("public static unsafe partial class Vulkan {");

			foreach (var (name, returnType, parameters) in GetCommands(xml))
			{
				code.AppendLine($"internal static delegate* unmanaged<{parameters.Select(x => x.TypeString()).JoinStrings()}, {returnType}> {name}_ptr;");
				code.AppendLine($"public static {returnType} {name}({parameters.Select(x => x.TypeString() + " " + x.name).JoinStrings()})");
				code.AppendLine("{");
				if (returnType != "void") code.Append("return ");
				code.AppendLine($"{name}_ptr({parameters.Select(x => x.name).JoinStrings()});");
				code.AppendLine("}");
			}

			code.AppendLine("}");
			code.AppendLine("}");

			File.WriteAllText(outputDir + "Vulkan.Commands.cs", code.ToString(), Encoding.UTF8);
		}

		private static IEnumerable<Command> GetCommands(XmlDocument xml)
		{
			foreach (XmlElement element in ((XmlElement)xml.SelectSingleNode(".//commands")).GetElementsByTagName("command"))
			{
				if (element.HasAttribute("alias")) continue;

				var name = element.SelectSingleNode(".//proto/name").InnerText;
				var returnType = element.SelectSingleNode(".//proto/type").InnerText;
				List<Parameter> parameters = new();

				foreach (XmlElement param in element.GetElementsByTagName("param"))
				{
					if (param.SelectSingleNode(".//name") == null) continue;

					var paramName = param.SelectSingleNode(".//name").InnerText;
					if (paramName == "event" || paramName == "object") paramName = "@" + paramName;

					var paramType = param.SelectSingleNode(".//type").InnerText;
					bool isPointer = param.InnerText.Contains('*');

					parameters.Add(new Parameter(paramName, Utility.ResolveType(paramType), isPointer));
				}

				yield return new Command(name, Utility.ResolveType(returnType), parameters);
			}
		}
	}
}