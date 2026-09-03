#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TBigint of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBigintSeqSet : TBigint
    {
        internal TBigintSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(long i, SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TbigintseqsetFromBaseTstzspanset(i, ss.Ptr));

    }
}
