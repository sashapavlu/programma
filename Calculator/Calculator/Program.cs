using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text("КАЛЬКУЛЯТОР");
            while(true)
            {
                int act = text.act("Выбери действие\n1 - плюс\n2 - минус\n3 - умножить\n4 - делить\n5 - a^2\n6 - a^3\n7 - a^4");
                if (act <= 4)
                {
                    int amountOfNumbers = text.AmountOfNumbers("Сколько чисел ты хочешь ввести");
                    amountOfNumbers = amountOfNumbers - 2;
                    Calculator calculator = new Calculator(act, amountOfNumbers);
                }
                else if (act > 4 && act < 8)
                {
                    Degree degree = new Degree(act);
                }
                int dicision = text.StopByDicision("1 - выйти, другое - продолжить");
                if (dicision == 1)
                {
                    break;
                }
            }
        }
    }
}
