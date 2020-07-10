using ObjectOrientedCalculator.Operations;

namespace ObjectOrientedCalculator
{
    public class Mult : ITwoArgCalculator
    {
        public double Calculate(double a, double b)
        {
            return (a * b);
        }
    }
}