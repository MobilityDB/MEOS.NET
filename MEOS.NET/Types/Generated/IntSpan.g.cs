#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The IntSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSpan : Span
    {
        internal IntSpan(IntPtr ptr) : base(ptr) { }

        public Span? Expand(int value)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.intspan_expand(this.Ptr, value));

        public int Lower()
            => MEOSExposedFunctions.intspan_lower(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.intspan_out(this.Ptr);

        public Span? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.intspan_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToBigintspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.intspan_to_bigintspan(this.Ptr));

        public Span? ToFloatspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.intspan_to_floatspan(this.Ptr));

        public int Upper()
            => MEOSExposedFunctions.intspan_upper(this.Ptr);

        public int Width()
            => MEOSExposedFunctions.intspan_width(this.Ptr);

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.intspan_in(str));

        public static Span? Make(int lower, int upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.intspan_make(lower, upper, lower_inc, upper_inc));

    }
}
