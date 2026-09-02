#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Indeterminate collation (<c>MEOS_ERR_INDETERMINATE_COLLATION</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSIndeterminateCollationException : MEOSException
    {
        internal MEOSIndeterminateCollationException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
