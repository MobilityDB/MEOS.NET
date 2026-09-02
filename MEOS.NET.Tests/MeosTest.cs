using MEOS.NET.Lifecycle;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The base every test class derives from, so each test runs against an open
    /// MEOS session.
    ///
    /// MEOS keeps its session state — the timezone its text I/O reads and writes
    /// through, and the error handler — per thread, and the test host runs a test
    /// on whichever thread it has free. A session opened once for the assembly
    /// therefore reaches the thread that opened it and no other: elsewhere a
    /// timestamp is read in the machine's own timezone rather than the suite's,
    /// and an error raised there reaches no handler at all.
    /// </summary>
    public abstract class MeosTest
    {
        [TestInitialize]
        public void OpenMeosSession() => MEOSLifecycle.Initialize("UTC");
    }
}
