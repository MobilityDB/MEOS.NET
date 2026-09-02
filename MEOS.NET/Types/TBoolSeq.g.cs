#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TBool of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBoolSeq : TBool
    {
        internal TBoolSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(bool b, Set s)
            => MEOSFactory.WrapTemporal(Meos.TboolseqFromBaseTstzset(b, s.Ptr));

        public static Temporal? FromBaseTstzspan(bool b, Span s)
            => MEOSFactory.WrapTemporal(Meos.TboolseqFromBaseTstzspan(b, s.Ptr));

    }
}
