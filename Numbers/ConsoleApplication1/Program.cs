using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void feet(int inches)
        {
            Console.WriteLine("{0} feet {1} inches", inches / 12, inches % 12);
        }
        public static void yards(int inches)
        {
            Console.WriteLine("{0} yards and {1} feet and {2} inches", inches / 12 / 3, inches / 12 % 3, inches % 12);
        }
        static void Main(string[] args)
        {
            int inches = 139;
            feet(inches);
            yards(inches);
            
        }
    }
}
