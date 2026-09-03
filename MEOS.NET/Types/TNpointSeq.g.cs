#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TNpoint of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNpointSeq : TNpoint
    {
        internal TNpointSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(Npoint np, Set s)
            => MEOSFactory.WrapTemporal(Meos.TnpointseqFromBaseTstzset(np.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(Npoint np, Span s, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TnpointseqFromBaseTstzspan(np.Ptr, s.Ptr, (int) interp));

    }
}
