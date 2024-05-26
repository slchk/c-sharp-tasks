using System;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Welcome ";
            string word2 = "to the ";
            string word3 = "C# lessons";
            string original = string.Concat(word1, word2, word3);
            Console.WriteLine(original);
        }
    }
}