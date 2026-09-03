#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The Pose class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Pose : Value
    {
        internal Pose(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public double AngularDistance(Pose pose2)
            => Meos.PoseAngularDistance(this.Ptr, pose2.Ptr);

        public Geo? ApplyGeo(Geo body)
            => MEOSFactory.WrapGeo(Meos.PoseApplyGeo(this.Ptr, body.Ptr));

        public string AsEWKT(int maxdd)
            => Meos.PoseAsEwkt(this.Ptr, maxdd);

        public string AsGeopose(int conformance, int precision)
            => Meos.PoseAsGeopose(this.Ptr, conformance, precision);

        public string AsHEXWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.PoseAsHexwkb(this.Ptr, variant, _size_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public string AsText(int maxdd)
            => Meos.PoseAsText(this.Ptr, maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.PoseAsWkb(this.Ptr, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public int Cmp(Pose pose2)
            => Meos.PoseCmp(this.Ptr, pose2.Ptr);

        public Pose? Compose(Pose frame)
            => MEOSFactory.WrapPose(Meos.PoseCompose(this.Ptr, frame.Ptr));

        public Temporal? ComposeTpose(Temporal frame)
            => MEOSFactory.WrapTemporal(Meos.PoseComposeTpose(this.Ptr, frame.Ptr));

        public Pose? Copy()
            => MEOSFactory.WrapPose(Meos.PoseCopy(this.Ptr));

        public bool Eq(Pose pose2)
            => Meos.PoseEq(this.Ptr, pose2.Ptr);

        public bool Ge(Pose pose2)
            => Meos.PoseGe(this.Ptr, pose2.Ptr);

        public bool Gt(Pose pose2)
            => Meos.PoseGt(this.Ptr, pose2.Ptr);

        public uint Hash()
            => Meos.PoseHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PoseHashExtended(this.Ptr, seed);

        public Pose? Inverse()
            => MEOSFactory.WrapPose(Meos.PoseInverse(this.Ptr));

        public bool Le(Pose pose2)
            => Meos.PoseLe(this.Ptr, pose2.Ptr);

        public bool Lt(Pose pose2)
            => Meos.PoseLt(this.Ptr, pose2.Ptr);

        public bool Ne(Pose pose2)
            => Meos.PoseNe(this.Ptr, pose2.Ptr);

        public Pose? Normalize()
            => MEOSFactory.WrapPose(Meos.PoseNormalize(this.Ptr));

        public bool Nsame(Pose pose2)
            => Meos.PoseNsame(this.Ptr, pose2.Ptr);

        public string Out(int maxdd)
            => Meos.PoseOut(this.Ptr, maxdd);

        public double Pitch()
            => Meos.PosePitch(this.Ptr);

        public double[] Quaternion()
            => Meos.PoseQuaternion(this.Ptr);

        public double Roll()
            => Meos.PoseRoll(this.Ptr);

        public Pose? Round(int maxdd)
            => MEOSFactory.WrapPose(Meos.PoseRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.PoseSrid(this.Ptr);

        public bool Same(Pose pose2)
            => Meos.PoseSame(this.Ptr, pose2.Ptr);

        public Pose? SetSRID(int srid)
            => MEOSFactory.WrapPose(Meos.PoseSetSrid(this.Ptr, srid));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.PoseTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Geo? ToPoint()
            => MEOSFactory.WrapGeo(Meos.PoseToPoint(this.Ptr));

        public PoseChain? ToPosechain()
            => MEOSFactory.WrapPoseChain(Meos.PoseToPosechain(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.PoseToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.PoseToStbox(this.Ptr));

        public Pose? Transform(int srid)
            => MEOSFactory.WrapPose(Meos.PoseTransform(this.Ptr, srid));

        public Pose? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapPose(Meos.PoseTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.PoseTstzspanToStbox(this.Ptr, s.Ptr));

        public double Yaw()
            => Meos.PoseYaw(this.Ptr);

        public double[] Ypr()
            => Meos.PoseYpr(this.Ptr);

        public static Pose? FromGeopose(string json)
            => MEOSFactory.WrapPose(Meos.PoseFromGeopose(json));

        public static Pose? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapPose(Meos.PoseFromHexwkb(hexwkb));

        public static Pose? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPose(Meos.PoseFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static Pose? In(string str)
            => MEOSFactory.WrapPose(Meos.PoseIn(str));

        public static Pose? Make2d(double x, double y, double theta, bool geodetic, int srid)
            => MEOSFactory.WrapPose(Meos.PoseMake2d(x, y, theta, geodetic, srid));

        public static Pose? Make3d(double x, double y, double z, double W, double X, double Y, double Z, bool geodetic, int srid)
            => MEOSFactory.WrapPose(Meos.PoseMake3d(x, y, z, W, X, Y, Z, geodetic, srid));

        public static Pose? MakePoint2d(Geo gs, double theta)
            => MEOSFactory.WrapPose(Meos.PoseMakePoint2d(gs.Ptr, theta));

        public static Pose? MakePoint3d(Geo gs, double W, double X, double Y, double Z)
            => MEOSFactory.WrapPose(Meos.PoseMakePoint3d(gs.Ptr, W, X, Y, Z));

        public static Pose? MakePoint3dYpr(Geo gs, double yaw, double pitch, double roll)
            => MEOSFactory.WrapPose(Meos.PoseMakePoint3dYpr(gs.Ptr, yaw, pitch, roll));

    }
}
