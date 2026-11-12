#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The NPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class NPoint : Value
    {
        internal NPoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int AlwaysEq(TNPoint temp)
            => Meos.AlwaysEqNpointTnpoint(this.Ptr, temp.Ptr);

        public int AlwaysNe(TNPoint temp)
            => Meos.AlwaysNeNpointTnpoint(this.Ptr, temp.Ptr);

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.NpointAsEwkb(this.Ptr, variant, _size_out);
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
            => Meos.NpointAsEwkt(this.Ptr, maxdd);

        public string AsHexEWKB(byte variant)
            => Meos.NpointAsHexewkb(this.Ptr, variant);

        public string AsHexWKB(byte variant)
            => Meos.NpointAsHexwkb(this.Ptr, variant);

        public string AsText(int maxdd)
            => Meos.NpointAsText(this.Ptr, maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.NpointAsWkb(this.Ptr, variant, _size_out);
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

        public int Cmp(NPoint np2)
            => Meos.NpointCmp(this.Ptr, np2.Ptr);

        public bool Contained(NPointSet s)
            => Meos.ContainedNpointSet(this.Ptr, s.Ptr);

        public bool ContainedRid(TNPoint temp)
            => Meos.ContainedRidNpointTnpoint(this.Ptr, temp.Ptr);

        public NPoint? Copy()
            => MEOSFactory.WrapNPoint(Meos.NpointCopy(this.Ptr));

        public bool Eq(NPoint np2)
            => Meos.NpointEq(this.Ptr, np2.Ptr);

        public int EverEq(TNPoint temp)
            => Meos.EverEqNpointTnpoint(this.Ptr, temp.Ptr);

        public int EverNe(TNPoint temp)
            => Meos.EverNeNpointTnpoint(this.Ptr, temp.Ptr);

        public bool Ge(NPoint np2)
            => Meos.NpointGe(this.Ptr, np2.Ptr);

        public bool Gt(NPoint np2)
            => Meos.NpointGt(this.Ptr, np2.Ptr);

        public uint Hash()
            => Meos.NpointHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.NpointHashExtended(this.Ptr, seed);

        public Set? Intersection(NPointSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionNpointSet(this.Ptr, s.Ptr));

        public bool Le(NPoint np2)
            => Meos.NpointLe(this.Ptr, np2.Ptr);

        public bool Lt(NPoint np2)
            => Meos.NpointLt(this.Ptr, np2.Ptr);

        public Set? Minus(NPointSet s)
            => MEOSFactory.WrapSet(Meos.MinusNpointSet(this.Ptr, s.Ptr));

        public bool Ne(NPoint np2)
            => Meos.NpointNe(this.Ptr, np2.Ptr);

        public double Position()
            => Meos.NpointPosition(this.Ptr);

        public NPoint? Round(int maxdd)
            => MEOSFactory.WrapNPoint(Meos.NpointRound(this.Ptr, maxdd));

        public long Route()
            => Meos.NpointRoute(this.Ptr);

        public int SRID()
            => Meos.NpointSrid(this.Ptr);

        public bool SameRid(TNPoint temp)
            => Meos.SameRidNpointTnpoint(this.Ptr, temp.Ptr);

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.NpointTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Geo? ToGeog()
            => MEOSFactory.WrapGeo(Meos.NpointToGeog(this.Ptr));

        public Geo? ToGeompoint()
            => MEOSFactory.WrapGeo(Meos.NpointToGeompoint(this.Ptr));

        public NSegment? ToNsegment()
            => MEOSFactory.WrapNSegment(Meos.NpointToNsegment(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.NpointToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.NpointToStbox(this.Ptr));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.NpointTstzspanToStbox(this.Ptr, s.Ptr));

        public Set? Union(NPointSet s)
            => MEOSFactory.WrapSet(Meos.UnionNpointSet(this.Ptr, s.Ptr));

        public static NPoint? FromEWKB(byte[] wkb)
            => NPoint.FromWKB(wkb);

        public static NPoint? FromEWKT(string str)
            => NPoint.FromText(str);

        public static NPoint? FromGeompoint(Geo gs, double tolerance)
            => MEOSFactory.WrapNPoint(Meos.GeompointToNpoint(gs.Ptr, tolerance));

        public static NPoint? FromHexEWKB(string hexwkb)
            => NPoint.FromHexWKB(hexwkb);

        public static NPoint? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapNPoint(Meos.NpointFromHexwkb(hexwkb));

        public static NPoint? FromText(string str)
            => MEOSFactory.WrapNPoint(Meos.NpointIn(str));

        public static NPoint? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapNPoint(Meos.NpointFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static NPoint? Make(long rid, double pos)
            => MEOSFactory.WrapNPoint(Meos.NpointMake(rid, pos));

    }
}
