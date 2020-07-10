namespace ObjectOrientedCalculator.Operations
{
    public static class OneArgFactory
    {
        public static IOneArgCalculator CreateObjectOrientedCalculator(string operation)
        {
            switch (operation)
            {
                case ("Exp"): return new Exp();
            }
            return null;
        }
    }
}