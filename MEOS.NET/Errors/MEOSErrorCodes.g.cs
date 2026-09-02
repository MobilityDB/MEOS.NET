#nullable enable

namespace MEOS.NET.Errors
{
    /// <summary>Every code MEOS raises with, and what each one means.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public enum MEOSErrorCodes
    {
        /// <summary>Successful operation (<c>MEOS_SUCCESS</c>).</summary>
        Success = 0,

        /// <summary>Unspecified internal error (<c>MEOS_ERR_INTERNAL_ERROR</c>).</summary>
        InternalError = 1,

        /// <summary>Internal type error (<c>MEOS_ERR_INTERNAL_TYPE_ERROR</c>).</summary>
        InternalTypeError = 2,

        /// <summary>Internal out of range error (<c>MEOS_ERR_VALUE_OUT_OF_RANGE</c>).</summary>
        ValueOutOfRange = 3,

        /// <summary>Internal division by zero error (<c>MEOS_ERR_DIVISION_BY_ZERO</c>).</summary>
        DivisionByZero = 4,

        /// <summary>Internal malloc error (<c>MEOS_ERR_MEMORY_ALLOC_ERROR</c>).</summary>
        MemoryAllocError = 5,

        /// <summary>Internal aggregation error (<c>MEOS_ERR_AGGREGATION_ERROR</c>).</summary>
        AggregationError = 6,

        /// <summary>Internal directory error (<c>MEOS_ERR_DIRECTORY_ERROR</c>).</summary>
        DirectoryError = 7,

        /// <summary>Internal file error (<c>MEOS_ERR_FILE_ERROR</c>).</summary>
        FileError = 8,

        /// <summary>Out of memory error (<c>MEOS_ERR_OUT_OF_MEMORY</c>).</summary>
        OutOfMemory = 9,

        /// <summary>Invalid argument (<c>MEOS_ERR_INVALID_ARG</c>).</summary>
        InvalidArg = 10,

        /// <summary>Invalid argument type (<c>MEOS_ERR_INVALID_ARG_TYPE</c>).</summary>
        InvalidArgType = 11,

        /// <summary>Invalid argument value (<c>MEOS_ERR_INVALID_ARG_VALUE</c>).</summary>
        InvalidArgValue = 12,

        /// <summary>Feature not currently supported (<c>MEOS_ERR_FEATURE_NOT_SUPPORTED</c>).</summary>
        FeatureNotSupported = 13,

        /// <summary>Indeterminate collation (<c>MEOS_ERR_INDETERMINATE_COLLATION</c>).</summary>
        IndeterminateCollation = 14,

        /// <summary>Syntax error (<c>MEOS_ERR_SYNTAX_ERROR</c>).</summary>
        SyntaxError = 15,

        /// <summary>Operation returned null (<c>MEOS_ERR_NULL_RESULT</c>).</summary>
        NullResult = 16,

        /// <summary>MFJSON input error (<c>MEOS_ERR_MFJSON_INPUT</c>).</summary>
        MFJSONInput = 20,

        /// <summary>MFJSON output error (<c>MEOS_ERR_MFJSON_OUTPUT</c>).</summary>
        MFJSONOutput = 21,

        /// <summary>Text input error (<c>MEOS_ERR_TEXT_INPUT</c>).</summary>
        TextInput = 22,

        /// <summary>Text output error (<c>MEOS_ERR_TEXT_OUTPUT</c>).</summary>
        TextOutput = 23,

        /// <summary>WKB input error (<c>MEOS_ERR_WKB_INPUT</c>).</summary>
        WKBInput = 24,

        /// <summary>WKB output error (<c>MEOS_ERR_WKB_OUTPUT</c>).</summary>
        WKBOutput = 25,

        /// <summary>GEOJSON input error (<c>MEOS_ERR_GEOJSON_INPUT</c>).</summary>
        GEOJSONInput = 26,

        /// <summary>GEOJSON output error (<c>MEOS_ERR_GEOJSON_OUTPUT</c>).</summary>
        GEOJSONOutput = 27,

        /// <summary>SQL JSON error (<c>MEOS_ERR_SQL_JSON_ERROR</c>).</summary>
        SQLJSONError = 28,

        /// <summary>Regular expression error (<c>MEOS_ERR_INVALID_REGULAR_EXPRESSION</c>).</summary>
        InvalidRegularExpression = 29,

    }
}
