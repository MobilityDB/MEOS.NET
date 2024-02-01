using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSDirectoryException : MEOSException
    {
        internal MEOSDirectoryException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
