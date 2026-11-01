#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPcpoint of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPcpointInst : TPcpoint
    {
        internal TPcpointInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Pcpoint pt, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TpcpointinstMake(pt.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
