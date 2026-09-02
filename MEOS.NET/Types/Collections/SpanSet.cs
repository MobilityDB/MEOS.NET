using MEOS.NET.Helpers;
using MEOS.NET.Functions;
using MEOS.NET.Types.General;

namespace MEOS.NET.Types.Collections
{
    public class SpanSet : MEOSObject
    {
        internal SpanSet(IntPtr ptr) : base(ptr)
        { }

        public static SpanSet FromBytes(byte[] bytes)
        {
            var setPtr = AllocHelper.AllocateArrayPointer<byte, IntPtr>(bytes, (bytesPtr) =>
            {
                return Meos.SpansetFromWkb(bytesPtr, (ulong)bytes.Length);
            });

            return new SpanSet(setPtr);
        }

        public static SpanSet FromHexWKB(string hexWKB)
        {
            var res = Meos.SpansetFromHexwkb(hexWKB);
            return new SpanSet(res);
        }

        public SpanSet Copy()
        {
            var copy = Meos.SpansetCopy(this._ptr);
            return new SpanSet(copy);
        }

        public byte[] ToBytes()
        {
            int arrSize = 0;
            var arr = AllocHelper.AllocatePointer<IntPtr>(sizeof(int), (countPtr) =>
            {
                var res = Meos.SpansetAsWkb(this._ptr, variant: 4, countPtr);
                arrSize = countPtr.ToStructure<int>();

                return res;
            });

            return arr.ToArrayOfType<byte>(arrSize);
        }

        public string ToHexWKB()
        {
            return AllocHelper.AllocatePointer<string>(sizeof(int), (sizePtr) =>
            {
                return Meos.SpansetAsHexwkb(this._ptr, 0, sizePtr);
            });
        }

        public virtual Span ToSpan()
        {
            var res = Meos.SpansetSpan(this._ptr);
            return new Span(res);
        }

        public int SpanCount()
            => Meos.SpansetNumSpans(this._ptr);

        public virtual Span StartSpan()
        {
            var res = Meos.SpansetStartSpan(this._ptr);
            return new Span(res);
        }

        public virtual Span EndSpan()
        {
            var res = Meos.SpansetEndSpan(this._ptr);
            return new Span(res);
        }

        public virtual Span SpanAt(int position)
        {
            var count = this.SpanCount();

            if (position < 0 || position + 1 > count)
            {
                throw new ArgumentOutOfRangeException(nameof(position), $"Requested element must be between 0 and {count - 1}");
            }

            var res = Meos.SpansetSpanN(this._ptr, position);
            return new Span(res);
        }

        public virtual IEnumerable<Span> GetSpans()
        {
            var spans = Meos.SpansetSpans(this._ptr);
            List<Span> spanList = new List<Span>(spans.Length);

            foreach(var span in spans)
            {
                spanList.Add(new Span(span));
            }

            return spanList;
        }

        public double Width(bool ignoreGaps = false)
            => Meos.NumspansetWidth(this._ptr, ignoreGaps);

        public bool IsAdjacent(Span span)
            => (Meos.AdjacentSpansetSpan(this._ptr, span._ptr));

        public bool IsAdjacent(SpanSet spanSet)
            => (Meos.AdjacentSpansetSpanset(this._ptr, spanSet._ptr));

        public bool IsContainedIn(Span span)
            => (Meos.ContainedSpansetSpan(this._ptr, span._ptr));

        public bool IsContainedIn(SpanSet spanSet)
            => (Meos.ContainedSpansetSpanset(this._ptr, spanSet._ptr));

        public bool Contains(Span span)
            => (Meos.ContainsSpansetSpan(this._ptr, span._ptr));

        public bool Contains(SpanSet spanSet)
            => (Meos.ContainsSpansetSpanset(this._ptr, spanSet._ptr));

        public bool Overlaps(Span span)
            => (Meos.OverlapsSpansetSpan(this._ptr, span._ptr));

        public bool Overlaps(SpanSet spanSet)
            => (Meos.OverlapsSpansetSpanset(this._ptr, spanSet._ptr));

