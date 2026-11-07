#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The PoseChainSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PoseChainSet : SpatialSet
    {
        internal PoseChainSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Contains(PoseChain pc)
            => Meos.ContainsSetPosechain(this.Ptr, pc.Ptr);

        public double Distance(PoseChainSet s2)
            => Meos.DistancePosechainsetPosechainset(this.Ptr, s2.Ptr);

        public PoseChain? EndValue()
            => MEOSFactory.WrapPoseChain(Meos.PosechainsetEndValue(this.Ptr));

        public Set? Intersection(PoseChain pc)
            => MEOSFactory.WrapSet(Meos.IntersectionSetPosechain(this.Ptr, pc.Ptr));

        public Set? Minus(PoseChain pc)
            => MEOSFactory.WrapSet(Meos.MinusSetPosechain(this.Ptr, pc.Ptr));

        public new string Out(int maxdd)
            => Meos.PosechainsetOut(this.Ptr, maxdd);

        public PoseChain? StartValue()
            => MEOSFactory.WrapPoseChain(Meos.PosechainsetStartValue(this.Ptr));

        public Set? Union(PoseChain pc)
            => MEOSFactory.WrapSet(Meos.UnionSetPosechain(this.Ptr, pc.Ptr));

        public PoseChain? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PosechainsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPoseChain(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public PoseChain?[] Values()
            => MEOSFactory.WrapPoseChainArray(Meos.PosechainsetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => PoseChainSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => PoseChainSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.PosechainsetIn(str));

        public static Set? Make(PoseChain[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.PosechainsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
