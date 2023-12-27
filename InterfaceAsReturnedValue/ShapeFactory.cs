namespace InterfaceAsReturnedValue
{
    // ShapeFactory class with a method returning IShape
    class ShapeFactory
    {
        public IShape CreateShape(string shapeType)
        {
            // Based on user input, return an object implementing IShape
            if (shapeType.ToLower() == "circle")
            {
                return new Circle();
            }
            else if (shapeType.ToLower() == "square")
            {
                return new Square();
            }
            else
            {
                throw new ArgumentException("Invalid shape type");
            }
        }
    }
}



