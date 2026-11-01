#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The PoseSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PoseSet : SpatialSet
    {
        internal PoseSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public Pose? EndValue()
            => MEOSFactory.WrapPose(Meos.PosesetEndValue(this.Ptr));

        public new string Out(int maxdd)
            => Meos.PosesetOut(this.Ptr, maxdd);

        public Pose? StartValue()
            => MEOSFactory.WrapPose(Meos.PosesetStartValue(this.Ptr));

        public Pose? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PosesetValueN(this.Ptr, n, _result))
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
            => MEOSFactory.WrapPoseArray(Meos.PosesetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => PoseSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => PoseSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.PosesetIn(str));

        public static Set? Make(Pose[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.PosesetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
