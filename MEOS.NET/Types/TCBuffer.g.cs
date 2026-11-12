#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TCBuffer class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCBuffer : TSpatial
    {
        internal TCBuffer(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Above(TCBuffer temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Acontains(CBuffer cb)
            => Meos.AcontainsTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Acontains(Geometry gs)
            => Meos.AcontainsTcbufferGeo(this.Ptr, gs.Ptr);

        public int Acontains(TCBuffer temp2)
            => Meos.AcontainsTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Acovers(CBuffer cb)
            => Meos.AcoversTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Acovers(Geometry gs)
            => Meos.AcoversTcbufferGeo(this.Ptr, gs.Ptr);

        public int Acovers(TCBuffer temp2)
            => Meos.AcoversTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Adisjoint(Geometry gs)
            => Meos.AdisjointTcbufferGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(CBuffer cb)
            => Meos.AdisjointTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Adisjoint(TCBuffer temp2)
            => Meos.AdisjointTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public bool Adjacent(TCBuffer temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Adwithin(Geometry gs, double dist)
            => Meos.AdwithinTcbufferGeo(this.Ptr, gs.Ptr, dist);

        public int Adwithin(CBuffer cb, double dist)
            => Meos.AdwithinTcbufferCbuffer(this.Ptr, cb.Ptr, dist);

        public int Adwithin(TCBuffer temp2, double dist)
            => Meos.AdwithinTcbufferTcbuffer(this.Ptr, temp2.Ptr, dist);

        public bool After(TCBuffer temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Aintersects(Geometry gs)
            => Meos.AintersectsTcbufferGeo(this.Ptr, gs.Ptr);

        public int Aintersects(CBuffer cb)
            => Meos.AintersectsTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Aintersects(TCBuffer temp2)
            => Meos.AintersectsTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int AlwaysEq(CBuffer cb)
            => Meos.AlwaysEqTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int AlwaysEq(TCBuffer temp2)
            => Meos.AlwaysEqTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int AlwaysNe(CBuffer cb)
            => Meos.AlwaysNeTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int AlwaysNe(TCBuffer temp2)
            => Meos.AlwaysNeTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int AlwaysOverlaps(STBox box)
            => Meos.AlwaysOverlapsTcbufferStbox(this.Ptr, box.Ptr);

        public Temporal? AtCbuffer(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtCbuffer(this.Ptr, cb.Ptr));

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtStbox(this.Ptr, box.Ptr, border_inc));

        public int Atouches(Geometry gs)
            => Meos.AtouchesTcbufferGeo(this.Ptr, gs.Ptr);

        public int Atouches(CBuffer cb)
            => Meos.AtouchesTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Atouches(TCBuffer temp2)
            => Meos.AtouchesTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public bool Before(TCBuffer temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(TCBuffer temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contained(TCBuffer temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TCBuffer temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? ConvexHull()
            => MEOSFactory.WrapGeo(Meos.TcbufferConvexHull(this.Ptr));

        public int Econtains(CBuffer cb)
            => Meos.EcontainsTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Econtains(Geometry gs)
            => Meos.EcontainsTcbufferGeo(this.Ptr, gs.Ptr);

        public int Econtains(TCBuffer temp2)
            => Meos.EcontainsTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Ecovers(CBuffer cb)
            => Meos.EcoversTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Ecovers(Geometry gs)
            => Meos.EcoversTcbufferGeo(this.Ptr, gs.Ptr);

        public int Ecovers(TCBuffer temp2)
            => Meos.EcoversTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Edisjoint(Geometry gs)
            => Meos.EdisjointTcbufferGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(CBuffer cb)
            => Meos.EdisjointTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Edisjoint(TCBuffer temp2)
            => Meos.EdisjointTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int Edwithin(Geometry gs, double dist)
            => Meos.EdwithinTcbufferGeo(this.Ptr, gs.Ptr, dist);

        public int Edwithin(CBuffer cb, double dist)
            => Meos.EdwithinTcbufferCbuffer(this.Ptr, cb.Ptr, dist);

        public int Edwithin(TCBuffer temp2, double dist)
            => Meos.EdwithinTcbufferTcbuffer(this.Ptr, temp2.Ptr, dist);

        public int Eintersects(Geometry gs)
            => Meos.EintersectsTcbufferGeo(this.Ptr, gs.Ptr);

        public int Eintersects(CBuffer cb)
            => Meos.EintersectsTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Eintersects(TCBuffer temp2)
            => Meos.EintersectsTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public CBuffer? EndValue()
            => MEOSFactory.WrapCBuffer(Meos.TcbufferEndValue(this.Ptr));

        public int Etouches(Geometry gs)
            => Meos.EtouchesTcbufferGeo(this.Ptr, gs.Ptr);

        public int Etouches(CBuffer cb)
            => Meos.EtouchesTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int Etouches(TCBuffer temp2)
            => Meos.EtouchesTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int EverEq(CBuffer cb)
            => Meos.EverEqTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int EverEq(TCBuffer temp2)
            => Meos.EverEqTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int EverNe(CBuffer cb)
            => Meos.EverNeTcbufferCbuffer(this.Ptr, cb.Ptr);

        public int EverNe(TCBuffer temp2)
            => Meos.EverNeTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public int EverOverlaps(STBox box)
            => Meos.EverOverlapsTcbufferStbox(this.Ptr, box.Ptr);

        public Temporal? Expand(double dist)
            => MEOSFactory.WrapTemporal(Meos.TcbufferExpand(this.Ptr, dist));

        public bool Left(TCBuffer temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Make(Temporal tfloat)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMake(this.Ptr, tfloat.Ptr));

        public double Mindistance(TCBuffer temp2, double threshold)
            => Meos.MindistanceTcbufferTcbuffer(this.Ptr, temp2.Ptr, threshold);

        public Temporal? MinusCbuffer(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusCbuffer(this.Ptr, cb.Ptr));

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusGeom(this.Ptr, gs.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusStbox(this.Ptr, box.Ptr, border_inc));

        public double Nad(CBuffer cb)
            => Meos.NadTcbufferCbuffer(this.Ptr, cb.Ptr);

        public double Nad(Geometry gs)
            => Meos.NadTcbufferGeo(this.Ptr, gs.Ptr);

        public double Nad(STBox box)
            => Meos.NadTcbufferStbox(this.Ptr, box.Ptr);

        public double Nad(TCBuffer temp2)
            => Meos.NadTcbufferTcbuffer(this.Ptr, temp2.Ptr);

        public Temporal? Nai(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.NaiTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Nai(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.NaiTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Nai(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.NaiTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public bool Overabove(TCBuffer temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TCBuffer temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TCBuffer temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TCBuffer temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TCBuffer temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TCBuffer temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TCBuffer temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TcbufferPoints(this.Ptr));

        public Set? Radius()
            => MEOSFactory.WrapSet(Meos.TcbufferRadius(this.Ptr));

        public bool Right(TCBuffer temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Rotate(double angle, double x0, double y0)
            => MEOSFactory.WrapTemporal(Meos.TcbufferRotate(this.Ptr, angle, x0, y0));

        public Temporal? RotateZ(double angle)
            => MEOSFactory.WrapTemporal(Meos.TcbufferRotateZ(this.Ptr, angle));

        public bool Same(TCBuffer temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? Shortestline(CBuffer cb)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Geo? Shortestline(Geometry gs)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTcbufferGeo(this.Ptr, gs.Ptr));

        public Geo? Shortestline(TCBuffer temp2)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public CBuffer? StartValue()
            => MEOSFactory.WrapCBuffer(Meos.TcbufferStartValue(this.Ptr));

        public Temporal? Tcontains(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tcontains(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tcontains(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tcovers(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TcoversTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tcovers(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcoversTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tcovers(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TcoversTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tdisjoint(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdisjoint(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tdisjoint(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tdistance(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdistance(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tdwithin(Geometry gs, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTcbufferGeo(this.Ptr, gs.Ptr, dist));

        public Temporal? Tdwithin(CBuffer cb, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTcbufferCbuffer(this.Ptr, cb.Ptr, dist));

        public Temporal? Tdwithin(TCBuffer temp2, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTcbufferTcbuffer(this.Ptr, temp2.Ptr, dist));

        public Temporal? Teq(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TeqTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Teq(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tintersects(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tintersects(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public Temporal? Tne(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TneTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Tne(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTfloat(this.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTgeogpoint(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTgeompoint(this.Ptr));

        public Temporal? Translate(double deltax, double deltay)
            => MEOSFactory.WrapTemporal(Meos.TcbufferTranslate(this.Ptr, deltax, deltay));

        public Geo? TraversedArea(bool unary_union)
            => MEOSFactory.WrapGeo(Meos.TcbufferTraversedArea(this.Ptr, unary_union));

        public Temporal? Ttouches(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTcbufferGeo(this.Ptr, gs.Ptr));

        public Temporal? Ttouches(CBuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTcbufferCbuffer(this.Ptr, cb.Ptr));

        public Temporal? Ttouches(TCBuffer temp2)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTcbufferTcbuffer(this.Ptr, temp2.Ptr));

        public (SpanSet?[], CBuffer?[]) Unnest()
        {
            var _answered = Meos.TcbufferUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapCBufferArray(_answered.Item2));
        }

        public CBuffer? Value()
            => MEOSFactory.WrapCBuffer(Meos.TcbufferValue(this.Ptr));

        public CBuffer? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TcbufferValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapCBuffer(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public CBuffer? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TcbufferValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapCBuffer(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public CBuffer?[] Values()
            => MEOSFactory.WrapCBufferArray(Meos.TcbufferValues(this.Ptr));

        public static Temporal? FromBaseTemp(CBuffer cb, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TcbufferFromBaseTemp(cb.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TCBuffer.FromText(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TcbufferFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => MEOSFactory.WrapTemporal(Meos.TcbufferIn(str));

    }
}
