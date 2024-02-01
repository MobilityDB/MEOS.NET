using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSInvalidArgumentTypeException : MEOSException
    {
        internal MEOSInvalidArgumentTypeException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
