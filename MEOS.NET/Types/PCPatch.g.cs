#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The PCPatch class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PCPatch : Value
    {
        internal PCPatch(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int AlwaysEq(TPCPatch temp)
            => Meos.AlwaysEqPcpatchTpcpatch(this.Ptr, temp.Ptr);

        public int AlwaysNe(TPCPatch temp)
            => Meos.AlwaysNePcpatchTpcpatch(this.Ptr, temp.Ptr);

        public string AsHexWKB()
            => Meos.PcpatchAsHexwkb(this.Ptr);

        public string AsText(int maxdd)
            => Meos.PcpatchHexOut(this.Ptr, maxdd);

        public int Cmp(PCPatch pa2)
            => Meos.PcpatchCmp(this.Ptr, pa2.Ptr);

        public bool Contained(PCPatchSet s)
            => Meos.ContainedPcpatchSet(this.Ptr, s.Ptr);

        public PCPatch? Copy()
            => MEOSFactory.WrapPCPatch(Meos.PcpatchCopy(this.Ptr));

        public bool Eq(PCPatch pa2)
            => Meos.PcpatchEq(this.Ptr, pa2.Ptr);

        public int EverEq(TPCPatch temp)
            => Meos.EverEqPcpatchTpcpatch(this.Ptr, temp.Ptr);

        public int EverNe(TPCPatch temp)
            => Meos.EverNePcpatchTpcpatch(this.Ptr, temp.Ptr);

        public bool Ge(PCPatch pa2)
            => Meos.PcpatchGe(this.Ptr, pa2.Ptr);

        public uint GetPcid()
            => Meos.PcpatchGetPcid(this.Ptr);

        public bool Gt(PCPatch pa2)
            => Meos.PcpatchGt(this.Ptr, pa2.Ptr);

        public uint Hash()
            => Meos.PcpatchHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PcpatchHashExtended(this.Ptr, seed);

        public Set? Intersection(PCPatchSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionPcpatchSet(this.Ptr, s.Ptr));

        public bool Le(PCPatch pa2)
            => Meos.PcpatchLe(this.Ptr, pa2.Ptr);

        public bool Lt(PCPatch pa2)
            => Meos.PcpatchLt(this.Ptr, pa2.Ptr);

        public int MemSize()
            => Meos.PcpatchMemSize(this.Ptr);

        public Set? Minus(PCPatchSet s)
            => MEOSFactory.WrapSet(Meos.MinusPcpatchSet(this.Ptr, s.Ptr));

        public bool Ne(PCPatch pa2)
            => Meos.PcpatchNe(this.Ptr, pa2.Ptr);

        public uint Npoints()
            => Meos.PcpatchNpoints(this.Ptr);

        public PCPoint? PointN(int n)
            => MEOSFactory.WrapPCPoint(Meos.PcpatchPointN(this.Ptr, n));

        public PCPoint?[] Points()
            => MEOSFactory.WrapPCPointArray(Meos.PcpatchPoints(this.Ptr));

        public Temporal? Teq(TPCPatch temp)
            => MEOSFactory.WrapTemporal(Meos.TeqPcpatchTpcpatch(this.Ptr, temp.Ptr));

        public Temporal? Tne(TPCPatch temp)
            => MEOSFactory.WrapTemporal(Meos.TnePcpatchTpcpatch(this.Ptr, temp.Ptr));

        public Geo? ToGeog()
            => MEOSFactory.WrapGeo(Meos.PcpatchToGeog(this.Ptr));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.PcpatchToGeom(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.PcpatchToSet(this.Ptr));

        public TPCBox? ToTpcbox()
            => MEOSFactory.WrapTPCBox(Meos.PcpatchToTpcbox(this.Ptr));

        public Set? Union(PCPatchSet s)
            => MEOSFactory.WrapSet(Meos.UnionPcpatchSet(this.Ptr, s.Ptr));

        public static PCPatch? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapPCPatch(Meos.PcpatchFromHexwkb(hexwkb));

        public static PCPatch? FromText(string str)
            => MEOSFactory.WrapPCPatch(Meos.PcpatchHexIn(str));

        public static PCPatch? Make(PCPoint[] points)
        {
            IntPtr[] _pointsValues = new IntPtr[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                _pointsValues[i] = points[i].Ptr;
            }

            GCHandle _points = GCHandle.Alloc(_pointsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPCPatch(Meos.PcpatchMake(_points.AddrOfPinnedObject(), points.Length));
            }
            finally
            {
                _points.Free();
            }
        }

        public static PCPatch? MakeCoords(uint pcid, double[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPCPatch(Meos.PcpatchMakeCoords(pcid, _values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
