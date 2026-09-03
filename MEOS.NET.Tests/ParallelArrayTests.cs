using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// Arrays a MEOS function reads in parallel are counted once, so the method
    /// takes both and passes the one length — and states that they agree, since
    /// a shorter one is read past the end of and MEOS cannot see it happen.
    /// </summary>
    [TestClass]
    public class ParallelArrayTests : MeosTest
    {
        private static Text[] Texts(params string[] parts)
        {
            Text[] texts = new Text[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                texts[i] = Text.In(parts[i])!;
            }

            return texts;
        }

        [TestMethod]
        public void AJsonbIsBuiltFromItsKeysAndItsValues()
        {
            Jsonb? made = Jsonb.MakeTwoArg(Texts("a", "b"), Texts("one", "two"));

            Assert.IsNotNull(made);
            Assert.AreEqual("{\"a\": \"one\", \"b\": \"two\"}", made!.ToString());
        }

        [TestMethod]
        public void ArraysOfDifferentLengthsAreRefusedBeforeTheCall()
        {
            Assert.ThrowsException<ArgumentException>(
                () => Jsonb.MakeTwoArg(Texts("a", "b", "c"), Texts("one", "two")));
        }
    }
}
