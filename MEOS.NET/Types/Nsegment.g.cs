#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A segment of a network route. A MeosType no membership predicate admits, so the coverage gate does not demand it; the 20 signatures naming it do.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Nsegment : Value
    {
        internal Nsegment(IntPtr ptr) : base(ptr) { }

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
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.NsegmentAsHexewkb(this.Ptr, variant, _size_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public string AsHexWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.NsegmentAsHexwkb(this.Ptr, variant, _size_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

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

        public int Cmp(Nsegment ns2)
            => Meos.NsegmentCmp(this.Ptr, ns2.Ptr);

        public Nsegment? Copy()
            => MEOSFactory.WrapNsegment(Meos.NsegmentCopy(this.Ptr));

        public double EndPosition()
            => Meos.NsegmentEndPosition(this.Ptr);

        public bool Eq(Nsegment ns2)
            => Meos.NsegmentEq(this.Ptr, ns2.Ptr);

        public bool Ge(Nsegment ns2)
            => Meos.NsegmentGe(this.Ptr, ns2.Ptr);

        public bool Gt(Nsegment ns2)
            => Meos.NsegmentGt(this.Ptr, ns2.Ptr);

        public bool Le(Nsegment ns2)
            => Meos.NsegmentLe(this.Ptr, ns2.Ptr);

        public bool Lt(Nsegment ns2)
            => Meos.NsegmentLt(this.Ptr, ns2.Ptr);

        public bool Ne(Nsegment ns2)
            => Meos.NsegmentNe(this.Ptr, ns2.Ptr);

        public string Out(int maxdd)
            => Meos.NsegmentOut(this.Ptr, maxdd);

        public Nsegment? Round(int maxdd)
            => MEOSFactory.WrapNsegment(Meos.NsegmentRound(this.Ptr, maxdd));

        public long Route()
            => Meos.NsegmentRoute(this.Ptr);

        public int SRID()
            => Meos.NsegmentSrid(this.Ptr);

        public double StartPosition()
            => Meos.NsegmentStartPosition(this.Ptr);

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.NsegmentToGeom(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.NsegmentToStbox(this.Ptr));

        public static Nsegment? FromEWKB(byte[] wkb)
            => Nsegment.FromWKB(wkb);

        public static Nsegment? FromEWKT(string str)
            => Nsegment.In(str);

        public static Nsegment? FromHexEWKB(string hexwkb)
            => Nsegment.FromHexWKB(hexwkb);

        public static Nsegment? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapNsegment(Meos.NsegmentFromHexwkb(hexwkb));

        public static Nsegment? FromText(string str)
            => Nsegment.In(str);

        public static Nsegment? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapNsegment(Meos.NsegmentFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static Nsegment? In(string str)
            => MEOSFactory.WrapNsegment(Meos.NsegmentIn(str));

        public static Nsegment? Make(long rid, double pos1, double pos2)
            => MEOSFactory.WrapNsegment(Meos.NsegmentMake(rid, pos1, pos2));

    }
}
