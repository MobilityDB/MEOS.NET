#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Unspecified internal error (<c>MEOS_ERR_INTERNAL_ERROR</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSInternalErrorException : MEOSException
    {
        internal MEOSInternalErrorException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
