using System.IO;
using System.Linq;

namespace FireburstGenerator;

public class HandleGenerator : IGenerator
{
	public void Generate(Registry registry, string outputDir)
	{
		CodeWriter writer = new("Fireburst", "System", "System.Runtime.InteropServices");

		foreach (Type type in registry.Types.Type.Where(x => x.Category == "handle"))
		{
			string? name = type.ElementName;
			if (name == null) continue;

			writer.WriteLine($"public partial struct {name} : IEquatable<{name}>");
			writer.WriteLine("{");
			writer.Indent();

			writer.WriteLine("public readonly IntPtr Handle;");
			writer.WriteLine("public bool IsNull => Handle == IntPtr.Zero;");
			writer.WriteLine($"public {name}(IntPtr handle) {{ Handle = handle; }}");
			writer.WriteLine($"public static {name} Null => new(IntPtr.Zero);");
			writer.WriteLine($"public static bool operator ==({name} left, {name} right) => left.Handle == right.Handle;");
			writer.WriteLine($"public static bool operator !=({name} left, {name} right) => left.Handle != right.Handle;");
			writer.WriteLine($"public bool Equals(ref {name} other) => Handle == other.Handle;");
			writer.WriteLine($"public bool Equals({name} other) => Handle == other.Handle;");
			writer.WriteLine($"public override bool Equals(object obj) => obj is {name} handle && Equals(ref handle);");
			writer.WriteLine("public override int GetHashCode() => Handle.GetHashCode();");
			writer.WriteLine($@"private string DebuggerDisplay => $""{name} [0x{{Handle:X}}]"";");

			writer.Unindent();
			writer.WriteLine("}");
			writer.WriteLine();
		}

		File.WriteAllText(outputDir + "Vulkan.Handles.cs", writer.ToString());
	}
}