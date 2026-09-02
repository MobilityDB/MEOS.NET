#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Internal division by zero error (<c>MEOS_ERR_DIVISION_BY_ZERO</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSDivisionByZeroException : MEOSException
    {
        internal MEOSDivisionByZeroException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
