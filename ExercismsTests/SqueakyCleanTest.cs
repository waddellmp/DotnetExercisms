using ExercismsLibray;

namespace ExercismsTests;

public class SqueakyCleanTest
{
    [Fact]
    public void ReplaceEmptySpacesWithUnderscores()
    {
        string input = "    ";
        
        Assert.Equal("____", SqueakyClean.Clean(input));
    }

    [Fact]
    public void RemoveNumbers()
    {
        string input = "12abc";
        Assert.Equal("abc", SqueakyClean.Clean(input));
    }
    
    [Fact]
    public void ReplaceHyphensWithCamelCase()
    {
        string input = "snake-case";
        Assert.Equal("snakeCase", SqueakyClean.Clean(input));
    }
    
    [Fact]
    public void ReplaceGreekCharacters()
    {
        string input = "MyΟβιεγτFinder";
        Assert.Equal("MyΟFinder", SqueakyClean.Clean(input));
    }
    
    [Fact]
    public void ReplaceSpecialCharacters()
    {
        string input = "My😀😀Finder😀";
        Assert.Equal("MyFinder", SqueakyClean.Clean(input));
    }
}