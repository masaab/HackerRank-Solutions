using AllianceInterview.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Domain
{
    public class Business:Entity
    {
        private Address BusinessAddress { get; }
        private string Name { get; }
        public Business(string name, Address address)
        {
            BusinessAddress = address;
            Name = name;
        }
        public new static Business Find(string Id)
        {
            return (Business)Entity.Find(Id);
        }

     
    }
}
