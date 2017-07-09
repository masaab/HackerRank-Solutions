using AllianceInterview.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Domain
{
    public class Business 
    {
        private Address BusinessAddress { get; }
        private string Name { get; }
        public Business(string name, Address address)
        {
            BusinessAddress = address;
            Name = name;
        }
        public string Id { get; set; }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public static Business Find(string  Id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
