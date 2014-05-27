using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monogram
{
    class Program
    {
        public static void DisplayMonogram(char a, char b, char c)
        {
            Console.WriteLine("** " + a + ". " + b + ". " + c + ". **");
           
 
        }
        static void Main()
        {
           char a = 'J'; char b = 'A'; char c = 'L'; char d = 'R'; char e = 'M';  char f = 'D';
           DisplayMonogram(a, b, c);
           DisplayMonogram(d, e, f);

        }
    }
}
