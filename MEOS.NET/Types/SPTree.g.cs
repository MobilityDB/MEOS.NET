#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>MEOS's in-memory SP-tree, the R-tree's sibling over the same key types. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class SPTree : Value
    {
        internal SPTree(IntPtr ptr) : base(ptr) { }

        public void Free()
            => Meos.SptreeFree(this.Ptr);

        public int Height()
            => Meos.SptreeHeight(this.Ptr);

        public bool Insert(IntPtr box, long id)
            => Meos.SptreeInsert(this.Ptr, box, id);

        public bool InsertTemporal(Temporal temp, long id)
            => Meos.SptreeInsertTemporal(this.Ptr, temp.Ptr, id);

        public bool InsertTemporalSplit(Temporal temp, long id, int maxboxes)
            => Meos.SptreeInsertTemporalSplit(this.Ptr, temp.Ptr, id, maxboxes);

        public int Join(SPTree sptree2, IndexSearchOp op, MeosArray result)
            => Meos.SptreeJoin(this.Ptr, sptree2.Ptr, (int) op, result.Ptr);

        public bool Load(IntPtr boxes, long[] ids)
        {
            GCHandle _ids = GCHandle.Alloc(ids, GCHandleType.Pinned);
            try
            {
                return Meos.SptreeLoad(this.Ptr, boxes, _ids.AddrOfPinnedObject(), ids.Length);
            }
            finally
            {
                _ids.Free();
            }
        }

        public long MemSize()
            => Meos.SptreeMemSize(this.Ptr);

        public int NumEntries()
            => Meos.SptreeNumEntries(this.Ptr);

        public int Search(IndexSearchOp op, IntPtr query, MeosArray result)
            => Meos.SptreeSearch(this.Ptr, (int) op, query, result.Ptr);

        public int SearchTemporal(IndexSearchOp op, Temporal temp, MeosArray result)
            => Meos.SptreeSearchTemporal(this.Ptr, (int) op, temp.Ptr, result.Ptr);

        public static SPTree? CreateBigintspan(SPTreeKind kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateBigintspan((int) kind));

        public static SPTree? CreateDatespan(SPTreeKind kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateDatespan((int) kind));

        public static SPTree? CreateFloatspan(SPTreeKind kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateFloatspan((int) kind));

        public static SPTree? CreateIntspan(SPTreeKind kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateIntspan((int) kind));

        public static SPTree? CreateStbox(SPTreeKind kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateStbox((int) kind));

        public static SPTree? CreateTbox(SPTreeKind kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateTbox((int) kind));

        public static SPTree? CreateTpcbox(SPTreeKind kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateTpcbox((int) kind));

        public static SPTree? CreateTstzspan(SPTreeKind kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateTstzspan((int) kind));

    }
}
