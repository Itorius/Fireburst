using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FireburstGenerator;

public class ConstantGenerator : IGenerator
{
	public static Dictionary<string, object> Constants = new();

	public void Generate(Registry registry, string outputDir)
	{
		CodeWriter writer = new("Fireburst", "System");

		writer.WriteLine();
		writer.WriteLine("public static unsafe partial class Vulkan");
		writer.WriteLine("{");
		writer.Indent();

		var apiConstants = registry.Enums.FirstOrDefault(x => x.Name == "API Constants");
		if (apiConstants is not null)
		{
			// <enum type="uint32_t" value="256"       name="VK_MAX_PHYSICAL_DEVICE_NAME_SIZE"/>
			foreach (var member in apiConstants.Members)
			{
				if (member.Value is null) continue;

				Constants.Add(member.Name, member.Value);
				
				if (member.Type == "uint32_t")
					writer.WriteLine($"public const uint {member.Name} = {member.Value};");
				else if (member.Type == "uint64_t")
				{
					if (member.Value.Contains("ULL")) member.Value = member.Value.Replace("ULL", "UL");
					writer.WriteLine($"public const ulong {member.Name} = {member.Value};");
				}
				else if (member.Type == "float")
					writer.WriteLine($"public const float {member.Name} = {member.Value};");
			}
		}

		foreach (var extension in registry.Extensions.Extension)
		{
			foreach (var require in extension.Require)
			{
				foreach (var registryEnum in require.Enum)
				{
					if (registryEnum.Value is null || registryEnum.Extends is not null) continue;

					Constants.Add(registryEnum.Name, registryEnum.Value);
					
					if (ulong.TryParse(registryEnum.Value, out ulong value))
						writer.WriteLine($"public const ulong {registryEnum.Name} = {value};");
					else if (registryEnum.Value.Contains("API_VERSION"))
					{
						var version = Regex.Match(registryEnum.Value, @"(?>\d_?)+$").Value;
						writer.WriteLine($"public static VkVersion {registryEnum.Name} = new({version.Split('_').Aggregate((x, y) => x + ", " + y)});");
					}
					else
						writer.WriteLine($"public const string {registryEnum.Name} = {registryEnum.Value};");
				}
			}
		}

		writer.Unindent();
		writer.WriteLine("}");
		File.WriteAllText(outputDir + "Vulkan.Constants.cs", writer.ToString());
	}
}