#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TInt class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TInt : TNumber
    {
        internal TInt(IntPtr ptr) : base(ptr) { }

        public Temporal? AtValue(int i)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_at_value(this.Ptr, i));

        public int EndValue()
            => MEOSExposedFunctions.tint_end_value(this.Ptr);

        public int MaxValue()
            => MEOSExposedFunctions.tint_max_value(this.Ptr);

        public int MinValue()
            => MEOSExposedFunctions.tint_min_value(this.Ptr);

        public Temporal? MinusValue(int i)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_minus_value(this.Ptr, i));

        public string Out()
            => MEOSExposedFunctions.tint_out(this.Ptr);

        public Temporal? ScaleValue(int width)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_scale_value(this.Ptr, width));

        public Temporal? ShiftScaleValue(int shift, int width)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_shift_scale_value(this.Ptr, shift, width));

        public Temporal? ShiftValue(int shift)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_shift_value(this.Ptr, shift));

        public int StartValue()
            => MEOSExposedFunctions.tint_start_value(this.Ptr);

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_to_tbigint(this.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_to_tfloat(this.Ptr));

        public int[] Values()
            => MEOSExposedFunctions.tint_values(this.Ptr);

        public static Temporal? FromBaseTemp(int i, Temporal temp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_from_base_temp(i, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tint_in(str));

    }
}
