#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPose of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoseSeq : TPose
    {
        internal TPoseSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(Pose pose, Set s)
            => MEOSFactory.WrapTemporal(Meos.TposeseqFromBaseTstzset(pose.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(Pose pose, Span s, InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TposeseqFromBaseTstzspan(pose.Ptr, s.Ptr, (int) interp));

    }
}
