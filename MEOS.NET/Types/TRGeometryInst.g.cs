#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TRGeometry of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TRGeometryInst : TRGeometry
    {
        internal TRGeometryInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Geo geom, Pose pose, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryinstMake(geom.Ptr, pose.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
