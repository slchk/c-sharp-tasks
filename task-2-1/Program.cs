namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            
            Console.WriteLine("Enter the number");
            string userInput = Console.ReadLine();
           
            if (int.TryParse(userInput, out int number))
            {
                if (array.Contains(number))
                {
                    Console.WriteLine($"Number {number} is in the array");
                }
                else
                {
                    Console.WriteLine($"Number {number} is not in the array.");
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
            
        }
    }
}