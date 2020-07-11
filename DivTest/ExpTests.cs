using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class ExpTests
    {
        [Test]
        public void CalculateTest()
        {
            Exp calculator = new Exp();
            Assert.AreEqual(148.413159102577, calculator.Calculate(5));
            Assert.AreEqual(0.367879441171442, calculator.Calculate(1));
        }
    }
}