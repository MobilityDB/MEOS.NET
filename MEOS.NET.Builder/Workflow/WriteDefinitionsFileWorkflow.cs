﻿using System.Text;

using MEOS.NET.Builder.Constants;
using MEOS.NET.Builder.EqualityComparers;
using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.Workflow
{
    internal class WriteDefinitionsFileWorkflow
	{
		private readonly string DllPath;

        internal IEnumerable<CSFunctionDeclaration> Declarations { get; init; }

        internal WriteDefinitionsFileWorkflow(IEnumerable<CSFunctionDeclaration> declarations, string dllPath)
		{
			this.Declarations = declarations;
			this.DllPath = dllPath;
		}

        internal void Write(string filePath)
		{
			var builder = new StringBuilder();

			builder.Append(this.GenerateUsingStatements());
			builder.Append(this.GenerateNamespace());

			File.WriteAllText($"{filePath}.cs.txt", builder.ToString());
		}

		private string GenerateUsingStatements()
			=> "using System.CodeDom.Compiler;\nusing System.Runtime.InteropServices;\n\nusing MEOS.NET.Enums;\n\n";

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
            builder.AppendLine("\t\tprivate partial class MEOSExternalFunctions");
			builder.AppendLine("\t\t{");

			builder.AppendLine($"\t\t\tprivate const string DllPath = \"{this.DllPath}\";");
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
				builder.AppendLine("\t\t\t[LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]");

				if (declaration.ReturnType == "bool")
				{
					builder.AppendLine("\t\t\t[return:MarshalAs(UnmanagedType.I1)]");
				}

				builder.AppendLine($"\t\t\tpublic static partial " +
					$"{declaration.ReturnType} {declaration.FunctionName}({declaration.ToArgumentsWithTypeString()});");

				builder.AppendLine();
			}

			// Removing last empty lines
			builder.Remove(builder.Length - 2, 2);

			return builder.ToString();
		}
    }
}

