using MEOS.NET.Exceptions;

namespace MEOS.NET.Errors
{
    public static class MEOSErrorHandling
    {
        //public delegate void ErrorHandlingMethod(int a, int b, string c);
        //public static event ErrorHandlingMethod OnError;

        internal static void CheckError()
        {
            throw new Exception("Hello this is exception");
        }

        internal static void DefaultErrorHandler(int level, int errorCode, string message)
        {
            // If MEOS error code is not defined in our C# code,
            // We return an unspecified exception to guarantee code-safety
            if (!Enum.IsDefined(typeof(MEOSErrorCodes), errorCode))
            {
                throw new MEOSUnspecifiedInternalException(level, MEOSErrorCodes.UnspecifiedInternalError, message);
            }

            var code = (MEOSErrorCodes)errorCode;

            switch (code)
            {
                case MEOSErrorCodes.Success:
                    return;

                case MEOSErrorCodes.UnspecifiedInternalError:
                    throw new MEOSUnspecifiedInternalException(level, code, message);

                case MEOSErrorCodes.InternalTypeError:
                    throw new MEOSInternalTypeErrorException(level, code, message);

                case MEOSErrorCodes.ValueOutOfRange:
                    throw new MEOSValueOutOfRangeException(level, code, message);

                case MEOSErrorCodes.DivisionByZero:
                    throw new MEOSDivisionByZeroException(level, code, message);

                case MEOSErrorCodes.MemoryAllocationError:
                    throw new MEOSMemoryAllocationException(level, code, message);

                case MEOSErrorCodes.AggregationError:
                    throw new MEOSAggregationException(level, code, message);

                case MEOSErrorCodes.DirectoryError:
                    throw new MEOSDirectoryException(level, code, message);

                case MEOSErrorCodes.FileError:
                    throw new MEOSFileException(level, code, message);

                case MEOSErrorCodes.InvalidArgument:
                    throw new MEOSInvalidArgumentException(level, code, message);

                case MEOSErrorCodes.InvalidArgumentType:
                    throw new MEOSInvalidArgumentTypeException(level, code, message);

                case MEOSErrorCodes.InvalidArgumentValue:
                    throw new MEOSInvalidArgumentValueException(level, code, message);

                case MEOSErrorCodes.BadMFJSONInput:
                    throw new MEOSBadMFJSONInputException(level, code, message);

                case MEOSErrorCodes.BadMFJSONOutput:
                    throw new MEOSBadMFJSONOutputException(level, code, message);

                case MEOSErrorCodes.BadTextInput:
                    throw new MEOSBadTextInputException(level, code, message);

                case MEOSErrorCodes.BadTextOutput:
                    throw new MEOSBadTextOutputException(level, code, message);

                case MEOSErrorCodes.BadWellKnownBinaryInput:
                    throw new MEOSBadWKBInputException(level, code, message);

                case MEOSErrorCodes.BadWellKnownBinaryOutput:
                    throw new MEOSBadWKBOutputException(level, code, message);

                case MEOSErrorCodes.BadGeoJSONInput:
                    throw new MEOSBadGeoJSONInputException(level, code, message);

                case MEOSErrorCodes.BadGeoJSONOutput:
                    throw new MEOSBadGeoJSONOutputException(level, code, message);

                default:
                    throw new MEOSUnspecifiedInternalException(level, code, message);
            }
        }
    }
}
