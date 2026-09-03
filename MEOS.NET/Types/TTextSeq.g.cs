#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TText of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TTextSeq : TText
    {
        internal TTextSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(Text txt, Set s)
            => MEOSFactory.WrapTemporal(Meos.TtextseqFromBaseTstzset(txt.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(Text txt, Span s)
            => MEOSFactory.WrapTemporal(Meos.TtextseqFromBaseTstzspan(txt.Ptr, s.Ptr));

    }
}
