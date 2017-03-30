using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Degree
    {
        public Degree(int act)
        {
            Console.WriteLine("Введи число a:");
            double numA = Double.Parse(Console.ReadLine());
            if (act == 5)
            {
                double answer = numA * numA;
                Console.WriteLine(numA + "^2 = " + answer);
            }
            else if (act == 6)
            {
                double answer = numA * numA * numA;
                Console.WriteLine(numA + "^3 = " + answer);
            }
            else if (act == 7)
            {
                double answer = numA * numA * numA * numA;
                Console.WriteLine(numA + "^4 = " + answer);
            }
        }
    }
}
