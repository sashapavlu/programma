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
            Text text = new Text("Калькулятор");
            while(true)
            {
                int act = text.act("Выбери действие\n1 - плюс\n2 - минус\n3 - умножить\n4 - делить");
                int amountOfNumbers = text.AmountOfNumbers("Сколько чисел ты хочешь ввести");
                Calculator calculator = new Calculator(act, amountOfNumbers);
                int dicision = text.StopByDicision("1 - выйти, другое - продолжить");
                if (dicision == 1)
                {
                    break;
                }
            }
        }
    }
}
