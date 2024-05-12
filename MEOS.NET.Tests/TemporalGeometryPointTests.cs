using MEOS.NET.Lifecycle;
using MEOS.NET.Types.General;

namespace MEOS.NET.Tests
{
    [TestClass]
    public class TemporalGeometryPointTests
    {
        [ClassInitialize]
        public static void InitializeTests(TestContext context)
        {
            MEOSLifecycle.Initialize("UTC");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            MEOSLifecycle.Terminate();
        }
    }
}