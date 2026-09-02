#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>Unordered set of base values.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Set : Collection
    {
        internal Set(IntPtr ptr) : base(ptr) { }

        public int Cmp(Set s2)
            => Meos.SetCmp(this.Ptr, s2.Ptr);

        public Set? Copy()
            => MEOSFactory.WrapSet(Meos.SetCopy(this.Ptr));

        public bool Eq(Set s2)
            => Meos.SetEq(this.Ptr, s2.Ptr);

        public bool Ge(Set s2)
            => Meos.SetGe(this.Ptr, s2.Ptr);

        public bool Gt(Set s2)
            => Meos.SetGt(this.Ptr, s2.Ptr);

        public uint Hash()
            => Meos.SetHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.SetHashExtended(this.Ptr, seed);

        public bool Le(Set s2)
            => Meos.SetLe(this.Ptr, s2.Ptr);

        public bool Lt(Set s2)
            => Meos.SetLt(this.Ptr, s2.Ptr);

        public bool Ne(Set s2)
            => Meos.SetNe(this.Ptr, s2.Ptr);

        public int NumValues()
            => Meos.SetNumValues(this.Ptr);

        public Set? Round(int maxdd)
            => MEOSFactory.WrapSet(Meos.SetRound(this.Ptr, maxdd));

        public Span? ToSpan()
            => MEOSFactory.WrapSpan(Meos.SetToSpan(this.Ptr));

        public SpanSet? ToSpanset()
            => MEOSFactory.WrapSpanSet(Meos.SetToSpanset(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(Meos.SetToTbox(this.Ptr));

        public static Set? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapSet(Meos.SetFromHexwkb(hexwkb));

    }
}
