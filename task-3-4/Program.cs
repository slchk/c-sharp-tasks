// 4. Дана строка: Плохой день.
// Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо используя команду
// insert создать строку со значением: Хороший день!!!!!!!!!."God day!!!!!!!!!".
// Replace the last "!" with "?".
using System;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "Bad day";
            string word = "Good";
            string signs = "!!!!!!!!!";
            
            string modified = original.Substring(3,4)
                .Insert(0, word)
                .Insert(8, signs);
            Console.WriteLine(modified);
            
            int lastIndex = modified.LastIndexOf("!");
            string final = modified.Remove(lastIndex, 1)
                .Insert(lastIndex, "?");
            Console.WriteLine(final);
        }
    }
}