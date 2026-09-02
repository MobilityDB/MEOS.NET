#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Numeric x time box (bbox of TNumber).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBox : Box
    {
        internal TBox(IntPtr ptr) : base(ptr) { }

        public int Cmp(TBox box2)
            => MEOSExposedFunctions.tbox_cmp(this.Ptr, box2.Ptr);

        public TBox? Copy()
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.tbox_copy(this.Ptr));

        public bool Eq(TBox box2)
            => MEOSExposedFunctions.tbox_eq(this.Ptr, box2.Ptr);

        public bool Ge(TBox box2)
            => MEOSExposedFunctions.tbox_ge(this.Ptr, box2.Ptr);

        public bool Gt(TBox box2)
            => MEOSExposedFunctions.tbox_gt(this.Ptr, box2.Ptr);

        public uint Hash()
            => MEOSExposedFunctions.tbox_hash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => MEOSExposedFunctions.tbox_hash_extended(this.Ptr, seed);

        public bool Hast()
            => MEOSExposedFunctions.tbox_hast(this.Ptr);

        public bool Hasx()
            => MEOSExposedFunctions.tbox_hasx(this.Ptr);

        public bool Le(TBox box2)
            => MEOSExposedFunctions.tbox_le(this.Ptr, box2.Ptr);

        public bool Lt(TBox box2)
            => MEOSExposedFunctions.tbox_lt(this.Ptr, box2.Ptr);

        public bool Ne(TBox box2)
            => MEOSExposedFunctions.tbox_ne(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => MEOSExposedFunctions.tbox_out(this.Ptr, maxdd);

        public TBox? Round(int maxdd)
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.tbox_round(this.Ptr, maxdd));

        public Span? ToBigintspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.tbox_to_bigintspan(this.Ptr));

        public Span? ToFloatspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.tbox_to_floatspan(this.Ptr));

        public Span? ToIntspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.tbox_to_intspan(this.Ptr));

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.tbox_to_tstzspan(this.Ptr));

        public static TBox? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.tbox_from_hexwkb(hexwkb));

        public static TBox? In(string str)
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.tbox_in(str));

        public static TBox? Make(Span s, Span p)
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.tbox_make(s.Ptr, p.Ptr));

    }
}
