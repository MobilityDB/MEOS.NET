#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Set of disjoint spans.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class SpanSet : Collection
    {
        internal SpanSet(IntPtr ptr) : base(ptr) { }

        public int Cmp(SpanSet ss2)
            => Meos.SpansetCmp(this.Ptr, ss2.Ptr);

        public SpanSet? Copy()
            => MEOSFactory.WrapSpanSet(Meos.SpansetCopy(this.Ptr));

        public Span? EndSpan()
            => MEOSFactory.WrapSpan(Meos.SpansetEndSpan(this.Ptr));

        public bool Eq(SpanSet ss2)
            => Meos.SpansetEq(this.Ptr, ss2.Ptr);

        public bool Ge(SpanSet ss2)
            => Meos.SpansetGe(this.Ptr, ss2.Ptr);

        public bool Gt(SpanSet ss2)
            => Meos.SpansetGt(this.Ptr, ss2.Ptr);

        public uint Hash()
            => Meos.SpansetHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.SpansetHashExtended(this.Ptr, seed);

        public bool Le(SpanSet ss2)
            => Meos.SpansetLe(this.Ptr, ss2.Ptr);

        public bool LowerInc()
            => Meos.SpansetLowerInc(this.Ptr);

        public bool Lt(SpanSet ss2)
            => Meos.SpansetLt(this.Ptr, ss2.Ptr);

        public bool Ne(SpanSet ss2)
            => Meos.SpansetNe(this.Ptr, ss2.Ptr);

        public int NumSpans()
            => Meos.SpansetNumSpans(this.Ptr);

        public Span? Span()
            => MEOSFactory.WrapSpan(Meos.SpansetSpan(this.Ptr));

        public Span? SpanN(int i)
            => MEOSFactory.WrapSpan(Meos.SpansetSpanN(this.Ptr, i));

        public Span?[] Spanarr()
            => MEOSFactory.WrapSpanArray(Meos.SpansetSpanarr(this.Ptr));

        public Span? StartSpan()
            => MEOSFactory.WrapSpan(Meos.SpansetStartSpan(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(Meos.SpansetToTbox(this.Ptr));

        public bool UpperInc()
            => Meos.SpansetUpperInc(this.Ptr);

        public static SpanSet? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapSpanSet(Meos.SpansetFromHexwkb(hexwkb));

    }
}
