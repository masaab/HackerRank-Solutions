using System.Collections.Generic;
using RandomHackerRank;
using Xunit;
using System.Linq;

namespace RandomHackerRankTest
{
   
    public class RandomHackerRankTest
    {
        [Fact]
        public void _2DArrayTest()
        {
            _2DArray array = new _2DArray();
            int? sum = array.GetLargestGlassHourSum();
            Assert.Equal(-6, sum);

        }

        [Fact]
        public void ReplenishBowlTest()
        {
            ReplenishBowl test = new ReplenishBowl();
            var output = test.GetTotalExtraCandiesAdded(8,new int[] { 3, 1, 7, 5 }, 4);
            Assert.Equal(11, output);
        }

        [Fact]
        public void BonAppetitTest()
        {
            var value = BonAppetit.ReturnExtraAmount(new List<int> { 3, 10, 2, 9 }, 1, 7);
            Assert.Equal(0, value);
        }

        [Fact]
        public void NonBonAppetitTest()
        {
            var value = BonAppetit.ReturnExtraAmount(new List<int> { 3, 10, 2, 9 }, 1, 12);
            Assert.Equal(5, value);
        }

        [Fact]
        public void BonAppetitTest2()
        {
            var value = BonAppetit.ReturnExtraAmount(new List<int> { 40,39,97,5,2,84,35,93,59,39 }, 2, 198);
            Assert.Equal(0, value);
        }

        [Theory]
        [InlineData(6,2,1)]
        [InlineData(5, 4,0)]
        [InlineData(7, 4,1)]
        [InlineData(6,5, 1)]
        public void DrawingBookTest(int bookSize, int pageNumber,int expectedInteger)
        {
            DrawingBook book = new DrawingBook();
            {
                var value = book.PageTurningPoint(bookSize, pageNumber);
                Assert.Equal(expectedInteger, value);
            }
        }

        [Theory]
        [InlineData(6,3)]
        public void JesseStrengthTest(int JesseStrength, int expectedAnswer)
        {
            int[] stones = { 4, 3, 7, 6, 7, 2, 2 };
            JesseRock.GetInputs(stones.ToList(), JesseStrength);
        }

        [Theory]
        [InlineData(20, 3, 6, 80, 6)]
        [InlineData(20, 3, 6, 85, 7)]
        [InlineData(100, 1, 1, 99, 0)]
        [InlineData(100,99,81,180, 1)]
        public void HalloweenSale(int originalPrice, int priceDeduction, int thresholdPrice, int userAmount, int expectedResult)
        {
            HalloweenSale sale = new HalloweenSale();
            int actualResult = sale.CalculateTotalGames(originalPrice, priceDeduction, thresholdPrice, userAmount);
            Assert.Equal(actualResult, expectedResult);
        }
    }
}
