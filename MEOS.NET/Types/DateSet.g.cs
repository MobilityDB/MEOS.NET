#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The DateSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class DateSet : Set
    {
        internal DateSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public DateOnly EndValue()
            => MEOSConvert.ToDateOnly(Meos.DatesetEndValue(this.Ptr));

        public string Out()
            => Meos.DatesetOut(this.Ptr);

        public Set? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(Meos.DatesetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public DateOnly StartValue()
            => MEOSConvert.ToDateOnly(Meos.DatesetStartValue(this.Ptr));

        public Set? ToTstzset()
            => MEOSFactory.WrapSet(Meos.DatesetToTstzset(this.Ptr));

        public DateOnly? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(4);
            try
            {
                if (!Meos.DatesetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateOnly(Marshal.ReadInt32(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public int[] Values()
            => Meos.DatesetValues(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.DatesetIn(str));

        public static Set? Make(int[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.DatesetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
