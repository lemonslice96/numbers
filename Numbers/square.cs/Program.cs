using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        public static void square(ref int a)
        {
            Console.WriteLine(a * a);
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Number?");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            square(ref a);
        }
    }
}
