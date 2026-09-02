#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TFloat class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TFloat : TNumber
    {
        internal TFloat(IntPtr ptr) : base(ptr) { }

        public Temporal? AtValue(double d)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_at_value(this.Ptr, d));

        public Temporal? Ceil()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_ceil(this.Ptr));

        public Temporal? Cos()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_cos(this.Ptr));

        public Temporal? Degrees(bool normalize)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_degrees(this.Ptr, normalize));

        public double EndValue()
            => MEOSExposedFunctions.tfloat_end_value(this.Ptr);

        public Temporal? Exp()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_exp(this.Ptr));

        public Temporal? Floor()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_floor(this.Ptr));

        public Temporal? Ln()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_ln(this.Ptr));

        public Temporal? Log10()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_log10(this.Ptr));

        public double MaxValue()
            => MEOSExposedFunctions.tfloat_max_value(this.Ptr);

        public double MinValue()
            => MEOSExposedFunctions.tfloat_min_value(this.Ptr);

        public Temporal? MinusValue(double d)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_minus_value(this.Ptr, d));

        public string Out(int maxdd)
            => MEOSExposedFunctions.tfloat_out(this.Ptr, maxdd);

        public Temporal? Radians()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_radians(this.Ptr));

        public Temporal? ScaleValue(double width)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_scale_value(this.Ptr, width));

        public Temporal? ShiftScaleValue(double shift, double width)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_shift_scale_value(this.Ptr, shift, width));

        public Temporal? ShiftValue(double shift)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_shift_value(this.Ptr, shift));

        public Temporal? Sin()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_sin(this.Ptr));

        public double StartValue()
            => MEOSExposedFunctions.tfloat_start_value(this.Ptr);

        public Temporal? Tan()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_tan(this.Ptr));

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_to_tbigint(this.Ptr));

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_to_tint(this.Ptr));

        public double[] Values()
            => MEOSExposedFunctions.tfloat_values(this.Ptr);

        public static Temporal? FromBaseTemp(double d, Temporal temp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_from_base_temp(d, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tfloat_in(str));

    }
}
