#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
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
