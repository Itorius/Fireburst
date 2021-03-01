using System;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace FireburstGenerator
{
	public interface IGenerator
	{
		void Generate(XmlDocument xml, string outputDir);

		int Priority()
		{
			return 0;
		}
	}

	public static class Program
	{
		public static void Main(string[] args)
		{
			XmlDocument xml = new XmlDocument();
			xml.Load("vk.xml");

			foreach (IGenerator generator in Assembly.GetExecutingAssembly().GetTypes()
				.Where(x => x.GetInterface("IGenerator") != null)
				.Select(x => (IGenerator)Activator.CreateInstance(x))
				.OrderByDescending(x => x.Priority()))
			{
				generator.Generate(xml, "/home/itorius/Development/Fireburst/Fireburst/");
			}
		}
	}
}