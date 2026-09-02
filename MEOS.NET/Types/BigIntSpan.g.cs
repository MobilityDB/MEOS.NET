#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The BigIntSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSpan : Span
    {
        internal BigIntSpan(IntPtr ptr) : base(ptr) { }

        public Span? Expand(long value)
            => MEOSFactory.WrapSpan(Meos.BigintspanExpand(this.Ptr, value));

        public long Lower()
            => Meos.BigintspanLower(this.Ptr);

        public string Out()
            => Meos.BigintspanOut(this.Ptr);

        public Span? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(Meos.BigintspanShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToFloatspan()
            => MEOSFactory.WrapSpan(Meos.BigintspanToFloatspan(this.Ptr));

        public Span? ToIntspan()
            => MEOSFactory.WrapSpan(Meos.BigintspanToIntspan(this.Ptr));

        public long Upper()
            => Meos.BigintspanUpper(this.Ptr);

        public long Width()
            => Meos.BigintspanWidth(this.Ptr);

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.BigintspanIn(str));

        public static Span? Make(long lower, long upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.BigintspanMake(lower, upper, lower_inc, upper_inc));

    }
}
