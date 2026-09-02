#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The Pcpatch class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Pcpatch : Value
    {
        internal Pcpatch(IntPtr ptr) : base(ptr) { }

        public string AsHEXWKB()
            => Meos.PcpatchAsHexwkb(this.Ptr);

        public int Cmp(Pcpatch pa2)
            => Meos.PcpatchCmp(this.Ptr, pa2.Ptr);

        public Pcpatch? Copy()
            => MEOSFactory.WrapPcpatch(Meos.PcpatchCopy(this.Ptr));

        public uint GetPcid()
            => Meos.PcpatchGetPcid(this.Ptr);

        public uint Hash()
            => Meos.PcpatchHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PcpatchHashExtended(this.Ptr, seed);

        public string HexOut(int maxdd)
            => Meos.PcpatchHexOut(this.Ptr, maxdd);

        public uint Npoints()
            => Meos.PcpatchNpoints(this.Ptr);

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.PcpatchToGeom(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.PcpatchToSet(this.Ptr));

        public TPCBox? ToTpcbox(int srid)
            => MEOSFactory.WrapTPCBox(Meos.PcpatchToTpcbox(this.Ptr, srid));

        public static Pcpatch? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapPcpatch(Meos.PcpatchFromHexwkb(hexwkb));

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

    }
}
