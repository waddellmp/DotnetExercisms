using System.Text.RegularExpressions;

namespace ExercismsLibray;

public static class WordCounter
{
    public static int CountWords(string sentence, string word)
    {
        // Convert sentence to string array
        var words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
        // Remove non-letters
        words = words.Select(w => Regex.Replace(w, @"\W", "")).ToArray();
        
        return words.Count(x => x.Equals(word));
    }
}