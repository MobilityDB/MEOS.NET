#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>A TInt of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TIntSeq : TInt
    {
        internal TIntSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(int i, Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tintseq_from_base_tstzset(i, s.Ptr));

        public static Temporal? FromBaseTstzspan(int i, Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tintseq_from_base_tstzspan(i, s.Ptr));

    }
}
