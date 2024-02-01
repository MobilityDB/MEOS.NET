using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    public class MEOSBadGeoJSONInputException : MEOSException
    {
        internal MEOSBadGeoJSONInputException(int level, MEOSErrorCodes code, string message) 
            : base(level, code, message)
        { }
    }
}
