#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TInt of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TIntSeq : TInt
    {
        internal TIntSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(int i, Set s)
            => MEOSFactory.WrapTemporal(Meos.TintseqFromBaseTstzset(i, s.Ptr));

        public static Temporal? FromBaseTstzspan(int i, Span s)
            => MEOSFactory.WrapTemporal(Meos.TintseqFromBaseTstzspan(i, s.Ptr));

    }
}
