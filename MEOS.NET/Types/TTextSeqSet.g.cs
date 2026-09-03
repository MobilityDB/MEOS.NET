#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TText of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TTextSeqSet : TText
    {
        internal TTextSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(Text txt, SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TtextseqsetFromBaseTstzspanset(txt.Ptr, ss.Ptr));

    }
}
