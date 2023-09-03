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
            AddressLineTwo = addressLineTwo;
            Number = number;
            ZipCode = zipCode;
            City = city;
            State = state;
            AddressType = addressType;
        }

        public int Id { get; private set; }
        public string Neighborhood { get; private set; }
        public string AddressLineTwo { get; private set; }
        public string Number { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public AddressType AddressType { get; private set; }
    }
}