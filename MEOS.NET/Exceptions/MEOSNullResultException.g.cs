#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Operation returned null (<c>MEOS_ERR_NULL_RESULT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSNullResultException : MEOSException
    {
        internal MEOSNullResultException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
