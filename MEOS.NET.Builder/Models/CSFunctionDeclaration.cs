namespace MEOS.NET.Builder.Models
{
	public class CSFunctionDeclaration : FunctionDeclaration
	{ 
		public IEnumerable<CSFunctionArgument> Arguments { get; init; } = new List<CSFunctionArgument>();

		public string ToArgumentsWithTypeString()
		{
			var stringArgs = this.Arguments.Select((arg) => arg.ToString());
			return string.Join(", ", stringArgs);
		}

		public string ToArgumentsWithoutTypeString()
		{
			var stringArgs = this.Arguments.Select((arg) => arg.Name);
			return string.Join(", ", stringArgs);
		}
	}
}

