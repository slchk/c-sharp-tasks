namespace task_10_1;

public class WordList
{
    public string GetFirstSingleLetterWord(List<string> words)
    {
        string result = null;
        foreach (string word in words)
        {
            if (word.Length == 1)
            {
                result = word;
                Console.WriteLine(word);
                break;
            }
        }
        return result;
    }
    
    public string GetLastEe(List<string> words)
    {
        words.Reverse();
        string result = null;
        foreach (string word in words)
        {
            if (word.Contains("ee") )
            {
                result = word;
                Console.WriteLine(word);
                break;
            }
        }
        return result;
    }
    
    public string GetLastWord(List<string> words)
    {
        words.Reverse();
        string result = null;
        int maxLength = words.Max(word => word.Length);
        int minLength = words.Min(word => word.Length);
        foreach (string word in words)
        {
            if (word.Length > minLength && word.Length < maxLength)
            {
                result = word;
                Console.WriteLine(word);
                break;
            }
        }
        return result;
    }
    public int GetUniqueValuesAmount(List<string> words)
    {
        HashSet<string> uniqueValues = new HashSet<string>(words); 
        Console.WriteLine($"Unique Values: {uniqueValues.Count}");
        return uniqueValues.Count; 
    }
    
    public int GetShortestWordLength(List<string> words)
    {
        string result = null;
        int minLength = words.Min(word => word.Length);
        foreach (string word in words)
        {
            if (word.Length == minLength)
            {
                result = word;
                Console.WriteLine($"The shortest word length: {result.Length}");
                break;
            }
        }
        return result.Length;
    }
    
    public string GetThree(List<string> words)
    {
        string result = null;
        foreach (string word in words)
        {
            if (word.Contains("3") )
            {
                result = word;
                Console.WriteLine(word);
                break;
            }
        }
        return result;
    }
    
    public List<KeyValuePair<string, string>> Transform(Dictionary<string, string> translator)
    {
        Dictionary<string, string> reversedDict = new Dictionary<string, string>();

        foreach (var kvp in translator)
        {
            reversedDict[kvp.Value] = kvp.Key;
        }
        
        List<KeyValuePair<string, string>> resultList = reversedDict.ToList();
        
        return resultList;
    }
    
}