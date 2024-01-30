namespace MEOS.NET.Errors
{
    public enum MEOSErrorCodes
    {
        Success = 0,  // Successful operation

        UnspecifiedInternalError = 1,  // Unspecified internal error
        InternalTypeError = 2,  // Internal type error
        ValueOutOfRange = 3,  // Internal out of range error
        DivisionByZero = 4,  // Internal division by zero error
        MemoryAllocationError = 5,  // Internal malloc error
        AggregationError = 6,  // Internal aggregation error
        DirectoryError = 7,  // Internal directory error
        FileError = 8,  // Internal file error

        InvalidArgument = 10, // Invalid argument
        InvalidArgumentType = 11, // Invalid argument type
        InvalidArgumentValue = 12, // Invalid argument value

        BadMFJSONInput = 20, // MFJSON input error
        BadMFJSONOutput = 21, // MFJSON output error
        BadTextInput = 22, // Text input error
        BadTextOutput = 23, // Text output error
        BadWellKnownBinaryInput = 24, // WKB input error
        BadWellKnownBinaryOutput = 25, // WKB output error
        BadGeoJSONInput = 26, // GEOJSON input error
        BadGeoJSONOutput = 27, // GEOJSON output error
    }
}
