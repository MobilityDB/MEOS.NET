#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TFloat of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TFloatSeq : TFloat
    {
        internal TFloatSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(double d, Set s)
            => MEOSFactory.WrapTemporal(Meos.TfloatseqFromBaseTstzset(d, s.Ptr));

        public static Temporal? FromBaseTstzspan(double d, Span s, InterpolationType interp)
            => MEOSFactory.WrapTemporal(Meos.TfloatseqFromBaseTstzspan(d, s.Ptr, (int) interp));

    }
}
