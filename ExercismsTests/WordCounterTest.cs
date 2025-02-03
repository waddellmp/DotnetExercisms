using ExercismsLibray;

namespace ExercismsTests;

public class WordCounterTest
{
    [Theory]
    [InlineData("", "", 0)]
    [InlineData("Revenge is a dish best served cold.", "dish", 1)]
    [InlineData("The blue sky has me feeling blue.", "blue", 2)]
    public void WordCounterSuccessTest(string input, string word, int expected)
    {
        // Act
        var actual = WordCounter.CountWords(input, word);
        
        // Assert
        Assert.Equal(expected, actual);
    }
}