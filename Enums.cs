using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Enums
    {
        enum Level
        {
            Low,
            Medium,
            High    
        }

        static void Main(string[] args)
        {
            Level myLevel = Level.Medium;
            switch (myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Level is Low");
                    break;
                case Level.Medium:
                    Console.WriteLine("Level is Medium");
                    break;
                case Level.High:
                    Console.WriteLine("Level is High");
                    break;
            }
        }
    }
}
