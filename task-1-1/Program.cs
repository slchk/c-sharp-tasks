using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 2;
            double operand2 = 0;
            Console.WriteLine("Enter the arithmetic operation sign");
            string sign = Console.ReadLine();
            switch (sign) 
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if(operand2 == 0)
                    {
                        Console.WriteLine("You cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
                default:
                    Console.WriteLine("You entered the wrong sign");
                    break;
            }
        }
    }
}

