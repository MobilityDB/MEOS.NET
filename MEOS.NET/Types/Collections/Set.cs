using System.Runtime.InteropServices;
using MEOS.NET.Helpers;
using MEOS.NET.Functions;
using MEOS.NET.Types.General;

namespace MEOS.NET.Types.Collections
{
    public class Set : MEOSObject, ICollection<Set>
    {
        internal Set(IntPtr ptr) : base(ptr)
        {}

        public static Set FromBytes(byte[] bytes)
        {
            var setPtr = AllocHelper.AllocateArrayPointer<byte, IntPtr>(bytes, (bytesPtr) =>
            {
                return Meos.SetFromWkb(bytesPtr, (ulong)bytes.Length);
            });

            return new Set(setPtr);
        }

        public static Set FromHexWKB(string hexWKB)
        {
            var res = Meos.SetFromHexwkb(hexWKB);
            return new Set(res);
        }

        public int Count()
            => Meos.SetNumValues(this._ptr);

        public byte[] ToBytes()
        {
            int arrSize = 0;
            var arr = AllocHelper.AllocatePointer<IntPtr>(sizeof(int), (countPtr) =>
            {
                var res = Meos.SetAsWkb(this._ptr, variant: 4, countPtr);
                arrSize = countPtr.ToStructure<int>();

                return res;
            });

            return arr.ToArrayOfType<byte>(arrSize);
        }

        public string ToHexWKB()
        {
            return AllocHelper.AllocatePointer<string>(sizeof(int), (sizePtr) =>
            {
                return Meos.SetAsHexwkb(this._ptr, 0, sizePtr);
            });
        }

        public Span ToSpan()
        {
            var res = Meos.SetToSpan(this._ptr);
            return new Span(res);
        }

        public SpanSet ToSpanSet()
        {
            var res = Meos.SetToSpanset(this._ptr);
            return new SpanSet(res);
        }

        public bool Contains(Set collection)
            => (Meos.ContainsSetSet(this._ptr, collection._ptr));

        public bool IsContainedIn(Set collection)
            => (Meos.ContainedSetSet(this._ptr, collection._ptr));

        public bool Overlaps(Set collection)
            => (Meos.OverlapsSetSet(this._ptr, collection._ptr));

        public bool IsLeftOf(Set collection)
            => (Meos.LeftSetSet(this._ptr, collection._ptr));

        public bool IsOverOrLeftOf(Set collection)
            => (Meos.OverleftSetSet(this._ptr, collection._ptr));

        public bool IsOverOrRightOf(Set collection)
            => (Meos.OverrightSetSet(this._ptr, collection._ptr));

        public bool IsRightOf(Set collection)
            => (Meos.RightSetSet(this._ptr, collection._ptr));

        public override bool Equals(object? obj)
        {
            if (this.GetType() != obj?.GetType())
            {
                return false;
            }

            return (Meos.SetEq(this._ptr, ((Set)obj)._ptr));
        }

        public override int GetHashCode()
            => (int)Meos.SetHash(this._ptr);
    }
}

