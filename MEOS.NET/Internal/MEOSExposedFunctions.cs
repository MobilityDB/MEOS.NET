using MEOS.NET.Errors;

namespace MEOS.NET.Internal
{
    internal partial class MEOSExposedFunctions
    {
        private delegate void VoidMEOSFunction(params object[] args);

        private static T SafeExecution<T>(T meosFunctionResult)
        {
            MEOSErrorHandling.CheckError();
            return meosFunctionResult;
        }

        private static void SafeExecution<T>(VoidMEOSFunction f, T args)
        {
            
            MEOSErrorHandling.CheckError();
        }

        public static IntPtr tgeompoint_in(string str)
            => SafeExecution<IntPtr>(MEOSExternalFunctions.tgeompoint_in(str));

        public static void test(int arg1, int arg2, string c)
            => SafeExecution<int>(MEOSExternalFunctions.meos_error, arg1, arg2, c);
    }
}
