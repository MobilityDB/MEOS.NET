using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSBadMFJSONOutputException : MEOSException
    {
        internal MEOSBadMFJSONOutputException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
