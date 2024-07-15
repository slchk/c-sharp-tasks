using System;
using System.Linq;
namespace task_11_1;

delegate string FindWord(List<string> words);
delegate int GetCount(List<string> words);
delegate List<KeyValuePair<string, string>> Transform(Dictionary<string, string> translator);

class Program
{
    static void Main()
    {
        List<string> words = new List<string> { "This", "is", "a", "b", "sequence", "of", "words", "beetroot", "tree", "sper33" };
        Dictionary<string, string> translator = new Dictionary<string, string>()
        {
            { "яблоко", "apple" },
            { "апельсин", "orange" },
            { "киви", "kiwi" }
        };

        WordList wordList = new WordList();
        FindWord del = new FindWord(wordList.GetFirstSingleLetterWord);
        Console.WriteLine(del(words));
        FindWord del2 = new FindWord(wordList.GetLastEe);
        Console.WriteLine(del2(words));
        FindWord del3 = new FindWord(wordList.GetLastWord);
        Console.WriteLine(del3(words));
        GetCount del4 = new GetCount(wordList.GetUniqueValuesAmount);
        Console.WriteLine($"Unique values: {del4(words)}");
        Transform del5 = new Transform(wordList.Transform);
        Console.WriteLine(del5(translator));
        
    }
}
