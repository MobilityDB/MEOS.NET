#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The CbufferSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class CbufferSet : Set
    {
        internal CbufferSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public Cbuffer? EndValue()
            => MEOSFactory.WrapCbuffer(Meos.CbuffersetEndValue(this.Ptr));

        public string Out(int maxdd)
            => Meos.CbuffersetOut(this.Ptr, maxdd);

        public Cbuffer? StartValue()
            => MEOSFactory.WrapCbuffer(Meos.CbuffersetStartValue(this.Ptr));

        public Cbuffer? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.CbuffersetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapCbuffer(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Cbuffer?[] Values()
            => MEOSFactory.WrapCbufferArray(Meos.CbuffersetValues(this.Ptr));

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.CbuffersetIn(str));

        public static Set? Make(Cbuffer[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.CbuffersetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
