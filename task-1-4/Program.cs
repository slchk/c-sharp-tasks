using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            if (number % 2 == 0)
            {
                Console.WriteLine("The first number is even");
            }
            else
            {
                Console.WriteLine("The first number is odd");
            }

            int number2 = 6;
            string message = (number2 % 2 == 0) ? "even" : "odd";
            Console.WriteLine($"The second number is {message}");
        }
    }
}