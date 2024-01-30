using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSFileException : MEOSException
    {
        internal MEOSFileException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
