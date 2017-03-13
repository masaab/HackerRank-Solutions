﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomHackerRank;

namespace RandomHackerRankTest
{
    [TestClass]
    public class RandomHackerRankTest
    {
        [TestMethod]
        public void _2DArrayTest()
        {
            _2DArray array = new _2DArray();
            int? sum = array.GetLargestGlassHourSum();
            Assert.AreEqual(-6, sum);

        }

        [TestMethod]
        public void ReplenishBowlTest()
        {
            ReplenishBowl test = new ReplenishBowl();
            var output = test.GetTotalExtraCandiesAdded(8,new int[] { 3, 1, 7, 5 }, 4);
            Assert.AreEqual(11, output);
        }
    }
}
