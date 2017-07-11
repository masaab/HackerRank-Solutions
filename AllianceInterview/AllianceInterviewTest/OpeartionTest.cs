using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllianceInterview.Domain;

namespace AllianceInterviewTest
{
    [TestClass]
    public class OpeartionTest
    {
        private Address GetAddress()
        {
            return new Address("street", "suburb", "state", "4127");
        }
        [TestMethod]
        public void PersonTest()
        {
            Person person = new Person("masaab", "mushtaq", GetAddress());
            Assert.IsNotNull(person.Id);
            person.Save();
        }
    }
}
