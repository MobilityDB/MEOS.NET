using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSDivisionByZeroException : MEOSException
    {
        internal MEOSDivisionByZeroException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
