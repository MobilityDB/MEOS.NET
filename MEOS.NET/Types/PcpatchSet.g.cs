#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The PcpatchSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PcpatchSet : SpatialSet
    {
        internal PcpatchSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public Pcpatch? EndValue()
            => MEOSFactory.WrapPcpatch(Meos.PcpatchsetEndValue(this.Ptr));

        public new string Out(int maxdd)
            => Meos.PcpatchsetOut(this.Ptr, maxdd);

        public Pcpatch? StartValue()
            => MEOSFactory.WrapPcpatch(Meos.PcpatchsetStartValue(this.Ptr));

        public Pcpatch? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PcpatchsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPcpatch(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Pcpatch?[] Values()
            => MEOSFactory.WrapPcpatchArray(Meos.PcpatchsetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => PcpatchSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => PcpatchSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.PcpatchsetIn(str));

        public static Set? Make(Pcpatch[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.PcpatchsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
