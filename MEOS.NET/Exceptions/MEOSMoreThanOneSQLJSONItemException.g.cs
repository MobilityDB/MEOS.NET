#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>More than one SQL/JSON item (<c>MEOS_ERR_MORE_THAN_ONE_SQL_JSON_ITEM</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSMoreThanOneSQLJSONItemException : MEOSException
    {
        internal MEOSMoreThanOneSQLJSONItemException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
