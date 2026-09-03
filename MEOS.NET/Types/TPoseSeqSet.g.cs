#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TPose of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoseSeqSet : TPose
    {
        internal TPoseSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(Pose pose, SpanSet ss, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TposeseqsetFromBaseTstzspanset(pose.Ptr, ss.Ptr, (int) interp));

    }
}
