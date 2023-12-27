using System;

namespace CustomException
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Attempt to get a positive number from the user
                int userInput = GetPositiveNumberFromUser();
                Console.WriteLine($"You entered a positive number: {userInput}");
            }
            catch (NegativeNumberException ex)
            {
                // Handle the custom exception for negative numbers
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to get a positive number from the user
        static int GetPositiveNumberFromUser()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the entered number is negative
            if (number < 0)
            {
                // Throw a custom exception for negative numbers
                throw new NegativeNumberException();
            }

            return number;
        }
    }
}

