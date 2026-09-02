#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The GeogSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class GeogSet : Set
    {
        internal GeogSet(IntPtr ptr) : base(ptr) { }

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.geogset_in(str));

    }
}
