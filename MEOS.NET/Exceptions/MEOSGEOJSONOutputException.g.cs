#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>GEOJSON output error (<c>MEOS_ERR_GEOJSON_OUTPUT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSGEOJSONOutputException : MEOSException
    {
        internal MEOSGEOJSONOutputException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
