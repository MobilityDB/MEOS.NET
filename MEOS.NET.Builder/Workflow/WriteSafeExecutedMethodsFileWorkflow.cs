using System.Text;

using MEOS.NET.Builder.Constants;
using MEOS.NET.Builder.EqualityComparers;
using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.Workflow
{
    internal class WriteSafeExecutedMethodsFileWorkflow
    {
        internal IEnumerable<CSFunctionDeclaration> Declarations { get; init; }

        internal WriteSafeExecutedMethodsFileWorkflow(IEnumerable<CSFunctionDeclaration> declarations)
            => this.Declarations = declarations;

        internal void Write(string filePath)
        {
            var builder = new StringBuilder();

            builder.AppendLine(this.GenerateUsingStatements());
            builder.Append(this.GenerateNamespace());

            File.WriteAllText($"{filePath}.cs.txt", builder.ToString());
        }

        private string GenerateUsingStatements()
            => "using System.CodeDom.Compiler;\n";

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

            builder.AppendLine($"\t[GeneratedCode(\"MEOS.NET.Builder\", \"{BuilderVersion.CurrentVersion}\")]");
            builder.AppendLine("\tinternal partial class MEOSExposedFunctions");
            builder.AppendLine("\t{");

            builder.AppendLine(this.GenerateDeclarations());

            builder.AppendLine("\t}");

            return builder.ToString();
        }

        private string GenerateDeclarations()
        {
            var builder = new StringBuilder();

            foreach (var declaration in this.Declarations.Distinct(new CSFunctionDeclarationComparer()))
            {
                builder.AppendLine($"\t\tpublic static {declaration.ReturnType} {declaration.FunctionName}({declaration.ToArgumentsWithTypeString()})");

                var argumentsWithNameOnly = declaration.ToArgumentsWithoutTypeString();

                builder.Append("\t\t\t=> SafeExecution");

                // Generic typed function if the return type is something else than nothing (void).
                if (declaration.ReturnType != "void")
                {
                    builder.Append($"<{declaration.ReturnType}>");
                }

                builder.AppendLine($"(() => MEOSExternalFunctions.{declaration.FunctionName}({argumentsWithNameOnly}));");
                builder.AppendLine();
            }

            // Removing last empty lines
            builder.Remove(builder.Length - 2, 2);

            return builder.ToString();
        }
    }
}
