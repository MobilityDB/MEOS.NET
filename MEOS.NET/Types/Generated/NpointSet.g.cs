#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The NpointSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class NpointSet : Set
    {
        internal NpointSet(IntPtr ptr) : base(ptr) { }

        public string Out(int maxdd)
            => MEOSExposedFunctions.npointset_out(this.Ptr, maxdd);

        public Set? Routes()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.npointset_routes(this.Ptr));

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.npointset_in(str));

    }
}
