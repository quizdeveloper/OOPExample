using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // real life
            Console.WriteLine("Hello World!");
            Duck duck = new Duck(); // create an instance of an object.
            duck.Legs = 2;
            duck.Eyes = 2;
            var msg = duck.Run();
            Console.WriteLine(msg);
            Console.ReadKey();
        }


        class Duck
        {
            public int Legs { get; set; }
            public int Eyes { get; set; }

            public string Run()
            {
                return "I'm a duck and I can fly. I have " + Legs+ " leg and I have "+ Eyes+" eyes";
            }
        }
    }
}
