#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPcpoint of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPcpointSeqSet : TPcpoint
    {
        internal TPcpointSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(Pcpoint pt, SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TpcpointseqsetFromBaseTstzspanset(pt.Ptr, ss.Ptr));

    }
}
