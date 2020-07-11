using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class DivIOTests
    {
        [Test]
        public void CalculateTest()
        {
            Div calculator = new Div();
            Assert.Throws<System.DivideByZeroException>(() => calculator.Calculate(1, 0));
        }
    }
}