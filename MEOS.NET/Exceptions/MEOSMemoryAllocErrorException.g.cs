#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Internal malloc error (<c>MEOS_ERR_MEMORY_ALLOC_ERROR</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSMemoryAllocErrorException : MEOSException
    {
        internal MEOSMemoryAllocErrorException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
