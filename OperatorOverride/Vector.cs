using System;

namespace OperatorOverride
{
    // Vector class representing a 2D vector
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor to initialize the vector
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Overloading the + operator to add two vectors
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Overriding the ToString method for better representation
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}

