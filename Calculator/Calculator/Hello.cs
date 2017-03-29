using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Text
    {
        public Text (string greeting)
        {
            Console.WriteLine(greeting);
        }
        public int act (string ActText)
        {
            Console.WriteLine(ActText);
            int act = Int32.Parse(Console.ReadLine());
            return act;
        }
        public int StopByDicision(string TextExit)
        {
            Console.WriteLine(TextExit);
            int decision = Int32.Parse(Console.ReadLine());
            return decision;
        }
        public int AmountOfNumbers (string TextNum)
        {
            Console.WriteLine(TextNum);
            int amountOfNumbers = Int32.Parse(Console.ReadLine());
            return amountOfNumbers;
        }
    }
}
