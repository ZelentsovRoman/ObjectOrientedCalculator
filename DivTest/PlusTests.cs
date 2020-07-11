using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class PlusTests
    {
        [Test]
        public void CalculateTest()
        {
            Plus calculator = new Plus();
            Assert.AreEqual(2, calculator.Calculate(1, 1));
            Assert.AreEqual(6.7, calculator.Calculate(5, 1.7));
            Assert.AreEqual(5, calculator.Calculate(0, 5));
        }
    }
}
