#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TNpoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNpoint : TSpatial
    {
        internal TNpoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int AlwaysEq(Npoint np)
            => Meos.AlwaysEqTnpointNpoint(this.Ptr, np.Ptr);

        public int AlwaysEq(TNpoint temp2)
            => Meos.AlwaysEqTnpointTnpoint(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Npoint np)
            => Meos.AlwaysNeTnpointNpoint(this.Ptr, np.Ptr);

        public int AlwaysNe(TNpoint temp2)
            => Meos.AlwaysNeTnpointTnpoint(this.Ptr, temp2.Ptr);

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtNpoint(Npoint np)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtNpoint(this.Ptr, np.Ptr));

        public Temporal? AtNpointset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtNpointset(this.Ptr, s.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtStbox(this.Ptr, box.Ptr, border_inc));

        public bool ContainedRid(BigIntSet s)
            => Meos.ContainedRidTnpointBigintset(this.Ptr, s.Ptr);

        public bool ContainedRid(TNpoint temp2)
            => Meos.ContainedRidTnpointTnpoint(this.Ptr, temp2.Ptr);

        public bool ContainsRid(long rid)
            => Meos.ContainsRidTnpointBigint(this.Ptr, rid);

        public bool ContainsRid(BigIntSet s)
            => Meos.ContainsRidTnpointBigintset(this.Ptr, s.Ptr);

        public bool ContainsRid(Npoint np)
            => Meos.ContainsRidTnpointNpoint(this.Ptr, np.Ptr);

        public bool ContainsRid(TNpoint temp2)
            => Meos.ContainsRidTnpointTnpoint(this.Ptr, temp2.Ptr);

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(Meos.TnpointCumulativeLength(this.Ptr));

        public Npoint? EndValue()
            => MEOSFactory.WrapNpoint(Meos.TnpointEndValue(this.Ptr));

        public int EverEq(Npoint np)
            => Meos.EverEqTnpointNpoint(this.Ptr, np.Ptr);

        public int EverEq(TNpoint temp2)
            => Meos.EverEqTnpointTnpoint(this.Ptr, temp2.Ptr);

        public int EverNe(Npoint np)
            => Meos.EverNeTnpointNpoint(this.Ptr, np.Ptr);

        public int EverNe(TNpoint temp2)
            => Meos.EverNeTnpointTnpoint(this.Ptr, temp2.Ptr);

        public double Length()
            => Meos.TnpointLength(this.Ptr);

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusGeom(this.Ptr, gs.Ptr));

        public Temporal? MinusNpoint(Npoint np)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusNpoint(this.Ptr, np.Ptr));

        public Temporal? MinusNpointset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusNpointset(this.Ptr, s.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusStbox(this.Ptr, box.Ptr, border_inc));

        public double Nad(Geometry gs)
            => Meos.NadTnpointGeo(this.Ptr, gs.Ptr);

        public double Nad(Npoint np)
            => Meos.NadTnpointNpoint(this.Ptr, np.Ptr);

        public double Nad(STBox box)
            => Meos.NadTnpointStbox(this.Ptr, box.Ptr);

        public double Nad(TNpoint temp2)
            => Meos.NadTnpointTnpoint(this.Ptr, temp2.Ptr);

        public Temporal? Nai(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.NaiTnpointGeo(this.Ptr, gs.Ptr));

        public Temporal? Nai(Npoint np)
            => MEOSFactory.WrapTemporal(Meos.NaiTnpointNpoint(this.Ptr, np.Ptr));

        public Temporal? Nai(TNpoint temp2)
            => MEOSFactory.WrapTemporal(Meos.NaiTnpointTnpoint(this.Ptr, temp2.Ptr));

        public new string Out(int maxdd)
            => Meos.TnpointOut(this.Ptr, maxdd);

        public bool OverlapsRid(BigIntSet s)
            => Meos.OverlapsRidTnpointBigintset(this.Ptr, s.Ptr);

        public bool OverlapsRid(TNpoint temp2)
            => Meos.OverlapsRidTnpointTnpoint(this.Ptr, temp2.Ptr);

        public Nsegment?[] Positions()
            => MEOSFactory.WrapNsegmentArray(Meos.TnpointPositions(this.Ptr));

        public bool RcontainedRid(long rid)
            => Meos.ContainedRidBigintTnpoint(rid, this.Ptr);

        public long Route()
            => Meos.TnpointRoute(this.Ptr);

        public Set? Routes()
            => MEOSFactory.WrapSet(Meos.TnpointRoutes(this.Ptr));

        public bool RsameRid(long rid)
            => Meos.SameRidBigintTnpoint(rid, this.Ptr);

        public bool SameRid(long rid)
            => Meos.SameRidTnpointBigint(this.Ptr, rid);

        public bool SameRid(BigIntSet s)
            => Meos.SameRidTnpointBigintset(this.Ptr, s.Ptr);

        public bool SameRid(Npoint np)
            => Meos.SameRidTnpointNpoint(this.Ptr, np.Ptr);

        public bool SameRid(TNpoint temp2)
            => Meos.SameRidTnpointTnpoint(this.Ptr, temp2.Ptr);

        public Geo? Shortestline(Geometry gs)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTnpointGeo(this.Ptr, gs.Ptr));

        public Geo? Shortestline(Npoint np)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTnpointNpoint(this.Ptr, np.Ptr));

        public Geo? Shortestline(TNpoint temp2)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTnpointTnpoint(this.Ptr, temp2.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TnpointSpeed(this.Ptr));

        public Npoint? StartValue()
            => MEOSFactory.WrapNpoint(Meos.TnpointStartValue(this.Ptr));

        public Temporal? Tdistance(Npoint np)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTnpointNpoint(this.Ptr, np.Ptr));

        public Temporal? Tdistance(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTnpointGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdistance(TNpoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTnpointTnpoint(this.Ptr, temp2.Ptr));

        public Temporal? Teq(Npoint np)
            => MEOSFactory.WrapTemporal(Meos.TeqTnpointNpoint(this.Ptr, np.Ptr));

        public Temporal? Tne(Npoint np)
            => MEOSFactory.WrapTemporal(Meos.TneTnpointNpoint(this.Ptr, np.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TnpointToTgeompoint(this.Ptr));

        public Geo? Trajectory()
            => MEOSFactory.WrapGeo(Meos.TnpointTrajectory(this.Ptr));

        public Geo? Twcentroid()
            => MEOSFactory.WrapGeo(Meos.TnpointTwcentroid(this.Ptr));

        public (SpanSet?[], Npoint?[]) Unnest()
        {
            var _answered = Meos.TnpointUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapNpointArray(_answered.Item2));
        }

        public Npoint? Value()
            => MEOSFactory.WrapNpoint(Meos.TnpointValue(this.Ptr));

        public Npoint? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TnpointValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapNpoint(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Npoint? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TnpointValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapNpoint(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Npoint?[] Values()
            => MEOSFactory.WrapNpointArray(Meos.TnpointValues(this.Ptr));

        public static Temporal? FromBaseTemp(Npoint np, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TnpointFromBaseTemp(np.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TNpoint.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TnpointFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TNpoint.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TnpointIn(str));

    }
}
