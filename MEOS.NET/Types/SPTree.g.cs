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

        public int Join(SPTree sptree2, string op, MeosArray result)
            => Meos.SptreeJoin(this.Ptr, sptree2.Ptr, Meos.IndexsearchopFromString(op), result.Ptr);

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

        public int Search(string op, IntPtr query, MeosArray result)
            => Meos.SptreeSearch(this.Ptr, Meos.IndexsearchopFromString(op), query, result.Ptr);

        public int SearchTemporal(string op, Temporal temp, MeosArray result)
            => Meos.SptreeSearchTemporal(this.Ptr, Meos.IndexsearchopFromString(op), temp.Ptr, result.Ptr);

        public int SearchTemporalDedup(string op, Temporal temp, int maxboxes, MeosArray result)
            => Meos.SptreeSearchTemporalDedup(this.Ptr, Meos.IndexsearchopFromString(op), temp.Ptr, maxboxes, result.Ptr);

        public static SPTree? CreateBigintspan(string kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateBigintspan(Meos.SptreekindFromString(kind)));

        public static SPTree? CreateDatespan(string kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateDatespan(Meos.SptreekindFromString(kind)));

        public static SPTree? CreateFloatspan(string kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateFloatspan(Meos.SptreekindFromString(kind)));

        public static SPTree? CreateIntspan(string kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateIntspan(Meos.SptreekindFromString(kind)));

        public static SPTree? CreateStbox(string kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateStbox(Meos.SptreekindFromString(kind)));

        public static SPTree? CreateTbox(string kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateTbox(Meos.SptreekindFromString(kind)));

        public static SPTree? CreateTpcbox(string kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateTpcbox(Meos.SptreekindFromString(kind)));

        public static SPTree? CreateTstzspan(string kind)
            => MEOSFactory.WrapSPTree(Meos.SptreeCreateTstzspan(Meos.SptreekindFromString(kind)));

    }
}
