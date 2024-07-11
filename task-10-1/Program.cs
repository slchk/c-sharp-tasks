using System;
using System.Collections.Generic;

namespace task_10_1;

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
        del(words);
        FindWord del2 = new FindWord(wordList.GetLastEe);
        del2(words);
        FindWord del3 = new FindWord(wordList.GetLastWord);
        del3(words);
        GetCount del4 = new GetCount(wordList.GetUniqueValuesAmount);
        del4(words);
        GetCount del5 = new GetCount(wordList.GetShortestWordLength);
        del5(words);
        FindWord del6 = new FindWord(wordList.GetThree);
        del6(words);
        Transform del7 = new Transform(wordList.Transform);
        del7(translator);
    }
}



 




