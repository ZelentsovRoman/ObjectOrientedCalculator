using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class MultAdvdTests
    {
        [Test]
        [TestCase(2, 7, 14)]
        [TestCase(6.37, 3.2, 20.384)]
        [TestCase(0, 5, 0)]
        [TestCase(6, -6, -36)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            Mult calculator = new Mult();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}