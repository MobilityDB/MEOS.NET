#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPCPoint of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPCPointSeq : TPCPoint
    {
        internal TPCPointSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(PCPoint pt, Set s)
            => MEOSFactory.WrapTemporal(Meos.TpcpointseqFromBaseTstzset(pt.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(PCPoint pt, Span sp)
            => MEOSFactory.WrapTemporal(Meos.TpcpointseqFromBaseTstzspan(pt.Ptr, sp.Ptr));

    }
}
