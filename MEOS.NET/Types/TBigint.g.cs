#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TBigint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBigint : TNumber
    {
        internal TBigint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public long EndValue()
            => Meos.TbigintEndValue(this.Ptr);

        public long MaxValue()
            => Meos.TbigintMaxValue(this.Ptr);

        public long MinValue()
            => Meos.TbigintMinValue(this.Ptr);

        public string Out()
            => Meos.TbigintOut(this.Ptr);

        public Temporal? ScaleValue(long width)
            => MEOSFactory.WrapTemporal(Meos.TbigintScaleValue(this.Ptr, width));

        public Temporal? ShiftScaleValue(long shift, long width)
            => MEOSFactory.WrapTemporal(Meos.TbigintShiftScaleValue(this.Ptr, shift, width));

        public Temporal? ShiftValue(long shift)
            => MEOSFactory.WrapTemporal(Meos.TbigintShiftValue(this.Ptr, shift));

        public long StartValue()
            => Meos.TbigintStartValue(this.Ptr);

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTfloat(this.Ptr));

        public Temporal? ToTh3index()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTh3index(this.Ptr));

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTint(this.Ptr));

        public Temporal? ToTquadbin()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTquadbin(this.Ptr));

        public Temporal? ToTs2cell()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTs2cell(this.Ptr));

        public static Temporal? FromBaseTemp(long i, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TbigintFromBaseTemp(i, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TbigintFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TbigintIn(str));

    }
}
