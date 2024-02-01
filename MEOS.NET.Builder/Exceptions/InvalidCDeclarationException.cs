using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.Exceptions
{
	public class InvalidCDeclarationException : Exception
	{
		public CFunctionDeclaration Declaration { get; private set; }

		public InvalidCDeclarationException(CFunctionDeclaration declaration)
			=> this.Declaration = declaration;
	}
}

