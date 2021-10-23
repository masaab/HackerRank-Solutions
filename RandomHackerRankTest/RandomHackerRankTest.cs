using System;
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
        public void MinimumFunctionTest()
        {
            MinimumFunction func = new MinimumFunction();
            string data = func.TotalMinimumFunctionCall();
            Assert.Equal("min(int, min(int, min(int, int)))",data);
        }


        [Fact]
        public void MelodiousPassowrdTest()
        {
            MelodiousPassword test = new MelodiousPassword();
        }

        [Fact]
        public void ReplenishBowlTest()
        {
            ReplenishBowl test = new ReplenishBowl();
            var output = test.GetTotalExtraCandiesAdded(8, new int[] { 3, 1, 7, 5 }, 4);
            Assert.Equal(11, output);
        }

        [Theory]
        [InlineData("apple", false)]
        [InlineData("beauty", false)]
        [InlineData("batman", true)]
        [InlineData("superman", true)]
        [InlineData("abyy", false)]
        [InlineData("azei", false)]
        [InlineData("ei", false)]
        [InlineData("i", true)]
        public void BeautifulWordTest(string data, bool expectedValue)
        {
            BeautifulWord t = new BeautifulWord();
            var value = t.CheckCorrectString(data);
            Assert.Equal(expectedValue, value);
        }

        [Theory]
        [InlineData(new int[] { 1, 0, 3, 2 }, true)]
        [InlineData(new int[] { 2,1,0 }, false)]
        public void AccurateSortingTest(int[]data,bool expectedValue)
        {
            AccurateSorting sort = new AccurateSorting();
            bool value = sort.CanSort(data);
            Assert.Equal(expectedValue, value);
        }
    }
}
