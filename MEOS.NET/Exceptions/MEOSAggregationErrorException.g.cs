#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>Internal aggregation error (<c>MEOS_ERR_AGGREGATION_ERROR</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MEOSAggregationErrorException : MEOSException
    {
        internal MEOSAggregationErrorException(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        { }
    }
}
