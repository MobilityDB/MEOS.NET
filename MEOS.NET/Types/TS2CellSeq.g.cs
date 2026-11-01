#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TS2Cell of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TS2CellSeq : TS2Cell
    {
        internal TS2CellSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(ulong value, Set s)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellseqFromBaseTstzset(value, s.Ptr));

        public static Temporal? FromBaseTstzspan(ulong value, Span s)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellseqFromBaseTstzspan(value, s.Ptr));

        public static Temporal? Make(ulong[] values, long[] times, bool lower_inc, bool upper_inc)
        {
            if (values.Length != times.Length)
            {
                throw new ArgumentException(
                    "values and times are read in step, so they hold the same number of elements.");
            }

            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            GCHandle _times = GCHandle.Alloc(times, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.Ts2cellseqMake(_values.AddrOfPinnedObject(), _times.AddrOfPinnedObject(), values.Length, lower_inc, upper_inc));
            }
            finally
            {
                _values.Free();
                _times.Free();
            }
        }

    }
}
