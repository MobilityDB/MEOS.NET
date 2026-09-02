#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Regular expression error (<c>MEOS_ERR_INVALID_REGULAR_EXPRESSION</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSInvalidRegularExpressionException : MEOSException
    {
        internal MEOSInvalidRegularExpressionException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
