#nullable enable

using System;

class Program
{
    static void Main()
    {
        // Nullable reference types in variables
        string? nullableString = null;
        // Without the ? operator we would get a null exception
        Console.WriteLine($"Length of nullableString: {nullableString?.Length}");

        // Nullable reference types in a method call
        DisplayLength(nullableString); // Pass the nullable string to the method

        // Non-nullable string
        DisplayLength("Hello");

        Console.ReadKey();
    }

    // Method with nullable parameters
    static void DisplayLength(string? text)
    {
        // Null check to avoid null reference exception
        if (text != null)
        {
            Console.WriteLine($"Length of text: {text.Length}"); 
        }
        else
        {
            Console.WriteLine("Text is null.");
        }
    }
}


