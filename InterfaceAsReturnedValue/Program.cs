using System;


namespace InterfaceAsReturnedValue
{
    class Program
    {
        static void Main()
        {
            // Instance of ShapeFactory
            ShapeFactory shapeFactory = new ShapeFactory();

            // Get a shape based on user input
            Console.Write("Enter shape type (circle or square): ");
            string userInput = Console.ReadLine();

            try
            {
                // Use the factory method to create a shape and call its Draw method
                IShape shape = shapeFactory.CreateShape(userInput);
                shape.Draw();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}





