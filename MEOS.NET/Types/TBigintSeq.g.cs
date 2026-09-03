#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TBigint of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBigintSeq : TBigint
    {
        internal TBigintSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(long i, Set s)
            => MEOSFactory.WrapTemporal(Meos.TbigintseqFromBaseTstzset(i, s.Ptr));

        public static Temporal? FromBaseTstzspan(long i, Span s)
            => MEOSFactory.WrapTemporal(Meos.TbigintseqFromBaseTstzspan(i, s.Ptr));

    }
}
