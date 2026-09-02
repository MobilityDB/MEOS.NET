#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The BigIntSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSpanSet : SpanSet
    {
        internal BigIntSpanSet(IntPtr ptr) : base(ptr) { }

        public long Lower()
            => MEOSExposedFunctions.bigintspanset_lower(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.bigintspanset_out(this.Ptr);

        public SpanSet? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.bigintspanset_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public long Upper()
            => MEOSExposedFunctions.bigintspanset_upper(this.Ptr);

        public long Width(bool boundspan)
            => MEOSExposedFunctions.bigintspanset_width(this.Ptr, boundspan);

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.bigintspanset_in(str));

    }
}
