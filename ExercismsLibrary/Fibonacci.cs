using System.Text;

namespace ExercismsLibray;

public static class Fibonacci
{
    // Naive approach
    public static int FindFibonacciNumber(int n)
    {
        // Fibonacci series begins with 0 and 1
        if (n <= 1)
        {
            return n;
        }
        
        // Next Fibonacci is the sum of two preceding fiboncacci numbers.
        return FindFibonacciNumber(n - 1) + FindFibonacciNumber(n - 2);
    }

    public static string FibonacciSeries(int n)
    {
        int a = 0, b = 1;
        StringBuilder sb = new();
        
        // Loop through n number of times to get the corresponding fib
        for (int i = 0; i < n; i++)
        {
            sb.Append(a.ToString() + ",");
            int temp = a + b;
            a = b;
            b = temp;
        }

        return sb.ToString().Remove(sb.Length - 1, 1);
    }
}