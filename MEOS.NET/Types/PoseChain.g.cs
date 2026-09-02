#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The PoseChain class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PoseChain : Value
    {
        internal PoseChain(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public PoseChain? Append(Pose pose)
            => MEOSFactory.WrapPoseChain(Meos.PosechainAppend(this.Ptr, pose.Ptr));

        public string AsEWKT(int maxdd)
            => Meos.PosechainAsEwkt(this.Ptr, maxdd);

        public string AsText(int maxdd)
            => Meos.PosechainAsText(this.Ptr, maxdd);

        public int Cmp(PoseChain pc2)
            => Meos.PosechainCmp(this.Ptr, pc2.Ptr);

        public PoseChain? Copy()
            => MEOSFactory.WrapPoseChain(Meos.PosechainCopy(this.Ptr));

        public Pose? EndPose()
            => MEOSFactory.WrapPose(Meos.PosechainEndPose(this.Ptr));

        public bool Eq(PoseChain pc2)
            => Meos.PosechainEq(this.Ptr, pc2.Ptr);

        public bool Ge(PoseChain pc2)
            => Meos.PosechainGe(this.Ptr, pc2.Ptr);

        public bool Gt(PoseChain pc2)
            => Meos.PosechainGt(this.Ptr, pc2.Ptr);

        public uint Hash()
            => Meos.PosechainHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PosechainHashExtended(this.Ptr, seed);

        public bool Le(PoseChain pc2)
            => Meos.PosechainLe(this.Ptr, pc2.Ptr);

        public bool Lt(PoseChain pc2)
            => Meos.PosechainLt(this.Ptr, pc2.Ptr);

        public bool Ne(PoseChain pc2)
            => Meos.PosechainNe(this.Ptr, pc2.Ptr);

        public bool Nsame(PoseChain pc2)
            => Meos.PosechainNsame(this.Ptr, pc2.Ptr);

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

        public bool Same(PoseChain pc2)
            => Meos.PosechainSame(this.Ptr, pc2.Ptr);

        public PoseChain? SetSRID(int srid)
            => MEOSFactory.WrapPoseChain(Meos.PosechainSetSrid(this.Ptr, srid));

        public Pose? StartPose()
            => MEOSFactory.WrapPose(Meos.PosechainStartPose(this.Ptr));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.PosechainTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

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

        public PoseChain? TransformPipeline(string pipeline, int srid_to, bool is_forward)
            => MEOSFactory.WrapPoseChain(Meos.PosechainTransformPipeline(this.Ptr, pipeline, srid_to, is_forward));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.PosechainTstzspanToStbox(this.Ptr, s.Ptr));

        public static PoseChain? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapPoseChain(Meos.PosechainFromHexwkb(hexwkb));

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
