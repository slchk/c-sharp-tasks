namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                Random rnd = new Random();
                int value = rnd.Next();
                int[] array = new int[number];
                
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next();
                }

                int minNumber = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < minNumber)
                    {
                        minNumber = array[i];
                    }
                }

                Console.WriteLine($"Minimum value in array is {minNumber}");

                int maxNumber = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > maxNumber)
                    {
                        maxNumber = array[i];
                    }
                }

                Console.WriteLine($"Maximum value in array is {maxNumber}");

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                double averageNumber = (double)sum / array.Length;

                Console.WriteLine($"Average value in array is {averageNumber}");
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }

        }
    }
}
