#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TCBuffer of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCBufferSeq : TCBuffer
    {
        internal TCBufferSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(CBuffer cb, Set s)
            => MEOSFactory.WrapTemporal(Meos.TcbufferseqFromBaseTstzset(cb.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(CBuffer cb, Span s, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TcbufferseqFromBaseTstzspan(cb.Ptr, s.Ptr, (int) interp));

    }
}
