using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        public static void squared(int input)
        {
            Console.WriteLine(input * input); 
        }
        public static void cubed(int input)
        {
            Console.WriteLine(input * input * input);
        }
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            squared(input);
            cubed(input);
        }
    }
}
