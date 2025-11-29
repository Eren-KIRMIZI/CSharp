using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class Assignment
    {
        static void Main(String[] Args)
        {
            int x = 5;
            x |= 3;
            Console.WriteLine("x = " + x);

            int y = 5;
            y ^= 3;
            Console.WriteLine("y = " + y);

            int z = 5;
            x >>= 3;
            Console.WriteLine("z = " + z);

            int w = 5;
            w <<= 3;
            Console.WriteLine("w = " + w);
        }
    }
}
