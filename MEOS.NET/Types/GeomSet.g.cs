#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The GeomSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class GeomSet : GeoSet
    {
        internal GeomSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Contained(GeomSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(GeomSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public bool Contains(Geometry gs)
            => Meos.ContainsSetGeo(this.Ptr, gs.Ptr);

        public double Distance(GeomSet s2, bool spheroid)
            => Meos.DistanceGeosetGeoset(this.Ptr, s2.Ptr, spheroid);

        public double Distance(Geometry gs, bool spheroid)
            => Meos.DistanceSetGeo(this.Ptr, gs.Ptr, spheroid);

        public Set? Intersection(GeomSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Intersection(Geometry gs)
            => MEOSFactory.WrapSet(Meos.IntersectionSetGeo(this.Ptr, gs.Ptr));

        public Set? Minus(GeomSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(Geometry gs)
            => MEOSFactory.WrapSet(Meos.MinusSetGeo(this.Ptr, gs.Ptr));

        public bool Overlaps(GeomSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public Set? ToGeogset()
            => MEOSFactory.WrapSet(Meos.GeomsetToGeogset(this.Ptr));

        public Set? Union(GeomSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public Set? Union(Geometry gs)
            => MEOSFactory.WrapSet(Meos.UnionSetGeo(this.Ptr, gs.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => GeomSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => GeomSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.GeomsetIn(str));

    }
}
