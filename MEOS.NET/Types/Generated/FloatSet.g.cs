#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The FloatSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class FloatSet : Set
    {
        internal FloatSet(IntPtr ptr) : base(ptr) { }

        public Set? Ceil()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.floatset_ceil(this.Ptr));

        public Set? Degrees(bool normalize)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.floatset_degrees(this.Ptr, normalize));

        public double EndValue()
            => MEOSExposedFunctions.floatset_end_value(this.Ptr);

        public Set? Floor()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.floatset_floor(this.Ptr));

        public string Out(int maxdd)
            => MEOSExposedFunctions.floatset_out(this.Ptr, maxdd);

        public Set? Radians()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.floatset_radians(this.Ptr));

        public Set? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.floatset_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public double StartValue()
            => MEOSExposedFunctions.floatset_start_value(this.Ptr);

        public Set? ToIntset()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.floatset_to_intset(this.Ptr));

        public double[] Values()
            => MEOSExposedFunctions.floatset_values(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.floatset_in(str));

    }
}
