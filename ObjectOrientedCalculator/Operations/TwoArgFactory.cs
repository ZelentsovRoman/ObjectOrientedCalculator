namespace ObjectOrientedCalculator.Operations
{
    public static class TwoArgFactory
    {
        public static ITwoArgCalculator CreateObjectOrientedCalculator(string operation)
        {
            switch (operation)
            {
                case ("Plus"): return new Plus();
                case ("Minus"): return new Minus();
                case ("Mult"): return new Mult();
                case ("Div"): return new Div();
                case ("Max"): return new Max();
            }
            return null;
        }
    }
}