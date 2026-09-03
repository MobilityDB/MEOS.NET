#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Contiguous range over an ordered base type.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Span : Collection
    {
        internal Span(IntPtr ptr) : base(ptr) { }

        public string AsHEXWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.SpanAsHexwkb(this.Ptr, variant, _size_out);
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
                IntPtr _bytes = Meos.SpanAsWkb(this.Ptr, variant, _size_out);
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

        public int Cmp(Span s2)
            => Meos.SpanCmp(this.Ptr, s2.Ptr);

        public Span? Copy()
            => MEOSFactory.WrapSpan(Meos.SpanCopy(this.Ptr));

        public bool Eq(Span s2)
            => Meos.SpanEq(this.Ptr, s2.Ptr);

        public bool Ge(Span s2)
            => Meos.SpanGe(this.Ptr, s2.Ptr);

        public bool Gt(Span s2)
            => Meos.SpanGt(this.Ptr, s2.Ptr);

        public uint Hash()
            => Meos.SpanHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.SpanHashExtended(this.Ptr, seed);

        public bool Le(Span s2)
            => Meos.SpanLe(this.Ptr, s2.Ptr);

        public bool LowerInc()
            => Meos.SpanLowerInc(this.Ptr);

        public bool Lt(Span s2)
            => Meos.SpanLt(this.Ptr, s2.Ptr);

        public bool Ne(Span s2)
            => Meos.SpanNe(this.Ptr, s2.Ptr);

        public SpanSet? ToSpanset()
            => MEOSFactory.WrapSpanSet(Meos.SpanToSpanset(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(Meos.SpanToTbox(this.Ptr));

        public bool UpperInc()
            => Meos.SpanUpperInc(this.Ptr);

        public static Span? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapSpan(Meos.SpanFromHexwkb(hexwkb));

        public static Span? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSpan(Meos.SpanFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

    }
}
