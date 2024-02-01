using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSInvalidArgumentValueException : MEOSException
    {
        internal MEOSInvalidArgumentValueException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
