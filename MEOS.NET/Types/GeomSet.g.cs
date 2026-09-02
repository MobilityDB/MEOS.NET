#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The GeomSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class GeomSet : Set
    {
        internal GeomSet(IntPtr ptr) : base(ptr) { }

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.GeomsetIn(str));

    }
}
