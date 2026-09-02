#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Syntax error (<c>MEOS_ERR_SYNTAX_ERROR</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSSyntaxErrorException : MEOSException
    {
        internal MEOSSyntaxErrorException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
