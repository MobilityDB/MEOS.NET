using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSBadTextInputException : MEOSException
    {
        internal MEOSBadTextInputException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
