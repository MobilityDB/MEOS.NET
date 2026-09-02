#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>A TBool of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBoolSeqSet : TBool
    {
        internal TBoolSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(bool b, SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TboolseqsetFromBaseTstzspanset(b, ss.Ptr));

    }
}
