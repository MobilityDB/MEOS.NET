#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TJsonb of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TJsonbSeqSet : TJsonb
    {
        internal TJsonbSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(Jsonb jsonb, SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TjsonbseqsetFromBaseTstzspanset(jsonb.Ptr, ss.Ptr));

    }
}
