using System.Runtime.CompilerServices;

namespace Requirements.Models
{
    public class Address
    {
        public Address(
            string neighborhood, 
            string addressLineTwo,
            string number,
            string zipCode,
            string city,
            string state,
            AddressType addressType)
        {
            Neighborhood = neighborhood;
            AdressLineTwo = addressLineTwo;
            Number = number;
            ZipCode = zipCode;
            City = city;
            State = state;
            AddressType = addressType;
        }

        public int Id { get; set; }
        public string Neighborhood { get; private set; }
        public string AdressLineTwo { get; private set; }
        public string Number { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public AddressType AddressType { get; set; }
    }
}