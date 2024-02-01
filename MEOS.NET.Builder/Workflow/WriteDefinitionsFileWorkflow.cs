using System.Text;

using MEOS.NET.Builder.Constants;
using MEOS.NET.Builder.EqualityComparers;
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
			=> "using System.CodeDom.Compiler;\nusing System.Runtime.InteropServices;\n\n";

        private string GenerateNamespace()
		{
			var builder = new StringBuilder();

			builder.AppendLine("namespace MEOS.NET.Internal");
			builder.AppendLine("{");

            builder.Append(this.GenerateClass());

            builder.AppendLine("}");

			return builder.ToString();
		}

		private string GenerateClass()
		{
			var builder = new StringBuilder();

			builder.AppendLine("\tinternal partial class MEOSExposedFunctions");
			builder.AppendLine("\t{");

            builder.AppendLine($"\t\t[GeneratedCode(\"MEOS.NET.Builder\", \"{BuilderVersion.CurrentVersion}\")]");
            builder.AppendLine("\t\tprivate class MEOSExternalFunctions");
			builder.AppendLine("\t\t{");

			builder.AppendLine($"\t\t\tprivate const string DllPath = @\"API\\\\Internal\\\\{this.DllName}\";");
			builder.AppendLine();

			builder.AppendLine(this.GenerateDeclarations());

			builder.AppendLine("\t\t}");

			builder.AppendLine("\t}");

			return builder.ToString();
		}

		private string GenerateDeclarations()
		{
			var builder = new StringBuilder();

			foreach (var declaration in this.Declarations.Distinct(new CSFunctionDeclarationComparer()))
			{
				builder.AppendLine("\t\t\t[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]");
				builder.AppendLine($"\t\t\tpublic static extern " +
					$"{declaration.ReturnType} {declaration.FunctionName}({declaration.ToArgumentsWithTypeString()});");

				builder.AppendLine();
			}

			// Removing last empty lines
			builder.Remove(builder.Length - 2, 2);

			return builder.ToString();
		}
    }
}

