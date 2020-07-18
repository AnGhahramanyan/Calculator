using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator
{
    class ConsoleHost

    {
        public static void MyMethod()
        {

            Console.WriteLine("Enter the formula");
            string formula = Console.ReadLine();

            bool valid = Validator.Validate(formula);

            if (valid)
            {
                object answer = Calculator.Calculate(formula);
                Console.WriteLine("Answer is " + answer);
            }
            else
            {
                Console.WriteLine("Your expression is not valid.");
            }
        }
    }
}
    
