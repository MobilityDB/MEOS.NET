#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TNPoint of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNPointSeqSet : TNPoint
    {
        internal TNPointSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(NPoint np, SpanSet ss, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TnpointseqsetFromBaseTstzspanset(np.Ptr, ss.Ptr, (int) interp));

    }
}
