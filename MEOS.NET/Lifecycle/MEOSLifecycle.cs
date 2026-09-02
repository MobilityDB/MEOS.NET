using System.Runtime.InteropServices;

using MEOS.NET.Errors;
using MEOS.NET.Functions;

namespace MEOS.NET.Lifecycle
{
    public static class MEOSLifecycle
    {
        // Hold a managed reference to the error-handler delegate for the lifetime
        // of the process so the GC does not free it while MEOS holds the
        // function pointer.  MEOS 1.3 `meos_initialize_error_handler` takes a
        // raw `error_handler_fn` (function pointer / nint) rather than a P/Invoke
        // delegate, so the call site marshals the delegate explicitly.
        private static Meos.ErrorHandlingMethod? errorHandlerDelegate;

        public static void Initialize(string timeZone)
        {
            Meos.MeosInitialize();
            Meos.MeosInitializeTimezone(timeZone);
            errorHandlerDelegate = MEOSErrorHandling.InternalErrorHandler;
            var fnPtr = Marshal.GetFunctionPointerForDelegate(errorHandlerDelegate);
            Meos.MeosInitializeErrorHandler(fnPtr);
        }

        public static void Terminate()
            => Meos.MeosFinalize();
    }
}
