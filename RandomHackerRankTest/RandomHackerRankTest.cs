using System.Collections.Generic;
using RandomHackerRank;
using Xunit;

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
    }
}
