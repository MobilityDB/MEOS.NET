#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The Npoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Npoint : Value
    {
        internal Npoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public string AsEWKT(int maxdd)
            => Meos.NpointAsEwkt(this.Ptr, maxdd);

        public string AsHEXWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.NpointAsHexwkb(this.Ptr, variant, _size_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

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

        public int Cmp(Npoint np2)
            => Meos.NpointCmp(this.Ptr, np2.Ptr);

        public bool Eq(Npoint np2)
            => Meos.NpointEq(this.Ptr, np2.Ptr);

        public bool Ge(Npoint np2)
            => Meos.NpointGe(this.Ptr, np2.Ptr);

        public bool Gt(Npoint np2)
            => Meos.NpointGt(this.Ptr, np2.Ptr);

        public uint Hash()
            => Meos.NpointHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.NpointHashExtended(this.Ptr, seed);

        public bool Le(Npoint np2)
            => Meos.NpointLe(this.Ptr, np2.Ptr);

        public bool Lt(Npoint np2)
            => Meos.NpointLt(this.Ptr, np2.Ptr);

        public bool Ne(Npoint np2)
            => Meos.NpointNe(this.Ptr, np2.Ptr);

        public string Out(int maxdd)
            => Meos.NpointOut(this.Ptr, maxdd);

        public double Position()
            => Meos.NpointPosition(this.Ptr);

        public Npoint? Round(int maxdd)
            => MEOSFactory.WrapNpoint(Meos.NpointRound(this.Ptr, maxdd));

        public long Route()
            => Meos.NpointRoute(this.Ptr);

        public int SRID()
            => Meos.NpointSrid(this.Ptr);

        public bool Same(Npoint np2)
            => Meos.NpointSame(this.Ptr, np2.Ptr);

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.NpointTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Geo? ToGeompoint()
            => MEOSFactory.WrapGeo(Meos.NpointToGeompoint(this.Ptr));

        public Nsegment? ToNsegment()
            => MEOSFactory.WrapNsegment(Meos.NpointToNsegment(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.NpointToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.NpointToStbox(this.Ptr));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.NpointTstzspanToStbox(this.Ptr, s.Ptr));

        public static Npoint? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapNpoint(Meos.NpointFromHexwkb(hexwkb));

        public static Npoint? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapNpoint(Meos.NpointFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static Npoint? In(string str)
            => MEOSFactory.WrapNpoint(Meos.NpointIn(str));

        public static Npoint? Make(long rid, double pos)
            => MEOSFactory.WrapNpoint(Meos.NpointMake(rid, pos));

    }
}
