using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSInternalTypeErrorException : MEOSException
    {
        internal MEOSInternalTypeErrorException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
