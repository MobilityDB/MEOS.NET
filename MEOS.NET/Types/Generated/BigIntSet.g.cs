#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The BigIntSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSet : Set
    {
        internal BigIntSet(IntPtr ptr) : base(ptr) { }

        public long EndValue()
            => MEOSExposedFunctions.bigintset_end_value(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.bigintset_out(this.Ptr);

        public Set? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.bigintset_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public long StartValue()
            => MEOSExposedFunctions.bigintset_start_value(this.Ptr);

        public long[] Values()
            => MEOSExposedFunctions.bigintset_values(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.bigintset_in(str));

    }
}
