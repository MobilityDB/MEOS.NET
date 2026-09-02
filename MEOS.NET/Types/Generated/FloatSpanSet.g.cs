#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The FloatSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class FloatSpanSet : SpanSet
    {
        internal FloatSpanSet(IntPtr ptr) : base(ptr) { }

        public SpanSet? Ceil()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.floatspanset_ceil(this.Ptr));

        public SpanSet? Degrees(bool normalize)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.floatspanset_degrees(this.Ptr, normalize));

        public SpanSet? Floor()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.floatspanset_floor(this.Ptr));

        public double Lower()
            => MEOSExposedFunctions.floatspanset_lower(this.Ptr);

        public string Out(int maxdd)
            => MEOSExposedFunctions.floatspanset_out(this.Ptr, maxdd);

        public SpanSet? Radians()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.floatspanset_radians(this.Ptr));

        public SpanSet? Round(int maxdd)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.floatspanset_round(this.Ptr, maxdd));

        public SpanSet? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.floatspanset_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public SpanSet? ToIntspanset()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.floatspanset_to_intspanset(this.Ptr));

        public double Upper()
            => MEOSExposedFunctions.floatspanset_upper(this.Ptr);

        public double Width(bool boundspan)
            => MEOSExposedFunctions.floatspanset_width(this.Ptr, boundspan);

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.floatspanset_in(str));

    }
}
