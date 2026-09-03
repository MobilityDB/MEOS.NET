#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TInt of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TIntInst : TInt
    {
        internal TIntInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(int i, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TintinstMake(i, MEOSConvert.ToTimestampTz(t)));

    }
}
