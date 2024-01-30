using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSInvalidArgumentException : MEOSException
    {
        internal MEOSInvalidArgumentException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
