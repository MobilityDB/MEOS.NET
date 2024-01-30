using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSBadWKBInputException : MEOSException
    {
        internal MEOSBadWKBInputException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
