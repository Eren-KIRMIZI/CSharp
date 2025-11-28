using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class TypeCasting
    {
        static void Main(String[] args)
        {
            // Implicit Casting (automatically) - converting a smaller type to a larger type size
            // char -> int -> long -> float -> double

            int myInt = 9;
            double myDouble = myInt; // Implicit casting: int to double 

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            double myDouble2 = 9.78;
            int myInt2 = (int) myDouble2; // Explicit casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9

            Console.WriteLine();

            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt3));    // Converts int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // Converts int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // Converts double to int
            Console.WriteLine(Convert.ToString(myBool));    // Converts bool to string
        }
    }
}
