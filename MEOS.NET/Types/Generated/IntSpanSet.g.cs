#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The IntSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSpanSet : SpanSet
    {
        internal IntSpanSet(IntPtr ptr) : base(ptr) { }

        public int Lower()
            => MEOSExposedFunctions.intspanset_lower(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.intspanset_out(this.Ptr);

        public SpanSet? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.intspanset_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public SpanSet? ToFloatspanset()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.intspanset_to_floatspanset(this.Ptr));

        public int Upper()
            => MEOSExposedFunctions.intspanset_upper(this.Ptr);

        public int Width(bool boundspan)
            => MEOSExposedFunctions.intspanset_width(this.Ptr, boundspan);

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.intspanset_in(str));

    }
}
