using System.Runtime.InteropServices;

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

    }
}
