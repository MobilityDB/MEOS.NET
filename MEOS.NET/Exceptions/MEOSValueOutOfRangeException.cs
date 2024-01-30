using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSValueOutOfRangeException : MEOSException
    {
        internal MEOSValueOutOfRangeException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
