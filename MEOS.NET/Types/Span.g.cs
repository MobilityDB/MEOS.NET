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

        public bool Adjacent(Span s2)
            => Meos.AdjacentSpanSpan(this.Ptr, s2.Ptr);

        public bool Adjacent(SpanSet ss)
            => Meos.AdjacentSpanSpanset(this.Ptr, ss.Ptr);

        public string AsHexWKB(byte variant)
            => Meos.SpanAsHexwkb(this.Ptr, variant);

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

        public bool Contained(Span s2)
            => Meos.ContainedSpanSpan(this.Ptr, s2.Ptr);

        public bool Contained(SpanSet ss)
            => Meos.ContainedSpanSpanset(this.Ptr, ss.Ptr);

        public bool Contains(Span s2)
            => Meos.ContainsSpanSpan(this.Ptr, s2.Ptr);

        public bool Contains(SpanSet ss)
            => Meos.ContainsSpanSpanset(this.Ptr, ss.Ptr);

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

        public Span? Intersection(Span s2)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Intersection(SpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpanSpanset(this.Ptr, ss.Ptr));

        public bool Le(Span s2)
            => Meos.SpanLe(this.Ptr, s2.Ptr);

        public bool Left(Span s2)
            => Meos.LeftSpanSpan(this.Ptr, s2.Ptr);

        public bool Left(SpanSet ss)
            => Meos.LeftSpanSpanset(this.Ptr, ss.Ptr);

        public bool LowerInc()
            => Meos.SpanLowerInc(this.Ptr);

        public bool Lt(Span s2)
            => Meos.SpanLt(this.Ptr, s2.Ptr);

        public SpanSet? Minus(Span s2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Minus(SpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpanset(this.Ptr, ss.Ptr));

        public bool Ne(Span s2)
            => Meos.SpanNe(this.Ptr, s2.Ptr);

        public bool Overlaps(Span s2)
            => Meos.OverlapsSpanSpan(this.Ptr, s2.Ptr);

        public bool Overlaps(SpanSet ss)
            => Meos.OverlapsSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overleft(Span s2)
            => Meos.OverleftSpanSpan(this.Ptr, s2.Ptr);

        public bool Overleft(SpanSet ss)
            => Meos.OverleftSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overright(Span s2)
            => Meos.OverrightSpanSpan(this.Ptr, s2.Ptr);

        public bool Overright(SpanSet ss)
            => Meos.OverrightSpanSpanset(this.Ptr, ss.Ptr);

        public bool Right(Span s2)
            => Meos.RightSpanSpan(this.Ptr, s2.Ptr);

        public bool Right(SpanSet ss)
            => Meos.RightSpanSpanset(this.Ptr, ss.Ptr);

        public bool Same(Span s2)
            => Meos.SameSpanSpan(this.Ptr, s2.Ptr);

        public byte[]? Sortkey()
        {
            IntPtr _size = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.SpanSortkey(this.Ptr, _size);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size);
            }
        }

        public SpanSet? ToSpanset()
            => MEOSFactory.WrapSpanSet(Meos.SpanToSpanset(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(Meos.SpanToTbox(this.Ptr));

        public SpanSet? Union(Span s2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Union(SpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpanset(this.Ptr, ss.Ptr));

        public bool UpperInc()
            => Meos.SpanUpperInc(this.Ptr);

        public static Span? FromHexWKB(string hexwkb)
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
