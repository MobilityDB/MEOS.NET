#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Text output error (<c>MEOS_ERR_TEXT_OUTPUT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSTextOutputException : MEOSException
    {
        internal MEOSTextOutputException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
