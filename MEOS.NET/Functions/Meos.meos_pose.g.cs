using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_pose.h</c> declares.</summary>
    public static partial class Meos
    {
        public static string PoseAsEwkt(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => Native.PoseAsEwkt(pose, maxdd));

        public static string PoseAsHexwkb(IntPtr pose, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.PoseAsHexwkb(pose, variant, size_out));

        public static string PoseAsText(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => Native.PoseAsText(pose, maxdd));

        public static IntPtr PoseAsWkb(IntPtr pose, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.PoseAsWkb(pose, variant, size_out));

        public static IntPtr PoseFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.PoseFromWkb(wkb, size));

        public static IntPtr PoseFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.PoseFromHexwkb(hexwkb));

        public static IntPtr PoseIn(string str)
            => SafeExecution<IntPtr>(() => Native.PoseIn(str));

        public static string PoseOut(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => Native.PoseOut(pose, maxdd));

        public static IntPtr PoseFromGeopose(string json)
            => SafeExecution<IntPtr>(() => Native.PoseFromGeopose(json));

        public static string PoseAsGeopose(IntPtr pose, int conformance, int precision)
            => SafeExecution<string>(() => Native.PoseAsGeopose(pose, conformance, precision));

        public static IntPtr TposeFromGeopose(string json)
            => SafeExecution<IntPtr>(() => Native.TposeFromGeopose(json));

        public static string TposeAsGeopose(IntPtr temp, int conformance, int precision)
            => SafeExecution<string>(() => Native.TposeAsGeopose(temp, conformance, precision));

        public static string TposeAsGeoposeStreamHeader(IntPtr temp, int precision)
            => SafeExecution<string>(() => Native.TposeAsGeoposeStreamHeader(temp, precision));

        public static string TposeAsGeoposeStreamElement(IntPtr temp, IntPtr inst, int precision)
            => SafeExecution<string>(() => Native.TposeAsGeoposeStreamElement(temp, inst, precision));

        public static string TposeAsGeoposeStream(IntPtr temp, int precision)
            => SafeExecution<string>(() => Native.TposeAsGeoposeStream(temp, precision));

        public static IntPtr[] GeoposeFrames()
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoposeFrames(_cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 48); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr GeoposeFrame(int frame_id)
            => SafeExecution<IntPtr>(() => Native.GeoposeFrame(frame_id));

        public static IntPtr PoseApplyGeo(IntPtr pose, IntPtr body)
            => SafeExecution<IntPtr>(() => Native.PoseApplyGeo(pose, body));

        public static IntPtr TposeApplyGeo(IntPtr temp, IntPtr body)
            => SafeExecution<IntPtr>(() => Native.TposeApplyGeo(temp, body));

        public static IntPtr TposeComposePose(IntPtr body, IntPtr frame)
            => SafeExecution<IntPtr>(() => Native.TposeComposePose(body, frame));

        public static IntPtr PoseComposeTpose(IntPtr body, IntPtr frame)
            => SafeExecution<IntPtr>(() => Native.PoseComposeTpose(body, frame));

        public static IntPtr TposeComposeTpose(IntPtr body, IntPtr frame)
            => SafeExecution<IntPtr>(() => Native.TposeComposeTpose(body, frame));

        public static IntPtr TposeInverse(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeInverse(temp));

        public static IntPtr PoseCopy(IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PoseCopy(pose));

        public static IntPtr PoseMake2d(double x, double y, double theta, bool geodetic, int srid)
            => SafeExecution<IntPtr>(() => Native.PoseMake2d(x, y, theta, geodetic, srid));

        public static IntPtr PoseMake3d(double x, double y, double z, double W, double X, double Y, double Z, bool geodetic, int srid)
            => SafeExecution<IntPtr>(() => Native.PoseMake3d(x, y, z, W, X, Y, Z, geodetic, srid));

        public static IntPtr PoseMakePoint2d(IntPtr gs, double theta)
            => SafeExecution<IntPtr>(() => Native.PoseMakePoint2d(gs, theta));

        public static IntPtr PoseMakePoint3d(IntPtr gs, double W, double X, double Y, double Z)
            => SafeExecution<IntPtr>(() => Native.PoseMakePoint3d(gs, W, X, Y, Z));

        public static IntPtr PoseMakePoint3dYpr(IntPtr gs, double yaw, double pitch, double roll)
            => SafeExecution<IntPtr>(() => Native.PoseMakePoint3dYpr(gs, yaw, pitch, roll));

        public static IntPtr PoseToPoint(IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PoseToPoint(pose));

        public static IntPtr PoseToStbox(IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PoseToStbox(pose));

        public static uint PoseHash(IntPtr pose)
            => SafeExecution<uint>(() => Native.PoseHash(pose));

        public static ulong PoseHashExtended(IntPtr pose, ulong seed)
            => SafeExecution<ulong>(() => Native.PoseHashExtended(pose, seed));

        public static double[] PoseQuaternion(IntPtr pose)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PoseQuaternion(pose, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                double[] _out = new double[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double[] PoseYpr(IntPtr pose)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PoseYpr(pose, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                double[] _out = new double[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double PoseYaw(IntPtr pose)
            => SafeExecution<double>(() => Native.PoseYaw(pose));

        public static double PosePitch(IntPtr pose)
            => SafeExecution<double>(() => Native.PosePitch(pose));

        public static double PoseRoll(IntPtr pose)
            => SafeExecution<double>(() => Native.PoseRoll(pose));

        public static double PoseAngularDistance(IntPtr pose1, IntPtr pose2)
            => SafeExecution<double>(() => Native.PoseAngularDistance(pose1, pose2));

        public static IntPtr PoseCompose(IntPtr body, IntPtr frame)
            => SafeExecution<IntPtr>(() => Native.PoseCompose(body, frame));

        public static IntPtr PoseInverse(IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PoseInverse(pose));

        public static IntPtr PoseNormalize(IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PoseNormalize(pose));

        public static IntPtr PoseRound(IntPtr pose, int maxdd)
            => SafeExecution<IntPtr>(() => Native.PoseRound(pose, maxdd));

        public static IntPtr PosearrRound(IntPtr posearr, int count, int maxdd)
            => SafeExecution<IntPtr>(() => Native.PosearrRound(posearr, count, maxdd));

        public static IntPtr PoseSetSrid(IntPtr pose, int srid)
            => SafeExecution<IntPtr>(() => Native.PoseSetSrid(pose, srid));

        public static int PoseSrid(IntPtr pose)
            => SafeExecution<int>(() => Native.PoseSrid(pose));

        public static IntPtr PoseTransform(IntPtr pose, int srid)
            => SafeExecution<IntPtr>(() => Native.PoseTransform(pose, srid));

        public static IntPtr PoseTransformPipeline(IntPtr pose, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => Native.PoseTransformPipeline(pose, pipelinestr, srid, is_forward));

        public static IntPtr PoseTstzspanToStbox(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PoseTstzspanToStbox(pose, s));

        public static IntPtr PoseTimestamptzToStbox(IntPtr pose, long t)
            => SafeExecution<IntPtr>(() => Native.PoseTimestamptzToStbox(pose, t));

        public static double DistancePoseGeo(IntPtr pose, IntPtr gs)
            => SafeExecution<double>(() => Native.DistancePoseGeo(pose, gs));

        public static double DistancePosePose(IntPtr pose1, IntPtr pose2)
            => SafeExecution<double>(() => Native.DistancePosePose(pose1, pose2));

        public static double DistancePoseStbox(IntPtr pose, IntPtr box)
            => SafeExecution<double>(() => Native.DistancePoseStbox(pose, box));

        public static int PoseCmp(IntPtr pose1, IntPtr pose2)
            => SafeExecution<int>(() => Native.PoseCmp(pose1, pose2));

        public static bool PoseEq(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => Native.PoseEq(pose1, pose2));

        public static bool PoseGe(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => Native.PoseGe(pose1, pose2));

        public static bool PoseGt(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => Native.PoseGt(pose1, pose2));

        public static bool PoseLe(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => Native.PoseLe(pose1, pose2));

        public static bool PoseLt(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => Native.PoseLt(pose1, pose2));

        public static bool PoseNe(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => Native.PoseNe(pose1, pose2));

        public static bool PoseNsame(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => Native.PoseNsame(pose1, pose2));

        public static bool PoseSame(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => Native.PoseSame(pose1, pose2));

        public static IntPtr PosesetIn(string str)
            => SafeExecution<IntPtr>(() => Native.PosesetIn(str));

        public static string PosesetOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.PosesetOut(s, maxdd));

        public static IntPtr PosesetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.PosesetMake(values, count));

        public static IntPtr PoseToSet(IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PoseToSet(pose));

        public static IntPtr PosesetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PosesetEndValue(s));

        public static IntPtr PosesetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PosesetStartValue(s));

        public static bool PosesetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.PosesetValueN(s, n, result));

        public static IntPtr[] PosesetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PosesetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool ContainedPoseSet(IntPtr pose, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedPoseSet(pose, s));

        public static bool ContainsSetPose(IntPtr s, IntPtr pose)
            => SafeExecution<bool>(() => Native.ContainsSetPose(s, pose));

        public static IntPtr IntersectionPoseSet(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionPoseSet(pose, s));

        public static IntPtr IntersectionSetPose(IntPtr s, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetPose(s, pose));

        public static IntPtr MinusPoseSet(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusPoseSet(pose, s));

        public static IntPtr MinusSetPose(IntPtr s, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.MinusSetPose(s, pose));

        public static IntPtr PoseUnionTransfn(IntPtr state, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PoseUnionTransfn(state, pose));

        public static IntPtr UnionPoseSet(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionPoseSet(pose, s));

        public static IntPtr UnionSetPose(IntPtr s, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.UnionSetPose(s, pose));

        public static IntPtr TposeFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TposeFromMfjson(str));

        public static IntPtr TposeIn(string str)
            => SafeExecution<IntPtr>(() => Native.TposeIn(str));

        public static IntPtr TposeinstMake(IntPtr pose, long t)
            => SafeExecution<IntPtr>(() => Native.TposeinstMake(pose, t));

        public static IntPtr TposeFromBaseTemp(IntPtr pose, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeFromBaseTemp(pose, temp));

        public static IntPtr TposeseqFromBaseTstzset(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TposeseqFromBaseTstzset(pose, s));

        public static IntPtr TposeseqFromBaseTstzspan(IntPtr pose, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => Native.TposeseqFromBaseTstzspan(pose, s, interp));

        public static IntPtr TposeseqsetFromBaseTstzspanset(IntPtr pose, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => Native.TposeseqsetFromBaseTstzspanset(pose, ss, interp));

        public static IntPtr TposeMake(IntPtr tpoint, IntPtr ttheta)
            => SafeExecution<IntPtr>(() => Native.TposeMake(tpoint, ttheta));

        public static IntPtr TposeToTpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeToTpoint(temp));

        public static IntPtr TposeEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeEndValue(temp));

        public static IntPtr TposePoints(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposePoints(temp));

        public static IntPtr TposeYaw(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeYaw(temp));

        public static IntPtr TposePitch(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposePitch(temp));

        public static IntPtr TposeRoll(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeRoll(temp));

        public static IntPtr TposeSpeed(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeSpeed(temp));

        public static IntPtr TposeAngularSpeed(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeAngularSpeed(temp));

        public static IntPtr TposeStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeStartValue(temp));

        public static IntPtr TposeTrajectory(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposeTrajectory(temp));

        public static bool TposeValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.TposeValueAtTimestamptz(temp, t, strict, result));

        public static bool TposeValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TposeValueN(temp, n, result));

        public static IntPtr[] TposeValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TposeValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TposeAtElevation(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TposeAtElevation(temp, s));

        public static IntPtr TposeAtGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TposeAtGeom(temp, gs));

        public static IntPtr TposeAtStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TposeAtStbox(temp, box, border_inc));

        public static IntPtr TposeAtPose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.TposeAtPose(temp, pose));

        public static IntPtr TposeMinusElevation(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TposeMinusElevation(temp, s));

        public static IntPtr TposeMinusGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TposeMinusGeom(temp, gs));

        public static IntPtr TposeMinusPose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.TposeMinusPose(temp, pose));

        public static IntPtr TposeMinusStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TposeMinusStbox(temp, box, border_inc));

        public static IntPtr TdistanceTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.TdistanceTposePose(temp, pose));

        public static IntPtr TdistanceTposeGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TdistanceTposeGeo(temp, gs));

        public static IntPtr TdistanceTposeTpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdistanceTposeTpose(temp1, temp2));

        public static double NadTposeGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => Native.NadTposeGeo(temp, gs));

        public static double NadTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<double>(() => Native.NadTposePose(temp, pose));

        public static double NadTposeStbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => Native.NadTposeStbox(temp, box));

        public static double NadTposeTpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.NadTposeTpose(temp1, temp2));

        public static IntPtr NaiTposeGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.NaiTposeGeo(temp, gs));

        public static IntPtr NaiTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.NaiTposePose(temp, pose));

        public static IntPtr NaiTposeTpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.NaiTposeTpose(temp1, temp2));

        public static IntPtr ShortestlineTposeGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTposeGeo(temp, gs));

        public static IntPtr ShortestlineTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTposePose(temp, pose));

        public static IntPtr ShortestlineTposeTpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTposeTpose(temp1, temp2));

        public static int AlwaysEqPoseTpose(IntPtr pose, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqPoseTpose(pose, temp));

        public static int AlwaysEqTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<int>(() => Native.AlwaysEqTposePose(temp, pose));

        public static int AlwaysEqTposeTpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTposeTpose(temp1, temp2));

        public static int AlwaysNePoseTpose(IntPtr pose, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNePoseTpose(pose, temp));

        public static int AlwaysNeTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<int>(() => Native.AlwaysNeTposePose(temp, pose));

        public static int AlwaysNeTposeTpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTposeTpose(temp1, temp2));

        public static int EverEqPoseTpose(IntPtr pose, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqPoseTpose(pose, temp));

        public static int EverEqTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<int>(() => Native.EverEqTposePose(temp, pose));

        public static int EverEqTposeTpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTposeTpose(temp1, temp2));

        public static int EverNePoseTpose(IntPtr pose, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNePoseTpose(pose, temp));

        public static int EverNeTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<int>(() => Native.EverNeTposePose(temp, pose));

        public static int EverNeTposeTpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTposeTpose(temp1, temp2));

        public static IntPtr TeqPoseTpose(IntPtr pose, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqPoseTpose(pose, temp));

        public static IntPtr TeqTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.TeqTposePose(temp, pose));

        public static IntPtr TnePoseTpose(IntPtr pose, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnePoseTpose(pose, temp));

        public static IntPtr TneTposePose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.TneTposePose(temp, pose));

        public static IntPtr PosechainIn(string str)
            => SafeExecution<IntPtr>(() => Native.PosechainIn(str));

        public static string PosechainOut(IntPtr pc, int maxdd)
            => SafeExecution<string>(() => Native.PosechainOut(pc, maxdd));

        public static string PosechainAsText(IntPtr pc, int maxdd)
            => SafeExecution<string>(() => Native.PosechainAsText(pc, maxdd));

        public static string PosechainAsEwkt(IntPtr pc, int maxdd)
            => SafeExecution<string>(() => Native.PosechainAsEwkt(pc, maxdd));

        public static IntPtr PosechainAsWkb(IntPtr pc, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.PosechainAsWkb(pc, variant, size_out));

        public static string PosechainAsHexwkb(IntPtr pc, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.PosechainAsHexwkb(pc, variant, size_out));

        public static IntPtr PosechainFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.PosechainFromWkb(wkb, size));

        public static IntPtr PosechainFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.PosechainFromHexwkb(hexwkb));

        public static IntPtr PosechainMake(IntPtr poses, int count)
            => SafeExecution<IntPtr>(() => Native.PosechainMake(poses, count));

        public static IntPtr PosechainCopy(IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.PosechainCopy(pc));

        public static IntPtr PosechainAppend(IntPtr pc, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PosechainAppend(pc, pose));

        public static IntPtr PoseToPosechain(IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.PoseToPosechain(pose));

        public static IntPtr PosechainToPose(IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.PosechainToPose(pc));

        public static IntPtr PosechainPrefixPose(IntPtr pc, int n)
            => SafeExecution<IntPtr>(() => Native.PosechainPrefixPose(pc, n));

        public static IntPtr PosechainToPoint(IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.PosechainToPoint(pc));

        public static IntPtr PosechainToStbox(IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.PosechainToStbox(pc));

        public static IntPtr PosechainTimestamptzToStbox(IntPtr pc, long t)
            => SafeExecution<IntPtr>(() => Native.PosechainTimestamptzToStbox(pc, t));

        public static IntPtr PosechainTstzspanToStbox(IntPtr pc, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PosechainTstzspanToStbox(pc, s));

        public static int PosechainNumPoses(IntPtr pc)
            => SafeExecution<int>(() => Native.PosechainNumPoses(pc));

        public static IntPtr PosechainStartPose(IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.PosechainStartPose(pc));

        public static IntPtr PosechainEndPose(IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.PosechainEndPose(pc));

        public static IntPtr PosechainPoseN(IntPtr pc, int n)
            => SafeExecution<IntPtr>(() => Native.PosechainPoseN(pc, n));

        public static IntPtr[] PosechainPoses(IntPtr pc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PosechainPoses(pc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static uint PosechainHash(IntPtr pc)
            => SafeExecution<uint>(() => Native.PosechainHash(pc));

        public static ulong PosechainHashExtended(IntPtr pc, ulong seed)
            => SafeExecution<ulong>(() => Native.PosechainHashExtended(pc, seed));

        public static IntPtr PosechainRound(IntPtr pc, int maxdd)
            => SafeExecution<IntPtr>(() => Native.PosechainRound(pc, maxdd));

        public static int PosechainSrid(IntPtr pc)
            => SafeExecution<int>(() => Native.PosechainSrid(pc));

        public static IntPtr PosechainSetSrid(IntPtr pc, int srid)
            => SafeExecution<IntPtr>(() => Native.PosechainSetSrid(pc, srid));

        public static IntPtr PosechainTransform(IntPtr pc, int srid_to)
            => SafeExecution<IntPtr>(() => Native.PosechainTransform(pc, srid_to));

        public static IntPtr PosechainTransformPipeline(IntPtr pc, string pipeline, int srid_to, bool is_forward)
            => SafeExecution<IntPtr>(() => Native.PosechainTransformPipeline(pc, pipeline, srid_to, is_forward));

        public static IntPtr TposechainFromGeopose(string json)
            => SafeExecution<IntPtr>(() => Native.TposechainFromGeopose(json));

        public static string TposechainAsGeopose(IntPtr temp, int precision)
            => SafeExecution<string>(() => Native.TposechainAsGeopose(temp, precision));

        public static string TposechainarrAsGeopose(IntPtr temparr, int count, int precision)
            => SafeExecution<string>(() => Native.TposechainarrAsGeopose(temparr, count, precision));

        public static bool PosechainEq(IntPtr pc1, IntPtr pc2)
            => SafeExecution<bool>(() => Native.PosechainEq(pc1, pc2));

        public static bool PosechainNe(IntPtr pc1, IntPtr pc2)
            => SafeExecution<bool>(() => Native.PosechainNe(pc1, pc2));

        public static bool PosechainSame(IntPtr pc1, IntPtr pc2)
            => SafeExecution<bool>(() => Native.PosechainSame(pc1, pc2));

        public static bool PosechainNsame(IntPtr pc1, IntPtr pc2)
            => SafeExecution<bool>(() => Native.PosechainNsame(pc1, pc2));

        public static int PosechainCmp(IntPtr pc1, IntPtr pc2)
            => SafeExecution<int>(() => Native.PosechainCmp(pc1, pc2));

        public static bool PosechainLt(IntPtr pc1, IntPtr pc2)
            => SafeExecution<bool>(() => Native.PosechainLt(pc1, pc2));

        public static bool PosechainLe(IntPtr pc1, IntPtr pc2)
            => SafeExecution<bool>(() => Native.PosechainLe(pc1, pc2));

        public static bool PosechainGt(IntPtr pc1, IntPtr pc2)
            => SafeExecution<bool>(() => Native.PosechainGt(pc1, pc2));

        public static bool PosechainGe(IntPtr pc1, IntPtr pc2)
            => SafeExecution<bool>(() => Native.PosechainGe(pc1, pc2));

        public static IntPtr PosechainsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.PosechainsetIn(str));

        public static string PosechainsetOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.PosechainsetOut(s, maxdd));

        public static IntPtr PosechainsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.PosechainsetMake(values, count));

        public static IntPtr PosechainToSet(IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.PosechainToSet(pc));

        public static IntPtr PosechainsetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PosechainsetEndValue(s));

        public static IntPtr PosechainsetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PosechainsetStartValue(s));

        public static bool PosechainsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.PosechainsetValueN(s, n, result));

        public static IntPtr[] PosechainsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PosechainsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool ContainedPosechainSet(IntPtr pc, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedPosechainSet(pc, s));

        public static bool ContainsSetPosechain(IntPtr s, IntPtr pc)
            => SafeExecution<bool>(() => Native.ContainsSetPosechain(s, pc));

        public static IntPtr IntersectionPosechainSet(IntPtr pc, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionPosechainSet(pc, s));

        public static IntPtr IntersectionSetPosechain(IntPtr s, IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetPosechain(s, pc));

        public static IntPtr MinusPosechainSet(IntPtr pc, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusPosechainSet(pc, s));

        public static IntPtr MinusSetPosechain(IntPtr s, IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.MinusSetPosechain(s, pc));

        public static IntPtr PosechainUnionTransfn(IntPtr state, IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.PosechainUnionTransfn(state, pc));

        public static IntPtr UnionPosechainSet(IntPtr pc, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionPosechainSet(pc, s));

        public static IntPtr UnionSetPosechain(IntPtr s, IntPtr pc)
            => SafeExecution<IntPtr>(() => Native.UnionSetPosechain(s, pc));

        public static IntPtr TposechainIn(string str)
            => SafeExecution<IntPtr>(() => Native.TposechainIn(str));

        public static IntPtr TposechainFromMfjson(string mfjson)
            => SafeExecution<IntPtr>(() => Native.TposechainFromMfjson(mfjson));

        public static IntPtr TposechainFromBaseTemp(IntPtr pc, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposechainFromBaseTemp(pc, temp));

        public static IntPtr TposechainToTpose(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TposechainToTpose(temp));

        public static int TposechainNumPoses(IntPtr temp)
            => SafeExecution<int>(() => Native.TposechainNumPoses(temp));

        public static int AlwaysEqPosechainTposechain(IntPtr posechain, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqPosechainTposechain(posechain, temp));

        public static int AlwaysEqTposechainPosechain(IntPtr temp, IntPtr posechain)
            => SafeExecution<int>(() => Native.AlwaysEqTposechainPosechain(temp, posechain));

        public static int AlwaysEqTposechainTposechain(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTposechainTposechain(temp1, temp2));

        public static int AlwaysNePosechainTposechain(IntPtr posechain, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNePosechainTposechain(posechain, temp));

        public static int AlwaysNeTposechainPosechain(IntPtr temp, IntPtr posechain)
            => SafeExecution<int>(() => Native.AlwaysNeTposechainPosechain(temp, posechain));

        public static int AlwaysNeTposechainTposechain(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTposechainTposechain(temp1, temp2));

        public static int EverEqPosechainTposechain(IntPtr posechain, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqPosechainTposechain(posechain, temp));

        public static int EverEqTposechainPosechain(IntPtr temp, IntPtr posechain)
            => SafeExecution<int>(() => Native.EverEqTposechainPosechain(temp, posechain));

        public static int EverEqTposechainTposechain(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTposechainTposechain(temp1, temp2));

        public static int EverNePosechainTposechain(IntPtr posechain, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNePosechainTposechain(posechain, temp));

        public static int EverNeTposechainPosechain(IntPtr temp, IntPtr posechain)
            => SafeExecution<int>(() => Native.EverNeTposechainPosechain(temp, posechain));

        public static int EverNeTposechainTposechain(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTposechainTposechain(temp1, temp2));

        public static IntPtr TeqPosechainTposechain(IntPtr posechain, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqPosechainTposechain(posechain, temp));

        public static IntPtr TeqTposechainPosechain(IntPtr temp, IntPtr posechain)
            => SafeExecution<IntPtr>(() => Native.TeqTposechainPosechain(temp, posechain));

        public static IntPtr TnePosechainTposechain(IntPtr posechain, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnePosechainTposechain(posechain, temp));

        public static IntPtr TneTposechainPosechain(IntPtr temp, IntPtr posechain)
            => SafeExecution<IntPtr>(() => Native.TneTposechainPosechain(temp, posechain));

    }
}
