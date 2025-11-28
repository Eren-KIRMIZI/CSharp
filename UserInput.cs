using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class userInput
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Name is: " + name);

            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + age);
        }
    }
}
