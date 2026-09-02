#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The FloatSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class FloatSpan : Span
    {
        internal FloatSpan(IntPtr ptr) : base(ptr) { }

        public Span? Ceil()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_ceil(this.Ptr));

        public Span? Degrees(bool normalize)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_degrees(this.Ptr, normalize));

        public Span? Expand(double value)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_expand(this.Ptr, value));

        public Span? Floor()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_floor(this.Ptr));

        public double Lower()
            => MEOSExposedFunctions.floatspan_lower(this.Ptr);

        public string Out(int maxdd)
            => MEOSExposedFunctions.floatspan_out(this.Ptr, maxdd);

        public Span? Radians()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_radians(this.Ptr));

        public Span? Round(int maxdd)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_round(this.Ptr, maxdd));

        public Span? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToBigintspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_to_bigintspan(this.Ptr));

        public Span? ToIntspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_to_intspan(this.Ptr));

        public double Upper()
            => MEOSExposedFunctions.floatspan_upper(this.Ptr);

        public double Width()
            => MEOSExposedFunctions.floatspan_width(this.Ptr);

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_in(str));

        public static Span? Make(double lower, double upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.floatspan_make(lower, upper, lower_inc, upper_inc));

    }
}
