using MEOS.NET.Errors;

namespace MEOS.NET.Internal
{
    internal partial class MEOSExposedFunctions
    {
        internal delegate void ErrorHandlingMethod(int level, int errorCode, string message);

        private static T SafeExecution<T>(Func<T> function)
        {
            var meosResult = function();
            MEOSErrorHandling.CheckError();

            return meosResult;
        }

        private static void SafeExecution(Action function)
        {
            function();
            MEOSErrorHandling.CheckError();
        }
    }
}
