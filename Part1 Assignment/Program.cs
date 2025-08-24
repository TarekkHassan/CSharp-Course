using System;

class Program
{
    static void Main()
    {
        //  welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        //  package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if weight exceeds the maximum allowed
        if (weight > 50)
        {
            //  error message and end the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // package width
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        //  package height
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        //  package length
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate the sum 
        double dimensionTotal = width + height + length;

        // Check if the total  exceed the maximum allowed
        if (dimensionTotal > 50)
        {
            //  error message and end the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the quote using the formula: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        //  the estimated shipping cost formatted as currency
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        //  thank you message
        Console.WriteLine("Thank you!");
    }
}
