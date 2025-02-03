namespace ExercismsLibray;

public class FindDuplicateInString
{
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