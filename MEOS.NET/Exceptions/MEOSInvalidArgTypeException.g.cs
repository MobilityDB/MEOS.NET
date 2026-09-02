#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Invalid argument type (<c>MEOS_ERR_INVALID_ARG_TYPE</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSInvalidArgTypeException : MEOSException
    {
        internal MEOSInvalidArgTypeException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
