#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Duplicate JSON object key value (<c>MEOS_ERR_DUPLICATE_JSON_OBJECT_KEY_VALUE</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSDuplicateJSONObjectKeyValueException : MEOSException
    {
        internal MEOSDuplicateJSONObjectKeyValueException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
