using System;
using System.Text;

namespace FireburstGenerator
{
	public class CodeWriter
	{
		private StringBuilder builder;
		private int indentCount;

		public CodeWriter(string @namespace, params string[] usings)
		{
			builder = new StringBuilder();
			foreach (string @using in usings)
			{
				WriteLine($"using {@using};");
			}

			WriteLine();
			WriteLine($"namespace {@namespace}");
			WriteLine("{");
			Indent();
		}

		public void Indent()
		{
			indentCount++;
		}

		public void Unindent()
		{
			indentCount--;
			if (indentCount < 0) throw new Exception("Indentation level can't be negative!");
		}

		public void WriteLine(string text)
		{
			builder.Append('\t', indentCount);
			builder.Append(text);
			builder.Append('\n');
		}

		public void Write(string text)
		{
			builder.Append('\t', indentCount);
			builder.Append(text);
		}

		public void WriteLine()
		{
			builder.Append('\n');
		}

		public override string ToString()
		{
			Unindent();
			Write("}");

			return builder.ToString();
		}
	}
}