#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TQuadbin of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TQuadbinInst : TQuadbin
    {
        internal TQuadbinInst(IntPtr ptr) : base(ptr) { }

        public new static Temporal? Make(ulong value, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TquadbininstMake(value, MEOSConvert.ToTimestampTz(t)));

    }
}
