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

        public Set? Ceil()
            => MEOSFactory.WrapSet(Meos.FloatsetCeil(this.Ptr));

        public Set? Degrees(bool normalize)
            => MEOSFactory.WrapSet(Meos.FloatsetDegrees(this.Ptr, normalize));

        public double EndValue()
            => Meos.FloatsetEndValue(this.Ptr);

        public Set? Floor()
            => MEOSFactory.WrapSet(Meos.FloatsetFloor(this.Ptr));

        public string Out(int maxdd)
            => Meos.FloatsetOut(this.Ptr, maxdd);

        public Set? Radians()
            => MEOSFactory.WrapSet(Meos.FloatsetRadians(this.Ptr));

        public Set? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(Meos.FloatsetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public double StartValue()
            => Meos.FloatsetStartValue(this.Ptr);

        public Set? ToIntset()
            => MEOSFactory.WrapSet(Meos.FloatsetToIntset(this.Ptr));

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

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.FloatsetIn(str));

    }
}
