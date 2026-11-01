#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TH3Index of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TH3IndexSeq : TH3Index
    {
        internal TH3IndexSeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzset(ulong value, Set s)
            => MEOSFactory.WrapTemporal(Meos.Th3indexseqFromBaseTstzset(value, s.Ptr));

        public static Temporal? FromBaseTstzspan(ulong value, Span s)
            => MEOSFactory.WrapTemporal(Meos.Th3indexseqFromBaseTstzspan(value, s.Ptr));

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
                return MEOSFactory.WrapTemporal(Meos.Th3indexseqMake(_values.AddrOfPinnedObject(), _times.AddrOfPinnedObject(), values.Length, lower_inc, upper_inc));
            }
            finally
            {
                _values.Free();
                _times.Free();
            }
        }

    }
}
