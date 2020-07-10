namespace ObjectOrientedCalculator.Operations
{
    public class Minus : ITwoArgCalculator
    {
        public double Calculate(double a, double b)
        {
            return (a - b);
        }
    }
}