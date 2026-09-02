#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TText class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TText : TAlpha
    {
        internal TText(IntPtr ptr) : base(ptr) { }

        public Temporal? Initcap()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.ttext_initcap(this.Ptr));

        public Temporal? Lower()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.ttext_lower(this.Ptr));

        public string Out()
            => MEOSExposedFunctions.ttext_out(this.Ptr);

        public Temporal? ToTjsonb()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.ttext_to_tjsonb(this.Ptr));

        public Temporal? Upper()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.ttext_upper(this.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.ttext_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.ttext_in(str));

    }
}
