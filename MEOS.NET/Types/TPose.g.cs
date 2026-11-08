#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TPose class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPose : TSpatial
    {
        internal TPose(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Above(TPose temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Adjacent(TPose temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool After(TPose temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Pose pose)
            => Meos.AlwaysEqTposePose(this.Ptr, pose.Ptr);

        public int AlwaysEq(TPose temp2)
            => Meos.AlwaysEqTposeTpose(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Pose pose)
            => Meos.AlwaysNeTposePose(this.Ptr, pose.Ptr);

        public int AlwaysNe(TPose temp2)
            => Meos.AlwaysNeTposeTpose(this.Ptr, temp2.Ptr);

        public Temporal? AngularSpeed()
            => MEOSFactory.WrapTemporal(Meos.TposeAngularSpeed(this.Ptr));

        public Temporal? ApplyGeo(Geo body)
            => MEOSFactory.WrapTemporal(Meos.TposeApplyGeo(this.Ptr, body.Ptr));

        public string AsGeopose(int conformance, int precision)
            => Meos.TposeAsGeopose(this.Ptr, conformance, precision);

        public string AsGeoposeStream(int precision)
            => Meos.TposeAsGeoposeStream(this.Ptr, precision);

        public string AsGeoposeStreamElement(Temporal inst, int precision)
            => Meos.TposeAsGeoposeStreamElement(this.Ptr, inst.Ptr, precision);

        public string AsGeoposeStreamHeader(int precision)
            => Meos.TposeAsGeoposeStreamHeader(this.Ptr, precision);

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TposeAtElevation(this.Ptr, s.Ptr));

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TposeAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtPose(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.TposeAtPose(this.Ptr, pose.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TposeAtStbox(this.Ptr, box.Ptr, border_inc));

        public bool Back(TPose temp2)
            => Meos.BackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Before(TPose temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(TPose temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? ComposePose(Pose frame)
            => MEOSFactory.WrapTemporal(Meos.TposeComposePose(this.Ptr, frame.Ptr));

        public Temporal? ComposeTpose(Temporal frame)
            => MEOSFactory.WrapTemporal(Meos.TposeComposeTpose(this.Ptr, frame.Ptr));

        public bool Contained(TPose temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TPose temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Edwithin(Geography gs, double dist, bool spheroid)
            => Meos.EdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Edwithin(Geometry gs, double dist, bool spheroid)
            => Meos.EdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Edwithin(TPose temp2, double dist, bool spheroid)
            => Meos.EdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public int Eintersects(Geography gs)
            => Meos.EintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Eintersects(Geometry gs)
            => Meos.EintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Eintersects(TPose temp2)
            => Meos.EintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public Pose? EndValue()
            => MEOSFactory.WrapPose(Meos.TposeEndValue(this.Ptr));

        public int EverEq(Pose pose)
            => Meos.EverEqTposePose(this.Ptr, pose.Ptr);

        public int EverEq(TPose temp2)
            => Meos.EverEqTposeTpose(this.Ptr, temp2.Ptr);

        public int EverNe(Pose pose)
            => Meos.EverNeTposePose(this.Ptr, pose.Ptr);

        public int EverNe(TPose temp2)
            => Meos.EverNeTposeTpose(this.Ptr, temp2.Ptr);

        public Temporal? Force2d()
            => MEOSFactory.WrapTemporal(Meos.TposeForce2d(this.Ptr));

        public bool Front(TPose temp2)
            => Meos.FrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Inverse()
            => MEOSFactory.WrapTemporal(Meos.TposeInverse(this.Ptr));

        public bool Left(TPose temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Make(Temporal ttheta)
            => MEOSFactory.WrapTemporal(Meos.TposeMake(this.Ptr, ttheta.Ptr));

        public Temporal? MinusElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TposeMinusElevation(this.Ptr, s.Ptr));

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TposeMinusGeom(this.Ptr, gs.Ptr));

        public Temporal? MinusPose(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.TposeMinusPose(this.Ptr, pose.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TposeMinusStbox(this.Ptr, box.Ptr, border_inc));

        public double Nad(Geo gs)
            => Meos.NadTposeGeo(this.Ptr, gs.Ptr);

        public double Nad(Pose pose)
            => Meos.NadTposePose(this.Ptr, pose.Ptr);

        public double Nad(STBox box)
            => Meos.NadTposeStbox(this.Ptr, box.Ptr);

        public double Nad(TPose temp2)
            => Meos.NadTposeTpose(this.Ptr, temp2.Ptr);

        public double Nad(Geography gs)
            => Meos.NadTposeGeo(this.Ptr, gs.Ptr);

        public double Nad(Geometry gs)
            => Meos.NadTposeGeo(this.Ptr, gs.Ptr);

        public Temporal? Nai(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.NaiTposeGeo(this.Ptr, gs.Ptr));

        public Temporal? Nai(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.NaiTposePose(this.Ptr, pose.Ptr));

        public Temporal? Nai(TPose temp2)
            => MEOSFactory.WrapTemporal(Meos.NaiTposeTpose(this.Ptr, temp2.Ptr));

        public Temporal? Nai(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.NaiTposeGeo(this.Ptr, gs.Ptr));

        public Temporal? Nai(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.NaiTposeGeo(this.Ptr, gs.Ptr));

        public bool Overabove(TPose temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TPose temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overback(TPose temp2)
            => Meos.OverbackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TPose temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TPose temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overfront(TPose temp2)
            => Meos.OverfrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TPose temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TPose temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TPose temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Pitch()
            => MEOSFactory.WrapTemporal(Meos.TposePitch(this.Ptr));

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TposePoints(this.Ptr));

        public bool Right(TPose temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Roll()
            => MEOSFactory.WrapTemporal(Meos.TposeRoll(this.Ptr));

        public Temporal? Rotate(double angle, double x0, double y0)
            => MEOSFactory.WrapTemporal(Meos.TposeRotate(this.Ptr, angle, x0, y0));

        public Temporal? RotateX(double angle)
            => MEOSFactory.WrapTemporal(Meos.TposeRotateX(this.Ptr, angle));

        public Temporal? RotateY(double angle)
            => MEOSFactory.WrapTemporal(Meos.TposeRotateY(this.Ptr, angle));

        public Temporal? RotateZ(double angle)
            => MEOSFactory.WrapTemporal(Meos.TposeRotateZ(this.Ptr, angle));

        public bool Same(TPose temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? Shortestline(Geo gs)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTposeGeo(this.Ptr, gs.Ptr));

        public Geo? Shortestline(Pose pose)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTposePose(this.Ptr, pose.Ptr));

        public Geo? Shortestline(TPose temp2)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTposeTpose(this.Ptr, temp2.Ptr));

        public Geo? Shortestline(Geography gs)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTposeGeo(this.Ptr, gs.Ptr));

        public Geo? Shortestline(Geometry gs)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTposeGeo(this.Ptr, gs.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TposeSpeed(this.Ptr));

        public Pose? StartValue()
            => MEOSFactory.WrapPose(Meos.TposeStartValue(this.Ptr));

        public Temporal? Tdistance(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTposePose(this.Ptr, pose.Ptr));

        public Temporal? Tdistance(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTposeGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdistance(TPose temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTposeTpose(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTposeGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdistance(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTposeGeo(this.Ptr, gs.Ptr));

        public Temporal? Teq(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.TeqTposePose(this.Ptr, pose.Ptr));

        public Temporal? Teq(TPose temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.TneTposePose(this.Ptr, pose.Ptr));

        public Temporal? Tne(TPose temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TposeToTgeogpoint(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TposeToTgeompoint(this.Ptr));

        public Temporal? ToTpoint()
            => MEOSFactory.WrapTemporal(Meos.TposeToTpoint(this.Ptr));

        public Geo? Trajectory()
            => MEOSFactory.WrapGeo(Meos.TposeTrajectory(this.Ptr));

        public Temporal? Translate(double deltax, double deltay, double deltaz)
            => MEOSFactory.WrapTemporal(Meos.TposeTranslate(this.Ptr, deltax, deltay, deltaz));

        public (SpanSet?[], Pose?[]) Unnest()
        {
            var _answered = Meos.TposeUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapPoseArray(_answered.Item2));
        }

        public Pose? Value()
            => MEOSFactory.WrapPose(Meos.TposeValue(this.Ptr));

        public Pose? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TposeValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPose(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Pose? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TposeValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPose(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Pose?[] Values()
            => MEOSFactory.WrapPoseArray(Meos.TposeValues(this.Ptr));

        public Temporal? Yaw()
            => MEOSFactory.WrapTemporal(Meos.TposeYaw(this.Ptr));

        public static Temporal? FromBaseTemp(Pose pose, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TposeFromBaseTemp(pose.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TPose.In(str);

        public static Temporal? FromGeopose(string json)
            => MEOSFactory.WrapTemporal(Meos.TposeFromGeopose(json));

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TposeFromMfjson(str));

        public static Temporal? FromText(string str)
            => TPose.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TposeIn(str));

    }
}
