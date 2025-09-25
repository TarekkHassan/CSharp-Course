using System;

namespace NumberProcessorApp
{
    class NumberHandler
    {
        public void Handle(int first, int second)
        {
            int newValue = first - 15; // Subtract 15 from the first value
            Console.WriteLine("Modified first number: " + newValue); // Show result
            Console.WriteLine("Unchanged second number: " + second); // Show second
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberHandler handler = new NumberHandler(); // Object created

            handler.Handle(100, 200); // Call with regular arguments

            handler.Handle(second: 300, first: 50); // Named arguments

            Console.ReadKey(); // Keep console open
        }
    }
}
