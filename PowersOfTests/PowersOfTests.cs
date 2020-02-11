using NUnit.Framework;
using PowersOf;

namespace PowersOfTests
{
    public class Tests
    {
        PowerOf powerOf;
        [SetUp]
        public void Setup()
        {
            powerOf = new PowerOf();
        }

        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, true)]
        [TestCase(5, true)]
        [TestCase(6, true)]
        [TestCase(8, true)]
        [TestCase(16, true)]
        [TestCase(32, true)]
        [TestCase(64, true)]
        public void isPowerOf1(int x, bool expectedResult)
        {
            var result = powerOf.isPowerOf(x, 1);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, false)]
        [TestCase(4, true)]
        [TestCase(5, false)]
        [TestCase(6, false)]
        [TestCase(8, true)]
        [TestCase(16, true)]
        [TestCase(32, true)]
        [TestCase(64, true)]
        public void isPowerOf2(int x, bool expectedResult)
        {
            var result = powerOf.isPowerOf(x, 2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1, true)]
        [TestCase(2, false)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, false)]
        [TestCase(6, false)]
        [TestCase(8, false)]
        [TestCase(9, true)]
        [TestCase(27, true)]
        [TestCase(81, true)]
        public void isPowerOf3(int x, bool expectedResult)
        {
            var result = powerOf.isPowerOf(x, 3);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1, true)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, true)]
        [TestCase(5, false)]
        [TestCase(6, false)]
        [TestCase(8, false)]
        [TestCase(16, true)]
        [TestCase(64, true)]
        [TestCase(256, true)]
        public void isPowerOf4(int x, bool expectedResult)
        {
            var result = powerOf.isPowerOf(x, 4);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1, true)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(8, false)]
        [TestCase(25, true)]
        [TestCase(125, true)]
        [TestCase(625, true)]
        public void isPowerOf5(int x, bool expectedResult)
        {
            var result = powerOf.isPowerOf(x, 5);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}