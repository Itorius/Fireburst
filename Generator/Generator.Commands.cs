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

		public void Generate(XmlDocument xml, string outputDir)
		{
			StringBuilder code = new StringBuilder();

			code.AppendLine("using System;");
			code.AppendLine("using System.Runtime.InteropServices;");
			code.AppendLine("namespace Fireburst {");
			code.AppendLine("public static unsafe partial class Vulkan {");

			foreach (XmlElement element in ((XmlElement)xml.SelectSingleNode(".//commands")).GetElementsByTagName("command"))
			{
				if (element.HasAttribute("alias")) continue;

				var name = element.SelectSingleNode(".//proto/name").InnerText;
				var returnType = element.SelectSingleNode(".//proto/type").InnerText;
				List<string> @params = new();

				foreach (XmlElement param in element.GetElementsByTagName("param"))
				{
					if (param.SelectSingleNode(".//name") == null) continue;
					
					var paramName = param.SelectSingleNode(".//name").InnerText;
					if (paramName == "event" || paramName == "object") paramName = "@" + paramName;
					
					var paramType = param.SelectSingleNode(".//type").InnerText;
					bool isPointer = param.InnerText.Contains('*');

					@params.Add($"{Utility.ResolveType(paramType)}{(isPointer ? "*" : "")} {paramName}");
				}

				code.AppendLine($"public static unsafe {Utility.ResolveType(returnType)} {name}({@params.Aggregate((x, y) => x + ", " + y)}) {{}}");
			}

			code.AppendLine("}");
			code.AppendLine("}");

			File.WriteAllText(outputDir + "Vulkan.Commands.cs", code.ToString(), Encoding.UTF8);

			// command
		}
	}
}