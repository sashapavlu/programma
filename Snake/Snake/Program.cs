using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 150, 40 );

            HorizontalLine upLine = new HorizontalLine(0, 148, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 148, 39, '+');
            VerticilLine leftLine = new VerticilLine(0, 39, 0, '+');
            VerticilLine rightLine = new VerticilLine(0, 39, 148, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            Point p = new Point(8, 3, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
