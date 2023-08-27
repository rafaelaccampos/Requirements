using Requirements.Models;

namespace Requirements.Data
{
    public class AddressInDatabase
    {
        public int Id { get; set; }
        public string Neighborhood { get; set; } = null!;
        public string AddressLineTwo { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string City { get; set; } = null!; 
        public string State { get; set; } = null!;
        public AddressType AddressType { get; set; }
    }
}