        public bool IsLeftOf(Span span)
            => (Meos.LeftSpansetSpan(this._ptr, span._ptr));

        public bool IsLeftOf(SpanSet spanSet)
            => (Meos.LeftSpansetSpanset(this._ptr, spanSet._ptr));

        public bool IsOverOrLeftOf(Span span)
            => (Meos.OverleftSpansetSpan(this._ptr, span._ptr));

        public bool IsOverOrLeftOf(SpanSet spanSet)
            => (Meos.OverleftSpansetSpanset(this._ptr, spanSet._ptr));

        public bool IsRightOf(Span span)
            => (Meos.RightSpansetSpan(this._ptr, span._ptr));

        public bool IsRightOf(SpanSet spanSet)
            => (Meos.RightSpansetSpanset(this._ptr, spanSet._ptr));

        public bool IsOverOrRightOf(Span span)
            => (Meos.OverrightSpansetSpan(this._ptr, span._ptr));

        public bool IsOverOrRightOf(SpanSet spanSet)
            => (Meos.OverrightSpansetSpanset(this._ptr, spanSet._ptr));

        public double DistanceTo(Set set)
            => this.DistanceTo(set.ToSpanSet());

        public double DistanceTo(Span span)
            => Meos.DistanceSpansetSpan(this._ptr, span._ptr);

        public double DistanceTo(SpanSet spanSet)
            => Meos.DistanceSpansetSpanset(this._ptr, spanSet._ptr);

        public SpanSet IntersectionWith(Span span)
        {
            var res = Meos.IntersectionSpansetSpan(this._ptr, span._ptr);
            return new SpanSet(res);
        }

        public SpanSet IntersectionWith(SpanSet spanSet)
        {
            var res = Meos.IntersectionSpansetSpanset(this._ptr, spanSet._ptr);
            return new SpanSet(res);
        }

        public SpanSet Minus(Span span)
        {
            var res = Meos.MinusSpansetSpan(this._ptr, span._ptr);
            return new SpanSet(res);
        }

        public SpanSet Minus(SpanSet spanSet)
        {
            var res = Meos.MinusSpansetSpanset(this._ptr, spanSet._ptr);
            return new SpanSet(res);
        }

        public SpanSet UnionWith(Span span)
        {
            var res = Meos.UnionSpansetSpan(this._ptr, span._ptr);
            return new SpanSet(res);
        }

        public SpanSet UnionWith(SpanSet spanSet)
        {
            var res = Meos.UnionSpansetSpanset(this._ptr, spanSet._ptr);
            return new SpanSet(res);
        }

        public bool Equals(SpanSet spanSet)
            => (Meos.SpansetEq(this._ptr, spanSet._ptr));

        public static SpanSet operator +(SpanSet spanSet1, SpanSet spanSet2)
            => spanSet1.UnionWith(spanSet2);

        public static SpanSet operator -(SpanSet spanSet1, SpanSet spanSet2)
            => spanSet1.Minus(spanSet2);

        public static bool operator ==(SpanSet spanSet1, SpanSet spanSet2)
            => spanSet1.Equals(spanSet2);

        public static bool operator !=(SpanSet spanSet1, SpanSet spanSet2)
            => (Meos.SpansetNe(spanSet1._ptr, spanSet2._ptr));

        public static bool operator >(SpanSet spanSet1, SpanSet spanSet2)
            => (Meos.SpansetGt(spanSet1._ptr, spanSet2._ptr));

        public static bool operator <(SpanSet spanSet1, SpanSet spanSet2)
            => (Meos.SpansetLt(spanSet1._ptr, spanSet2._ptr));

        public static bool operator >=(SpanSet spanSet1, SpanSet spanSet2)
            => (Meos.SpansetGe(spanSet1._ptr, spanSet2._ptr));

        public static bool operator <=(SpanSet spanSet1, SpanSet spanSet2)
            => (Meos.SpansetLe(spanSet1._ptr, spanSet2._ptr));

        public override int GetHashCode()
            => (int)Meos.SpansetHash(this._ptr);
    }
}

