#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>MEOS's in-memory R-tree over spans, boxes and their kin. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class RTree : Value
    {
        internal RTree(IntPtr ptr) : base(ptr) { }

        public void Free()
            => Meos.RtreeFree(this.Ptr);

        public int Height()
            => Meos.RtreeHeight(this.Ptr);

        public bool InsertTemporal(Temporal temp, long id)
            => Meos.RtreeInsertTemporal(this.Ptr, temp.Ptr, id);

        public bool InsertTemporalSplit(Temporal temp, long id, int maxboxes)
            => Meos.RtreeInsertTemporalSplit(this.Ptr, temp.Ptr, id, maxboxes);

        public int Join(RTree rtree2, IndexSearchOp op, MeosArray result)
            => Meos.RtreeJoin(this.Ptr, rtree2.Ptr, (int) op, result.Ptr);

        public long MemSize()
            => Meos.RtreeMemSize(this.Ptr);

        public int NumEntries()
            => Meos.RtreeNumEntries(this.Ptr);

        public int SearchTemporal(IndexSearchOp op, Temporal temp, MeosArray result)
            => Meos.RtreeSearchTemporal(this.Ptr, (int) op, temp.Ptr, result.Ptr);

        public static RTree? CreateBigintspan()
            => MEOSFactory.WrapRTree(Meos.RtreeCreateBigintspan());

        public static RTree? CreateDatespan()
            => MEOSFactory.WrapRTree(Meos.RtreeCreateDatespan());

        public static RTree? CreateFloatspan()
            => MEOSFactory.WrapRTree(Meos.RtreeCreateFloatspan());

        public static RTree? CreateIntspan()
            => MEOSFactory.WrapRTree(Meos.RtreeCreateIntspan());

        public static RTree? CreateStbox()
            => MEOSFactory.WrapRTree(Meos.RtreeCreateStbox());

        public static RTree? CreateTbox()
            => MEOSFactory.WrapRTree(Meos.RtreeCreateTbox());

        public static RTree? CreateTpcbox()
            => MEOSFactory.WrapRTree(Meos.RtreeCreateTpcbox());

        public static RTree? CreateTstzspan()
            => MEOSFactory.WrapRTree(Meos.RtreeCreateTstzspan());

    }
}
