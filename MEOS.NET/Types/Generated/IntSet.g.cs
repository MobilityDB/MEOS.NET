#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The IntSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSet : Set
    {
        internal IntSet(IntPtr ptr) : base(ptr) { }

        public int EndValue()
            => MEOSExposedFunctions.intset_end_value(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.intset_out(this.Ptr);

        public Set? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.intset_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public int StartValue()
            => MEOSExposedFunctions.intset_start_value(this.Ptr);

        public Set? ToFloatset()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.intset_to_floatset(this.Ptr));

        public int[] Values()
            => MEOSExposedFunctions.intset_values(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.intset_in(str));

    }
}
