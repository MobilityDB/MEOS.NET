#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TText class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TText : TAlpha
    {
        internal TText(IntPtr ptr) : base(ptr) { }

        public Temporal? Initcap()
            => MEOSFactory.WrapTemporal(Meos.TtextInitcap(this.Ptr));

        public Temporal? Lower()
            => MEOSFactory.WrapTemporal(Meos.TtextLower(this.Ptr));

        public string Out()
            => Meos.TtextOut(this.Ptr);

        public Temporal? ToTjsonb()
            => MEOSFactory.WrapTemporal(Meos.TtextToTjsonb(this.Ptr));

        public Temporal? Upper()
            => MEOSFactory.WrapTemporal(Meos.TtextUpper(this.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TtextFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TtextIn(str));

    }
}
