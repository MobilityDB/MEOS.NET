#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>A TBigint of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBigintInst : TBigint
    {
        internal TBigintInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(long i, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TbigintinstMake(i, MEOSConvert.ToTimestampTz(t)));

    }
}
