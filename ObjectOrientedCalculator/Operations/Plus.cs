namespace ObjectOrientedCalculator.Operations
{
    public class Plus : ITwoArgCalculator
    {
        public double Calculate(double a, double b)
        {
            return (a + b);
        }
    }
}
