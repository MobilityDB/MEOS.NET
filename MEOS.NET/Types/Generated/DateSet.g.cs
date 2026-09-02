#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The DateSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class DateSet : Set
    {
        internal DateSet(IntPtr ptr) : base(ptr) { }

        public DateOnly EndValue()
            => MEOSConvert.ToDateOnly(MEOSExposedFunctions.dateset_end_value(this.Ptr));

        public string Out()
            => MEOSExposedFunctions.dateset_out(this.Ptr);

        public Set? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.dateset_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public DateOnly StartValue()
            => MEOSConvert.ToDateOnly(MEOSExposedFunctions.dateset_start_value(this.Ptr));

        public Set? ToTstzset()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.dateset_to_tstzset(this.Ptr));

        public int[] Values()
            => MEOSExposedFunctions.dateset_values(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.dateset_in(str));

    }
}
