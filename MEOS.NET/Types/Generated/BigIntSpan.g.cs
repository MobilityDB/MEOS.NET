#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The BigIntSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSpan : Span
    {
        internal BigIntSpan(IntPtr ptr) : base(ptr) { }

        public Span? Expand(long value)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.bigintspan_expand(this.Ptr, value));

        public long Lower()
            => MEOSExposedFunctions.bigintspan_lower(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.bigintspan_out(this.Ptr);

        public Span? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.bigintspan_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToFloatspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.bigintspan_to_floatspan(this.Ptr));

        public Span? ToIntspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.bigintspan_to_intspan(this.Ptr));

        public long Upper()
            => MEOSExposedFunctions.bigintspan_upper(this.Ptr);

        public long Width()
            => MEOSExposedFunctions.bigintspan_width(this.Ptr);

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.bigintspan_in(str));

        public static Span? Make(long lower, long upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.bigintspan_make(lower, upper, lower_inc, upper_inc));

    }
}
