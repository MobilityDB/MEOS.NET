#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TCBuffer of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCBufferInst : TCBuffer
    {
        internal TCBufferInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(CBuffer cb, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TcbufferinstMake(cb.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
