using AllianceInterview.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Domain
{
    public class Business : IOperation
    {
        private Address BusinessAddress { get; }
        private string Name { get; }
        public Business(string name, Address address)
        {
            BusinessAddress = address;
            Name = name;
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
            throw new NotImplementedException();
        }
    }
}
