#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TCbuffer class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCbuffer : TSpatial
    {
        internal TCbuffer(IntPtr ptr) : base(ptr) { }

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? Expand(double dist)
            => MEOSFactory.WrapTemporal(Meos.TcbufferExpand(this.Ptr, dist));

        public Temporal? Make(Temporal tfloat)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMake(this.Ptr, tfloat.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusStbox(this.Ptr, box.Ptr, border_inc));

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TcbufferPoints(this.Ptr));

        public Set? Radius()
            => MEOSFactory.WrapSet(Meos.TcbufferRadius(this.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTfloat(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTgeompoint(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TcbufferFromMfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TcbufferIn(str));

    }
}
