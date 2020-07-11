using System;
using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class MaxTests
    {
        [Test]
        public void CalculateTest()
        {
            Max calculator = new Max();
            Assert.AreEqual(7, calculator.Calculate(7, 3));
            Assert.AreEqual(3, calculator.Calculate(3, -11));
            Assert.AreEqual(2.5, calculator.Calculate(2.5, 2));
        }
    }
}