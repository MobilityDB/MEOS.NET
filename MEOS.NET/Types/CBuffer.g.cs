#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The CBuffer class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class CBuffer : Value
    {
        internal CBuffer(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int Acontains(TCBuffer temp)
            => Meos.AcontainsCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Acovers(TCBuffer temp)
            => Meos.AcoversCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Adisjoint(TCBuffer temp)
            => Meos.AdisjointCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Adwithin(TCBuffer temp, double dist)
            => Meos.AdwithinCbufferTcbuffer(this.Ptr, temp.Ptr, dist);

        public int Aintersects(TCBuffer temp)
            => Meos.AintersectsCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int AlwaysEq(TCBuffer temp)
            => Meos.AlwaysEqCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int AlwaysNe(TCBuffer temp)
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

        public int Atouches(TCBuffer temp)
            => Meos.AtouchesCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Cmp(CBuffer cb2)
            => Meos.CbufferCmp(this.Ptr, cb2.Ptr);

        public bool Contained(CBufferSet s)
            => Meos.ContainedCbufferSet(this.Ptr, s.Ptr);

        public int Contains(CBuffer cb2)
            => Meos.ContainsCbufferCbuffer(this.Ptr, cb2.Ptr);

        public CBuffer? Copy()
            => MEOSFactory.WrapCBuffer(Meos.CbufferCopy(this.Ptr));

        public int Covers(CBuffer cb2)
            => Meos.CoversCbufferCbuffer(this.Ptr, cb2.Ptr);

        public int Disjoint(CBuffer cb2)
            => Meos.DisjointCbufferCbuffer(this.Ptr, cb2.Ptr);

        public double Distance(CBuffer cb2)
            => Meos.DistanceCbufferCbuffer(this.Ptr, cb2.Ptr);

        public double Distance(Geometry gs)
            => Meos.DistanceCbufferGeo(this.Ptr, gs.Ptr);

        public double Distance(STBox box)
            => Meos.DistanceCbufferStbox(this.Ptr, box.Ptr);

        public int Dwithin(CBuffer cb2, double dist)
            => Meos.DwithinCbufferCbuffer(this.Ptr, cb2.Ptr, dist);

        public int Econtains(TCBuffer temp)
            => Meos.EcontainsCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Ecovers(TCBuffer temp)
            => Meos.EcoversCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Edisjoint(TCBuffer temp)
            => Meos.EdisjointCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int Edwithin(TCBuffer temp, double dist)
            => Meos.EdwithinCbufferTcbuffer(this.Ptr, temp.Ptr, dist);

        public int Eintersects(TCBuffer temp)
            => Meos.EintersectsCbufferTcbuffer(this.Ptr, temp.Ptr);

        public bool Eq(CBuffer cb2)
            => Meos.CbufferEq(this.Ptr, cb2.Ptr);

        public int Etouches(TCBuffer temp)
            => Meos.EtouchesCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int EverEq(TCBuffer temp)
            => Meos.EverEqCbufferTcbuffer(this.Ptr, temp.Ptr);

        public int EverNe(TCBuffer temp)
            => Meos.EverNeCbufferTcbuffer(this.Ptr, temp.Ptr);

        public bool Ge(CBuffer cb2)
            => Meos.CbufferGe(this.Ptr, cb2.Ptr);

        public bool Gt(CBuffer cb2)
            => Meos.CbufferGt(this.Ptr, cb2.Ptr);

        public uint Hash()
            => Meos.CbufferHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.CbufferHashExtended(this.Ptr, seed);

        public Set? Intersection(CBufferSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionCbufferSet(this.Ptr, s.Ptr));

        public int Intersects(CBuffer cb2)
            => Meos.IntersectsCbufferCbuffer(this.Ptr, cb2.Ptr);

        public bool Le(CBuffer cb2)
            => Meos.CbufferLe(this.Ptr, cb2.Ptr);

        public bool Lt(CBuffer cb2)
            => Meos.CbufferLt(this.Ptr, cb2.Ptr);

        public int MemSize()
            => Meos.CbufferMemSize(this.Ptr);

        public Set? Minus(CBufferSet s)
            => MEOSFactory.WrapSet(Meos.MinusCbufferSet(this.Ptr, s.Ptr));

        public double Nad(STBox box)
            => Meos.NadCbufferStbox(this.Ptr, box.Ptr);

        public bool Ne(CBuffer cb2)
            => Meos.CbufferNe(this.Ptr, cb2.Ptr);

        public Geo? Point()
            => MEOSFactory.WrapGeo(Meos.CbufferPoint(this.Ptr));

        public double Radius()
            => Meos.CbufferRadius(this.Ptr);

        public CBuffer? Round(int maxdd)
            => MEOSFactory.WrapCBuffer(Meos.CbufferRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.CbufferSrid(this.Ptr);

        public CBuffer? SetSRID(int srid)
            => MEOSFactory.WrapCBuffer(Meos.CbufferSetSrid(this.Ptr, srid));

        public Temporal? Tcontains(TCBuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TcontainsCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tcovers(TCBuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TcoversCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tdisjoint(TCBuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TdisjointCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tdwithin(TCBuffer temp, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinCbufferTcbuffer(this.Ptr, temp.Ptr, dist));

        public Temporal? Teq(TCBuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TeqCbufferTcbuffer(this.Ptr, temp.Ptr));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.CbufferTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Temporal? Tintersects(TCBuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TintersectsCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tne(TCBuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TneCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Geo? ToGeog()
            => MEOSFactory.WrapGeo(Meos.CbufferToGeog(this.Ptr));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.CbufferToGeom(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.CbufferToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.CbufferToStbox(this.Ptr));

        public int Touches(CBuffer cb2)
            => Meos.TouchesCbufferCbuffer(this.Ptr, cb2.Ptr);

        public CBuffer? Transform(int srid)
            => MEOSFactory.WrapCBuffer(Meos.CbufferTransform(this.Ptr, srid));

        public CBuffer? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapCBuffer(Meos.CbufferTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.CbufferTstzspanToStbox(this.Ptr, s.Ptr));

        public Temporal? Ttouches(TCBuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TtouchesCbufferTcbuffer(this.Ptr, temp.Ptr));

        public Set? Union(CBufferSet s)
            => MEOSFactory.WrapSet(Meos.UnionCbufferSet(this.Ptr, s.Ptr));

        public static CBuffer? FromEWKB(byte[] wkb)
            => CBuffer.FromWKB(wkb);

        public static CBuffer? FromEWKT(string str)
            => CBuffer.FromText(str);

        public static CBuffer? FromHexEWKB(string hexwkb)
            => CBuffer.FromHexWKB(hexwkb);

        public static CBuffer? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapCBuffer(Meos.CbufferFromHexwkb(hexwkb));

        public static CBuffer? FromText(string str)
            => MEOSFactory.WrapCBuffer(Meos.CbufferIn(str));

        public static CBuffer? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapCBuffer(Meos.CbufferFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static CBuffer? Make(Geo point, double radius)
            => MEOSFactory.WrapCBuffer(Meos.CbufferMake(point.Ptr, radius));

    }
}
