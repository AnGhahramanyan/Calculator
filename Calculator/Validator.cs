using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Validator
    {
        public static bool Validate(string formula)
        {
            Console.WriteLine("Validating " + formula);

            foreach (var s in formula)
            {
                if (!char.IsDigit(s) && (s != '+' && s != '-' && s != '/' && s != '*'))

            
                {
                    
                    return false;

                }
               
            }

            return true;


        }

    }



}
