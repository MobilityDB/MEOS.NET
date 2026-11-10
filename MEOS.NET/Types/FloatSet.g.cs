#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The FloatSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class FloatSet : Set
    {
        internal FloatSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public Set? Ceil()
            => MEOSFactory.WrapSet(Meos.FloatsetCeil(this.Ptr));

        public bool Contained(FloatSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(double d)
            => Meos.ContainsSetFloat(this.Ptr, d);

        public bool Contains(FloatSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public Set? Degrees(bool normalize)
            => MEOSFactory.WrapSet(Meos.FloatsetDegrees(this.Ptr, normalize));

        public double Distance(FloatSet s2)
            => Meos.DistanceFloatsetFloatset(this.Ptr, s2.Ptr);

        public double Distance(double d)
            => Meos.DistanceSetFloat(this.Ptr, d);

        public double EndValue()
            => Meos.FloatsetEndValue(this.Ptr);

        public Set? Floor()
            => MEOSFactory.WrapSet(Meos.FloatsetFloor(this.Ptr));

        public Set? Intersection(double d)
            => MEOSFactory.WrapSet(Meos.IntersectionSetFloat(this.Ptr, d));

        public Set? Intersection(FloatSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public bool Left(double d)
            => Meos.LeftSetFloat(this.Ptr, d);

        public bool Left(FloatSet s2)
            => Meos.LeftSetSet(this.Ptr, s2.Ptr);

        public Set? Minus(double d)
            => MEOSFactory.WrapSet(Meos.MinusSetFloat(this.Ptr, d));

        public Set? Minus(FloatSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public bool Overlaps(FloatSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Overleft(double d)
            => Meos.OverleftSetFloat(this.Ptr, d);

        public bool Overleft(FloatSet s2)
            => Meos.OverleftSetSet(this.Ptr, s2.Ptr);

        public bool Overright(double d)
            => Meos.OverrightSetFloat(this.Ptr, d);

        public bool Overright(FloatSet s2)
            => Meos.OverrightSetSet(this.Ptr, s2.Ptr);

        public Set? Radians()
            => MEOSFactory.WrapSet(Meos.FloatsetRadians(this.Ptr));

        public bool Rcontained(double d)
            => Meos.ContainedFloatSet(d, this.Ptr);

        public bool Right(double d)
            => Meos.RightSetFloat(this.Ptr, d);

        public bool Right(FloatSet s2)
            => Meos.RightSetSet(this.Ptr, s2.Ptr);

        public Set? Rintersection(double d)
            => MEOSFactory.WrapSet(Meos.IntersectionFloatSet(d, this.Ptr));

        public bool Rleft(double d)
            => Meos.LeftFloatSet(d, this.Ptr);

        public Set? Rminus(double d)
            => MEOSFactory.WrapSet(Meos.MinusFloatSet(d, this.Ptr));

        public bool Roverleft(double d)
            => Meos.OverleftFloatSet(d, this.Ptr);

        public bool Roverright(double d)
            => Meos.OverrightFloatSet(d, this.Ptr);

        public bool Rright(double d)
            => Meos.RightFloatSet(d, this.Ptr);

        public Set? Runion(double d)
            => MEOSFactory.WrapSet(Meos.UnionFloatSet(d, this.Ptr));

        public Set? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(Meos.FloatsetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public double StartValue()
            => Meos.FloatsetStartValue(this.Ptr);

        public Set? ToIntset()
            => MEOSFactory.WrapSet(Meos.FloatsetToIntset(this.Ptr));

        public Set? Union(double d)
            => MEOSFactory.WrapSet(Meos.UnionSetFloat(this.Ptr, d));

        public Set? Union(FloatSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public double? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.FloatsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double[] Values()
            => Meos.FloatsetValues(this.Ptr);

        public static Set? FromFloat(double d)
            => MEOSFactory.WrapSet(Meos.FloatToSet(d));

        public static Set? FromText(string str)
            => FloatSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.FloatsetIn(str));

        public static Set? Make(double[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.FloatsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
