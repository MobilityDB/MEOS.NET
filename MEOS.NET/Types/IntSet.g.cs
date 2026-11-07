#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The IntSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSet : Set
    {
        internal IntSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public string AsText()
            => this.Out();

        public bool Contained(IntSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(int i)
            => Meos.ContainsSetInt(this.Ptr, i);

        public bool Contains(IntSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public int Distance(IntSet s2)
            => Meos.DistanceIntsetIntset(this.Ptr, s2.Ptr);

        public int Distance(int i)
            => Meos.DistanceSetInt(this.Ptr, i);

        public int EndValue()
            => Meos.IntsetEndValue(this.Ptr);

        public Set? Intersection(int i)
            => MEOSFactory.WrapSet(Meos.IntersectionSetInt(this.Ptr, i));

        public Set? Intersection(IntSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public bool Left(int i)
            => Meos.LeftSetInt(this.Ptr, i);

        public bool Left(IntSet s2)
            => Meos.LeftSetSet(this.Ptr, s2.Ptr);

        public Set? Minus(int i)
            => MEOSFactory.WrapSet(Meos.MinusSetInt(this.Ptr, i));

        public Set? Minus(IntSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public string Out()
            => Meos.IntsetOut(this.Ptr);

        public bool Overlaps(IntSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Overleft(int i)
            => Meos.OverleftSetInt(this.Ptr, i);

        public bool Overleft(IntSet s2)
            => Meos.OverleftSetSet(this.Ptr, s2.Ptr);

        public bool Overright(int i)
            => Meos.OverrightSetInt(this.Ptr, i);

        public bool Overright(IntSet s2)
            => Meos.OverrightSetSet(this.Ptr, s2.Ptr);

        public bool Rcontained(int i)
            => Meos.ContainedIntSet(i, this.Ptr);

        public bool Right(int i)
            => Meos.RightSetInt(this.Ptr, i);

        public bool Right(IntSet s2)
            => Meos.RightSetSet(this.Ptr, s2.Ptr);

        public Set? Rintersection(int i)
            => MEOSFactory.WrapSet(Meos.IntersectionIntSet(i, this.Ptr));

        public bool Rleft(int i)
            => Meos.LeftIntSet(i, this.Ptr);

        public Set? Rminus(int i)
            => MEOSFactory.WrapSet(Meos.MinusIntSet(i, this.Ptr));

        public bool Roverleft(int i)
            => Meos.OverleftIntSet(i, this.Ptr);

        public bool Roverright(int i)
            => Meos.OverrightIntSet(i, this.Ptr);

        public bool Rright(int i)
            => Meos.RightIntSet(i, this.Ptr);

        public Set? Runion(int i)
            => MEOSFactory.WrapSet(Meos.UnionIntSet(i, this.Ptr));

        public Set? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(Meos.IntsetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public int StartValue()
            => Meos.IntsetStartValue(this.Ptr);

        public Set? ToFloatset()
            => MEOSFactory.WrapSet(Meos.IntsetToFloatset(this.Ptr));

        public Set? Union(int i)
            => MEOSFactory.WrapSet(Meos.UnionSetInt(this.Ptr, i));

        public Set? Union(IntSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public int? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(4);
            try
            {
                if (!Meos.IntsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return Marshal.ReadInt32(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public int[] Values()
            => Meos.IntsetValues(this.Ptr);

        public static Set? FromInt(int i)
            => MEOSFactory.WrapSet(Meos.IntToSet(i));

        public static Set? FromText(string str)
            => IntSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.IntsetIn(str));

        public static Set? Make(int[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.IntsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
