#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TText class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TText : TAlpha
    {
        internal TText(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Temporal? AtValue(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TtextAtValue(this.Ptr, txt.Ptr));

        public Text? EndValue()
            => MEOSFactory.WrapText(Meos.TtextEndValue(this.Ptr));

        public Temporal? Initcap()
            => MEOSFactory.WrapTemporal(Meos.TtextInitcap(this.Ptr));

        public Temporal? Lower()
            => MEOSFactory.WrapTemporal(Meos.TtextLower(this.Ptr));

        public Text? MaxValue()
            => MEOSFactory.WrapText(Meos.TtextMaxValue(this.Ptr));

        public Text? MinValue()
            => MEOSFactory.WrapText(Meos.TtextMinValue(this.Ptr));

        public Temporal? MinusValue(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TtextMinusValue(this.Ptr, txt.Ptr));

        public string Out()
            => Meos.TtextOut(this.Ptr);

        public Text? StartValue()
            => MEOSFactory.WrapText(Meos.TtextStartValue(this.Ptr));

        public Temporal? ToTjsonb()
            => MEOSFactory.WrapTemporal(Meos.TtextToTjsonb(this.Ptr));

        public Temporal? Upper()
            => MEOSFactory.WrapTemporal(Meos.TtextUpper(this.Ptr));

        public Text?[] Values()
            => MEOSFactory.WrapTextArray(Meos.TtextValues(this.Ptr));

        public static Temporal? FromBaseTemp(Text txt, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TtextFromBaseTemp(txt.Ptr, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TtextFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TtextIn(str));

    }
}
