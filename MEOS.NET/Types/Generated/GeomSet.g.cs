#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The GeomSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class GeomSet : Set
    {
        internal GeomSet(IntPtr ptr) : base(ptr) { }

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.geomset_in(str));

    }
}
