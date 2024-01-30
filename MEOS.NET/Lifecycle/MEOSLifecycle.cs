using MEOS.NET.Errors;
using MEOS.NET.Internal;

namespace MEOS.NET.Lifecycle
{
    public static class MEOSLifecycle
    {
        public static void Initialize(string timeZone)
        {
            MEOSFunctions.meos_initialize(timeZone, MEOSErrorHandling.DefaultErrorHandler);

            //MEOSFunctions.meos_initialize(timeZone, MEOSErrorHandling.DefaultErrorHandler);
        }

        public static void Terminate()
            => MEOSFunctions.meos_finalize(); 
    }
}
