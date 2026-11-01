#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The NpointSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class NpointSet : SpatialSet
    {
        internal NpointSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public Npoint? EndValue()
            => MEOSFactory.WrapNpoint(Meos.NpointsetEndValue(this.Ptr));

        public new string Out(int maxdd)
            => Meos.NpointsetOut(this.Ptr, maxdd);

        public Set? Routes()
            => MEOSFactory.WrapSet(Meos.NpointsetRoutes(this.Ptr));

        public Npoint? StartValue()
            => MEOSFactory.WrapNpoint(Meos.NpointsetStartValue(this.Ptr));

        public Npoint? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.NpointsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapNpoint(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Npoint?[] Values()
            => MEOSFactory.WrapNpointArray(Meos.NpointsetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => NpointSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => NpointSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.NpointsetIn(str));

    }
}
