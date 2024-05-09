using System.Runtime.InteropServices;

namespace MEOS.NET.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TimestampTz
    {
        public long Time;
    }
}
