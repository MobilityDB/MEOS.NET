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

        public string AsHEXWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.SpansetAsHexwkb(this.Ptr, variant, _size_out);
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

        public bool Le(SpanSet ss2)
            => Meos.SpansetLe(this.Ptr, ss2.Ptr);

        public bool LowerInc()
            => Meos.SpansetLowerInc(this.Ptr);

        public bool Lt(SpanSet ss2)
            => Meos.SpansetLt(this.Ptr, ss2.Ptr);

        public bool Ne(SpanSet ss2)
            => Meos.SpansetNe(this.Ptr, ss2.Ptr);

        public int NumSpans()
            => Meos.SpansetNumSpans(this.Ptr);

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

        public bool UpperInc()
            => Meos.SpansetUpperInc(this.Ptr);

        public static SpanSet? FromHEXWKB(string hexwkb)
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

        public static SpanSet? Make(Span spans, int count)
            => MEOSFactory.WrapSpanSet(Meos.SpansetMake(spans.Ptr, count));

    }
}
