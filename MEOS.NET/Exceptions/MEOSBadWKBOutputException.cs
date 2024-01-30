using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSBadWKBOutputException : MEOSException
    {
        internal MEOSBadWKBOutputException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
