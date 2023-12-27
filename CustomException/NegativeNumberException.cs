using System;

namespace CustomException
{
    // Custom exception class
    public class NegativeNumberException : Exception
    {
        // Parameterless constructor with a default error message
        public NegativeNumberException() : base("Negative numbers are not allowed.") { }

        // Constructor with a custom error message
        public NegativeNumberException(string message) : base(message) { }
    }
}


