#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>WKB output error (<c>MEOS_ERR_WKB_OUTPUT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSWKBOutputException : MEOSException
    {
        internal MEOSWKBOutputException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
