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
            Draw(3, 5, '#');

            Console.ReadLine();
        }

        static void Draw (int x, int y, char sym)
    {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
    }

    }
        
}
