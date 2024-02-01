using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.Exceptions
{
	public class InvalidCDeclarationException : Exception
	{
		public string? ReturnType { get; set; }
		public string? FunctionName { get; set; }
		public string? Arguments { get; set; }

		internal InvalidCDeclarationException(CFunctionDeclaration declaration)
		{
			this.ReturnType = declaration.ReturnType;
			this.FunctionName = declaration.FunctionName;
			this.Arguments = declaration.Arguments;
		}
	}
}

