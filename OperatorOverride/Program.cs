using System;

namespace OperatorOverride
{

    class Program
    {
        static void Main()
        {
            // Creating instances of the Vector class
            Vector vector1 = new Vector(1.5, 2.0);
            Vector vector2 = new Vector(2.5, 3.5);

            // Using the overloaded + operator to add two vectors
            Vector result = vector1 + vector2;

            // Displaying the result
            Console.WriteLine($"Vector1: {vector1}");
            Console.WriteLine($"Vector2: {vector2}");
            Console.WriteLine($"Result of Addition: {result}");
        }
    }
}


