using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSMemoryAllocationException : MEOSException
    {
        internal MEOSMemoryAllocationException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
