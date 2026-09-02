#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>MFJSON output error (<c>MEOS_ERR_MFJSON_OUTPUT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSMFJSONOutputException : MEOSException
    {
        internal MEOSMFJSONOutputException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
