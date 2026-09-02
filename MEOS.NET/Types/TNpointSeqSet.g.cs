#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TNpoint of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNpointSeqSet : TNpoint
    {
        internal TNpointSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(Npoint np, SpanSet ss, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TnpointseqsetFromBaseTstzspanset(np.Ptr, ss.Ptr, (int) interp));

    }
}
