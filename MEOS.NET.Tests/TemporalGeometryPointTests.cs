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

        [TestMethod]
        public void TestTemporalGeometryPointFromStringNotNull()
        {
            var temporalGeometry = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");
            Assert.IsNotNull(temporalGeometry);
        }

        [TestMethod]
        public void TestTemporalGeometryPointArrayFromStringNotNull()
        {
            var temporalGeometry = TemporalGeometryPoint.From("[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02]");
            Assert.IsNotNull(temporalGeometry);
        }

        [TestMethod]
        public void TestTemporalGeometryPointEqual_True()
        {
            var temp1 = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");
            var temp2 = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");

            bool equals = temp1.Equals(temp2);
            bool equalsOperator = temp1 == temp2;

            Assert.IsTrue(equals);
            Assert.IsTrue(equalsOperator);
        }

        [TestMethod]
        public void TestTemporalGeometryPointEqual_False()
        {
            var temp1 = TemporalGeometryPoint.From("[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02]");
            var temp2 = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");

            bool equals = temp1.Equals(temp2);
            bool equalsOperator = temp1 == temp2;

            Assert.IsFalse(equals);
            Assert.IsFalse(equalsOperator);
        }

        [TestMethod]
        public void TestTemporalGeometryPointNotEqual_True()
        {
            var temp1 = TemporalGeometryPoint.From("[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02]");
            var temp2 = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");

            bool notEquals = !(temp1.Equals(temp2));
            bool notEqualsOperator = temp1 != temp2;

            Assert.IsTrue(notEquals);
            Assert.IsTrue(notEqualsOperator);
        }

        [TestMethod]
        public void TestTemporalGeometryPointNotEqual_False()
        {
            var temp1 = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");
            var temp2 = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");

            bool notEquals = !(temp1.Equals(temp2));
            bool notEqualsOperator = temp1 != temp2;

            Assert.IsFalse(notEquals);
            Assert.IsFalse(notEqualsOperator);
        }

        [TestMethod]
        public void TestTemporalGeometryPointToString_Valid()
        {
            var temp = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");
            Assert.AreEqual("POINT(1 1)@2023-08-06 01:45:00+00", temp.ToString());
        }

        public void TestTemporalGeometryPointToJson_Valid()
        {
            var temp = TemporalGeometryPoint.From("{[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02],[POINT(3 3)@2000-01-03, POINT(3 3)@2000-01-04]}");
            Assert.AreEqual("{\r\n  \"type\": \"MovingGeomPoint\",\r\n  \"crs\": {\r\n    \"type\": \"Name\",\r\n    \"properties\": {\r\n      \"name\": \"\"\r\n    }\r\n  },\r\n  \"bbox\": [\r\n    [\r\n      1,\r\n      1\r\n    ],\r\n    [\r\n      2,\r\n      2\r\n    ]\r\n  ],\r\n  \"period\": {\r\n    \"begin\": \"2000-01-01T00:00:00+00\",\r\n    \"end\": \"2000-01-02T00:00:00+00\"\r\n  },\r\n  \"coordinates\": [\r\n    [\r\n      1,\r\n      1\r\n    ],\r\n    [\r\n      2,\r\n      2\r\n    ]\r\n  ],\r\n  \"datetimes\": [\r\n    \"2000-01-01T00:00:00+00\",\r\n    \"2000-01-02T00:00:00+00\"\r\n  ],\r\n  \"lower_inc\": true,\r\n  \"upper_inc\": true,\r\n  \"interpolation\": \"Linear\"\r\n}",
                temp.ToJson());
        }
    }
}