#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The IntSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSet : Set
    {
        internal IntSet(IntPtr ptr) : base(ptr) { }

        public int EndValue()
            => Meos.IntsetEndValue(this.Ptr);

        public string Out()
            => Meos.IntsetOut(this.Ptr);

        public Set? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(Meos.IntsetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public int StartValue()
            => Meos.IntsetStartValue(this.Ptr);

        public Set? ToFloatset()
            => MEOSFactory.WrapSet(Meos.IntsetToFloatset(this.Ptr));

        public int[] Values()
            => Meos.IntsetValues(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.IntsetIn(str));

    }
}
