#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>WKB input error (<c>MEOS_ERR_WKB_INPUT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSWKBInputException : MEOSException
    {
        internal MEOSWKBInputException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
