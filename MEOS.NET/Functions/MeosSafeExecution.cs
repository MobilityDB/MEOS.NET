using MEOS.NET.Errors;

namespace MEOS.NET.Functions
{
    /// <summary>
    /// The MEOS surface: every public MEOS function, one static method each.
    /// </summary>
    /// <remarks>
    /// MEOS reports an error through the handler and returns, so the value a call
    /// returns means nothing once an error was reported. Every wrapper therefore
    /// goes through <c>SafeExecution</c>, which raises what the handler recorded.
    /// </remarks>
    public static partial class Meos
    {
        internal delegate void ErrorHandlingMethod(int level, int errorCode, string message);

        private static T SafeExecution<T>(Func<T> function)
        {
            var result = function();
            MEOSErrorHandling.CheckError();

            return result;
        }

        private static void SafeExecution(Action function)
        {
            function();
            MEOSErrorHandling.CheckError();
        }
    }
}
