using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class dataTypes
    {
        static void Main(String[] Args)
        {
            string name = "Eren";
            Console.WriteLine("My name is " + name);

            int myAge = 23;
            Console.WriteLine("I am " + myAge + " years old.");

            double weight = 74.50;
            Console.WriteLine("My weight is " + weight + " kg.");

            float height = 1.74f; 
            Console.WriteLine("My height is " + height + " meters.");

            char surnameInitial = 'K';
            Console.WriteLine("My surname starts with the letter " + surnameInitial + ".");

            bool myAnswer = true;
            Console.WriteLine("Do you like coding?");
            Console.WriteLine("My answer is: " + myAnswer);

            String myMessage = "I am learning C# programming.";
            Console.WriteLine(myMessage);

            decimal bankBalance = 500.75m; 
            Console.WriteLine("My bank balance is TL" + bankBalance);

            DateTime birthDate = new DateTime(2002, 8, 30);
            Console.WriteLine("My birth date is " + birthDate.ToShortDateString());

            var favoriteLanguage = "C#"; // var otomatik tipi belirler
            Console.WriteLine("My favorite programming language is " + favoriteLanguage);

            // Object (her türü saklayabilir)
            object randomValue = 12345;
            Console.WriteLine("Object: Random value is " + randomValue);

            // Const (sabit değer)
            const double Pi = 3.14159;
            Console.WriteLine("Const: Pi value is " + Pi);

            string lastName = "KIRMIZI";
            string fullName = name + " " + lastName;
            Console.WriteLine("Hello " + fullName);

            int x = 5, y = 7;
            Console.WriteLine(x + y);
        }
    }
}
