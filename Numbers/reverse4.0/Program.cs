using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverse3.cs
{
    class reverse4
    {
        public static void reverse(ref int w, ref int x, ref int y, ref int z)
        {
            int temp = w; int temp2 = x;
            w = z;
            x = y;
            y = temp2;
            z = temp;
        }
        static void Main(string[] args)
        {
            int w = 0, x = 1, y = 2, z = 3;
            reverse(ref w, ref x, ref y, ref z);
            Console.WriteLine(w);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}
