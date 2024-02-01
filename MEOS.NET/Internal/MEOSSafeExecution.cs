using MEOS.NET.Errors;

namespace MEOS.NET.Internal
{
    internal partial class MEOSExposedFunctions
    {
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
