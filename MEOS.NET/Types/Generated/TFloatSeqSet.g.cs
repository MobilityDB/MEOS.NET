#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>A TFloat of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TFloatSeqSet : TFloat
    {
        internal TFloatSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(double d, SpanSet ss, InterpolationType interp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloatseqset_from_base_tstzspanset(d, ss.Ptr, (int) interp));

    }
}
