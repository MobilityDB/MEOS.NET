using MEOS.NET.Errors;
using MEOS.NET.Internal;

namespace MEOS.NET.Lifecycle
{
    public static class MEOSLifecycle
    {
        public static void Initialize(string timeZone)
            => MEOSExposedFunctions.meos_initialize(timeZone, MEOSErrorHandling.InternalErrorHandler);

        public static void Terminate()
            => MEOSExposedFunctions.meos_finalize(); 
    }
}
