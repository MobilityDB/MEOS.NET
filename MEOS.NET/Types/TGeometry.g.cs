#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TGeometry class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeometry : TGeo
    {
        internal TGeometry(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int Acontains(Geometry gs)
            => Meos.AcontainsTgeoGeo(this.Ptr, gs.Ptr);

        public int Acontains(TGeometry temp2)
            => Meos.AcontainsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Acovers(Geometry gs)
            => Meos.AcoversTgeoGeo(this.Ptr, gs.Ptr);

        public int Acovers(TGeometry temp2)
            => Meos.AcoversTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Atouches(Geometry gs)
            => Meos.AtouchesTgeoGeo(this.Ptr, gs.Ptr);

        public int Atouches(TGeometry temp2)
            => Meos.AtouchesTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Econtains(Geometry gs)
            => Meos.EcontainsTgeoGeo(this.Ptr, gs.Ptr);

        public int Econtains(TGeometry temp2)
            => Meos.EcontainsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Ecovers(Geometry gs)
            => Meos.EcoversTgeoGeo(this.Ptr, gs.Ptr);

        public int Ecovers(TGeometry temp2)
            => Meos.EcoversTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Etouches(Geometry gs)
            => Meos.EtouchesTgeoGeo(this.Ptr, gs.Ptr);

        public int Etouches(TGeometry temp2)
            => Meos.EtouchesTgeoTgeo(this.Ptr, temp2.Ptr);

        public Temporal? Tcontains(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tcontains(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tcovers(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TcoversTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tcovers(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TcoversTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? ToTcbuffer()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTcbuffer(this.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTgeography(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTgeompoint(this.Ptr));

        public Temporal? Ttouches(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTgeoTgeo(this.Ptr, temp2.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TGeometry.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeometryFromMfjson(str));

        public static Temporal? FromText(string str)
            => TGeometry.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeometryIn(str));

    }
}
