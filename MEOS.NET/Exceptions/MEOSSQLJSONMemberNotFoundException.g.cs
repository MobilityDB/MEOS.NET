#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>SQL/JSON member not found (<c>MEOS_ERR_SQL_JSON_MEMBER_NOT_FOUND</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSSQLJSONMemberNotFoundException : MEOSException
    {
        internal MEOSSQLJSONMemberNotFoundException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
