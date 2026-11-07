#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Date or time value out of range (<c>MEOS_ERR_DATETIME_OUT_OF_RANGE</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSDatetimeOutOfRangeException : MEOSException
    {
        internal MEOSDatetimeOutOfRangeException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
