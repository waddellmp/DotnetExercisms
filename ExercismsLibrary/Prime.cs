namespace ExercismsLibray;

public static class Prime
{
    public static bool IsPrime(int number)
    {
        // 0 and 1 are not prime
        if (number < 2) return false;
        
        // Check for divisibility 2 to n - 1
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0) return false;
        }

        // This must mean the number is divisible by itself
        return true;
    }
}