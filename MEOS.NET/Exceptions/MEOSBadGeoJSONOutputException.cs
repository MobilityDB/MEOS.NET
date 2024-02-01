using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSBadGeoJSONOutputException : MEOSException
    {
        internal MEOSBadGeoJSONOutputException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
