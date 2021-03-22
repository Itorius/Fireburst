using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace FireburstGenerator
{
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

			using StreamReader reader = new("vk.xml");
			Registry registry = (Registry)serializer.Deserialize(reader);

			foreach (IGenerator generator in Assembly.GetExecutingAssembly().GetTypes()
				.Where(x => x.GetInterface("IGenerator") != null)
				.Select(x => (IGenerator)Activator.CreateInstance(x))
				.OrderByDescending(x => x.Priority()))
			{
				generator.Generate(registry, "../../../../Fireburst/");
			}
		}
	}
}