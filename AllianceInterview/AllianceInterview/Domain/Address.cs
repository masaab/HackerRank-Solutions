using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Domain
{
    public class Address
    {
        private string Street { get; }
        private string Suburb { get; }
        private string State { get; }
        private string Postcode { get; }
        public Address(string street, string suburb, string state, string postcode)
        {
            Street = street;
            Suburb = suburb;
            State = state;
            Postcode = postcode;
        }
    }
}
