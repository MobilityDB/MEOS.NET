#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TJsonb class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TJsonb : TAlpha
    {
        internal TJsonb(IntPtr ptr) : base(ptr) { }

        public Temporal? ArrayLength()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tjsonb_array_length(this.Ptr));

        public Temporal? DeleteIndex(int idx)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tjsonb_delete_index(this.Ptr, idx));

        public string Out()
            => MEOSExposedFunctions.tjsonb_out(this.Ptr);

        public Temporal? Pretty()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tjsonb_pretty(this.Ptr));

        public Temporal? StripNulls(bool strip_in_arrays)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tjsonb_strip_nulls(this.Ptr, strip_in_arrays));

        public Temporal? ToTtext()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tjsonb_to_ttext(this.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tjsonb_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tjsonb_in(str));

    }
}
