using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverse3.cs
{
    class Program
    {
        public static void reverse( ref int thirdint, ref int firstint , ref int secondint)
        {
            firstint = thirdint;
            thirdint = firstint - secondint;
        }
        static void Main(string[] args)
        {
            int firstint = 1; int secondint = 2; int thirdint = 3;
            Console.WriteLine("{0} and {1} and {2}", firstint, secondint, thirdint);
            reverse(ref thirdint, ref firstint, ref secondint);
            Console.WriteLine(firstint);
            Console.WriteLine(secondint);
            Console.WriteLine(thirdint);
        }
    }
}
