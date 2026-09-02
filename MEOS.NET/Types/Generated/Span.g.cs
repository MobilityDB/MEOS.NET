#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Contiguous range over an ordered base type.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Span : Collection
    {
        internal Span(IntPtr ptr) : base(ptr) { }

        public int Cmp(Span s2)
            => MEOSExposedFunctions.span_cmp(this.Ptr, s2.Ptr);

        public Span? Copy()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.span_copy(this.Ptr));

        public bool Eq(Span s2)
            => MEOSExposedFunctions.span_eq(this.Ptr, s2.Ptr);

        public bool Ge(Span s2)
            => MEOSExposedFunctions.span_ge(this.Ptr, s2.Ptr);

        public bool Gt(Span s2)
            => MEOSExposedFunctions.span_gt(this.Ptr, s2.Ptr);

        public uint Hash()
            => MEOSExposedFunctions.span_hash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => MEOSExposedFunctions.span_hash_extended(this.Ptr, seed);

        public bool Le(Span s2)
            => MEOSExposedFunctions.span_le(this.Ptr, s2.Ptr);

        public bool LowerInc()
            => MEOSExposedFunctions.span_lower_inc(this.Ptr);

        public bool Lt(Span s2)
            => MEOSExposedFunctions.span_lt(this.Ptr, s2.Ptr);

        public bool Ne(Span s2)
            => MEOSExposedFunctions.span_ne(this.Ptr, s2.Ptr);

        public SpanSet? ToSpanset()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.span_to_spanset(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.span_to_tbox(this.Ptr));

        public bool UpperInc()
            => MEOSExposedFunctions.span_upper_inc(this.Ptr);

        public static Span? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.span_from_hexwkb(hexwkb));

    }
}
