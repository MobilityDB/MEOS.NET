using System.Runtime.InteropServices;

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
            GCHandle pinnedArray = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            IntPtr pointer = pinnedArray.AddrOfPinnedObject();

            var res = MEOSExposedFunctions.set_from_wkb(pointer, (ulong)bytes.Length);

            pinnedArray.Free();

            return new Set(res);
            // TODO : Check if correct behaviour
            // TODO : Create Helper with alloc and callback (func that returns <T>, here "res") to avoid using GCHandle with Free everywhere
                    // Careful with errors happening in that callback
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
            throw new NotImplementedException(); // TODO : Check PyMEOS
        }

        public string ToHexWKB()
        {
            throw new NotImplementedException();
        }

        public Span ToSpan()
        {
            throw new NotImplementedException();
        }

        public SpanSet ToSpanSet()
        {
            throw new NotImplementedException();
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
            => HashCode.Combine(_ptr);
    }
}

