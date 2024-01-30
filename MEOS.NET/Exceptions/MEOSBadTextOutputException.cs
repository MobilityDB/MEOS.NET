using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSBadTextOutputException : MEOSException
    {
        internal MEOSBadTextOutputException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
