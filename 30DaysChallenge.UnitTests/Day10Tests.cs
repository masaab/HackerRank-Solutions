using System;
using Xunit;

namespace _30DaysChallenge.UnitTests
{
    public class Day10Tests
    {
        [Theory]
        [InlineData(125, 5)]
        [InlineData(5, 1)]
        [InlineData(13, 2)]
        [InlineData(25,2)] 
        public void Day10Test(int input, int expected)
        {
            int actual = Day10.CountTotalConsecutiveOne(input);
            Assert.Equal(expected, actual);
        }
    }
}
