#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TBool class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBool : TAlpha
    {
        internal TBool(IntPtr ptr) : base(ptr) { }

        public Temporal? AtValue(bool b)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbool_at_value(this.Ptr, b));

        public bool EndValue()
            => MEOSExposedFunctions.tbool_end_value(this.Ptr);

        public Temporal? MinusValue(bool b)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbool_minus_value(this.Ptr, b));

        public string Out()
            => MEOSExposedFunctions.tbool_out(this.Ptr);

        public bool StartValue()
            => MEOSExposedFunctions.tbool_start_value(this.Ptr);

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbool_to_tint(this.Ptr));

        public SpanSet? WhenTrue()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.tbool_when_true(this.Ptr));

        public static Temporal? FromBaseTemp(bool b, Temporal temp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbool_from_base_temp(b, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbool_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tbool_in(str));

    }
}
