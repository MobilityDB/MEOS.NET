namespace MEOS.NET.Builder.Models
{
	public class CFunctionDeclaration : FunctionDeclaration
	{
        public bool HasUndefinedElements()
            => string.IsNullOrEmpty(this.ReturnType) ||
                string.IsNullOrEmpty(this.FunctionName) ||
                string.IsNullOrEmpty(this.Arguments);
    }
}

