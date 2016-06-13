using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 5, '*');
            p1.Draw();

            Point p2 = new Point(6, 2, '#');
            p2.Draw();

            HorizontalLine horLine1 = new HorizontalLine(0, 79,0, '+');
            VerticalLine verLine1 = new VerticalLine(0, 24, 0, '+');
            VerticalLine verLine2 = new VerticalLine(0, 24, 79, '+');
            HorizontalLine horLine2 = new HorizontalLine(0, 79, 24, '+');

            Console.SetCursorPosition(1, 1);

            Console.ReadLine();
        }
               

    }
        
}
