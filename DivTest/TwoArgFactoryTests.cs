using System;
using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class TwoArgFactoryTests
    {
        [Test]
        [TestCase("Max", typeof(Max))]
        [TestCase("Plus", typeof(Plus))]
        [TestCase("Minus", typeof(Minus))]
        [TestCase("Mult", typeof(Mult))]
        [TestCase("Div", typeof(Div))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgFactory.CreateObjectOrientedCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}