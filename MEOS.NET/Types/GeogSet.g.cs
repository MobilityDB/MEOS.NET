#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The GeogSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class GeogSet : GeoSet
    {
        internal GeogSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Contained(GeogSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(GeogSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public bool Contains(Geography gs)
            => Meos.ContainsSetGeo(this.Ptr, gs.Ptr);

        public double Distance(GeogSet s2, bool spheroid)
            => Meos.DistanceGeosetGeoset(this.Ptr, s2.Ptr, spheroid);

        public double Distance(Geography gs, bool spheroid)
            => Meos.DistanceSetGeo(this.Ptr, gs.Ptr, spheroid);

        public Set? Intersection(GeogSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Intersection(Geography gs)
            => MEOSFactory.WrapSet(Meos.IntersectionSetGeo(this.Ptr, gs.Ptr));

        public Set? Minus(GeogSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(Geography gs)
            => MEOSFactory.WrapSet(Meos.MinusSetGeo(this.Ptr, gs.Ptr));

        public bool Overlaps(GeogSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public Set? Union(GeogSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public Set? Union(Geography gs)
            => MEOSFactory.WrapSet(Meos.UnionSetGeo(this.Ptr, gs.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => GeogSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => GeogSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.GeogsetIn(str));

    }
}
