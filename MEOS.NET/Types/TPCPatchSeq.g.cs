#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPCPatch of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPCPatchSeq : TPCPatch
    {
        internal TPCPatchSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(PCPatch pa, Set s)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchseqFromBaseTstzset(pa.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(PCPatch pa, Span sp)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchseqFromBaseTstzspan(pa.Ptr, sp.Ptr));

    }
}
