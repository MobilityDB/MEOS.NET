#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A segment of a network route. A MeosType no membership predicate admits, so the coverage gate does not demand it; the 20 signatures naming it do.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Nsegment : Value
    {
        internal Nsegment(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public int Cmp(Nsegment ns2)
            => Meos.NsegmentCmp(this.Ptr, ns2.Ptr);

        public double EndPosition()
            => Meos.NsegmentEndPosition(this.Ptr);

        public bool Eq(Nsegment ns2)
            => Meos.NsegmentEq(this.Ptr, ns2.Ptr);

        public bool Ge(Nsegment ns2)
            => Meos.NsegmentGe(this.Ptr, ns2.Ptr);

        public bool Gt(Nsegment ns2)
            => Meos.NsegmentGt(this.Ptr, ns2.Ptr);

        public bool Le(Nsegment ns2)
            => Meos.NsegmentLe(this.Ptr, ns2.Ptr);

        public bool Lt(Nsegment ns2)
            => Meos.NsegmentLt(this.Ptr, ns2.Ptr);

        public bool Ne(Nsegment ns2)
            => Meos.NsegmentNe(this.Ptr, ns2.Ptr);

        public string Out(int maxdd)
            => Meos.NsegmentOut(this.Ptr, maxdd);

        public Nsegment? Round(int maxdd)
            => MEOSFactory.WrapNsegment(Meos.NsegmentRound(this.Ptr, maxdd));

        public long Route()
            => Meos.NsegmentRoute(this.Ptr);

        public int SRID()
            => Meos.NsegmentSrid(this.Ptr);

        public double StartPosition()
            => Meos.NsegmentStartPosition(this.Ptr);

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.NsegmentToGeom(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.NsegmentToStbox(this.Ptr));

        public static Nsegment? In(string str)
            => MEOSFactory.WrapNsegment(Meos.NsegmentIn(str));

        public static Nsegment? Make(long rid, double pos1, double pos2)
            => MEOSFactory.WrapNsegment(Meos.NsegmentMake(rid, pos1, pos2));

    }
}
