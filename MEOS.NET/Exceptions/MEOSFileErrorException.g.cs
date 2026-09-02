#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Internal file error (<c>MEOS_ERR_FILE_ERROR</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSFileErrorException : MEOSException
    {
        internal MEOSFileErrorException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
