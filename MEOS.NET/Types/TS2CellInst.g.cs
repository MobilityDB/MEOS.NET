#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TS2Cell of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TS2CellInst : TS2Cell
    {
        internal TS2CellInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(S2Cell value, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellinstMake(value.value, MEOSConvert.ToTimestampTz(t)));

    }
}
