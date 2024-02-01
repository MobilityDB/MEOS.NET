using MEOS.NET.Errors;

namespace MEOS.NET.Exceptions
{
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
