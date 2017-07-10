using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _30DaysChallenge;

namespace _30DayChallengeTest
{
    public class _30DayChallengeTest
    {
    [Fact]
        public void Day1Test()
        {
           DataTypeValue value =   Day1.MainMethod();
            Assert.AreEqual(value.InputInt, 16);
            Assert.AreEqual(value.InputDouble, 8);
            Assert.AreEqual(value.InputString, "Masaab");
        }
    }
}
