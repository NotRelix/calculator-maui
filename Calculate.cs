﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculate
    {
        public static double DoCalculation(double val1, double val2, string operandMath)
        {
            double result = 0;

            switch (operandMath)
            {
                case "/":
                    result = val1 / val2;
                    break;
                case "-":
                    result = val1 - val2;
                    break;
                case "*":
                    result = val1 * val2;
                    break;
                case "+":
                    result = val1 + val2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
