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
                    int newArrayIndex = 0;
                    int newArrayLength = 0;
                    foreach (int i in array)
                    {
                        if (i != number)
                        {
                            newArrayLength++;
                        }
                    }
                    
                    int[] newArray = new int[newArrayLength];
                    foreach (int i in array)
                    {
                        if (i != number)
                        {
                            newArray[newArrayIndex] = i;
                            newArrayIndex++;
                        }
                    }
                    Console.WriteLine(string.Join(", ", newArray));
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