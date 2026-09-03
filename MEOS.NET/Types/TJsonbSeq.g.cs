#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TJsonb of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TJsonbSeq : TJsonb
    {
        internal TJsonbSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(Jsonb jsonb, Set s)
            => MEOSFactory.WrapTemporal(Meos.TjsonbseqFromBaseTstzset(jsonb.Ptr, s.Ptr));

        public static Temporal? FromBaseTstzspan(Jsonb jsonb, Span sp)
            => MEOSFactory.WrapTemporal(Meos.TjsonbseqFromBaseTstzspan(jsonb.Ptr, sp.Ptr));

    }
}
