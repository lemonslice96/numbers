using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monogram
{
    class Program
    {
        public void DisplayMonogram(char a, char b, char c, char d, char e, char f)
        {
            Console.WriteLine("** " + a + ". " + b + ". " + c + ". **");
            Console.WriteLine("** " + d + ". " + e + ". " + f + ". **");
 
        }
        static void Main()
        {
            char a = 'J'; char b = 'A'; char c = 'L'; char d = 'R'; char e = 'J';  char f = 'C';
            DisplayMonogram(a, b, c, d, e, f);

        }
    }
}
