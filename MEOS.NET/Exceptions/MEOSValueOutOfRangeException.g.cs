#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Internal out of range error (<c>MEOS_ERR_VALUE_OUT_OF_RANGE</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSValueOutOfRangeException : MEOSException
    {
        internal MEOSValueOutOfRangeException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
