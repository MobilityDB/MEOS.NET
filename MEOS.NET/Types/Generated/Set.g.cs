#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Unordered set of base values.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Set : Collection
    {
        internal Set(IntPtr ptr) : base(ptr) { }

        public int Cmp(Set s2)
            => MEOSExposedFunctions.set_cmp(this.Ptr, s2.Ptr);

        public Set? Copy()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.set_copy(this.Ptr));

        public bool Eq(Set s2)
            => MEOSExposedFunctions.set_eq(this.Ptr, s2.Ptr);

        public bool Ge(Set s2)
            => MEOSExposedFunctions.set_ge(this.Ptr, s2.Ptr);

        public bool Gt(Set s2)
            => MEOSExposedFunctions.set_gt(this.Ptr, s2.Ptr);

        public uint Hash()
            => MEOSExposedFunctions.set_hash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => MEOSExposedFunctions.set_hash_extended(this.Ptr, seed);

        public bool Le(Set s2)
            => MEOSExposedFunctions.set_le(this.Ptr, s2.Ptr);

        public bool Lt(Set s2)
            => MEOSExposedFunctions.set_lt(this.Ptr, s2.Ptr);

        public bool Ne(Set s2)
            => MEOSExposedFunctions.set_ne(this.Ptr, s2.Ptr);

        public int NumValues()
            => MEOSExposedFunctions.set_num_values(this.Ptr);

        public Set? Round(int maxdd)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.set_round(this.Ptr, maxdd));

        public Span? ToSpan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.set_to_span(this.Ptr));

        public SpanSet? ToSpanset()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.set_to_spanset(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.set_to_tbox(this.Ptr));

        public static Set? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.set_from_hexwkb(hexwkb));

    }
}
