using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public Calculator(int act, int AmountOfNumbers)
        {
            if (act == 1)
            {
                Plus plus = new Plus(AmountOfNumbers);
            }
            else if (act == 2)
            {
                Minus minus = new Minus(AmountOfNumbers);
            }
            else if (act == 3)
            {
                Multiply multiply = new Multiply(AmountOfNumbers);
            }
            else if (act == 4)
            {
                Divide divide = new Divide(AmountOfNumbers);
            }
        }
    }
}
