// 3. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
// Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную,
// а также всё, что после них во вторую. Результат вывести в консоль. 
using System;
using System.Text.RegularExpressions;

namespace MyApp     
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string[] parts = original.Split("abc");
            string partOne = parts[0];
            string partTwo = parts[1];
            Console.WriteLine(partOne);
            Console.WriteLine(partTwo);
        }
    }
}