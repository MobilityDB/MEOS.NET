#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Out of memory error (<c>MEOS_ERR_OUT_OF_MEMORY</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSOutOfMemoryException : MEOSException
    {
        internal MEOSOutOfMemoryException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
