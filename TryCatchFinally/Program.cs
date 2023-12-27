using System;
using System.Numerics;

namespace TryCatchFinally
{
    class Program
    {
        public static int result;

        static void Main()
        {
            Random rand = new Random();
            Division(10, rand.Next(2));
        }


        public static void Division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
}


