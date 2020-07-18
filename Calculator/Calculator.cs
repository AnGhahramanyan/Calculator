using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
namespace Calculator
{
    class Calculator
    {
        public static object Calculate(string formula)
        {
            var calc = new System.Data.DataTable();
            return calc.Compute(formula, "");

        }
    }
}
