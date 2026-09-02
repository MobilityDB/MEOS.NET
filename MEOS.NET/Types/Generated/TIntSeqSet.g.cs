#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>A TInt of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TIntSeqSet : TInt
    {
        internal TIntSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(int i, SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TintseqsetFromBaseTstzspanset(i, ss.Ptr));

    }
}
