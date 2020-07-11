using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class DivAdvTests
    {
        [Test]
        [TestCase(1, 2, 0.5)]
        [TestCase(6, 3, 2)]
        [TestCase(10, 10, 1)]
        [TestCase(0, 4, 0)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Div();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}