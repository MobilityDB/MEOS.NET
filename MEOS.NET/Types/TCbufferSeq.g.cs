#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TCbuffer of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCbufferSeq : TCbuffer
    {
        internal TCbufferSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(Cbuffer cb, Set s)
            => MEOSFactory.WrapTemporal(Meos.TcbufferseqFromBaseTstzset(cb.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(Cbuffer cb, Span s, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TcbufferseqFromBaseTstzspan(cb.Ptr, s.Ptr, (int) interp));

    }
}
