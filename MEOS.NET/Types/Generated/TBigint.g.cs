#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TBigint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBigint : TNumber
    {
        internal TBigint(IntPtr ptr) : base(ptr) { }

        public long EndValue()
            => MEOSExposedFunctions.tbigint_end_value(this.Ptr);

        public long MaxValue()
            => MEOSExposedFunctions.tbigint_max_value(this.Ptr);

        public long MinValue()
            => MEOSExposedFunctions.tbigint_min_value(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.tbigint_out(this.Ptr);

        public Temporal? ScaleValue(long width)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_scale_value(this.Ptr, width));

        public Temporal? ShiftScaleValue(long shift, long width)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_shift_scale_value(this.Ptr, shift, width));

        public Temporal? ShiftValue(long shift)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_shift_value(this.Ptr, shift));

        public long StartValue()
            => MEOSExposedFunctions.tbigint_start_value(this.Ptr);

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_to_tfloat(this.Ptr));

        public Temporal? ToTh3index()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_to_th3index(this.Ptr));

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_to_tint(this.Ptr));

        public Temporal? ToTquadbin()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_to_tquadbin(this.Ptr));

        public Temporal? ToTs2cell()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_to_ts2cell(this.Ptr));

        public static Temporal? FromBaseTemp(long i, Temporal temp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_from_base_temp(i, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbigint_in(str));

    }
}
