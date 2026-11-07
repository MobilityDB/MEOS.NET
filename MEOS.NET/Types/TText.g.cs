#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

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

        public int AlwaysEq(Text txt)
            => Meos.AlwaysEqTtextText(this.Ptr, txt.Ptr);

        public int AlwaysGe(Text txt)
            => Meos.AlwaysGeTtextText(this.Ptr, txt.Ptr);

        public int AlwaysGt(Text txt)
            => Meos.AlwaysGtTtextText(this.Ptr, txt.Ptr);

        public int AlwaysLe(Text txt)
            => Meos.AlwaysLeTtextText(this.Ptr, txt.Ptr);

        public int AlwaysLt(Text txt)
            => Meos.AlwaysLtTtextText(this.Ptr, txt.Ptr);

        public int AlwaysNe(Text txt)
            => Meos.AlwaysNeTtextText(this.Ptr, txt.Ptr);

        public string AsText()
            => this.Out();

        public Temporal? AtValue(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TtextAtValue(this.Ptr, txt.Ptr));

        public Text? EndValue()
            => MEOSFactory.WrapText(Meos.TtextEndValue(this.Ptr));

        public int EverEq(Text txt)
            => Meos.EverEqTtextText(this.Ptr, txt.Ptr);

        public int EverGe(Text txt)
            => Meos.EverGeTtextText(this.Ptr, txt.Ptr);

        public int EverGt(Text txt)
            => Meos.EverGtTtextText(this.Ptr, txt.Ptr);

        public int EverLe(Text txt)
            => Meos.EverLeTtextText(this.Ptr, txt.Ptr);

        public int EverLt(Text txt)
            => Meos.EverLtTtextText(this.Ptr, txt.Ptr);

        public int EverNe(Text txt)
            => Meos.EverNeTtextText(this.Ptr, txt.Ptr);

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

        public Temporal? Teq(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TeqTtextText(this.Ptr, txt.Ptr));

        public Temporal? Textcat(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TextcatTtextText(this.Ptr, txt.Ptr));

        public Temporal? Textcat(TText temp2)
            => MEOSFactory.WrapTemporal(Meos.TextcatTtextTtext(this.Ptr, temp2.Ptr));

        public Temporal? Tge(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TgeTtextText(this.Ptr, txt.Ptr));

        public Temporal? Tgt(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TgtTtextText(this.Ptr, txt.Ptr));

        public Temporal? Tle(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TleTtextText(this.Ptr, txt.Ptr));

        public Temporal? Tlt(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TltTtextText(this.Ptr, txt.Ptr));

        public Temporal? Tne(Text txt)
            => MEOSFactory.WrapTemporal(Meos.TneTtextText(this.Ptr, txt.Ptr));

        public Temporal? ToTjsonb()
            => MEOSFactory.WrapTemporal(Meos.TtextToTjsonb(this.Ptr));

        public (SpanSet?[], Text?[]) Unnest()
        {
            var _answered = Meos.TtextUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapTextArray(_answered.Item2));
        }

        public Temporal? Upper()
            => MEOSFactory.WrapTemporal(Meos.TtextUpper(this.Ptr));

        public Text? Value()
            => MEOSFactory.WrapText(Meos.TtextValue(this.Ptr));

        public Text? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TtextValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapText(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Text? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TtextValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapText(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Text?[] Values()
            => MEOSFactory.WrapTextArray(Meos.TtextValues(this.Ptr));

        public static Temporal? FromBaseTemp(Text txt, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TtextFromBaseTemp(txt.Ptr, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TtextFromMfjson(str));

        public static Temporal? FromText(string str)
            => TText.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TtextIn(str));

    }
}
