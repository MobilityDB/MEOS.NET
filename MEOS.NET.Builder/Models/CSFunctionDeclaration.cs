namespace MEOS.NET.Builder.Models
{
    internal class CSFunctionDeclaration : FunctionDeclaration
	{
        internal IEnumerable<CSFunctionArgument> Arguments { get; init; } = new List<CSFunctionArgument>();

        internal string ToArgumentsWithTypeString()
		{
			var stringArgs = this.Arguments.Select((arg) => arg.ToString());
			return string.Join(", ", stringArgs);
		}

        internal string ToArgumentsWithoutTypeString()
		{
			var stringArgs = this.Arguments.Select((arg) => arg.Name);
			return string.Join(", ", stringArgs);
		}
	}
}

