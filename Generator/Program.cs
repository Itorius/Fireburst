using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace FireburstGenerator;

public interface IGenerator
{
	void Generate(Registry registry, string outputDir);

	int Priority()
	{
		return 0;
	}
}

public static class Program
{
	public static void Main(string[] args)
	{
		XmlSerializer serializer = new(typeof(Registry));

		{
			using StreamReader reader = new("video.xml");
			Registry? registry = (Registry?)serializer.Deserialize(reader);

			if (registry is not null)
			{
				if (!Directory.Exists("../Fireburst/Vulkan.Video/")) Directory.CreateDirectory("../Fireburst/Vulkan.Video/");
				
				var generatorTypes = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetInterface("IGenerator") is not null);

				foreach (IGenerator? generator in generatorTypes.Select(x => (IGenerator?)Activator.CreateInstance(x)).OrderByDescending(x => x?.Priority()))
				{
					generator?.Generate(registry, "../Fireburst/Vulkan.Video/");
				}
			}
		}

		{
			using StreamReader reader = new("vk.xml");
			Registry? registry = (Registry?)serializer.Deserialize(reader);

			if (registry is not null)
			{
				if (!Directory.Exists("../Fireburst/Vulkan/")) Directory.CreateDirectory("../Fireburst/Vulkan/");
				
				var generatorTypes = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetInterface("IGenerator") is not null);

				foreach (IGenerator? generator in generatorTypes.Select(x => (IGenerator?)Activator.CreateInstance(x)).OrderByDescending(x => x?.Priority()))
				{
					generator?.Generate(registry, "../Fireburst/Vulkan/");
				}
			}
		}
	}
}