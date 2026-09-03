#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A walk over an R-tree's entries in order of distance from a query. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class RTreeNNCursor : Value
    {
        internal RTreeNNCursor(IntPtr ptr) : base(ptr) { }

        public void Close()
            => Meos.RtreeNnCursorClose(this.Ptr);

        public static RTreeNNCursor? Open(RTree rtree, IntPtr query)
            => MEOSFactory.WrapRTreeNNCursor(Meos.RtreeNnCursorOpen(rtree.Ptr, query));

    }
}
