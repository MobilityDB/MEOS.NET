#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>SQL/JSON object not found (<c>MEOS_ERR_SQL_JSON_OBJECT_NOT_FOUND</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSSQLJSONObjectNotFoundException : MEOSException
    {
        internal MEOSSQLJSONObjectNotFoundException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
