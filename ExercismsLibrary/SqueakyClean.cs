using System.Text;
using System.Text.RegularExpressions;

namespace ExercismsLibray;

public static class SqueakyClean
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new(identifier);
        // Replace empty spaces with underscores
        sb.Replace(" ", "_");
        // Replace control char with "CTRL"
        sb.Replace("\0", "CTRL");

        // Convert kebab-case to camel case
        var cleaned = sb.ToString().ToCamelCase();

        // Replace non-letters and underscores
        cleaned = Regex.Replace(cleaned, @"[^\w_]", "");
        // Replace Greek lower chars
        cleaned = Regex.Replace(cleaned, @"[\u03B1-\u03C9]", "");
        // Replace numbers with empty spaces
        cleaned = Regex.Replace(cleaned, @"\d", "");
        return cleaned;
    }

    private static string ToCamelCase(this string str)
    {
        // Handle kebab case
        if (str.Contains('-'))
        {
            // Use regex + a capture group to reference it in lambda
            string formatted = Regex.Replace(str, @"-(.)", match =>
            {
                if (match.Groups.Count > 0)
                {
                    return match.Groups[1].Value.ToUpper();
                }

                return match.Value;
            });
            return formatted;
        }

        return str;
    }
}