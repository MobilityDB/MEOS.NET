#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPCPoint of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPCPointInst : TPCPoint
    {
        internal TPCPointInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(PCPoint pt, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TpcpointinstMake(pt.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
