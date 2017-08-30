using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _30DaysChallenge;
using RandomHackerRank;

namespace _30DayChallengeTest
{
    public class _30DayChallengeTest
    {
        //[TestMethod]
        //public void Day1Test()
        //{
        //   DataTypeValue value =   Day1.MainMethod();
        //    Assert.AreEqual(value.InputInt, 16);
        //    Assert.AreEqual(value.InputDouble, 8);
        //    Assert.AreEqual(value.InputString, "Masaab");
        //}

        [TestMethod]
        public void SockMerchantTest()
        {
            int value =SockMerchant.GetSockPair(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            Assert.AreEqual(3, value);
        }

        [TestMethod]
        public void ArraySumTest()
        {
            int total = ArraySum.AddArrayElement(new[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(15, total);
        }
    }
}
