#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TCbuffer class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCbuffer : TSpatial
    {
        internal TCbuffer(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public Temporal? AtCbuffer(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtCbuffer(this.Ptr, cb.Ptr));

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TcbufferAtStbox(this.Ptr, box.Ptr, border_inc));

        public Geo? ConvexHull()
            => MEOSFactory.WrapGeo(Meos.TcbufferConvexHull(this.Ptr));

        public Cbuffer? EndValue()
            => MEOSFactory.WrapCbuffer(Meos.TcbufferEndValue(this.Ptr));

        public Temporal? Expand(double dist)
            => MEOSFactory.WrapTemporal(Meos.TcbufferExpand(this.Ptr, dist));

        public Temporal? Make(Temporal tfloat)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMake(this.Ptr, tfloat.Ptr));

        public Temporal? MinusCbuffer(Cbuffer cb)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusCbuffer(this.Ptr, cb.Ptr));

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusGeom(this.Ptr, gs.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TcbufferMinusStbox(this.Ptr, box.Ptr, border_inc));

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TcbufferPoints(this.Ptr));

        public Set? Radius()
            => MEOSFactory.WrapSet(Meos.TcbufferRadius(this.Ptr));

        public Temporal? Rotate(double angle, double x0, double y0)
            => MEOSFactory.WrapTemporal(Meos.TcbufferRotate(this.Ptr, angle, x0, y0));

        public Temporal? RotateZ(double angle)
            => MEOSFactory.WrapTemporal(Meos.TcbufferRotateZ(this.Ptr, angle));

        public Cbuffer? StartValue()
            => MEOSFactory.WrapCbuffer(Meos.TcbufferStartValue(this.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTfloat(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TcbufferToTgeompoint(this.Ptr));

        public Temporal? Translate(double deltax, double deltay)
            => MEOSFactory.WrapTemporal(Meos.TcbufferTranslate(this.Ptr, deltax, deltay));

        public Geo? TraversedArea(bool unary_union)
            => MEOSFactory.WrapGeo(Meos.TcbufferTraversedArea(this.Ptr, unary_union));

        public (SpanSet?[], Cbuffer?[]) Unnest()
        {
            var _answered = Meos.TcbufferUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapCbufferArray(_answered.Item2));
        }

        public Cbuffer? Value()
            => MEOSFactory.WrapCbuffer(Meos.TcbufferValue(this.Ptr));

        public Cbuffer? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TcbufferValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapCbuffer(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Cbuffer? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TcbufferValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapCbuffer(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Cbuffer?[] Values()
            => MEOSFactory.WrapCbufferArray(Meos.TcbufferValues(this.Ptr));

        public static Temporal? FromBaseTemp(Cbuffer cb, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TcbufferFromBaseTemp(cb.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TCbuffer.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TcbufferFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TCbuffer.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TcbufferIn(str));

    }
}
