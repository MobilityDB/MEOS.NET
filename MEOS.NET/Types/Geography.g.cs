#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The Geography class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Geography : Geo
    {
        internal Geography(IntPtr ptr) : base(ptr) { }

        public double Area(bool use_spheroid)
            => Meos.GeogArea(this.Ptr, use_spheroid);

        public Geo? Centroid(bool use_spheroid)
            => MEOSFactory.WrapGeo(Meos.GeogCentroid(this.Ptr, use_spheroid));

        public double Distance(Geo g2)
            => Meos.GeogDistance(this.Ptr, g2.Ptr);

        public bool Dwithin(Geo g2, double tolerance, bool use_spheroid)
            => Meos.GeogDwithin(this.Ptr, g2.Ptr, tolerance, use_spheroid);

        public double Length(bool use_spheroid)
            => Meos.GeogLength(this.Ptr, use_spheroid);

        public double Perimeter(bool use_spheroid)
            => Meos.GeogPerimeter(this.Ptr, use_spheroid);

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.GeogToGeom(this.Ptr));

        public static Geo? ArrayUnion(Geo[] gsarr)
        {
            IntPtr[] _gsarrValues = new IntPtr[gsarr.Length];
            for (int i = 0; i < gsarr.Length; i++)
            {
                _gsarrValues[i] = gsarr[i].Ptr;
            }

            GCHandle _gsarr = GCHandle.Alloc(_gsarrValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapGeo(Meos.GeogArrayUnion(_gsarr.AddrOfPinnedObject(), gsarr.Length));
            }
            finally
            {
                _gsarr.Free();
            }
        }

        public static Geo? FromHexewkb(string wkt)
            => MEOSFactory.WrapGeo(Meos.GeogFromHexewkb(wkt));

        public static Geo? In(string str, int typmod)
            => MEOSFactory.WrapGeo(Meos.GeogIn(str, typmod));

    }
}
