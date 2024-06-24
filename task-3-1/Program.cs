// Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.
// написать метод который будет генерировать тебе рандомную строку с текстом в котром точно будет тест и всякией цифкруи спец символы
using System;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random strng = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789%$&^";
            int length = 5;
            string randomString = "";
            
            for (int i = 0; i < chars.Length; i++)
            {
                char value = chars[strng.Next(chars.Length)];
                randomString += value;
            }
            randomString += "test";
            Console.WriteLine(randomString);
            
            string modifiedString = Regex.Replace(randomString, @"\d", "")
                .Replace("test", "testing");
            Console.WriteLine(modifiedString);
        }
    }
}

