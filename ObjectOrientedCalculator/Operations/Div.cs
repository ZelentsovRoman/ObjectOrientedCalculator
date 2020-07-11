﻿using System;
using System.Windows.Forms;
namespace ObjectOrientedCalculator.Operations
{
    public class Div : ITwoArgCalculator
    {
        public double Calculate(double a, double b)
        {
           return (a/b);
        }
    }
}