#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The NpointSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class NpointSet : Set
    {
        internal NpointSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public Npoint? EndValue()
            => MEOSFactory.WrapNpoint(Meos.NpointsetEndValue(this.Ptr));

        public string Out(int maxdd)
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

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.NpointsetIn(str));

        public static Set? Make(Npoint[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.NpointsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
