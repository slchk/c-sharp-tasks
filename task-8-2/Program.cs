// Пользователь вводит набор чисел в виде одной строки "1, 2, 3, 4, 4, 5".
// Избавиться от повторяющихся элементов в строке и вывести результат на экран.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers list");
        string input = Console.ReadLine();
        string[] inputs = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        HashSet<int> uniqueNumbers = new HashSet<int>();
        foreach (string item in inputs)
        {
            if (int.TryParse(item, out int number))
            {
                uniqueNumbers.Add(number);
            }
            else
            {
                Console.WriteLine($"'{item}' is not a number.");
            }
        }
        
        List<int> resultList = new List<int>(uniqueNumbers);
        resultList.Sort();
        
        Console.WriteLine($"Unique Numbers: {string.Join(", ", resultList)}");
    }
}