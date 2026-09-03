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

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TposeAtElevation(this.Ptr, s.Ptr));

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TposeAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtPose(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.TposeAtPose(this.Ptr, pose.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TposeAtStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? ComposePose(Pose frame)
            => MEOSFactory.WrapTemporal(Meos.TposeComposePose(this.Ptr, frame.Ptr));

        public Temporal? ComposeTpose(Temporal frame)
            => MEOSFactory.WrapTemporal(Meos.TposeComposeTpose(this.Ptr, frame.Ptr));

        public Pose? EndValue()
            => MEOSFactory.WrapPose(Meos.TposeEndValue(this.Ptr));

        public Temporal? Inverse()
            => MEOSFactory.WrapTemporal(Meos.TposeInverse(this.Ptr));

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

        public Temporal? Pitch()
            => MEOSFactory.WrapTemporal(Meos.TposePitch(this.Ptr));

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TposePoints(this.Ptr));

        public Temporal? Roll()
            => MEOSFactory.WrapTemporal(Meos.TposeRoll(this.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TposeSpeed(this.Ptr));

        public Pose? StartValue()
            => MEOSFactory.WrapPose(Meos.TposeStartValue(this.Ptr));

        public Temporal? ToTpoint()
            => MEOSFactory.WrapTemporal(Meos.TposeToTpoint(this.Ptr));

        public Geo? Trajectory()
            => MEOSFactory.WrapGeo(Meos.TposeTrajectory(this.Ptr));

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

        public static Temporal? FromGeopose(string json)
            => MEOSFactory.WrapTemporal(Meos.TposeFromGeopose(json));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TposeFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TposeIn(str));

    }
}
