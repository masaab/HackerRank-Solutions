using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview.Domain
{
    public class Address
    {
        public string Street { get; }
        public string Suburb { get; }
        public string State { get; }
        public string Postcode { get; }
        public Address(string street, string suburb, string state, string postcode)
        {
            Street = street;
            Suburb = suburb;
            State = state;
            Postcode = postcode;
        }

        public override bool Equals(object obj)
        {
            if (obj == null && obj.GetType() != this.GetType())
            {
                return false;
            }
            var address = (Address)obj;
            var value = (address.Street == this.Street) && (address.Suburb == this.Suburb) && (address.State == this.State) && (address.Postcode == this.Postcode);
            return value;
        }

        public override string ToString()
        {
            return $"{Street}-{Suburb}-{State}-{Postcode}".Trim();
        }
    }
}
