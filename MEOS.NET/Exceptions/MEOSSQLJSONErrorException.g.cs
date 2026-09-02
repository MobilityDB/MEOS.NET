#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>SQL JSON error (<c>MEOS_ERR_SQL_JSON_ERROR</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSSQLJSONErrorException : MEOSException
    {
        internal MEOSSQLJSONErrorException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
