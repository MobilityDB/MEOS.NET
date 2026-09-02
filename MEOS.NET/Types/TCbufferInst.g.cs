#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TCbuffer of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCbufferInst : TCbuffer
    {
        internal TCbufferInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Cbuffer cb, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TcbufferinstMake(cb.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
