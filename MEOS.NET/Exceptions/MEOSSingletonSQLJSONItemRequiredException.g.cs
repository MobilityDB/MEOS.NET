#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Singleton SQL/JSON item required (<c>MEOS_ERR_SINGLETON_SQL_JSON_ITEM_REQUIRED</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSSingletonSQLJSONItemRequiredException : MEOSException
    {
        internal MEOSSingletonSQLJSONItemRequiredException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
