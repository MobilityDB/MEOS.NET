#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>A TBigint of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBigintSeq : TBigint
    {
        internal TBigintSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(long i, Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigintseq_from_base_tstzset(i, s.Ptr));

        public static Temporal? FromBaseTstzspan(long i, Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigintseq_from_base_tstzspan(i, s.Ptr));

    }
}
