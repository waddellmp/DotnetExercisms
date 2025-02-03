using System.Text;

namespace ExercismsLibray
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            if (String.IsNullOrEmpty(input)) return "";

            StringBuilder sb = new();
            
            // Loop through string from end -> start
            for(int i = input.Length - 1; i > -1; i--)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }
    }
}
