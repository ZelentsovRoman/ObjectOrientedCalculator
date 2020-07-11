using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class MinusTests
    {
        [Test]
        public void CalculateTest()
        {
            Minus calculator = new Minus();
            Assert.AreEqual(-95, calculator.Calculate(5, 100));
            Assert.AreEqual(1, calculator.Calculate(1, 0));
            Assert.AreEqual(2.7, calculator.Calculate(10, 7.3));
        }
    }
}