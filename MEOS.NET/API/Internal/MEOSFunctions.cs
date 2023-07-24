using System.Runtime.InteropServices;

namespace MEOS.NET.API.Internal
{
    public unsafe static class MEOSFunctions
    {
        private const string DllPath = @"API\\Internal\\libmeos.so";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_initialize(string tz_str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_finalize();
    }
}
