using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSUnspecifiedInternalException : MEOSException
    {
        internal MEOSUnspecifiedInternalException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
