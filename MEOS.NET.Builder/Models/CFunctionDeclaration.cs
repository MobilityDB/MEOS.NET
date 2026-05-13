namespace MEOS.NET.Builder.Models
{
	internal class CFunctionDeclaration : FunctionDeclaration
	{
        internal string? Arguments { get; init; } = string.Empty;

        // Empty argument list is a valid C declaration (e.g. `int foo();`).
        internal bool HasUndefinedElements()
            => string.IsNullOrEmpty(this.ReturnType) ||
                string.IsNullOrEmpty(this.FunctionName);
    }
}

