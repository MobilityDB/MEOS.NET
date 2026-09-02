#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TNpoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNpoint : TSpatial
    {
        internal TNpoint(IntPtr ptr) : base(ptr) { }

        public Temporal? AtNpointset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtNpointset(this.Ptr, s.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(Meos.TnpointCumulativeLength(this.Ptr));

        public double Length()
            => Meos.TnpointLength(this.Ptr);

        public Temporal? MinusNpointset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusNpointset(this.Ptr, s.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusStbox(this.Ptr, box.Ptr, border_inc));

        public new string Out(int maxdd)
            => Meos.TnpointOut(this.Ptr, maxdd);

        public long Route()
            => Meos.TnpointRoute(this.Ptr);

        public Set? Routes()
            => MEOSFactory.WrapSet(Meos.TnpointRoutes(this.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TnpointSpeed(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TnpointToTgeompoint(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TnpointFromMfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TnpointIn(str));

    }
}
