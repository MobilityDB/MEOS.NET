#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The BigIntSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSet : Set
    {
        internal BigIntSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public string AsText()
            => this.Out();

        public bool Contained(BigIntSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool ContainedRid(TNpoint temp)
            => Meos.ContainedRidBigintsetTnpoint(this.Ptr, temp.Ptr);

        public bool Contains(long i)
            => Meos.ContainsSetBigint(this.Ptr, i);

        public bool Contains(BigIntSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public bool ContainsRid(TNpoint temp)
            => Meos.ContainsRidBigintsetTnpoint(this.Ptr, temp.Ptr);

        public long Distance(BigIntSet s2)
            => Meos.DistanceBigintsetBigintset(this.Ptr, s2.Ptr);

        public long Distance(long i)
            => Meos.DistanceSetBigint(this.Ptr, i);

        public long EndValue()
            => Meos.BigintsetEndValue(this.Ptr);

        public Set? Intersection(long i)
            => MEOSFactory.WrapSet(Meos.IntersectionSetBigint(this.Ptr, i));

        public Set? Intersection(BigIntSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public bool Left(long i)
            => Meos.LeftSetBigint(this.Ptr, i);

        public bool Left(BigIntSet s2)
            => Meos.LeftSetSet(this.Ptr, s2.Ptr);

        public Set? Minus(long i)
            => MEOSFactory.WrapSet(Meos.MinusSetBigint(this.Ptr, i));

        public Set? Minus(BigIntSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public string Out()
            => Meos.BigintsetOut(this.Ptr);

        public bool Overlaps(BigIntSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool OverlapsRid(TNpoint temp)
            => Meos.OverlapsRidBigintsetTnpoint(this.Ptr, temp.Ptr);

        public bool Overleft(long i)
            => Meos.OverleftSetBigint(this.Ptr, i);

        public bool Overleft(BigIntSet s2)
            => Meos.OverleftSetSet(this.Ptr, s2.Ptr);

        public bool Overright(long i)
            => Meos.OverrightSetBigint(this.Ptr, i);

        public bool Overright(BigIntSet s2)
            => Meos.OverrightSetSet(this.Ptr, s2.Ptr);

        public bool Rcontained(long i)
            => Meos.ContainedBigintSet(i, this.Ptr);

        public bool Right(long i)
            => Meos.RightSetBigint(this.Ptr, i);

        public bool Right(BigIntSet s2)
            => Meos.RightSetSet(this.Ptr, s2.Ptr);

        public Set? Rintersection(long i)
            => MEOSFactory.WrapSet(Meos.IntersectionBigintSet(i, this.Ptr));

        public bool Rleft(long i)
            => Meos.LeftBigintSet(i, this.Ptr);

        public Set? Rminus(long i)
            => MEOSFactory.WrapSet(Meos.MinusBigintSet(i, this.Ptr));

        public bool Roverleft(long i)
            => Meos.OverleftBigintSet(i, this.Ptr);

        public bool Roverright(long i)
            => Meos.OverrightBigintSet(i, this.Ptr);

        public bool Rright(long i)
            => Meos.RightBigintSet(i, this.Ptr);

        public Set? Runion(long i)
            => MEOSFactory.WrapSet(Meos.UnionBigintSet(i, this.Ptr));

        public bool SameRid(TNpoint temp)
            => Meos.SameRidBigintsetTnpoint(this.Ptr, temp.Ptr);

        public Set? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(Meos.BigintsetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public long StartValue()
            => Meos.BigintsetStartValue(this.Ptr);

        public Set? Union(long i)
            => MEOSFactory.WrapSet(Meos.UnionSetBigint(this.Ptr, i));

        public Set? Union(BigIntSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public long? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.BigintsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return Marshal.ReadInt64(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public long[] Values()
            => Meos.BigintsetValues(this.Ptr);

        public static Set? FromBigint(long i)
            => MEOSFactory.WrapSet(Meos.BigintToSet(i));

        public static Set? FromText(string str)
            => BigIntSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.BigintsetIn(str));

        public static Set? Make(long[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.BigintsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
