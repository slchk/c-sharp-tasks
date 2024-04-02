using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5 };
            Console.WriteLine(string.Join(", ", numbers));
            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i;
            }

            double average = (double)sum / numbers.Length;
            
            int[] numbers2 = { 9, 15, 63 };
            Console.WriteLine(string.Join(", ", numbers2));
            int sum2 = 0;
            foreach (int j in numbers2)
            {
                sum2 += j;
            }

            double average2 = (double)sum2 / numbers2.Length;

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