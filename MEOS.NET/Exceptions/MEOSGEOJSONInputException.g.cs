#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>GEOJSON input error (<c>MEOS_ERR_GEOJSON_INPUT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSGEOJSONInputException : MEOSException
    {
        internal MEOSGEOJSONInputException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
