#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Text input error (<c>MEOS_ERR_TEXT_INPUT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSTextInputException : MEOSException
    {
        internal MEOSTextInputException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
