using System;
using System.Windows.Forms;
namespace ObjectOrientedCalculator.Operations
{
    public class Div : ITwoArgCalculator
    {
        public double Calculate(double a, double b)
        {
            try
            {
                if (b == 0)
                    throw new Exception("DivideByZeroException");
                return (a / b);

            }
            catch (Exception)
            {

                return (Double.NaN);

            }
        }
    }
}