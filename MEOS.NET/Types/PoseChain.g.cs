#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The PoseChain class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PoseChain : Value
    {
        internal PoseChain(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int AlwaysEq(TPoseChain temp)
            => Meos.AlwaysEqPosechainTposechain(this.Ptr, temp.Ptr);

        public int AlwaysNe(TPoseChain temp)
            => Meos.AlwaysNePosechainTposechain(this.Ptr, temp.Ptr);

        public PoseChain? Append(Pose pose)
            => MEOSFactory.WrapPoseChain(Meos.PosechainAppend(this.Ptr, pose.Ptr));

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.PosechainAsEwkb(this.Ptr, variant, _size_out);
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

        public string AsEWKT(int maxdd)
            => Meos.PosechainAsEwkt(this.Ptr, maxdd);

        public string AsHexEWKB(byte variant)
            => Meos.PosechainAsHexewkb(this.Ptr, variant);

        public string AsHexWKB(byte variant)
            => Meos.PosechainAsHexwkb(this.Ptr, variant);

        public string AsText(int maxdd)
            => Meos.PosechainAsText(this.Ptr, maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.PosechainAsWkb(this.Ptr, variant, _size_out);
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

        public int Cmp(PoseChain pc2)
            => Meos.PosechainCmp(this.Ptr, pc2.Ptr);

        public bool Contained(PoseChainSet s)
            => Meos.ContainedPosechainSet(this.Ptr, s.Ptr);

        public PoseChain? Copy()
            => MEOSFactory.WrapPoseChain(Meos.PosechainCopy(this.Ptr));

        public double Distance(Geo gs)
            => Meos.DistancePosechainGeo(this.Ptr, gs.Ptr);

        public double Distance(PoseChain pc2)
            => Meos.DistancePosechainPosechain(this.Ptr, pc2.Ptr);

        public double Distance(STBox box)
            => Meos.DistancePosechainStbox(this.Ptr, box.Ptr);

        public double Distance(Geography gs)
            => Meos.DistancePosechainGeo(this.Ptr, gs.Ptr);

        public double Distance(Geometry gs)
            => Meos.DistancePosechainGeo(this.Ptr, gs.Ptr);

        public Pose? EndPose()
            => MEOSFactory.WrapPose(Meos.PosechainEndPose(this.Ptr));

        public bool Eq(PoseChain pc2)
            => Meos.PosechainEq(this.Ptr, pc2.Ptr);

        public int EverEq(TPoseChain temp)
            => Meos.EverEqPosechainTposechain(this.Ptr, temp.Ptr);

        public int EverNe(TPoseChain temp)
            => Meos.EverNePosechainTposechain(this.Ptr, temp.Ptr);

        public bool Ge(PoseChain pc2)
            => Meos.PosechainGe(this.Ptr, pc2.Ptr);

        public bool Gt(PoseChain pc2)
            => Meos.PosechainGt(this.Ptr, pc2.Ptr);

        public uint Hash()
            => Meos.PosechainHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PosechainHashExtended(this.Ptr, seed);

        public Set? Intersection(PoseChainSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionPosechainSet(this.Ptr, s.Ptr));

        public bool Le(PoseChain pc2)
            => Meos.PosechainLe(this.Ptr, pc2.Ptr);

        public bool Lt(PoseChain pc2)
            => Meos.PosechainLt(this.Ptr, pc2.Ptr);

        public int MemSize()
            => Meos.PosechainMemSize(this.Ptr);

        public Set? Minus(PoseChainSet s)
            => MEOSFactory.WrapSet(Meos.MinusPosechainSet(this.Ptr, s.Ptr));

        public bool Ne(PoseChain pc2)
            => Meos.PosechainNe(this.Ptr, pc2.Ptr);

        public int NumPoses()
            => Meos.PosechainNumPoses(this.Ptr);

        public string Out(int maxdd)
            => Meos.PosechainOut(this.Ptr, maxdd);

        public Pose? PoseN(int n)
            => MEOSFactory.WrapPose(Meos.PosechainPoseN(this.Ptr, n));

        public Pose?[] Poses()
            => MEOSFactory.WrapPoseArray(Meos.PosechainPoses(this.Ptr));

        public Pose? PrefixPose(int n)
            => MEOSFactory.WrapPose(Meos.PosechainPrefixPose(this.Ptr, n));

        public PoseChain? Round(int maxdd)
            => MEOSFactory.WrapPoseChain(Meos.PosechainRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.PosechainSrid(this.Ptr);

        public PoseChain? SetSRID(int srid)
            => MEOSFactory.WrapPoseChain(Meos.PosechainSetSrid(this.Ptr, srid));

        public Pose? StartPose()
            => MEOSFactory.WrapPose(Meos.PosechainStartPose(this.Ptr));

        public Temporal? Teq(TPoseChain temp)
            => MEOSFactory.WrapTemporal(Meos.TeqPosechainTposechain(this.Ptr, temp.Ptr));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.PosechainTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Temporal? Tne(TPoseChain temp)
            => MEOSFactory.WrapTemporal(Meos.TnePosechainTposechain(this.Ptr, temp.Ptr));

        public Geo? ToPoint()
            => MEOSFactory.WrapGeo(Meos.PosechainToPoint(this.Ptr));

        public Pose? ToPose()
            => MEOSFactory.WrapPose(Meos.PosechainToPose(this.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.PosechainToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.PosechainToStbox(this.Ptr));

        public PoseChain? Transform(int srid_to)
            => MEOSFactory.WrapPoseChain(Meos.PosechainTransform(this.Ptr, srid_to));

        public PoseChain? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapPoseChain(Meos.PosechainTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.PosechainTstzspanToStbox(this.Ptr, s.Ptr));

        public Set? Union(PoseChainSet s)
            => MEOSFactory.WrapSet(Meos.UnionPosechainSet(this.Ptr, s.Ptr));

        public static PoseChain? FromEWKB(byte[] wkb)
            => PoseChain.FromWKB(wkb);

        public static PoseChain? FromEWKT(string str)
            => PoseChain.In(str);

        public static PoseChain? FromHexEWKB(string hexwkb)
            => PoseChain.FromHexWKB(hexwkb);

        public static PoseChain? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapPoseChain(Meos.PosechainFromHexwkb(hexwkb));

        public static PoseChain? FromText(string str)
            => PoseChain.In(str);

        public static PoseChain? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPoseChain(Meos.PosechainFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static PoseChain? In(string str)
            => MEOSFactory.WrapPoseChain(Meos.PosechainIn(str));

        public static PoseChain? Make(Pose[] poses)
        {
            IntPtr[] _posesValues = new IntPtr[poses.Length];
            for (int i = 0; i < poses.Length; i++)
            {
                _posesValues[i] = poses[i].Ptr;
            }

            GCHandle _poses = GCHandle.Alloc(_posesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPoseChain(Meos.PosechainMake(_poses.AddrOfPinnedObject(), poses.Length));
            }
            finally
            {
                _poses.Free();
            }
        }

    }
}
