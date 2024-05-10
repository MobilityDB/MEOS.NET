using System.Text;

namespace MEOS.NET.Builder.Models
{
    internal class CSFunctionDeclaration : FunctionDeclaration
	{
        internal IEnumerable<CSFunctionArgument> Arguments { get; init; } = new List<CSFunctionArgument>();

        internal string ToArgumentsWithTypeString()
		{
			var stringArgs = this.Arguments.Select((arg) => arg.ToString()).ToList();

			var builder = new StringBuilder();

			for (int i = 0; i < stringArgs.Count; i++)
			{
				if (stringArgs[i].Contains("bool "))
				{
					builder.Append("[MarshalAs(UnmanagedType.I1)]");
				}

				builder.Append(stringArgs[i]);

				if (i !=  stringArgs.Count - 1)
				{
					builder.Append(", ");
				}
			}

			return builder.ToString();
		}

        internal string ToArgumentsWithoutTypeString()
		{
			var stringArgs = this.Arguments.Select((arg) => arg.Name);
			return string.Join(", ", stringArgs);
		}
	}
}

