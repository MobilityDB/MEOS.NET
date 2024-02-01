using MEOS.NET.Errors;

namespace MEOS.NET.Internal
{
    internal partial class MEOSExposedFunctions
    {
        public static IntPtr tgeompoint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_in(str));

        public static void meos_error(int errlevel, int errcode, string format)
            => SafeExecution(() => MEOSExternalFunctions.meos_error(errlevel, errcode, format));
    }
}
