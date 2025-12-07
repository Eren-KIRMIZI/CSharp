using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    // Interface: bir sözleşme
    interface IAnimal
    {
        void MakeSound(); // Gövdesi yok -> zorunlu
        void Move(); // Gövdesi yok -> zorunlu
    }

    // Dog interface'i uyguluyor -> Metotları yazmak zorunda
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("The dog says: hav hav");
        }

        public void Move()
        {
            Console.WriteLine("The dog is running.");
        }
    }

    // Cat interface'i uyguluyor -> Metotları yazmak zorunda
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("The cat says: miyav miyav");
        }
        public void Move()
        {
            Console.WriteLine("The cat is jumping.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal myDog = new Dog();
            IAnimal myCat = new Cat();
            myDog.MakeSound();
            myDog.Move();
            myCat.MakeSound();
            myCat.Move();
        }
    }
}
