#nullable enable

using MEOS.NET.Exceptions;

namespace MEOS.NET.Errors
{
    /// <summary>Turns the error MEOS reports into the exception for its code.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    internal static class MEOSErrorHandling
    {
        private static MEOSException? pending;

        /// <summary>Raise what MEOS reported since the last check, if anything.</summary>
        internal static void CheckError()
        {
            if (pending is null)
            {
                return;
            }

            var raised = pending;
            pending = null;
            throw raised;
        }

        /// <summary>The handler MEOS calls; it records, and CheckError raises.</summary>
        internal static void InternalErrorHandler(int level, int errorCode, string message)
            => pending = errorCode switch
            {
                0 => null,  // MEOS_SUCCESS
                1 => new MEOSInternalErrorException(level, MEOSErrorCodes.InternalError, message),
                2 => new MEOSInternalTypeErrorException(level, MEOSErrorCodes.InternalTypeError, message),
                3 => new MEOSValueOutOfRangeException(level, MEOSErrorCodes.ValueOutOfRange, message),
                4 => new MEOSDivisionByZeroException(level, MEOSErrorCodes.DivisionByZero, message),
                5 => new MEOSMemoryAllocErrorException(level, MEOSErrorCodes.MemoryAllocError, message),
                6 => new MEOSAggregationErrorException(level, MEOSErrorCodes.AggregationError, message),
                7 => new MEOSDirectoryErrorException(level, MEOSErrorCodes.DirectoryError, message),
                8 => new MEOSFileErrorException(level, MEOSErrorCodes.FileError, message),
                9 => new MEOSOutOfMemoryException(level, MEOSErrorCodes.OutOfMemory, message),
                10 => new MEOSInvalidArgException(level, MEOSErrorCodes.InvalidArg, message),
                11 => new MEOSInvalidArgTypeException(level, MEOSErrorCodes.InvalidArgType, message),
                12 => new MEOSInvalidArgValueException(level, MEOSErrorCodes.InvalidArgValue, message),
                13 => new MEOSFeatureNotSupportedException(level, MEOSErrorCodes.FeatureNotSupported, message),
                14 => new MEOSIndeterminateCollationException(level, MEOSErrorCodes.IndeterminateCollation, message),
                15 => new MEOSSyntaxErrorException(level, MEOSErrorCodes.SyntaxError, message),
                16 => new MEOSNullResultException(level, MEOSErrorCodes.NullResult, message),
                20 => new MEOSMFJSONInputException(level, MEOSErrorCodes.MFJSONInput, message),
                21 => new MEOSMFJSONOutputException(level, MEOSErrorCodes.MFJSONOutput, message),
                22 => new MEOSTextInputException(level, MEOSErrorCodes.TextInput, message),
                23 => new MEOSTextOutputException(level, MEOSErrorCodes.TextOutput, message),
                24 => new MEOSWKBInputException(level, MEOSErrorCodes.WKBInput, message),
                25 => new MEOSWKBOutputException(level, MEOSErrorCodes.WKBOutput, message),
                26 => new MEOSGEOJSONInputException(level, MEOSErrorCodes.GEOJSONInput, message),
                27 => new MEOSGEOJSONOutputException(level, MEOSErrorCodes.GEOJSONOutput, message),
                28 => new MEOSSQLJSONErrorException(level, MEOSErrorCodes.SQLJSONError, message),
                29 => new MEOSInvalidRegularExpressionException(level, MEOSErrorCodes.InvalidRegularExpression, message),
                // A code this binding does not name is still an error MEOS
                // raised, so it reaches the caller rather than being dropped.
                _ => new MEOSInternalErrorException(
                    level, MEOSErrorCodes.InternalError, message),
            };
    }
}
