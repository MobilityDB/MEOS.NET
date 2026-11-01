#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPcpatch of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPcpatchSeqSet : TPcpatch
    {
        internal TPcpatchSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(Pcpatch pa, SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchseqsetFromBaseTstzspanset(pa.Ptr, ss.Ptr));

    }
}
