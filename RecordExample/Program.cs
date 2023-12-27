using System;

// Defining a record named Person with three properties: FirstName, LastName, and Age
record Person(string FirstName, string LastName, int Age);

class Program
{
    static void Main()
    {
        // Creating a record
        var person1 = new Person("John", "Doe", 30);

        // Displaying record properties
        Console.WriteLine($"person1- Name: {person1.FirstName} {person1.LastName}, Age: {person1.Age}");

        // Creating a new record with modified values
        var person2 = person1 with { Age = 31 };

        // Displaying the modified record
        Console.WriteLine($"person2- Name: {person2.FirstName} {person2.LastName}, Age: {person2.Age}");

        // Checking equality between records 
        bool areEqual = person1.Equals(person2);
        Console.WriteLine($"Are person1 and person2 equal? {areEqual}");

        // Checking equality using the == operator (compares values)
        bool usingEqualityOperator = person1 == person2;
        Console.WriteLine($"Using == operator: {usingEqualityOperator}");

        // Checking reference equality using ReferenceEquals (should be false for records)
        bool referenceEquality = ReferenceEquals(person1, person2);
        Console.WriteLine($"Reference equality: {referenceEquality}");

        // Deconstructing the original record (person1) into individual variables
        var (firstName, lastName, age) = person1;
        Console.WriteLine($"Deconstructed: {firstName} {lastName}, Age: {age}");
        Console.ReadKey();
    }
}


