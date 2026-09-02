#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>A TBool of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBoolInst : TBool
    {
        internal TBoolInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(bool b, DateTime t)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tboolinst_make(b, MEOSConvert.ToTimestampTz(t)));

    }
}
