using System;

namespace GenericExample
{
    class Program
    {
        static void Main()
        {
            // Create an instance of MaximumFinder
            MaximumFinder maximumFinder = new MaximumFinder();

            // Find the maximum of two integers
            int maxInt = maximumFinder.FindMaximum(10, 5);
            Console.WriteLine($"Maximum of 10 and 5: {maxInt}");

            // Find the maximum of two doubles
            double maxDouble = maximumFinder.FindMaximum(7.5, 9.2);
            Console.WriteLine($"Maximum of 7.5 and 9.2: {maxDouble}");

            // Find the maximum of two strings
            string maxString = maximumFinder.FindMaximum("apple", "orange");
            Console.WriteLine($"Maximum of 'apple' and 'orange': {maxString}");
            Console.ReadKey();
        }
    }
}

