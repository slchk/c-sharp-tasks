using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            if(number >= 0 && number <= 14)
            {
                Console.WriteLine("Number falls within the range [0 - 14]");
            }
            else if(number >= 15 && number <= 35)
            {
                Console.WriteLine("Number falls within the range [15 - 35]");
            }
            else if(number >= 36 && number <= 50)
            {
                Console.WriteLine("Number falls within the range [36 - 50]");
            }
            else if(number >= 50 && number <= 100)
            {
                Console.WriteLine("Number falls within the range [50 - 100]");
            }
            else
            {
                Console.WriteLine("Your number is not in any of the ranges");
            }
                
        }
    }
}