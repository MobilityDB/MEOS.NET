#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TCbuffer of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCbufferSeqSet : TCbuffer
    {
        internal TCbufferSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(Cbuffer cb, SpanSet ss, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TcbufferseqsetFromBaseTstzspanset(cb.Ptr, ss.Ptr, (int) interp));

    }
}
