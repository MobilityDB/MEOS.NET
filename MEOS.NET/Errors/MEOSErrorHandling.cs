using MEOS.NET.Exceptions;

namespace MEOS.NET.Errors
{
    public static class MEOSErrorHandling
    {
        private static MEOSException? currentException = null;

        internal static void CheckError()
        {
            if (currentException is null)
            {
                return;
            }

            var e = currentException;
            currentException = null;

            throw e;
        }

        internal static void InternalErrorHandler(int level, int errorCode, string message)
        {
            // If MEOS error code is not defined in our C# code,
            // We register an unspecified exception to guarantee code-safety
            if (!Enum.IsDefined(typeof(MEOSErrorCodes), errorCode))
            {
                RegisterException(new MEOSUnspecifiedInternalException(level, MEOSErrorCodes.UnspecifiedInternalError, message));
            }

            var code = (MEOSErrorCodes)errorCode;

            switch (code)
            {
                case MEOSErrorCodes.Success:
                    return;

                case MEOSErrorCodes.UnspecifiedInternalError:
                    RegisterException(new MEOSUnspecifiedInternalException(level, code, message));
                    break;

                case MEOSErrorCodes.InternalTypeError:
                    RegisterException(new MEOSInternalTypeErrorException(level, code, message));
                    break;

                case MEOSErrorCodes.ValueOutOfRange:
                    RegisterException(new MEOSValueOutOfRangeException(level, code, message));
                    break;

                case MEOSErrorCodes.DivisionByZero:
                    RegisterException(new MEOSDivisionByZeroException(level, code, message));
                    break;

                case MEOSErrorCodes.MemoryAllocationError:
                    RegisterException(new MEOSMemoryAllocationException(level, code, message));
                    break;

                case MEOSErrorCodes.AggregationError:
                    RegisterException(new MEOSAggregationException(level, code, message));
                    break;

                case MEOSErrorCodes.DirectoryError:
                    RegisterException(new MEOSDirectoryException(level, code, message));
                    break;

                case MEOSErrorCodes.FileError:
                    RegisterException(new MEOSFileException(level, code, message));
                    break;

                case MEOSErrorCodes.InvalidArgument:
                    RegisterException(new MEOSInvalidArgumentException(level, code, message));
                    break;

                case MEOSErrorCodes.InvalidArgumentType:
                    RegisterException(new MEOSInvalidArgumentTypeException(level, code, message));
                    break;

                case MEOSErrorCodes.InvalidArgumentValue:
                    RegisterException(new MEOSInvalidArgumentValueException(level, code, message));
                    break;

                case MEOSErrorCodes.BadMFJSONInput:
                    RegisterException(new MEOSBadMFJSONInputException(level, code, message));
                    break;

                case MEOSErrorCodes.BadMFJSONOutput:
                    RegisterException(new MEOSBadMFJSONOutputException(level, code, message));
                    break;

                case MEOSErrorCodes.BadTextInput:
                    RegisterException(new MEOSBadTextInputException(level, code, message));
                    break;

                case MEOSErrorCodes.BadTextOutput:
                    RegisterException(new MEOSBadTextOutputException(level, code, message));
                    break;

                case MEOSErrorCodes.BadWellKnownBinaryInput:
                    RegisterException(new MEOSBadWKBInputException(level, code, message));
                    break;

                case MEOSErrorCodes.BadWellKnownBinaryOutput:
                    RegisterException(new MEOSBadWKBOutputException(level, code, message));
                    break;

                case MEOSErrorCodes.BadGeoJSONInput:
                    RegisterException(new MEOSBadGeoJSONInputException(level, code, message));
                    break;

                case MEOSErrorCodes.BadGeoJSONOutput:
                    RegisterException(new MEOSBadGeoJSONOutputException(level, code, message));
                    break;

                default:
                    RegisterException(new MEOSUnspecifiedInternalException(level, code, message));
                    break;
            }
        }

        private static void RegisterException(MEOSException exception)
            => currentException = exception;
    }
}
