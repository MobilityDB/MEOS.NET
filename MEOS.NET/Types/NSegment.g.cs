#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A segment of a network route. A MeosType no membership predicate admits, so the coverage gate does not demand it; the 20 signatures naming it do.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class NSegment : Value
    {
        internal NSegment(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.NsegmentAsEwkb(this.Ptr, variant, _size_out);
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
            => Meos.NsegmentAsEwkt(this.Ptr, maxdd);

        public string AsHexEWKB(byte variant)
            => Meos.NsegmentAsHexewkb(this.Ptr, variant);

        public string AsHexWKB(byte variant)
            => Meos.NsegmentAsHexwkb(this.Ptr, variant);

        public string AsText(int maxdd)
            => Meos.NsegmentAsText(this.Ptr, maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.NsegmentAsWkb(this.Ptr, variant, _size_out);
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

        public int Cmp(NSegment ns2)
            => Meos.NsegmentCmp(this.Ptr, ns2.Ptr);

        public NSegment? Copy()
            => MEOSFactory.WrapNSegment(Meos.NsegmentCopy(this.Ptr));

        public double EndPosition()
            => Meos.NsegmentEndPosition(this.Ptr);

        public bool Eq(NSegment ns2)
            => Meos.NsegmentEq(this.Ptr, ns2.Ptr);

        public bool Ge(NSegment ns2)
            => Meos.NsegmentGe(this.Ptr, ns2.Ptr);

        public bool Gt(NSegment ns2)
            => Meos.NsegmentGt(this.Ptr, ns2.Ptr);

        public bool Le(NSegment ns2)
            => Meos.NsegmentLe(this.Ptr, ns2.Ptr);

        public bool Lt(NSegment ns2)
            => Meos.NsegmentLt(this.Ptr, ns2.Ptr);

        public bool Ne(NSegment ns2)
            => Meos.NsegmentNe(this.Ptr, ns2.Ptr);

        public NSegment? Round(int maxdd)
            => MEOSFactory.WrapNSegment(Meos.NsegmentRound(this.Ptr, maxdd));

        public long Route()
            => Meos.NsegmentRoute(this.Ptr);

        public int SRID()
            => Meos.NsegmentSrid(this.Ptr);

        public double StartPosition()
            => Meos.NsegmentStartPosition(this.Ptr);

        public Geo? ToGeog()
            => MEOSFactory.WrapGeo(Meos.NsegmentToGeog(this.Ptr));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.NsegmentToGeom(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.NsegmentToStbox(this.Ptr));

        public static NSegment? FromEWKB(byte[] wkb)
            => NSegment.FromWKB(wkb);

        public static NSegment? FromEWKT(string str)
            => NSegment.FromText(str);

        public static NSegment? FromHexEWKB(string hexwkb)
            => NSegment.FromHexWKB(hexwkb);

        public static NSegment? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapNSegment(Meos.NsegmentFromHexwkb(hexwkb));

        public static NSegment? FromText(string str)
            => MEOSFactory.WrapNSegment(Meos.NsegmentIn(str));

        public static NSegment? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapNSegment(Meos.NsegmentFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static NSegment? Make(long rid, double pos1, double pos2)
            => MEOSFactory.WrapNSegment(Meos.NsegmentMake(rid, pos1, pos2));

    }
}
