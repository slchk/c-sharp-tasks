using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumberArray = { 1, 2, 3, 5 };
            Console.WriteLine(string.Join(", ", firstNumberArray));
            int sum = 0;

            foreach (var number in firstNumberArray)
            {
                sum += number;
            }

            double average = (double)sum / firstNumberArray.Length;
            
            int[] secondNumberArray = { 9, 15, 63 };
            Console.WriteLine(string.Join(", ", secondNumberArray));
            int sum2 = 0;
            foreach (var number in secondNumberArray)
            {
                sum2 += number;
            }

            double average2 = (double)sum2 / secondNumberArray.Length;

            if (average > average2)
            {
                Console.WriteLine(
                    $"The arithmetic mean of array 1 ({average}) is greater than the arithmetic mean of array 2 ({average2})");
            }
            else if (average < average2)
            {
                Console.WriteLine(
                    $"The arithmetic mean of array 1 ({average}) is less than the arithmetic mean of array 2 ({average2})");
            }
            else
            {
                Console.WriteLine(
                    $" The arithmetic mean of array 1 ({average}) is equal to arithmetic mean of array 2 ({average2})");
            }
        }
    }
}