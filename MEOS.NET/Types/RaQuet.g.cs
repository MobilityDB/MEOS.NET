#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A raster tile. A MeosType no membership predicate admits, as NSegment is.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class RaQuet : Value
    {
        internal RaQuet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public string AsHexWKB(byte variant)
            => Meos.RaquetAsHexwkb(this.Ptr, variant);

        public string AsText()
            => this.Out();

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

        public bool BandHasNodataValue()
            => Meos.RaquetBandHasNodataValue(this.Ptr);

        public double? BandNodataValue()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.RaquetBandNodataValue(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public string BandPixelType()
            => Meos.RaquetBandPixelType(this.Ptr);

        public int Cmp(RaQuet rq2)
            => Meos.RaquetCmp(this.Ptr, rq2.Ptr);

        public RaQuet? Copy()
            => MEOSFactory.WrapRaQuet(Meos.RaquetCopy(this.Ptr));

        public bool Eq(RaQuet rq2)
            => Meos.RaquetEq(this.Ptr, rq2.Ptr);

        public bool Ge(RaQuet rq2)
            => Meos.RaquetGe(this.Ptr, rq2.Ptr);

        public bool Gt(RaQuet rq2)
            => Meos.RaquetGt(this.Ptr, rq2.Ptr);

        public uint Hash()
            => Meos.RaquetHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.RaquetHashExtended(this.Ptr, seed);

        public int Height()
            => Meos.RaquetHeight(this.Ptr);

        public bool Le(RaQuet rq2)
            => Meos.RaquetLe(this.Ptr, rq2.Ptr);

        public bool Lt(RaQuet rq2)
            => Meos.RaquetLt(this.Ptr, rq2.Ptr);

        public int MemSize()
            => Meos.RaquetMemSize(this.Ptr);

        public bool Ne(RaQuet rq2)
            => Meos.RaquetNe(this.Ptr, rq2.Ptr);

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

        public ulong Quadbin()
            => Meos.RaquetQuadbin(this.Ptr);

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.RaquetToStbox(this.Ptr));

        public int Width()
            => Meos.RaquetWidth(this.Ptr);

        public static RaQuet? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapRaQuet(Meos.RaquetFromHexwkb(hexwkb));

        public static RaQuet? FromText(string str)
            => RaQuet.In(str);

        public static RaQuet? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaQuet(Meos.RaquetFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static RaQuet? In(string str)
            => MEOSFactory.WrapRaQuet(Meos.RaquetIn(str));

        public static RaQuet? Make(ulong quadbin, int width, int height, string pixtype, double nodata, bool has_nodata, byte[] pixels)
        {
            GCHandle _pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaQuet(Meos.RaquetMake(quadbin, width, height, Meos.MeospixtypeFromString(pixtype), nodata, has_nodata, _pixels.AddrOfPinnedObject(), (ulong) pixels.Length));
            }
            finally
            {
                _pixels.Free();
            }
        }

        public static ulong PixtypeSize(string pixtype)
            => Meos.RaquetPixtypeSize(Meos.MeospixtypeFromString(pixtype));

        public static RaQuet? Read(string path, ulong quadbin)
            => MEOSFactory.WrapRaQuet(Meos.RaquetRead(path, quadbin));

        public static RaQuet? ReadBytes(byte[] data, ulong quadbin)
        {
            GCHandle _data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaQuet(Meos.RaquetReadBytes(_data.AddrOfPinnedObject(), (ulong) data.Length, quadbin));
            }
            finally
            {
                _data.Free();
            }
        }

    }
}
