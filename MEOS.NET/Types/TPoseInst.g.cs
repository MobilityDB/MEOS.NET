#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TPose of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoseInst : TPose
    {
        internal TPoseInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Pose pose, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TposeinstMake(pose.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
