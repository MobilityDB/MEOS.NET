#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TJsonb class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TJsonb : TAlpha
    {
        internal TJsonb(IntPtr ptr) : base(ptr) { }

        public Temporal? ArrayLength()
            => MEOSFactory.WrapTemporal(Meos.TjsonbArrayLength(this.Ptr));

        public Temporal? DeleteIndex(int idx)
            => MEOSFactory.WrapTemporal(Meos.TjsonbDeleteIndex(this.Ptr, idx));

        public string Out()
            => Meos.TjsonbOut(this.Ptr);

        public Temporal? Pretty()
            => MEOSFactory.WrapTemporal(Meos.TjsonbPretty(this.Ptr));

        public Temporal? StripNulls(bool strip_in_arrays)
            => MEOSFactory.WrapTemporal(Meos.TjsonbStripNulls(this.Ptr, strip_in_arrays));

        public Temporal? ToTtext()
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTtext(this.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TjsonbFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TjsonbIn(str));

    }
}
