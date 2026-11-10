#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Invalid argument for an SQL/JSON datetime function (<c>MEOS_ERR_INVALID_ARGUMENT_FOR_SQL_JSON_DATETIME_FUNCTION</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSInvalidArgumentForSQLJSONDatetimeFunctionException : MEOSException
    {
        internal MEOSInvalidArgumentForSQLJSONDatetimeFunctionException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
