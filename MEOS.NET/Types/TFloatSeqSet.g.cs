#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TFloat of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TFloatSeqSet : TFloat
    {
        internal TFloatSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(double d, SpanSet ss, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TfloatseqsetFromBaseTstzspanset(d, ss.Ptr, (int) interp));

    }
}
