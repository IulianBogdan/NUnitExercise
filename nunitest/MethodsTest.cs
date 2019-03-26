using NUnit.Framework;

namespace nunitest
{
    [TestFixture]
    class MethodsTest
    {
        public static Methods methods;
        [SetUp]
        public void Setup()
        {
            methods = new Methods();
        }

        [Test]
        public void GetCircleAreaTest_True()
        {
            int value = 5;
            Assert.AreNotEqual(78.54, methods.GetCircleArea(value));
        }

        [Test]
        public void GetCircleAreaTest_False()
        {
            int value = 5;
            Assert.AreNotEqual(90, methods.GetCircleArea(value));
        }

        [Test]
        public void GetFactorialTest_True()
        {
            int value = 8;
            Assert.AreEqual(40320, methods.GetFactorial(value));
        }

        [Test]
        public void GetFactorialTest_False()
        {
            int value = 8;
            Assert.AreNotEqual(30, methods.GetFactorial(value));
        }

        [Test]
        public void GetSum_True()
        {
            int[] value = new int[5] { 5, 6, 3, 1, 6 };
            Assert.AreEqual(21, methods.CalculateSum(value));
        }

        [Test]
        public void GetSum_False()
        {
            int[] value = new int[5] { 5, 6, 3, 1, 6 };
            Assert.AreEqual(21, methods.CalculateSum(value));
        }
    }
}
