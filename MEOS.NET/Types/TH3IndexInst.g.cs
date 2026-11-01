#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TH3Index of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TH3IndexInst : TH3Index
    {
        internal TH3IndexInst(IntPtr ptr) : base(ptr) { }

        public new static Temporal? Make(ulong value, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.Th3indexinstMake(value, MEOSConvert.ToTimestampTz(t)));

    }
}
