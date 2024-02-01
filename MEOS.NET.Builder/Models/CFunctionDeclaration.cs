namespace MEOS.NET.Builder.Models
{
	internal class CFunctionDeclaration : FunctionDeclaration
	{
        internal string? Arguments { get; init; } = string.Empty;

        internal bool HasUndefinedElements()
            => string.IsNullOrEmpty(this.ReturnType) ||
                string.IsNullOrEmpty(this.FunctionName) ||
                string.IsNullOrEmpty(this.Arguments);
    }
}

