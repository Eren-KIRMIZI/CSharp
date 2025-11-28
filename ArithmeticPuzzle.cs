using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class UserInput
    {
        static void Main(String[] Args)
        {
            int x = 5;
            int y = 8;

            int a = ++x + y--;    // Ön artırma x=6, sonra ekle 6+8=14, sonra y=7
            int b = x * y + x--;  // x=6*7=42 + x--(6) = 48, sonra x=5
            int c = y / ++x;      // x=6, y=7/6=1 (tamsayı bölme)
            int d = b % c + --y;  // b % c = 48 % 1 = 0, y=6, toplam = 6

            int result = a + b - c * d + x % y; // karmaşık formül

            Console.WriteLine("Sonuç = " + result);
        }
    }
}
