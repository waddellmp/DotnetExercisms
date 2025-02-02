using ExercismsLibrary;

namespace ExercismsTests;

public class BirdCountTest
{
    [Theory]
    [InlineData(new int[]{6, 12, 5, 10, 0, 5, 3})]
    public void BirdCountInstance(int[] inlineData)
    {
        // Arrange
        BirdCount _sut = new(inlineData);
        
        // Assert
        Assert.IsType<BirdCount>(_sut);
    }
    
    
}