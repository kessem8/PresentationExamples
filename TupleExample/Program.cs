using System;

class Program
{
    static void Main()
    {
        // Creating a tuple without named elements
        var person = Tuple.Create("Bar", 25, "New York");

        // Accessing elements by index
        Console.WriteLine($"Name: {person.Item1}");
        Console.WriteLine($"Age: {person.Item2}");
        Console.WriteLine($"City: {person.Item3}\n");

        // Creating a named tuple
        var namedPerson = (Name: "Eden", Age: 30, City: "Tel Aviv");

        // Accessing elements by name
        Console.WriteLine($"Name: {namedPerson.Name}");
        Console.WriteLine($"Age: {namedPerson.Age}");
        Console.WriteLine($"City: {namedPerson.City}\n");

        // Calling a method that is returning a named tuple
        var returnedPerson = GetPerson(); // 

        // Accessing elements by name
        Console.WriteLine($"Name: {returnedPerson.Name}");
        Console.WriteLine($"Age: {returnedPerson.Age}");
        Console.WriteLine($"City: {returnedPerson.City}");

        Console.ReadKey();
    }

    // Method returning a named tuple
    static (string Name, int Age, string City) GetPerson()
    {
        return ("Dan", 32, "Miami");
    }
}

