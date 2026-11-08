#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Set of disjoint spans.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class SpanSet : Collection
    {
        internal SpanSet(IntPtr ptr) : base(ptr) { }

        public bool Adjacent(Span s)
            => Meos.AdjacentSpansetSpan(this.Ptr, s.Ptr);

        public bool Adjacent(SpanSet ss2)
            => Meos.AdjacentSpansetSpanset(this.Ptr, ss2.Ptr);

        public string AsHexWKB(byte variant)
            => Meos.SpansetAsHexwkb(this.Ptr, variant);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.SpansetAsWkb(this.Ptr, variant, _size_out);
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

        public int Cmp(SpanSet ss2)
            => Meos.SpansetCmp(this.Ptr, ss2.Ptr);

        public bool Contained(Span s)
            => Meos.ContainedSpansetSpan(this.Ptr, s.Ptr);

        public bool Contained(SpanSet ss2)
            => Meos.ContainedSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Contains(Span s)
            => Meos.ContainsSpansetSpan(this.Ptr, s.Ptr);

        public bool Contains(SpanSet ss2)
            => Meos.ContainsSpansetSpanset(this.Ptr, ss2.Ptr);

        public SpanSet? Copy()
            => MEOSFactory.WrapSpanSet(Meos.SpansetCopy(this.Ptr));

        public Span? EndSpan()
            => MEOSFactory.WrapSpan(Meos.SpansetEndSpan(this.Ptr));

        public bool Eq(SpanSet ss2)
            => Meos.SpansetEq(this.Ptr, ss2.Ptr);

        public bool Ge(SpanSet ss2)
            => Meos.SpansetGe(this.Ptr, ss2.Ptr);

        public bool Gt(SpanSet ss2)
            => Meos.SpansetGt(this.Ptr, ss2.Ptr);

        public uint Hash()
            => Meos.SpansetHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.SpansetHashExtended(this.Ptr, seed);

        public SpanSet? Intersection(Span s)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Intersection(SpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Le(SpanSet ss2)
            => Meos.SpansetLe(this.Ptr, ss2.Ptr);

        public bool Left(Span s)
            => Meos.LeftSpansetSpan(this.Ptr, s.Ptr);

        public bool Left(SpanSet ss2)
            => Meos.LeftSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool LowerInc()
            => Meos.SpansetLowerInc(this.Ptr);

        public bool Lt(SpanSet ss2)
            => Meos.SpansetLt(this.Ptr, ss2.Ptr);

        public int MemSize()
            => Meos.SpansetMemSize(this.Ptr);

        public SpanSet? Minus(Span s)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Minus(SpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Ne(SpanSet ss2)
            => Meos.SpansetNe(this.Ptr, ss2.Ptr);

        public int NumSpans()
            => Meos.SpansetNumSpans(this.Ptr);

        public bool Overlaps(Span s)
            => Meos.OverlapsSpansetSpan(this.Ptr, s.Ptr);

        public bool Overlaps(SpanSet ss2)
            => Meos.OverlapsSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overleft(Span s)
            => Meos.OverleftSpansetSpan(this.Ptr, s.Ptr);

        public bool Overleft(SpanSet ss2)
            => Meos.OverleftSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overright(Span s)
            => Meos.OverrightSpansetSpan(this.Ptr, s.Ptr);

        public bool Overright(SpanSet ss2)
            => Meos.OverrightSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Right(Span s)
            => Meos.RightSpansetSpan(this.Ptr, s.Ptr);

        public bool Right(SpanSet ss2)
            => Meos.RightSpansetSpanset(this.Ptr, ss2.Ptr);

        public byte[]? Sortkey()
        {
            IntPtr _size = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.SpansetSortkey(this.Ptr, _size);
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

        public Span? Span()
            => MEOSFactory.WrapSpan(Meos.SpansetSpan(this.Ptr));

        public Span? SpanN(int i)
            => MEOSFactory.WrapSpan(Meos.SpansetSpanN(this.Ptr, i));

        public Span?[] Spanarr()
            => MEOSFactory.WrapSpanArray(Meos.SpansetSpanarr(this.Ptr));

        public Span?[] Spans()
            => MEOSFactory.WrapSpanArray(Meos.SpansetSpans(this.Ptr));

        public Span?[] SplitEachNSpans(int elems_per_span)
            => MEOSFactory.WrapSpanArray(Meos.SpansetSplitEachNSpans(this.Ptr, elems_per_span));

        public Span?[] SplitNSpans(int span_count)
            => MEOSFactory.WrapSpanArray(Meos.SpansetSplitNSpans(this.Ptr, span_count));

        public Span? StartSpan()
            => MEOSFactory.WrapSpan(Meos.SpansetStartSpan(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(Meos.SpansetToTbox(this.Ptr));

        public SpanSet? Union(Span s)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Union(SpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool UpperInc()
            => Meos.SpansetUpperInc(this.Ptr);

        public static SpanSet? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapSpanSet(Meos.SpansetFromHexwkb(hexwkb));

        public static SpanSet? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSpanSet(Meos.SpansetFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static SpanSet? Make(Span[] spans)
        {
            IntPtr _spans = Marshal.AllocHGlobal(24 * Math.Max(spans.Length, 1));
            byte[] _spansValue = new byte[24];
            for (int i = 0; i < spans.Length; i++)
            {
                Marshal.Copy(spans[i].Ptr, _spansValue, 0, 24);
                Marshal.Copy(_spansValue, 0, IntPtr.Add(_spans, i * 24), 24);
            }

            try
            {
                return MEOSFactory.WrapSpanSet(Meos.SpansetMake(_spans, spans.Length));
            }
            finally
            {
                Marshal.FreeHGlobal(_spans);
            }
        }

    }
}
