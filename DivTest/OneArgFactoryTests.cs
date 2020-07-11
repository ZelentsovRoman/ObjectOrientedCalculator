using System;
using NUnit.Framework;
using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator.Tests.Operations
{
    [TestFixture]
    public class OneArgFactoryTests
    {
        [Test]
        [TestCase("Exp", typeof(Exp))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgFactory.CreateObjectOrientedCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}