using System;

namespace ObjectOrientedCalculator.Operations
{
    public class Max : ITwoArgCalculator
    {
        public double Calculate(double a, double b)
        {
            return (Math.Max(a,b));
        }
    }
}