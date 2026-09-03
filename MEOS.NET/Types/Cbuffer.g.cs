#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The Cbuffer class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Cbuffer : Value
    {
        internal Cbuffer(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public string AsEWKT(int maxdd)
            => Meos.CbufferAsEwkt(this.Ptr, maxdd);

        public string AsText(int maxdd)
            => Meos.CbufferAsText(this.Ptr, maxdd);

        public int Cmp(Cbuffer cb2)
            => Meos.CbufferCmp(this.Ptr, cb2.Ptr);

        public Cbuffer? Copy()
            => MEOSFactory.WrapCbuffer(Meos.CbufferCopy(this.Ptr));

        public bool Eq(Cbuffer cb2)
            => Meos.CbufferEq(this.Ptr, cb2.Ptr);

        public bool Ge(Cbuffer cb2)
            => Meos.CbufferGe(this.Ptr, cb2.Ptr);

        public bool Gt(Cbuffer cb2)
            => Meos.CbufferGt(this.Ptr, cb2.Ptr);

        public uint Hash()
            => Meos.CbufferHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.CbufferHashExtended(this.Ptr, seed);

        public bool Le(Cbuffer cb2)
            => Meos.CbufferLe(this.Ptr, cb2.Ptr);

        public bool Lt(Cbuffer cb2)
            => Meos.CbufferLt(this.Ptr, cb2.Ptr);

        public bool Ne(Cbuffer cb2)
            => Meos.CbufferNe(this.Ptr, cb2.Ptr);

        public bool Nsame(Cbuffer cb2)
            => Meos.CbufferNsame(this.Ptr, cb2.Ptr);

        public string Out(int maxdd)
            => Meos.CbufferOut(this.Ptr, maxdd);

        public Geo? Point()
            => MEOSFactory.WrapGeo(Meos.CbufferPoint(this.Ptr));

        public double Radius()
            => Meos.CbufferRadius(this.Ptr);

        public Cbuffer? Round(int maxdd)
            => MEOSFactory.WrapCbuffer(Meos.CbufferRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.CbufferSrid(this.Ptr);

        public bool Same(Cbuffer cb2)
            => Meos.CbufferSame(this.Ptr, cb2.Ptr);

        public Cbuffer? SetSRID(int srid)
            => MEOSFactory.WrapCbuffer(Meos.CbufferSetSrid(this.Ptr, srid));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.CbufferTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.CbufferToGeom(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.CbufferToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.CbufferToStbox(this.Ptr));

        public Cbuffer? Transform(int srid)
            => MEOSFactory.WrapCbuffer(Meos.CbufferTransform(this.Ptr, srid));

        public Cbuffer? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapCbuffer(Meos.CbufferTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.CbufferTstzspanToStbox(this.Ptr, s.Ptr));

        public static Cbuffer? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapCbuffer(Meos.CbufferFromHexwkb(hexwkb));

        public static Cbuffer? In(string str)
            => MEOSFactory.WrapCbuffer(Meos.CbufferIn(str));

        public static Cbuffer? Make(Geo point, double radius)
            => MEOSFactory.WrapCbuffer(Meos.CbufferMake(point.Ptr, radius));

    }
}
