using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FireburstGenerator
{
	public class CommandGenerator : IGenerator
	{
		public int Priority() => -1000;

		public void Generate(Registry registry, string outputDir)
		{
			CodeWriter writer = new("Fireburst", "System");
			writer.WriteLine("public static unsafe partial class Vulkan");
			writer.WriteLine("{");
			writer.Indent();

			foreach (Command command in registry.Commands.Command)
			{
				if (command.Alias != null) continue;
				
				List<(string type, string name)> parameters = new();

				foreach (Param param in command.Param)
				{
					param.Name = param.Name switch
					{
						"object" => "@object",
						"event" => "@event",
						_ => param.Name
					};

					int count = 0;
					foreach (char c in param.Name)
					{
						if (c == 'p') count++;
						else
						{
							if (char.IsLower(c)) count = 0;
							break;
						}
					}

					parameters.Add((Utility.ResolveType(param.Type) + new string('*', count), param.Name));
				}

				string returnType = Utility.ResolveType(command.Proto.Type);
				writer.WriteLine($"internal static delegate* unmanaged<{parameters.Select(x => x.type).JoinStrings()}, {returnType}> {command.Proto.Name}_ptr;");
				writer.WriteLine();
				writer.WriteLine($"public static {returnType} {command.Proto.Name}({parameters.Select(x => x.type + " " + x.name).JoinStrings()})");
				writer.WriteLine("{");
				writer.Indent();
				if (returnType != "void") writer.WriteLine($"return {command.Proto.Name}_ptr({parameters.Select(x => x.name).JoinStrings()});");
				else writer.WriteLine($"{command.Proto.Name}_ptr({parameters.Select(x => x.name).JoinStrings()});");
				writer.Unindent();
				writer.WriteLine("}");
				writer.WriteLine();
			}

			writer.Unindent();
			writer.WriteLine("}");

			File.WriteAllText(outputDir + "Vulkan.Commands.cs", writer.ToString());
		}
	}
}