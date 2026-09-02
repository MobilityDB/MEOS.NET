#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TFloat of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TFloatInst : TFloat
    {
        internal TFloatInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(double d, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TfloatinstMake(d, MEOSConvert.ToTimestampTz(t)));

    }
}
