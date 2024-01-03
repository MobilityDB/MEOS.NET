using System.Text.RegularExpressions;
using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.Workflow
{
	public class MapDefinitionsWorkflow
	{
		public IEnumerable<CSFunctionDeclaration> MapCDeclaractions(IEnumerable<CFunctionDeclaration> declarations)
		{
            return declarations.Select(d =>
                new CSFunctionDeclaration
                {
                    Arguments = this.MapCArguments(d.Arguments!),
                    FunctionName = d.FunctionName,
                    ReturnType = this.MapCType(d.ReturnType!),
                }
            );
		}

        private string MapCType(string cType)
        {
            // String type
            var newType = cType.Replace("char*", "string");

            // Pointer types
            if (newType.Contains('*'))
            {
                return "IntPtr";
            }

            // Non-pointer types
            newType = newType.Replace("ushort_t", "ushort");
            newType = newType.Replace("uint32", "uint");
            newType = newType.Replace("uint64", "ulong");
            newType = newType.Replace("size_t", "ulong");

            newType = newType.Replace("uint8_t", "byte");
            newType = newType.Replace("int8", "short");
            newType = newType.Replace("int32", "int");
            newType = newType.Replace("int64", "double");

            newType = newType.Replace("TimestampTz", "DateTimeOffset");
            newType = newType.Replace("Timestamp", "DateTime");

            newType = newType.Replace("Datum", "object");

            newType = newType.Replace("TimeADT", "int");
            newType = newType.Replace("DateADT", "long");

            // Enums
            newType = newType.Replace("interpType", "InterpolationType");

            return newType;
        }

		private string MapCArguments(string args)
        {
            if (args.Trim() == "void")
            {
                return string.Empty;
            }

            var splitted = args.Split(',');
            var regexPattern = "(?:\\s*const)?\\s*([\\w\\s]+)\\s+(\\*{0,2})\\s*(\\w+)\\s*";

            var mappedArgs = new List<string>();

            foreach (var arg in splitted)
            {
                var match = Regex.Match(arg, regexPattern);

                if (!match.Success)
                {
                    continue;
                }

                var oldType = match.Groups[1]?.ToString().Trim() + match.Groups[2]?.ToString().Trim();
                var newType = this.MapCType(oldType);

                var argName = match.Groups[3]?.ToString().Trim();

                mappedArgs.Add($"{newType} {argName}");
            }

            return string.Join(",", mappedArgs);

        }
    }
}

