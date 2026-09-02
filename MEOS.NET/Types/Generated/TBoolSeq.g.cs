#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>A TBool of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBoolSeq : TBool
    {
        internal TBoolSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(bool b, Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tboolseq_from_base_tstzset(b, s.Ptr));

        public static Temporal? FromBaseTstzspan(bool b, Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tboolseq_from_base_tstzspan(b, s.Ptr));

    }
}
