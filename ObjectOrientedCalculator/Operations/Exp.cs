using System;

namespace ObjectOrientedCalculator.Operations
{
    public class Exp : IOneArgCalculator
    {
        public double Calculate(double a)
        {
            return Math.Exp(a);
        }
    }
}