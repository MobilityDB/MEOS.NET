#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The GeogSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class GeogSet : Set
    {
        internal GeogSet(IntPtr ptr) : base(ptr) { }

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.GeogsetIn(str));

    }
}
