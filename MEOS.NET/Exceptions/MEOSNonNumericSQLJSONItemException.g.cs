#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Non-numeric SQL/JSON item (<c>MEOS_ERR_NON_NUMERIC_SQL_JSON_ITEM</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSNonNumericSQLJSONItemException : MEOSException
    {
        internal MEOSNonNumericSQLJSONItemException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
