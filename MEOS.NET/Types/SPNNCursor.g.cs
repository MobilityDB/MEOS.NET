#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The SP-tree's nearest-neighbour walk, the R-tree cursor's sibling. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class SPNNCursor : Value
    {
        internal SPNNCursor(IntPtr ptr) : base(ptr) { }

        public void Close()
            => Meos.SptreeNnCursorClose(this.Ptr);

        public static SPNNCursor? Open(SPTree sptree, IntPtr query)
            => MEOSFactory.WrapSPNNCursor(Meos.SptreeNnCursorOpen(sptree.Ptr, query));

    }
}
