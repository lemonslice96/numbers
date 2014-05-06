using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void difference(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static int product(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            int e = 100, r = 50;
            sum(e, r);
            difference(e, r);
            int result = product(e, r);
            Console.WriteLine(result);
        }
    }
}
