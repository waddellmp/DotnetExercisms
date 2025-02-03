using ExercismsLibray;

namespace ExercismsTests;

public class FindDuplicateInStringTest
{
    [Theory]
    [InlineData("abcc", new char[]{'c'})]
    [InlineData("Freddies", new char[]{'d', 'e'})]
    [InlineData("ZombieLand", new char[]{})]
    public void FindDuplicateInStringSuccess(string input, char[] expected)
    {
        // Act
        var actual = FindDuplicateInString.FindDuplicate(input);
        
        // Assert
        Assert.Equal(expected, actual);
    }
}