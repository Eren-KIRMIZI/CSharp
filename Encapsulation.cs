using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}
