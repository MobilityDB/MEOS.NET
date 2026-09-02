#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Feature not currently supported (<c>MEOS_ERR_FEATURE_NOT_SUPPORTED</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSFeatureNotSupportedException : MEOSException
    {
        internal MEOSFeatureNotSupportedException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
