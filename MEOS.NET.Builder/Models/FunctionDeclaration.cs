namespace MEOS.NET.Builder.Models
{
	internal abstract class FunctionDeclaration
	{
        internal string? ReturnType { get; init; } = string.Empty;
        internal string? FunctionName { get; init; } = string.Empty;
    }
}

