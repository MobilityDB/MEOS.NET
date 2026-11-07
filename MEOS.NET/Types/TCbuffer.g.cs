#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TCbuffer class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCbuffer : TSpatial
    {
        internal TCbuffer(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Above(TCbuffer temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Acontains(Cbuffer cb)
            => Meos.AcontainsTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Acontains(Geometry gs)
            => Meos.AcontainsTcbufferGeo(this.Ptr, gs.Ptr);

        public int Acontains(TCbuffer temp2)
            => Meos.AcontainsTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Acovers(Cbuffer cb)
            => Meos.AcoversTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Acovers(Geometry gs)
            => Meos.AcoversTcbufferGeo(this.Ptr, gs.Ptr);

        public int Acovers(TCbuffer temp2)
            => Meos.AcoversTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Adisjoint(Geometry gs)
            => Meos.AdisjointTcbufferGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(Cbuffer cb)
            => Meos.AdisjointTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Adisjoint(TCbuffer temp2)
            => Meos.AdisjointTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public bool Adjacent(TCbuffer temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Adwithin(Geometry gs, double dist)
            => Meos.AdwithinTcbufferGeo(this.Ptr, gs.Ptr, dist);

        public int Adwithin(Cbuffer cb, double dist)
            => Meos.AdwithinTcbufferCbuffer(this.Ptr, cb.Ptr, dist);

        public int Adwithin(TCbuffer temp2, double dist)
            => Meos.AdwithinTcbufferTcbuffer(this.Ptr, temp2.Ptr, dist);

        public bool After(TCbuffer temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Aintersects(Geometry gs)
            => Meos.AintersectsTcbufferGeo(this.Ptr, gs.Ptr);

        public int Aintersects(Cbuffer cb)
            => Meos.AintersectsTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Aintersects(TCbuffer temp2)
            => Meos.AintersectsTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Cbuffer cb)
            => Meos.AlwaysEqTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int AlwaysEq(TCbuffer temp2)
            => Meos.AlwaysEqTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Cbuffer cb)
            => Meos.AlwaysNeTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int AlwaysNe(TCbuffer temp2)
            => Meos.AlwaysNeTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public Temporal? AtCbuffer(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtCbuffer(this.Ptr, cb.Ptr));

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtStbox(this.Ptr, box.Ptr, border_inc));

        public int Atouches(Geometry gs)
            => Meos.AtouchesTcbufferGeo(this.Ptr, gs.Ptr);

        public int Atouches(Cbuffer cb)
            => Meos.AtouchesTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Atouches(TCbuffer temp2)
            => Meos.AtouchesTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public bool Before(TCbuffer temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(TCbuffer temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contained(TCbuffer temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TCbuffer temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? ConvexHull()
            => MEOSFactory.WrapGeo(Meos.TcbufferConvexHull(this.Ptr));

        public int Econtains(Cbuffer cb)
            => Meos.EcontainsTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Econtains(Geometry gs)
            => Meos.EcontainsTcbufferGeo(this.Ptr, gs.Ptr);

        public int Econtains(TCbuffer temp2)
            => Meos.EcontainsTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Ecovers(Cbuffer cb)
            => Meos.EcoversTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Ecovers(Geometry gs)
            => Meos.EcoversTcbufferGeo(this.Ptr, gs.Ptr);

        public int Ecovers(TCbuffer temp2)
            => Meos.EcoversTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Edisjoint(Geometry gs)
            => Meos.EdisjointTcbufferGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(Cbuffer cb)
            => Meos.EdisjointTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Edisjoint(TCbuffer temp2)
            => Meos.EdisjointTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Edwithin(Geometry gs, double dist)
            => Meos.EdwithinTcbufferGeo(this.Ptr, gs.Ptr, dist);

        public int Edwithin(Cbuffer cb, double dist)
            => Meos.EdwithinTcbufferCbuffer(this.Ptr, cb.Ptr, dist);

        public int Edwithin(TCbuffer temp2, double dist)
            => Meos.EdwithinTcbufferTcbuffer(this.Ptr, temp2.Ptr, dist);

        public int Eintersects(Geometry gs)
            => Meos.EintersectsTcbufferGeo(this.Ptr, gs.Ptr);

        public int Eintersects(Cbuffer cb)
            => Meos.EintersectsTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Eintersects(TCbuffer temp2)
            => Meos.EintersectsTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public Cbuffer? EndValue()
            => MEOSFactory.WrapCbuffer(Meos.TcbufferEndValue(this.Ptr));

        public int Etouches(Geometry gs)
            => Meos.EtouchesTcbufferGeo(this.Ptr, gs.Ptr);

        public int Etouches(Cbuffer cb)
            => Meos.EtouchesTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Etouches(TCbuffer temp2)
            => Meos.EtouchesTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int EverEq(Cbuffer cb)
            => Meos.EverEqTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int EverEq(TCbuffer temp2)
            => Meos.EverEqTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int EverNe(Cbuffer cb)
            => Meos.EverNeTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int EverNe(TCbuffer temp2)
            => Meos.EverNeTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public Temporal? Expand(double dist)
            => MEOSFactory.WrapTemporal(Meos.TcbufferExpand(this.Ptr, dist));

        public bool Left(TCbuffer temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Make(Temporal tfloat)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMake(this.Ptr, tfloat.Ptr));

        public double Mindistance(TCbuffer temp2, double threshold)
            => Meos.MindistanceTcbufferTcbuffer(this.Ptr, temp2.Ptr, threshold);

        public Temporal? MinusCbuffer(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusCbuffer(this.Ptr, cb.Ptr));

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusGeom(this.Ptr, gs.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusStbox(this.Ptr, box.Ptr, border_inc));

        public double Nad(Cbuffer cb)
            => Meos.NadTcbufferCbuffer(this.Ptr, cb.Ptr);

        public double Nad(Geometry gs)
            => Meos.NadTcbufferGeo(this.Ptr, gs.Ptr);

        public double Nad(STBox box)
            => Meos.NadTcbufferStbox(this.Ptr, box.Ptr);

        public double Nad(TCbuffer temp2)
            => Meos.NadTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public Temporal? Nai(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.NaiTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Nai(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.NaiTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Nai(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.NaiTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public bool Overabove(TCbuffer temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TCbuffer temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TCbuffer temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TCbuffer temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TCbuffer temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TCbuffer temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TCbuffer temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TcbufferPoints(this.Ptr));

        public Set? Radius()
            => MEOSFactory.WrapSet(Meos.TcbufferRadius(this.Ptr));

        public bool Right(TCbuffer temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Rotate(double angle, double x0, double y0)
            => MEOSFactory.WrapTemporal(Meos.TcbufferRotate(this.Ptr, angle, x0, y0));

        public Temporal? RotateZ(double angle)
            => MEOSFactory.WrapTemporal(Meos.TcbufferRotateZ(this.Ptr, angle));

        public bool Same(TCbuffer temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? Shortestline(Cbuffer cb)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Geo? Shortestline(Geometry gs)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTcbufferGeo(this.Ptr, gs.Ptr));

        public Geo? Shortestline(TCbuffer temp2)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Cbuffer? StartValue()
            => MEOSFactory.WrapCbuffer(Meos.TcbufferStartValue(this.Ptr));

        public Temporal? Tcontains(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tcontains(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tcontains(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tcovers(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TcoversTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tcovers(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcoversTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tcovers(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TcoversTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tdisjoint(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdisjoint(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tdisjoint(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tdistance(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdistance(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tdwithin(Geometry gs, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTcbufferGeo(this.Ptr, gs.Ptr, dist));

        public Temporal? Tdwithin(Cbuffer cb, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTcbufferCbuffer(this.Ptr, cb.Ptr, dist));

        public Temporal? Tdwithin(TCbuffer temp2, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTcbufferTcbuffer(this.Ptr, temp2.Ptr, dist));

        public Temporal? Teq(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TeqTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Teq(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tintersects(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tintersects(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TneTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tne(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTfloat(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTgeompoint(this.Ptr));

        public Temporal? Translate(double deltax, double deltay)
            => MEOSFactory.WrapTemporal(Meos.TcbufferTranslate(this.Ptr, deltax, deltay));

        public Geo? TraversedArea(bool unary_union)
            => MEOSFactory.WrapGeo(Meos.TcbufferTraversedArea(this.Ptr, unary_union));

        public Temporal? Ttouches(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Ttouches(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Ttouches(TCbuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public (SpanSet?[], Cbuffer?[]) Unnest()
        {
            var _answered = Meos.TcbufferUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapCbufferArray(_answered.Item2));
        }

        public Cbuffer? Value()
            => MEOSFactory.WrapCbuffer(Meos.TcbufferValue(this.Ptr));

        public Cbuffer? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TcbufferValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapCbuffer(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Cbuffer? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TcbufferValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapCbuffer(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Cbuffer?[] Values()
            => MEOSFactory.WrapCbufferArray(Meos.TcbufferValues(this.Ptr));

        public static Temporal? FromBaseTemp(Cbuffer cb, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TcbufferFromBaseTemp(cb.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TCbuffer.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TcbufferFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TCbuffer.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TcbufferIn(str));

    }
}
