using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Vehicle  // Base Class (parent)
    {
        public string brand = "Ford"; // Vehicle Field
        public void Honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // Derived Class (child)
    {
        public string modelName = "Mustang"; // Car Field
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();  // Create a Vehicle object

            // Call the Honk() method (from the Vehicle class) on the myCar object
            myCar.Honk();

            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
