using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Validator
    {
        public static bool Validate(string formula)
        {
            bool operation = false;
            for (int i = 0; i < formula.Length; i++)
            {
                char s = formula[i];
                if (!char.IsDigit(s))
                {
                    if (!(s == '+' || s == '-' || s == '/' || s == '*'))
                    {
                        Console.WriteLine($"Invalid character '{s}'");
                        return false;

                    }
                    if (i == formula.Length - 1)
                    {
                        Console.WriteLine($"Last character not valid '{s}'");
                        return false;
                    }
                    if (i == 0)
                    {
                        Console.WriteLine($"First character not valid '{s}'");
                        return false;
                    }
                }
            }
            return true;
        }
    }



}
