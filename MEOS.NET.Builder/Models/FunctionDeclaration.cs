namespace MEOS.NET.Builder.Models
{
	public abstract class FunctionDeclaration
	{
        public string? ReturnType { get; init; } = string.Empty;
        public string? FunctionName { get; init; } = string.Empty;
    }
}

