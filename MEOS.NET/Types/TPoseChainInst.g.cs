#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPoseChain of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoseChainInst : TPoseChain
    {
        internal TPoseChainInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(PoseChain pc, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TposechaininstMake(pc.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
