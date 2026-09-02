#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TInt class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TInt : TNumber
    {
        internal TInt(IntPtr ptr) : base(ptr) { }

        public Temporal? AtValue(int i)
            => MEOSFactory.WrapTemporal(Meos.TintAtValue(this.Ptr, i));

        public int EndValue()
            => Meos.TintEndValue(this.Ptr);

        public int MaxValue()
            => Meos.TintMaxValue(this.Ptr);

        public int MinValue()
            => Meos.TintMinValue(this.Ptr);

        public Temporal? MinusValue(int i)
            => MEOSFactory.WrapTemporal(Meos.TintMinusValue(this.Ptr, i));

        public string Out()
            => Meos.TintOut(this.Ptr);

        public Temporal? ScaleValue(int width)
            => MEOSFactory.WrapTemporal(Meos.TintScaleValue(this.Ptr, width));

        public Temporal? ShiftScaleValue(int shift, int width)
            => MEOSFactory.WrapTemporal(Meos.TintShiftScaleValue(this.Ptr, shift, width));

        public Temporal? ShiftValue(int shift)
            => MEOSFactory.WrapTemporal(Meos.TintShiftValue(this.Ptr, shift));

        public int StartValue()
            => Meos.TintStartValue(this.Ptr);

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.TintToTbigint(this.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TintToTfloat(this.Ptr));

        public int[] Values()
            => Meos.TintValues(this.Ptr);

        public static Temporal? FromBaseTemp(int i, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TintFromBaseTemp(i, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TintFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TintIn(str));

    }
}
