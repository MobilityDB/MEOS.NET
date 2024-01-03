using System.Text.RegularExpressions;
using MEOS.NET.Builder.Exceptions;
using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.Workflow
{
	public class ReadFileWorkflow
	{
        private readonly string regexPattern = "^\\s*extern\\s+(const\\s+)?([a-zA-Z_][a-zA-Z0-9_\\s]*\\**)\\s+(\\**)([a-zA-Z_][a-zA-Z0-9_]*)\\s*\\((.*?)\\)\\s*;";

        public IEnumerable<CFunctionDeclaration> Run(string filePath)
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
					/*ret_type = match.group(2).strip() + match.group(3).strip()
					fn_name = match.group(4).strip()
					arg_list = transform_fn_args(match.group(5).strip())*/

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
						throw new InvalidDeclarationException();
					}

					declarations.Add(declaration);
                }

            }

			return declarations;
		}
	}
}

