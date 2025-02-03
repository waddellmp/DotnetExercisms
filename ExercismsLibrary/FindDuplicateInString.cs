namespace ExercismsLibray;

public class FindDuplicateInString
{
    // public static char[] FindDuplicate(string input)
    // {
    //     char[] chars = input.ToCharArray();
    //     char[] duplicates = [];
    //     foreach (var c in chars)
    //     {
    //         if (chars.Count(x => x == c) > 1)
    //         {
    //             duplicates.Append(c);
    //         }
    //     }
    //     return duplicates;
    // }
    public static IEnumerable<char> FindDuplicate(string input)
    {
        // User a hashset for enforced key uniqueness.
        HashSet<char> hash = new();

        foreach (var c in input)
        {
            if (hash.Contains(c))
            {
                yield return c;
            }
            
            hash.Add(c);
        }
    }
    
}