#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPcpatch of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPcpatchInst : TPcpatch
    {
        internal TPcpatchInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Pcpatch pa, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchinstMake(pa.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
