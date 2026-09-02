#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Set of disjoint spans.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class SpanSet : Collection
    {
        internal SpanSet(IntPtr ptr) : base(ptr) { }

        public int Cmp(SpanSet ss2)
            => MEOSExposedFunctions.spanset_cmp(this.Ptr, ss2.Ptr);

        public SpanSet? Copy()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.spanset_copy(this.Ptr));

        public Span? EndSpan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.spanset_end_span(this.Ptr));

        public bool Eq(SpanSet ss2)
            => MEOSExposedFunctions.spanset_eq(this.Ptr, ss2.Ptr);

        public bool Ge(SpanSet ss2)
            => MEOSExposedFunctions.spanset_ge(this.Ptr, ss2.Ptr);

        public bool Gt(SpanSet ss2)
            => MEOSExposedFunctions.spanset_gt(this.Ptr, ss2.Ptr);

        public uint Hash()
            => MEOSExposedFunctions.spanset_hash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => MEOSExposedFunctions.spanset_hash_extended(this.Ptr, seed);

        public bool Le(SpanSet ss2)
            => MEOSExposedFunctions.spanset_le(this.Ptr, ss2.Ptr);

        public bool LowerInc()
            => MEOSExposedFunctions.spanset_lower_inc(this.Ptr);

        public bool Lt(SpanSet ss2)
            => MEOSExposedFunctions.spanset_lt(this.Ptr, ss2.Ptr);

        public bool Ne(SpanSet ss2)
            => MEOSExposedFunctions.spanset_ne(this.Ptr, ss2.Ptr);

        public int NumSpans()
            => MEOSExposedFunctions.spanset_num_spans(this.Ptr);

        public Span? Span()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.spanset_span(this.Ptr));

        public Span? SpanN(int i)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.spanset_span_n(this.Ptr, i));

        public Span?[] Spanarr()
            => MEOSFactory.WrapSpanArray(MEOSExposedFunctions.spanset_spanarr(this.Ptr));

        public Span? StartSpan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.spanset_start_span(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.spanset_to_tbox(this.Ptr));

        public bool UpperInc()
            => MEOSExposedFunctions.spanset_upper_inc(this.Ptr);

        public static SpanSet? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.spanset_from_hexwkb(hexwkb));

    }
}
