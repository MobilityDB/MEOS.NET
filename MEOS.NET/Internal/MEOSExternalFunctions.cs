using MEOS.NET.Errors;
using System.Runtime.InteropServices;

namespace MEOS.NET.Internal
{
    internal partial class MEOSExposedFunctions
    {
        private class MEOSExternalFunctions
        {
            private const string DllPath = "/home/totojr/Externals/MobilityDB/build/libmeos.so";

            [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr tgeompoint_in(string str);

            [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void meos_error(int errlevel, int errcode, string format);
        } 
    }
}
