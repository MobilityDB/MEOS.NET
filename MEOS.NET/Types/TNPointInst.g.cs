#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TNPoint of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNPointInst : TNPoint
    {
        internal TNPointInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(NPoint np, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TnpointinstMake(np.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
