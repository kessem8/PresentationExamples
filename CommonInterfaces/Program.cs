using System;
namespace CommonInterfaces
{
    class Program
    {
        static void Main()
        {
            // Create instances of Person
            Person person1 = new Person("Dana", 25);
            Person person2 = new Person("Yuval", 30);

            // ICloneable usage
            Person clonedPerson = (Person)person1.Clone();

            // IComparable usage
            int comparisonResult = person1.CompareTo(person2);

            // Display original and cloned persons
            Console.WriteLine("Original Person:");
            person1.DisplayInfo();

            Console.WriteLine("\nCloned Person:");
            clonedPerson.DisplayInfo();

            // Display comparison result
            Console.WriteLine($"\nComparison Result: {comparisonResult}");

            // IDisposable usage (simulate usage within a using statement)
            using (Person disposablePerson = new Person("Noa", 36))
            {
                disposablePerson.DisplayInfo();
                // Resources are automatically disposed when using block exit.
            }
            Console.ReadKey();
        }
    }
}
