using ExercismsLibray;

namespace ExercismsTests;

public class PrimeTest
{
    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    public void IsPrimeTest(int number, bool expected)
    {
        // Act
        var actual = Prime.IsPrime(number);
        
        // Assert
        Assert.Equal(expected, actual);
    }
}