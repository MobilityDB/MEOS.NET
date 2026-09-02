#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TsTzSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSet : Set
    {
        internal TsTzSet(IntPtr ptr) : base(ptr) { }

        public DateTime EndValue()
            => MEOSConvert.ToDateTime(Meos.TstzsetEndValue(this.Ptr));

        public string Out()
            => Meos.TstzsetOut(this.Ptr);

        public DateTime StartValue()
            => MEOSConvert.ToDateTime(Meos.TstzsetStartValue(this.Ptr));

        public Set? ToDateset()
            => MEOSFactory.WrapSet(Meos.TstzsetToDateset(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TstzsetToStbox(this.Ptr));

        public long[] Values()
            => Meos.TstzsetValues(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.TstzsetIn(str));

    }
}
