namespace CommonInterfaces
{
    // Example class implementing ICloneable, IComparable, and IDisposable
    class Person : ICloneable, IComparable<Person>, IDisposable
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // ICloneable implementation
        public object Clone()
        {
            // Create a new Person object with the same values
            return new Person(Name, Age);
        }

        // IComparable<Person> implementation
        public int CompareTo(Person other)
        {
            // Compare persons based on their age
            return Age.CompareTo(other.Age);
        }

        // IDisposable implementation
        public void Dispose()
        {
            // Implement resource cleanup logic here
            Console.WriteLine($"Disposing resources for {Name}");
        }

        // Custom method to display person information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
    