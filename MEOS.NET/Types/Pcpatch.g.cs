#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The Pcpatch class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Pcpatch : Value
    {
        internal Pcpatch(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.HexOut(15);

        public string AsHexWKB()
            => Meos.PcpatchAsHexwkb(this.Ptr);

        public string AsText(int maxdd)
            => this.HexOut(maxdd);

        public int Cmp(Pcpatch pa2)
            => Meos.PcpatchCmp(this.Ptr, pa2.Ptr);

        public Pcpatch? Copy()
            => MEOSFactory.WrapPcpatch(Meos.PcpatchCopy(this.Ptr));

        public bool Eq(Pcpatch pa2)
            => Meos.PcpatchEq(this.Ptr, pa2.Ptr);

        public bool Ge(Pcpatch pa2)
            => Meos.PcpatchGe(this.Ptr, pa2.Ptr);

        public uint GetPcid()
            => Meos.PcpatchGetPcid(this.Ptr);

        public bool Gt(Pcpatch pa2)
            => Meos.PcpatchGt(this.Ptr, pa2.Ptr);

        public uint Hash()
            => Meos.PcpatchHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PcpatchHashExtended(this.Ptr, seed);

        public string HexOut(int maxdd)
            => Meos.PcpatchHexOut(this.Ptr, maxdd);

        public bool Le(Pcpatch pa2)
            => Meos.PcpatchLe(this.Ptr, pa2.Ptr);

        public bool Lt(Pcpatch pa2)
            => Meos.PcpatchLt(this.Ptr, pa2.Ptr);

        public int MemSize()
            => Meos.PcpatchMemSize(this.Ptr);

        public bool Ne(Pcpatch pa2)
            => Meos.PcpatchNe(this.Ptr, pa2.Ptr);

        public uint Npoints()
            => Meos.PcpatchNpoints(this.Ptr);

        public Pcpoint? PointN(int n)
            => MEOSFactory.WrapPcpoint(Meos.PcpatchPointN(this.Ptr, n));

        public Pcpoint?[] Points()
            => MEOSFactory.WrapPcpointArray(Meos.PcpatchPoints(this.Ptr));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.PcpatchToGeom(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.PcpatchToSet(this.Ptr));

        public TPCBox? ToTpcbox()
            => MEOSFactory.WrapTPCBox(Meos.PcpatchToTpcbox(this.Ptr));

        public static Pcpatch? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapPcpatch(Meos.PcpatchFromHexwkb(hexwkb));

        public static Pcpatch? FromText(string str)
            => Pcpatch.HexIn(str);

        public static Pcpatch? HexIn(string str)
            => MEOSFactory.WrapPcpatch(Meos.PcpatchHexIn(str));

        public static Pcpatch? Make(Pcpoint[] points)
        {
            IntPtr[] _pointsValues = new IntPtr[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                _pointsValues[i] = points[i].Ptr;
            }

            GCHandle _points = GCHandle.Alloc(_pointsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPcpatch(Meos.PcpatchMake(_points.AddrOfPinnedObject(), points.Length));
            }
            finally
            {
                _points.Free();
            }
        }

        public static Pcpatch? MakeCoords(uint pcid, double[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPcpatch(Meos.PcpatchMakeCoords(pcid, _values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
