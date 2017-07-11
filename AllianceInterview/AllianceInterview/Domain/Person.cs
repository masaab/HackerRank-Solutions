using AllianceInterview.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Domain
{
    public class Person :Entity
    {
        private string FirstName { get; }
        private string LastName { get; }
        private Address PersonAddress { get; }
        public Person(string firstName, string lastName, Address personAddress)
        {
            FirstName = firstName;
            lastName = LastName;
            PersonAddress = personAddress;
        }

        public new static Person Find(string Id)
        {
            return (Person)Entity.Find(Id);
        }
    }
}
