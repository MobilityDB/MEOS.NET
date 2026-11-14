#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_cellindex.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr TcellindexGetResolution(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcellindexGetResolution(temp));

        public static IntPtr TcellindexIsValidCell(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcellindexIsValidCell(temp));

        public static IntPtr TcellindexCellToParent(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => Native.TcellindexCellToParent(temp, resolution));

        public static IntPtr TcellindexCellToPoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcellindexCellToPoint(temp));

        public static IntPtr TcellindexCellToBoundary(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcellindexCellToBoundary(temp));

        public static IntPtr TcellindexCellArea(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcellindexCellArea(temp));

        public static IntPtr TcellindexAtStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TcellindexAtStbox(temp, box, border_inc));

        public static IntPtr TcellindexMinusStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TcellindexMinusStbox(temp, box, border_inc));

        public static int EverOverlapsTcellindexStbox(IntPtr temp, IntPtr box)
            => SafeExecution<int>(() => Native.EverOverlapsTcellindexStbox(temp, box));

        public static int AlwaysOverlapsTcellindexStbox(IntPtr temp, IntPtr box)
            => SafeExecution<int>(() => Native.AlwaysOverlapsTcellindexStbox(temp, box));

        public static int EverOverlapsStboxTcellindex(IntPtr box, IntPtr temp)
            => SafeExecution<int>(() => Native.EverOverlapsStboxTcellindex(box, temp));

        public static int AlwaysOverlapsStboxTcellindex(IntPtr box, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysOverlapsStboxTcellindex(box, temp));

    }
}
