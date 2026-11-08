#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The NPointSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class NPointSet : SpatialSet
    {
        internal NPointSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Contained(NPointSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(NPoint np)
            => Meos.ContainsSetNpoint(this.Ptr, np.Ptr);

        public bool Contains(NPointSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public double Distance(NPointSet s2)
            => Meos.DistanceNpointsetNpointset(this.Ptr, s2.Ptr);

        public NPoint? EndValue()
            => MEOSFactory.WrapNPoint(Meos.NpointsetEndValue(this.Ptr));

        public Set? Intersection(NPoint np)
            => MEOSFactory.WrapSet(Meos.IntersectionSetNpoint(this.Ptr, np.Ptr));

        public Set? Intersection(NPointSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(NPoint np)
            => MEOSFactory.WrapSet(Meos.MinusSetNpoint(this.Ptr, np.Ptr));

        public Set? Minus(NPointSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public new string Out(int maxdd)
            => Meos.NpointsetOut(this.Ptr, maxdd);

        public bool Overlaps(NPointSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public Set? Routes()
            => MEOSFactory.WrapSet(Meos.NpointsetRoutes(this.Ptr));

        public NPoint? StartValue()
            => MEOSFactory.WrapNPoint(Meos.NpointsetStartValue(this.Ptr));

        public Set? Union(NPoint np)
            => MEOSFactory.WrapSet(Meos.UnionSetNpoint(this.Ptr, np.Ptr));

        public Set? Union(NPointSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public NPoint? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.NpointsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapNPoint(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public NPoint?[] Values()
            => MEOSFactory.WrapNPointArray(Meos.NpointsetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => NPointSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => NPointSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.NpointsetIn(str));

        public static Set? Make(NPoint[] values)
        {
            IntPtr _values = Marshal.AllocHGlobal(16 * Math.Max(values.Length, 1));
            byte[] _valuesValue = new byte[16];
            for (int i = 0; i < values.Length; i++)
            {
                Marshal.Copy(values[i].Ptr, _valuesValue, 0, 16);
                Marshal.Copy(_valuesValue, 0, IntPtr.Add(_values, i * 16), 16);
            }

            try
            {
                return MEOSFactory.WrapSet(Meos.NpointsetMake(_values, values.Length));
            }
            finally
            {
                Marshal.FreeHGlobal(_values);
            }
        }

    }
}
