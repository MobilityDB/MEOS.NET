#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The Cbuffer class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Cbuffer : Value
    {
        internal Cbuffer(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int Acontains(TCbuffer temp)
            => Meos.AcontainsCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Acovers(TCbuffer temp)
            => Meos.AcoversCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Adisjoint(TCbuffer temp)
            => Meos.AdisjointCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Adwithin(TCbuffer temp, double dist)
            => Meos.AdwithinCbufferTcbuffer(this.Ptr, temp.Ptr, dist);

        public int Aintersects(TCbuffer temp)
            => Meos.AintersectsCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int AlwaysEq(TCbuffer temp)
            => Meos.AlwaysEqCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int AlwaysNe(TCbuffer temp)
            => Meos.AlwaysNeCbufferTcbuffer(this.Ptr, temp.Ptr);

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.CbufferAsEwkb(this.Ptr, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public string AsEWKT(int maxdd)
            => Meos.CbufferAsEwkt(this.Ptr, maxdd);

        public string AsHexEWKB(byte variant)
            => Meos.CbufferAsHexewkb(this.Ptr, variant);

        public string AsHexWKB(byte variant)
            => Meos.CbufferAsHexwkb(this.Ptr, variant);

        public string AsText(int maxdd)
            => Meos.CbufferAsText(this.Ptr, maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.CbufferAsWkb(this.Ptr, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public int Atouches(TCbuffer temp)
            => Meos.AtouchesCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Cmp(Cbuffer cb2)
            => Meos.CbufferCmp(this.Ptr, cb2.Ptr);

        public bool Contained(CbufferSet s)
            => Meos.ContainedCbufferSet(this.Ptr, s.Ptr);

        public int Contains(Cbuffer cb2)
            => Meos.ContainsCbufferCbuffer(this.Ptr, cb2.Ptr);

        public Cbuffer? Copy()
            => MEOSFactory.WrapCbuffer(Meos.CbufferCopy(this.Ptr));

        public int Covers(Cbuffer cb2)
            => Meos.CoversCbufferCbuffer(this.Ptr, cb2.Ptr);

        public int Disjoint(Cbuffer cb2)
            => Meos.DisjointCbufferCbuffer(this.Ptr, cb2.Ptr);

        public double Distance(Cbuffer cb2)
            => Meos.DistanceCbufferCbuffer(this.Ptr, cb2.Ptr);

        public double Distance(Geometry gs)
            => Meos.DistanceCbufferGeo(this.Ptr, gs.Ptr);

        public double Distance(STBox box)
            => Meos.DistanceCbufferStbox(this.Ptr, box.Ptr);

        public int Dwithin(Cbuffer cb2, double dist)
            => Meos.DwithinCbufferCbuffer(this.Ptr, cb2.Ptr, dist);

        public int Econtains(TCbuffer temp)
            => Meos.EcontainsCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Ecovers(TCbuffer temp)
            => Meos.EcoversCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Edisjoint(TCbuffer temp)
            => Meos.EdisjointCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Edwithin(TCbuffer temp, double dist)
            => Meos.EdwithinCbufferTcbuffer(this.Ptr, temp.Ptr, dist);

        public int Eintersects(TCbuffer temp)
            => Meos.EintersectsCbufferTcbuffer(this.Ptr, temp.Ptr);

        public bool Eq(Cbuffer cb2)
            => Meos.CbufferEq(this.Ptr, cb2.Ptr);

        public int Etouches(TCbuffer temp)
            => Meos.EtouchesCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int EverEq(TCbuffer temp)
            => Meos.EverEqCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int EverNe(TCbuffer temp)
            => Meos.EverNeCbufferTcbuffer(this.Ptr, temp.Ptr);

        public bool Ge(Cbuffer cb2)
            => Meos.CbufferGe(this.Ptr, cb2.Ptr);

        public bool Gt(Cbuffer cb2)
            => Meos.CbufferGt(this.Ptr, cb2.Ptr);

        public uint Hash()
            => Meos.CbufferHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.CbufferHashExtended(this.Ptr, seed);

        public Set? Intersection(CbufferSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionCbufferSet(this.Ptr, s.Ptr));

        public int Intersects(Cbuffer cb2)
            => Meos.IntersectsCbufferCbuffer(this.Ptr, cb2.Ptr);

        public bool Le(Cbuffer cb2)
            => Meos.CbufferLe(this.Ptr, cb2.Ptr);

        public bool Lt(Cbuffer cb2)
            => Meos.CbufferLt(this.Ptr, cb2.Ptr);

        public int MemSize()
            => Meos.CbufferMemSize(this.Ptr);

        public Set? Minus(CbufferSet s)
            => MEOSFactory.WrapSet(Meos.MinusCbufferSet(this.Ptr, s.Ptr));

        public double Nad(STBox box)
            => Meos.NadCbufferStbox(this.Ptr, box.Ptr);

        public bool Ne(Cbuffer cb2)
            => Meos.CbufferNe(this.Ptr, cb2.Ptr);

        public string Out(int maxdd)
            => Meos.CbufferOut(this.Ptr, maxdd);

        public Geo? Point()
            => MEOSFactory.WrapGeo(Meos.CbufferPoint(this.Ptr));

        public double Radius()
            => Meos.CbufferRadius(this.Ptr);

        public Cbuffer? Round(int maxdd)
            => MEOSFactory.WrapCbuffer(Meos.CbufferRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.CbufferSrid(this.Ptr);

        public Cbuffer? SetSRID(int srid)
            => MEOSFactory.WrapCbuffer(Meos.CbufferSetSrid(this.Ptr, srid));

        public Temporal? Tcontains(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TcontainsCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tcovers(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TcoversCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tdisjoint(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TdisjointCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tdwithin(TCbuffer temp, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinCbufferTcbuffer(this.Ptr, temp.Ptr, dist));

        public Temporal? Teq(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TeqCbufferTcbuffer(this.Ptr, temp.Ptr));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.CbufferTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Temporal? Tintersects(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TintersectsCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tne(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TneCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.CbufferToGeom(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.CbufferToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.CbufferToStbox(this.Ptr));

        public int Touches(Cbuffer cb2)
            => Meos.TouchesCbufferCbuffer(this.Ptr, cb2.Ptr);

        public Cbuffer? Transform(int srid)
            => MEOSFactory.WrapCbuffer(Meos.CbufferTransform(this.Ptr, srid));

        public Cbuffer? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapCbuffer(Meos.CbufferTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.CbufferTstzspanToStbox(this.Ptr, s.Ptr));

        public Temporal? Ttouches(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TtouchesCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Set? Union(CbufferSet s)
            => MEOSFactory.WrapSet(Meos.UnionCbufferSet(this.Ptr, s.Ptr));

        public static Cbuffer? FromEWKB(byte[] wkb)
            => Cbuffer.FromWKB(wkb);

        public static Cbuffer? FromEWKT(string str)
            => Cbuffer.In(str);

        public static Cbuffer? FromHexEWKB(string hexwkb)
            => Cbuffer.FromHexWKB(hexwkb);

        public static Cbuffer? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapCbuffer(Meos.CbufferFromHexwkb(hexwkb));

        public static Cbuffer? FromText(string str)
            => Cbuffer.In(str);

        public static Cbuffer? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapCbuffer(Meos.CbufferFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static Cbuffer? In(string str)
            => MEOSFactory.WrapCbuffer(Meos.CbufferIn(str));

        public static Cbuffer? Make(Geo point, double radius)
            => MEOSFactory.WrapCbuffer(Meos.CbufferMake(point.Ptr, radius));

    }
}
