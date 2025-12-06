using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    abstract class Abstract
    {
        // Soyut metod: *nasıl* yaptığı belli değil
        public abstract void MakeSound();

        // Normal metod: tüm hayvanlarda ortak davranış
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

    class Dog : Abstract
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog says: hav hav");
        }
    }

    class Cat : Abstract
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat says: miyav miyav");
        }
    }

    class Program
            {
        static void Main(string[] args)
        {
            Abstract myDog = new Dog();
            Abstract myCat = new Cat();
            myDog.MakeSound();
            myDog.Sleep();
            myCat.MakeSound();
            myCat.Sleep();
        }
    }
}
