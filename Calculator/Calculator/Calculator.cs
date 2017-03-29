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
                Console.WriteLine("Введи число a:");
                double numA = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введи число b:");
                double numB = Double.Parse(Console.ReadLine());
                double answer = numA + numB;
                Console.WriteLine(numA + " + " + numB + " = " + answer);
                for (int i = 0; i < AmountOfNumbers; i++)
                {
                    numA = answer;
                    Console.WriteLine("Введи число b:");
                    numB = Double.Parse(Console.ReadLine());
                    answer = numA + numB;
                    Console.WriteLine(numA + " + " + numB + " = " + answer);
                }
            }
        }
    }
}
