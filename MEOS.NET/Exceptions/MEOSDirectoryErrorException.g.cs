#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Internal directory error (<c>MEOS_ERR_DIRECTORY_ERROR</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSDirectoryErrorException : MEOSException
    {
        internal MEOSDirectoryErrorException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
