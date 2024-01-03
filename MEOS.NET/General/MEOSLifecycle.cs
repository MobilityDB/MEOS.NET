using MEOS.NET.API.Internal;

namespace MEOS.NET.General
{
    public static class MEOSLifecycle
    {
        public static void Initialize(string timeZone)
            => MEOSFunctions.meos_initialize_timezone(timeZone);

        public static void Terminate()
            => MEOSFunctions.meos_finalize();
    }
}
