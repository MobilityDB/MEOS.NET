#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The CbufferSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class CbufferSet : Set
    {
        internal CbufferSet(IntPtr ptr) : base(ptr) { }

        public string Out(int maxdd)
            => MEOSExposedFunctions.cbufferset_out(this.Ptr, maxdd);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.cbufferset_in(str));

    }
}
