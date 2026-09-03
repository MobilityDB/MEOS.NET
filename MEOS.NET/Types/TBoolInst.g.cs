#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TBool of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBoolInst : TBool
    {
        internal TBoolInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(bool b, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TboolinstMake(b, MEOSConvert.ToTimestampTz(t)));

    }
}
