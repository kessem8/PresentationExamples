namespace InterfaceAsReturnedValue
{
    // Implementation of IShape for a Circle
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}