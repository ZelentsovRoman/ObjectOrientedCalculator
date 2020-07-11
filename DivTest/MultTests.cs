using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class MultTests
    {
        [Test]
        public void CalculateTest()
        {
            Mult calculator = new Mult();
            Assert.AreEqual(10, calculator.Calculate(5, 2));
            Assert.AreEqual(100, calculator.Calculate(10, 10));
            Assert.AreEqual(-5, calculator.Calculate(5, -1));
        }
    }
}