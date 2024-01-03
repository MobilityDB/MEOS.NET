using System.Text;
using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.Workflow
{
	public class WriteDefinitionsFileWorkflow
	{
		private readonly string DllName = "libmeos.so";

		public IEnumerable<CSFunctionDeclaration> Declarations { get; init; }

		public WriteDefinitionsFileWorkflow(IEnumerable<CSFunctionDeclaration> declarations)
			=> this.Declarations = declarations;

		public void Write(string filePath)
		{
			var builder = new StringBuilder();

			builder.Append(this.GenerateUsingStatements());
			builder.Append(this.GenerateNamespace());

			File.WriteAllText(filePath, builder.ToString());
		}

		private string GenerateUsingStatements()
			=> "using System.Runtime.InteropServices;\n\n";


		private string GenerateNamespace()
		{
			var builder = new StringBuilder();

			builder.AppendLine("namespace MEOS.NET.API.Internal");
			builder.AppendLine("{");

            builder.Append(this.GenerateClass());

            builder.AppendLine("}");

			return builder.ToString();
		}

		private string GenerateClass()
		{
			var builder = new StringBuilder();

			builder.AppendLine("\tinternal static class MEOSFunctions");
			builder.AppendLine("\t{");

			builder.AppendLine($"\t\tprivate const string DllPath = @\"API\\\\Internal\\\\{this.DllName}\";");
			builder.AppendLine();

			builder.AppendLine(this.GenerateDeclarations());

			builder.AppendLine("\t}");

			return builder.ToString();
		}

		private string GenerateDeclarations()
		{
			var builder = new StringBuilder();

			foreach (var declaration in this.Declarations)
			{
				builder.AppendLine("\t\t[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]");
				builder.AppendLine($"\t\tpublic static extern " +
					$"{declaration.ReturnType} {declaration.FunctionName}({declaration.Arguments});");

				builder.AppendLine();
			}

			// Removing last empty lines
			builder.Remove(builder.Length - 2, 2);

			return builder.ToString();
		}
    }
}

