using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a List of integers
        List<int> numbers = new List<int>();

        // Adding elements to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Accessing elements by index
        Console.WriteLine($"Element at index 1: {numbers[1]}");

        // Iterating through the list
        Console.WriteLine("List Elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Checking if a value exists in the list
        int searchValue = 20;
        bool containsValue = numbers.Contains(searchValue);
        Console.WriteLine($"{searchValue} exists in the list: {containsValue}");
        Console.ReadKey();
    }
}


