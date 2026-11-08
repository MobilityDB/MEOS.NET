#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TCBuffer of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCBufferSeqSet : TCBuffer
    {
        internal TCBufferSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(CBuffer cb, SpanSet ss, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TcbufferseqsetFromBaseTstzspanset(cb.Ptr, ss.Ptr, (int) interp));

    }
}
