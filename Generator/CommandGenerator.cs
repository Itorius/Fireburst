using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FireburstGenerator
{
	public class CommandGenerator : IGenerator
	{
		public int Priority() => -1000;

		private static readonly HashSet<string> IgnoredLoads = new()
		{
			"vkGetInstanceProcAddr",
			"vkCreateInstance",
			"vkEnumerateInstanceExtensionProperties",
			"vkEnumerateInstanceLayerProperties",
			"vkEnumerateInstanceVersion"
		};

		public void Generate(Registry registry, string outputDir)
		{
			CodeWriter writer = new("Fireburst", "System");
			writer.WriteLine("public static unsafe partial class Vulkan");
			writer.WriteLine("{");
			writer.Indent();

			CodeWriter loaderWriter = new("Fireburst", "System");
			loaderWriter.WriteLine("public static unsafe partial class Vulkan");
			loaderWriter.WriteLine("{");
			loaderWriter.Indent();
			loaderWriter.WriteLine("private static void LoadCommands(VkInstance instance, LoadFunction load)");
			loaderWriter.WriteLine("{");
			loaderWriter.Indent();

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
				string funcPtrType = $"delegate* unmanaged<{parameters.Select(x => x.type).JoinStrings()}, {returnType}>";
				string name = command.Proto.Name;

				writer.WriteLine($"internal static {funcPtrType} {name}_ptr;");
				writer.WriteLine();
				writer.WriteLine($"public static {returnType} {name}({parameters.Select(x => x.type + " " + x.name).JoinStrings()})");
				writer.WriteLine("{");
				writer.Indent();
				if (returnType != "void") writer.WriteLine($"return {name}_ptr({parameters.Select(x => x.name).JoinStrings()});");
				else writer.WriteLine($"{name}_ptr({parameters.Select(x => x.name).JoinStrings()});");
				writer.Unindent();
				writer.WriteLine("}");
				writer.WriteLine();

				if (!IgnoredLoads.Contains(name)) loaderWriter.WriteLine($"{name}_ptr = ({funcPtrType})load(instance, nameof({name}));");
			}

			writer.Unindent();
			writer.WriteLine("}");

			loaderWriter.Unindent();
			loaderWriter.WriteLine("}");
			loaderWriter.Unindent();
			loaderWriter.WriteLine("}");

			File.WriteAllText(outputDir + "Vulkan.Commands.cs", writer.ToString());
			File.WriteAllText(outputDir + "Vulkan.Loader.cs", loaderWriter.ToString());
		}
	}
}