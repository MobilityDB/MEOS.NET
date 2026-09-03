using System.Runtime.InteropServices;

using MEOS.NET.Functions;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The `each` family fills an array the CALLER allocates, so the wrapper
    /// takes that array rather than making one: MEOS writes one pointer per
    /// member of the object, and storage for fewer of them is written past.
    /// </summary>
    [TestClass]
    public class CallerAllocatedArrayTests : MeosTest
    {
        [TestMethod]
        public void EachFillsTheArrayTheCallerGivesIt()
        {
            Jsonb jb = Jsonb.In("{\"a\": 1, \"b\": \"two\"}")!;
            IntPtr values = Marshal.AllocHGlobal(IntPtr.Size * 8);
            try
            {
                IntPtr[] keys = Meos.JsonbEach(jb.Ptr, values);

                Assert.AreEqual(2, keys.Length);
                Assert.AreEqual("a", Meos.TextOut(keys[0]));
                Assert.AreEqual("b", Meos.TextOut(keys[1]));
                Assert.AreEqual("1",
                    Meos.JsonbOut(Marshal.ReadIntPtr(values, 0)));
                Assert.AreEqual("\"two\"",
                    Meos.JsonbOut(Marshal.ReadIntPtr(values, IntPtr.Size)));
            }
            finally
            {
                Marshal.FreeHGlobal(values);
            }
        }
    }
}
