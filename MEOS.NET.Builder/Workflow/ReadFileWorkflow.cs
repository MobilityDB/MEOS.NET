using System.Text.RegularExpressions;

using MEOS.NET.Builder.Exceptions;
using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.Workflow
{
    internal class ReadFileWorkflow
	{
        private readonly string regexPattern = "^\\s*extern\\s+(const\\s+)?([a-zA-Z_][a-zA-Z0-9_\\s]*\\**)\\s+(\\**)([a-zA-Z_][a-zA-Z0-9_]*)\\s*\\((.*?)\\)\\s*;";

        internal IEnumerable<CFunctionDeclaration> Run(string filePath)
		{
			var lines = File.ReadAllLines(filePath);

			if (lines.Length < 1)
			{
				throw new InvalidOperationException();
			}

			var declarations = new List<CFunctionDeclaration>();

			foreach (var line in lines)
			{
				var match = Regex.Match(line, pattern: this.regexPattern);

				if (match.Success)
				{
					var returnType = $"{match.Groups[2]?.ToString().Trim()}{match.Groups[3]?.ToString().Trim()}";
					var functionName = match.Groups[4]?.ToString().Trim();
					var args = match.Groups[5]?.ToString().Trim();

					var declaration = new CFunctionDeclaration()
					{
						Arguments = args,
						FunctionName = functionName,
						ReturnType = returnType,
					};

					if (declaration.HasUndefinedElements())
					{
						throw new InvalidCDeclarationException(declaration);
					}

					declarations.Add(declaration);
                }

            }

			return declarations;
		}
	}
}

