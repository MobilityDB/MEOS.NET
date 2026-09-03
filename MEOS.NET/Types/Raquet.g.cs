#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A raster tile. A MeosType no membership predicate admits, as Nsegment is.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Raquet : Value
    {
        internal Raquet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public string AsHEXWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.RaquetAsHexwkb(this.Ptr, variant, _size_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.RaquetAsWkb(this.Ptr, variant, _size_out);
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

        public int Cmp(Raquet rq2)
            => Meos.RaquetCmp(this.Ptr, rq2.Ptr);

        public Raquet? Copy()
            => MEOSFactory.WrapRaquet(Meos.RaquetCopy(this.Ptr));

        public bool Eq(Raquet rq2)
            => Meos.RaquetEq(this.Ptr, rq2.Ptr);

        public bool Ge(Raquet rq2)
            => Meos.RaquetGe(this.Ptr, rq2.Ptr);

        public bool Gt(Raquet rq2)
            => Meos.RaquetGt(this.Ptr, rq2.Ptr);

        public uint Hash()
            => Meos.RaquetHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.RaquetHashExtended(this.Ptr, seed);

        public int Height()
            => Meos.RaquetHeight(this.Ptr);

        public bool Le(Raquet rq2)
            => Meos.RaquetLe(this.Ptr, rq2.Ptr);

        public bool Lt(Raquet rq2)
            => Meos.RaquetLt(this.Ptr, rq2.Ptr);

        public bool Ne(Raquet rq2)
            => Meos.RaquetNe(this.Ptr, rq2.Ptr);

        public double Nodata()
            => Meos.RaquetNodata(this.Ptr);

        public string Out()
            => Meos.RaquetOut(this.Ptr);

        public byte[]? Pixels()
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.RaquetPixels(this.Ptr, _size_out);
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

        public string Pixtype()
            => Meos.RaquetPixtype(this.Ptr);

        public ulong Quadbin()
            => Meos.RaquetQuadbin(this.Ptr);

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.RaquetToStbox(this.Ptr));

        public int Width()
            => Meos.RaquetWidth(this.Ptr);

        public static Raquet? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapRaquet(Meos.RaquetFromHexwkb(hexwkb));

        public static Raquet? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaquet(Meos.RaquetFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static Raquet? In(string str)
            => MEOSFactory.WrapRaquet(Meos.RaquetIn(str));

        public static Raquet? Read(string path, ulong quadbin)
            => MEOSFactory.WrapRaquet(Meos.RaquetRead(path, quadbin));

        public static Raquet? ReadBytes(byte[] data, ulong quadbin)
        {
            GCHandle _data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaquet(Meos.RaquetReadBytes(_data.AddrOfPinnedObject(), (ulong) data.Length, quadbin));
            }
            finally
            {
                _data.Free();
            }
        }

    }
}
