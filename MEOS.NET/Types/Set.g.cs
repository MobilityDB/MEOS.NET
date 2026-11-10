#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Unordered set of base values.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Set : Collection
    {
        internal Set(IntPtr ptr) : base(ptr) { }

        public string AsHexWKB(byte variant)
            => Meos.SetAsHexwkb(this.Ptr, variant);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.SetAsWkb(this.Ptr, variant, _size_out);
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

        public int Cmp(Set s2)
            => Meos.SetCmp(this.Ptr, s2.Ptr);

        public bool Contained(Set s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(Set s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public Set? Copy()
            => MEOSFactory.WrapSet(Meos.SetCopy(this.Ptr));

        public bool Eq(Set s2)
            => Meos.SetEq(this.Ptr, s2.Ptr);

        public bool Ge(Set s2)
            => Meos.SetGe(this.Ptr, s2.Ptr);

        public bool Gt(Set s2)
            => Meos.SetGt(this.Ptr, s2.Ptr);

        public uint Hash()
            => Meos.SetHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.SetHashExtended(this.Ptr, seed);

        public Set? Intersection(Set s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public bool Le(Set s2)
            => Meos.SetLe(this.Ptr, s2.Ptr);

        public bool Left(Set s2)
            => Meos.LeftSetSet(this.Ptr, s2.Ptr);

        public bool Lt(Set s2)
            => Meos.SetLt(this.Ptr, s2.Ptr);

        public int MemSize()
            => Meos.SetMemSize(this.Ptr);

        public Set? Minus(Set s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public bool Ne(Set s2)
            => Meos.SetNe(this.Ptr, s2.Ptr);

        public int NumValues()
            => Meos.SetNumValues(this.Ptr);

        public string Out(int maxdd)
            => Meos.SetOut(this.Ptr, maxdd);

        public bool Overlaps(Set s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Overleft(Set s2)
            => Meos.OverleftSetSet(this.Ptr, s2.Ptr);

        public bool Overright(Set s2)
            => Meos.OverrightSetSet(this.Ptr, s2.Ptr);

        public bool Right(Set s2)
            => Meos.RightSetSet(this.Ptr, s2.Ptr);

        public Set? Round(int maxdd)
            => MEOSFactory.WrapSet(Meos.SetRound(this.Ptr, maxdd));

        public byte[]? Sortkey()
        {
            IntPtr _size = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.SetSortkey(this.Ptr, _size);
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

        public Span?[] Spans()
            => MEOSFactory.WrapSpanArray(Meos.SetSpans(this.Ptr));

        public Span?[] SplitEachNSpans(int elems_per_span)
            => MEOSFactory.WrapSpanArray(Meos.SetSplitEachNSpans(this.Ptr, elems_per_span));

        public Span?[] SplitNSpans(int span_count)
            => MEOSFactory.WrapSpanArray(Meos.SetSplitNSpans(this.Ptr, span_count));

        public Span? ToSpan()
            => MEOSFactory.WrapSpan(Meos.SetToSpan(this.Ptr));

        public SpanSet? ToSpanset()
            => MEOSFactory.WrapSpanSet(Meos.SetToSpanset(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(Meos.SetToTbox(this.Ptr));

        public Set? Union(Set s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public static Set? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapSet(Meos.SetFromHexwkb(hexwkb));

        public static Set? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.SetFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

    }
}
