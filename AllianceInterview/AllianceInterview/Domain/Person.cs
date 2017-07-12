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
        public const string textFileName = "Person.txt";
        public string FirstName { get; }
        public string LastName { get; }
        public Address Address { get; }
        public Person(string firstName, string lastName, Address personAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = personAddress;
           
        }

        public new static Person Find(string Id)
        {
            return (Person)Entity.Find(Id);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Person person = (Person)obj;
            return (person.FirstName == this.FirstName) && (person.LastName == this.LastName) && (person.Address.Equals(this.Address));
        }

        public override string ToString()
        {
            return $"{FirstName} | {LastName} | {Address.ToString()} | Person";
        }
    }
}
