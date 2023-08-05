using MEOS.NET.Types.Temporal;
using System.Runtime.InteropServices;

namespace MEOS.NET.API.Internal
{
    public static class MEOSFunctions
    {
        private const string DllPath = @"API\\Internal\\libmeos.so";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_initialize(string tz_str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_finalize();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int int_bucket(int value, int size, int origin);        
        
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_in(string str);        
        
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgeompoint_in(String str);        
        
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern String tpoint_out(IntPtr temp, int maxdd);
    }
}
