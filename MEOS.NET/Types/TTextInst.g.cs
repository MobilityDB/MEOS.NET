#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TText of subtype TInstant.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TTextInst : TText
    {
        internal TTextInst(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Text txt, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TtextinstMake(txt.Ptr, MEOSConvert.ToTimestampTz(t)));

    }
}
