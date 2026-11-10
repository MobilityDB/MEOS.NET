#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Invalid SQL/JSON subscript (<c>MEOS_ERR_INVALID_SQL_JSON_SUBSCRIPT</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSInvalidSQLJSONSubscriptException : MEOSException
    {
        internal MEOSInvalidSQLJSONSubscriptException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
