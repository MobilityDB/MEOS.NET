#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TsTzSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSet : Set
    {
        internal TsTzSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public DateTime EndValue()
            => MEOSConvert.ToDateTime(Meos.TstzsetEndValue(this.Ptr));

        public string Out()
            => Meos.TstzsetOut(this.Ptr);

        public Set? ShiftScale(Interval shift, Interval duration)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSet(Meos.TstzsetShiftScale(this.Ptr, _shift, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
                Marshal.FreeHGlobal(_duration);
            }
        }

        public DateTime StartValue()
            => MEOSConvert.ToDateTime(Meos.TstzsetStartValue(this.Ptr));

        public Set? ToDateset()
            => MEOSFactory.WrapSet(Meos.TstzsetToDateset(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TstzsetToStbox(this.Ptr));

        public Set? Tprecision(Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSet(Meos.TstzsetTprecision(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public DateTime? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TstzsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateTime(Marshal.ReadInt64(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public long[] Values()
            => Meos.TstzsetValues(this.Ptr);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.TstzsetIn(str));

        public static Set? Make(long[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.TstzsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
