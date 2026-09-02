#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TJsonb of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TJsonbInst : TJsonb
    {
        internal TJsonbInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Jsonb jsonb, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TjsonbinstMake(jsonb.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
