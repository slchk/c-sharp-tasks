namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            
            Console.WriteLine("Enter the number");
            string userInput = Console.ReadLine();
           
            if (int.TryParse(userInput, out int numberToDelete))
            {
                if (array.Contains(numberToDelete))
                {
                    int newArrayIndex = 0;
                    int newArrayLength = 0;
                    foreach (int number in array)
                    {
                        if (number != numberToDelete)
                        {
                            newArrayLength++;
                        }
                    }
                    
                    int[] newArray = new int[newArrayLength];
                    foreach (int number in array)
                    {
                        if (number != numberToDelete)
                        {
                            newArray[newArrayIndex] = number;
                            newArrayIndex++;
                        }
                    }
                    Console.WriteLine(string.Join(", ", newArray));
                }
                else
                {
                    Console.WriteLine($"Number {numberToDelete} is not in the array.");
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
            
        }
    }
}