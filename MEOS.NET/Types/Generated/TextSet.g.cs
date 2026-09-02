#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TextSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TextSet : Set
    {
        internal TextSet(IntPtr ptr) : base(ptr) { }

        public Set? Initcap()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.textset_initcap(this.Ptr));

        public Set? Lower()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.textset_lower(this.Ptr));

        public string Out()
            => MEOSExposedFunctions.textset_out(this.Ptr);

        public Set? Upper()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.textset_upper(this.Ptr));

        public static Set? In(string str)
            => MEOSFactory.WrapSet(MEOSExposedFunctions.textset_in(str));

    }
}
