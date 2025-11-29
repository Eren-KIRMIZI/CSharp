using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class LogicalPuzzle
    {
        static void Main(String[] Args)
        {
            int a = 3;
            int b = 4;
            int c = 2;

            bool result = (a++ > 3 && ++b > 4)
                          || !((c += a) == 6 && b-- > 3);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("result = " + result);
        }
    }
}
