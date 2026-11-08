#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TNPoint of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNPointSeq : TNPoint
    {
        internal TNPointSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(NPoint np, Set s)
            => MEOSFactory.WrapTemporal(Meos.TnpointseqFromBaseTstzset(np.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(NPoint np, Span s, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TnpointseqFromBaseTstzspan(np.Ptr, s.Ptr, (int) interp));

    }
}
