using System;

namespace QuitApp_V2
{
    interface IQuittable
    {
        void Quit();
    }

    // Intern class implements IQuittable
    class Intern : IQuittable
    {
        public string Name { get; set; }

        public void Quit()
        {
            Console.WriteLine($"Intern {Name} has ended their internship.");
            Console.WriteLine("Please fill out the exit survey.");
        }
    }

    class Program
    {
        static void Main()
        {
            Intern intern = new Intern { Name = "John Cina" };

            // Use interface reference
            IQuittable quitter = intern;

            quitter.Quit();

            Console.ReadLine();
        }
    }
}
