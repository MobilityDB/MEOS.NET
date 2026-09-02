#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Invalid argument value (<c>MEOS_ERR_INVALID_ARG_VALUE</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSInvalidArgValueException : MEOSException
    {
        internal MEOSInvalidArgValueException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
