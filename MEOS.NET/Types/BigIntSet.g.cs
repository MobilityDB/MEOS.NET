#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The BigIntSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSet : Set
    {
        internal BigIntSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public long EndValue()
            => Meos.BigintsetEndValue(this.Ptr);

        public string Out()
            => Meos.BigintsetOut(this.Ptr);

        public Set? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(Meos.BigintsetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public long StartValue()
            => Meos.BigintsetStartValue(this.Ptr);

        public long? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.BigintsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return Marshal.ReadInt64(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public long[] Values()
            => Meos.BigintsetValues(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.BigintsetIn(str));

        public static Set? Make(long[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.BigintsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
