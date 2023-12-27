using System;
using System.Collections.Generic;
namespace StackExample
{
    class Program
    {
        static void Main()
        {
            // Creating a stack of integers
            Stack<int> numberStack = new Stack<int>();

            // Pushing elements onto the stack
            numberStack.Push(10);
            numberStack.Push(20);
            numberStack.Push(30);

            // Peeking at the top element
            int topElement = numberStack.Peek();
            Console.WriteLine($"Top Element: {topElement}");

            // Popping elements off the stack
            int poppedElement = numberStack.Pop();
            Console.WriteLine($"Popped Element: {poppedElement}");

            // Iterating through the stack
            Console.WriteLine("Stack Elements:");
            foreach (int number in numberStack)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}


