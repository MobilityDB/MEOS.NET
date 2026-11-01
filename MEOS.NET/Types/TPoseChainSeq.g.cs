#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPoseChain of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoseChainSeq : TPoseChain
    {
        internal TPoseChainSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(PoseChain pc, Set s)
            => MEOSFactory.WrapTemporal(Meos.TposechainseqFromBaseTstzset(pc.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(PoseChain pc, Span s, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TposechainseqFromBaseTstzspan(pc.Ptr, s.Ptr, (int) interp));

    }
}
