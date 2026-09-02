#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Internal type error (<c>MEOS_ERR_INTERNAL_TYPE_ERROR</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSInternalTypeErrorException : MEOSException
    {
        internal MEOSInternalTypeErrorException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
