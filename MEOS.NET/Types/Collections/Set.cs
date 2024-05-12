using System.Runtime.InteropServices;
using MEOS.NET.Helpers;
using MEOS.NET.Internal;
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
                return MEOSExposedFunctions.set_from_wkb(bytesPtr, (ulong)bytes.Length);
            });

            return new Set(setPtr);
        }

        public static Set FromHexWKB(string hexWKB)
        {
            var res = MEOSExposedFunctions.set_from_hexwkb(hexWKB);
            return new Set(res);
        }

        public int Count()
            => MEOSExposedFunctions.set_num_values(this._ptr);

        public byte[] ToBytes()
        {
            int arrSize = 0;
            var arr = AllocHelper.AllocatePointer<IntPtr>(sizeof(int), (countPtr) =>
            {
                var res = MEOSExposedFunctions.set_as_wkb(this._ptr, variant: 4, countPtr);
                arrSize = countPtr.ToStructure<int>();

                return res;
            });

            return arr.ToArrayOfType<byte>(arrSize);
        }

        public string ToHexWKB()
        {
            return AllocHelper.AllocatePointer<string>(sizeof(int), (sizePtr) =>
            {
                return MEOSExposedFunctions.set_as_hexwkb(this._ptr, 0, sizePtr);
            });
        }

        public Span ToSpan()
        {
            var res = MEOSExposedFunctions.set_to_span(this._ptr);
            return new Span(res);
        }

        public SpanSet ToSpanSet()
        {
            var res = MEOSExposedFunctions.set_to_spanset(this._ptr);
            return new SpanSet(res);
        }

        public bool Contains(Set collection)
            => MEOSExposedFunctions.contains_set_set(this._ptr, collection._ptr);

        public bool IsContainedIn(Set collection)
            => MEOSExposedFunctions.contained_set_set(this._ptr, collection._ptr);

        public bool Overlaps(Set collection)
            => MEOSExposedFunctions.overlaps_set_set(this._ptr, collection._ptr);

        public bool IsLeftOf(Set collection)
            => MEOSExposedFunctions.left_set_set(this._ptr, collection._ptr);

        public bool IsOverOrLeftOf(Set collection)
            => MEOSExposedFunctions.overleft_set_set(this._ptr, collection._ptr);

        public bool IsOverOrRightOf(Set collection)
            => MEOSExposedFunctions.overright_set_set(this._ptr, collection._ptr);

        public bool IsRightOf(Set collection)
            => MEOSExposedFunctions.right_set_set(this._ptr, collection._ptr);

        public override bool Equals(object? obj)
        {
            if (this.GetType() != obj?.GetType())
            {
                return false;
            }

            return MEOSExposedFunctions.set_eq(this._ptr, ((Set)obj)._ptr);
        }

        public override int GetHashCode()
            => (int)MEOSExposedFunctions.set_hash(this._ptr);
    }
}

