namespace task_11_1;

public class WordList
{
    public string GetFirstSingleLetterWord(List<string> words)
    {
        return words.FirstOrDefault(word => word.Length == 1);
    }

    public string GetLastEe(List<string> words)
    {
        return words.LastOrDefault(word => word.Contains("ee"));
    }

    public string GetLastWord(List<string> words)
    {
        int maxLength = words.Max(word => word.Length);
        int minLength = words.Min(word => word.Length);
        return words.LastOrDefault(word => word.Length > minLength && word.Length < maxLength);;
    }
    public int GetUniqueValuesAmount(List<string> words)
    {
        return words.Distinct().Count();
    }
    
    public List<KeyValuePair<string, string>> Transform(Dictionary<string, string> translator)
    {
        return translator.Select(kvp => new KeyValuePair<string, string>(kvp.Value, kvp.Key)).ToList();
    }
}