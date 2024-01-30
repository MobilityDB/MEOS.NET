using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSAggregationException : MEOSException
    {
        internal MEOSAggregationException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
