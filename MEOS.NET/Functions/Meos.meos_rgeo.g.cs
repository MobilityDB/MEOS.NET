using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_rgeo.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr TrgeometryIn(string str)
            => SafeExecution<IntPtr>(() => Native.TrgeometryIn(str));

        public static IntPtr TrgeometryFromMfjson(string mfjson)
            => SafeExecution<IntPtr>(() => Native.TrgeometryFromMfjson(mfjson));

        public static string TrgeometryOut(IntPtr temp)
            => SafeExecution<string>(() => Native.TrgeometryOut(temp));

        public static string TrgeometryAsText(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => Native.TrgeometryAsText(temp, maxdd));

        public static string TrgeometryAsEwkt(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => Native.TrgeometryAsEwkt(temp, maxdd));

        public static IntPtr TrgeometryinstMake(IntPtr geom, IntPtr pose, long t)
            => SafeExecution<IntPtr>(() => Native.TrgeometryinstMake(geom, pose, t));

        public static IntPtr TrgeometryseqMake(IntPtr geom, IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TrgeometryseqMake(geom, instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr TrgeometryseqsetMake(IntPtr geom, IntPtr sequences, int count, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TrgeometryseqsetMake(geom, sequences, count, normalize));

        public static IntPtr TrgeometryseqsetMakeGaps(IntPtr geom, IntPtr instants, int count, int interp, IntPtr maxt, double maxdist)
            => SafeExecution<IntPtr>(() => Native.TrgeometryseqsetMakeGaps(geom, instants, count, interp, maxt, maxdist));

        public static IntPtr GeometryTposeToTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.GeometryTposeToTrgeometry(gs, temp));

        public static IntPtr TrgeometryToTpose(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryToTpose(temp));

        public static IntPtr TrgeometryToTgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryToTgeompoint(temp));

        public static IntPtr TrgeometryToTgeometry(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryToTgeometry(temp));

        public static IntPtr TrgeometryEndInstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryEndInstant(temp));

        public static IntPtr TrgeometryEndSequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryEndSequence(temp));

        public static IntPtr TrgeometryEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryEndValue(temp));

        public static IntPtr TrgeometryGeom(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryGeom(temp));

        public static IntPtr TrgeometryInstantN(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => Native.TrgeometryInstantN(temp, n));

        public static IntPtr[] TrgeometryInstants(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometryInstants(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TrgeometryPoints(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryPoints(temp));

        public static IntPtr TrgeometryYaw(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryYaw(temp));

        public static IntPtr TrgeometryPitch(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryPitch(temp));

        public static IntPtr TrgeometryRoll(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryRoll(temp));

        public static IntPtr[] TrgeometrySegments(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometrySegments(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TrgeometrySequenceN(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TrgeometrySequenceN(temp, i));

        public static IntPtr[] TrgeometrySequences(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometrySequences(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TrgeometryStartInstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryStartInstant(temp));

        public static IntPtr TrgeometryStartSequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryStartSequence(temp));

        public static IntPtr TrgeometryStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryStartValue(temp));

        public static bool TrgeometryValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TrgeometryValueN(temp, n, result));

        public static IntPtr TrgeometryTraversedArea(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => Native.TrgeometryTraversedArea(temp, unary_union));

        public static IntPtr TrgeometryCentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryCentroid(temp));

        public static IntPtr TrgeometryConvexHull(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryConvexHull(temp));

        public static IntPtr TrgeometryBodyPointTrajectory(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TrgeometryBodyPointTrajectory(temp, gs));

        public static IntPtr[] TrgeometrySpaceBoxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometrySpaceBoxes(temp, xsize, ysize, zsize, sorigin, bitmatrix, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TrgeometrySpaceTimeBoxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometrySpaceTimeBoxes(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TrgeometryStboxes(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometryStboxes(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TrgeometrySplitNStboxes(IntPtr temp, int box_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometrySplitNStboxes(temp, box_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TrgeometrySplitEachNStboxes(IntPtr temp, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometrySplitEachNStboxes(temp, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double TrgeometryHausdorffDistance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.TrgeometryHausdorffDistance(temp1, temp2));

        public static double TrgeometryFrechetDistance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.TrgeometryFrechetDistance(temp1, temp2));

        public static double TrgeometryDyntimewarpDistance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.TrgeometryDyntimewarpDistance(temp1, temp2));

        public static IntPtr[] TrgeometryFrechetPath(IntPtr temp1, IntPtr temp2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometryFrechetPath(temp1, temp2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TrgeometryDyntimewarpPath(IntPtr temp1, IntPtr temp2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrgeometryDyntimewarpPath(temp1, temp2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double TrgeometryLength(IntPtr temp)
            => SafeExecution<double>(() => Native.TrgeometryLength(temp));

        public static IntPtr TrgeometryCumulativeLength(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryCumulativeLength(temp));

        public static IntPtr TrgeometryAngularSpeed(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAngularSpeed(temp));

        public static IntPtr TrgeometrySpeed(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometrySpeed(temp));

        public static IntPtr TrgeometryTwcentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryTwcentroid(temp));

        public static IntPtr TrgeometryAppendTinstant(IntPtr temp, IntPtr inst, int interp, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAppendTinstant(temp, inst, interp, maxdist, maxt, expand));

        public static IntPtr TrgeometryAppendTsequence(IntPtr temp, IntPtr seq, bool expand)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAppendTsequence(temp, seq, expand));

        public static IntPtr TrgeometryDeleteTimestamptz(IntPtr temp, long t, bool connect)
            => SafeExecution<IntPtr>(() => Native.TrgeometryDeleteTimestamptz(temp, t, connect));

        public static IntPtr TrgeometryDeleteTstzset(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => Native.TrgeometryDeleteTstzset(temp, s, connect));

        public static IntPtr TrgeometryDeleteTstzspan(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => Native.TrgeometryDeleteTstzspan(temp, s, connect));

        public static IntPtr TrgeometryDeleteTstzspanset(IntPtr temp, IntPtr ss, bool connect)
            => SafeExecution<IntPtr>(() => Native.TrgeometryDeleteTstzspanset(temp, ss, connect));

        public static IntPtr TrgeometryMerge(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMerge(temp1, temp2));

        public static IntPtr TrgeometryMergeArray(IntPtr temparr, int count)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMergeArray(temparr, count));

        public static IntPtr TrgeometryRound(IntPtr temp, int maxdd)
            => SafeExecution<IntPtr>(() => Native.TrgeometryRound(temp, maxdd));

        public static IntPtr TrgeometrySetInterp(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => Native.TrgeometrySetInterp(temp, interp));

        public static IntPtr TrgeometryAsTinstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAsTinstant(temp));

        public static IntPtr TrgeometryAsTsequence(IntPtr temp, string interp_str)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAsTsequence(temp, interp_str));

        public static IntPtr TrgeometryAsTsequenceset(IntPtr temp, string interp_str)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAsTsequenceset(temp, interp_str));

        public static IntPtr TrgeometryAfterTimestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAfterTimestamptz(temp, t, strict));

        public static IntPtr TrgeometryBeforeTimestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TrgeometryBeforeTimestamptz(temp, t, strict));

        public static IntPtr TrgeometryRestrictValues(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TrgeometryRestrictValues(temp, s, atfunc));

        public static IntPtr TrgeometryRestrictTimestamptz(IntPtr temp, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TrgeometryRestrictTimestamptz(temp, t, atfunc));

        public static IntPtr TrgeometryRestrictTstzset(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TrgeometryRestrictTstzset(temp, s, atfunc));

        public static IntPtr TrgeometryRestrictTstzspan(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TrgeometryRestrictTstzspan(temp, s, atfunc));

        public static IntPtr TrgeometryRestrictTstzspanset(IntPtr temp, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TrgeometryRestrictTstzspanset(temp, ss, atfunc));

        public static IntPtr TrgeometryAtGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtGeom(temp, gs));

        public static IntPtr TrgeometryMinusGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusGeom(temp, gs));

        public static IntPtr TrgeometryAtStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtStbox(temp, box, border_inc));

        public static IntPtr TrgeometryMinusStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusStbox(temp, box, border_inc));

        public static IntPtr TrgeometryAtValue(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtValue(temp, pose));

        public static IntPtr TrgeometryMinusValue(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusValue(temp, pose));

        public static IntPtr TrgeometryAtValues(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtValues(temp, s));

        public static IntPtr TrgeometryMinusValues(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusValues(temp, s));

        public static IntPtr TrgeometryAtTimestamptz(IntPtr temp, long t)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtTimestamptz(temp, t));

        public static IntPtr TrgeometryMinusTimestamptz(IntPtr temp, long t)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusTimestamptz(temp, t));

        public static IntPtr TrgeometryAtTstzset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtTstzset(temp, s));

        public static IntPtr TrgeometryMinusTstzset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusTstzset(temp, s));

        public static IntPtr TrgeometryAtTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtTstzspan(temp, s));

        public static IntPtr TrgeometryMinusTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusTstzspan(temp, s));

        public static IntPtr TrgeometryAtTstzspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtTstzspanset(temp, ss));

        public static IntPtr TrgeometryMinusTstzspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusTstzspanset(temp, ss));

        public static IntPtr TrgeometryAtElevation(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TrgeometryAtElevation(temp, s));

        public static IntPtr TrgeometryMinusElevation(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TrgeometryMinusElevation(temp, s));

        public static IntPtr TdistanceTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TdistanceTrgeometryGeo(temp, gs));

        public static IntPtr TdistanceTrgeometryTpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdistanceTrgeometryTpoint(temp1, temp2));

        public static IntPtr TdistanceTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdistanceTrgeometryTrgeometry(temp1, temp2));

        public static double NadStboxTrgeometry(IntPtr box, IntPtr temp)
            => SafeExecution<double>(() => Native.NadStboxTrgeometry(box, temp));

        public static double NadTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => Native.NadTrgeometryGeo(temp, gs));

        public static double NadTrgeometryStbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => Native.NadTrgeometryStbox(temp, box));

        public static double NadTrgeometryTpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.NadTrgeometryTpoint(temp1, temp2));

        public static double NadTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.NadTrgeometryTrgeometry(temp1, temp2));

        public static IntPtr NaiTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.NaiTrgeometryGeo(temp, gs));

        public static IntPtr NaiTrgeometryTpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.NaiTrgeometryTpoint(temp1, temp2));

        public static IntPtr NaiTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.NaiTrgeometryTrgeometry(temp1, temp2));

        public static IntPtr ShortestlineTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTrgeometryGeo(temp, gs));

        public static IntPtr ShortestlineTrgeometryTpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTrgeometryTpoint(temp1, temp2));

        public static IntPtr ShortestlineTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTrgeometryTrgeometry(temp1, temp2));

        public static int AlwaysEqGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqGeoTrgeometry(gs, temp));

        public static int AlwaysEqTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AlwaysEqTrgeometryGeo(temp, gs));

        public static int AlwaysEqTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTrgeometryTrgeometry(temp1, temp2));

        public static int AlwaysNeGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeGeoTrgeometry(gs, temp));

        public static int AlwaysNeTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AlwaysNeTrgeometryGeo(temp, gs));

        public static int AlwaysNeTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTrgeometryTrgeometry(temp1, temp2));

        public static int EverEqGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqGeoTrgeometry(gs, temp));

        public static int EverEqTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EverEqTrgeometryGeo(temp, gs));

        public static int EverEqTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTrgeometryTrgeometry(temp1, temp2));

        public static int EverNeGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeGeoTrgeometry(gs, temp));

        public static int EverNeTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EverNeTrgeometryGeo(temp, gs));

        public static int EverNeTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTrgeometryTrgeometry(temp1, temp2));

        public static IntPtr TeqGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqGeoTrgeometry(gs, temp));

        public static IntPtr TeqTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TeqTrgeometryGeo(temp, gs));

        public static IntPtr TneGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneGeoTrgeometry(gs, temp));

        public static IntPtr TneTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TneTrgeometryGeo(temp, gs));

        public static int EcontainsGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EcontainsGeoTrgeometry(gs, temp));

        public static int AcontainsGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AcontainsGeoTrgeometry(gs, temp));

        public static int EcoversGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EcoversGeoTrgeometry(gs, temp));

        public static int AcoversGeoTrgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AcoversGeoTrgeometry(gs, temp));

        public static int EcoversTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EcoversTrgeometryGeo(temp, gs));

        public static int AcoversTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AcoversTrgeometryGeo(temp, gs));

        public static int EdisjointTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EdisjointTrgeometryGeo(temp, gs));

        public static int AdisjointTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AdisjointTrgeometryGeo(temp, gs));

        public static int EintersectsTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EintersectsTrgeometryGeo(temp, gs));

        public static int AintersectsTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AintersectsTrgeometryGeo(temp, gs));

        public static int EtouchesTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EtouchesTrgeometryGeo(temp, gs));

        public static int AtouchesTrgeometryGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AtouchesTrgeometryGeo(temp, gs));

        public static int EdwithinTrgeometryGeo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => Native.EdwithinTrgeometryGeo(temp, gs, dist));

        public static int AdwithinTrgeometryGeo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => Native.AdwithinTrgeometryGeo(temp, gs, dist));

        public static int EdisjointTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EdisjointTrgeometryTrgeometry(temp1, temp2));

        public static int AdisjointTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AdisjointTrgeometryTrgeometry(temp1, temp2));

        public static int EintersectsTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EintersectsTrgeometryTrgeometry(temp1, temp2));

        public static int AintersectsTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AintersectsTrgeometryTrgeometry(temp1, temp2));

        public static int EdwithinTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => Native.EdwithinTrgeometryTrgeometry(temp1, temp2, dist));

        public static int AdwithinTrgeometryTrgeometry(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => Native.AdwithinTrgeometryTrgeometry(temp1, temp2, dist));

    }
}
