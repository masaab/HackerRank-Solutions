using AllianceInterview.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Domain
{
    public class Person : IOperation
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
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Find()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            Operation operation``;
            operation.Save(new Person("","",new Address("","","","")));
            throw new NotImplementedException();
        }
    }
}
