#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TGeography class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeography : TGeo
    {
        internal TGeography(IntPtr ptr) : base(ptr) { }

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TgeographyToTgeogpoint(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TgeographyToTgeometry(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TgeographyFromMfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeographyIn(str));

    }
}
