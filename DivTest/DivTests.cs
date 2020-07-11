using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class DivTests
    {
        [Test]
        public void CalculateTest()
        {
            Div calculator = new Div();
            Assert.AreEqual(2.5, calculator.Calculate(5, 2));
            Assert.AreEqual(2, calculator.Calculate(10, 5));
            Assert.AreEqual(1, calculator.Calculate(4, 4));
        }
    }
}