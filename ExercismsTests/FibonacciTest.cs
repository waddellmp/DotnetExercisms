using ExercismsLibray;

namespace ExercismsTests;

public class FibonacciTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(7, 13)]
    public void ValidFibonacci(int number, int expected)
    {
        // Act
        int fib = Fibonacci.FindFibonacciNumber(number);
        
        // Assert
        Assert.Equal(expected, fib);
    }

    [Theory]
    [InlineData(5, "0,1,1,2,3")]
    [InlineData(6, "0,1,1,2,3,5")]
    [InlineData(7, "0,1,1,2,3,5,8")]
    public void ValidSeries(int number, string expected)
    {
        // Act
        string actual = Fibonacci.FibonacciSeries(number);
        
        // Assert
        Assert.Equal(expected, actual);
    }
}