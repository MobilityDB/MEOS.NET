using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSBadMFJSONInputException : MEOSException
    {
        internal MEOSBadMFJSONInputException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
