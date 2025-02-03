using ExercismsLibray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismsTests
{
    public class ReverseStringTest
    {
        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        public void ReverseStringSuccess(string input, string expected)
        {
            // Act
            var actual = ReverseString.Reverse(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
