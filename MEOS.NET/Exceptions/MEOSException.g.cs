#nullable enable

using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
    /// <summary>An error MEOS raised, with the code and level it raised it at.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public abstract class MEOSException : Exception
    {
        public int Level { get; init; }

        public MEOSErrorCodes Code { get; init; }

        internal MEOSException(int level, MEOSErrorCodes code, string message)
            : base(message)
        {
            this.Level = level;
            this.Code = code;
        }
    }
}
