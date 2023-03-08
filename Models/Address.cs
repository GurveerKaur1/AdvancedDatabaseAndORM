namespace AdvancedDatabaseAndORM.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }

        public HashSet<CustomerAddress> customerAddresses { get; set; } = new HashSet<CustomerAddress>();
       
        public Address( string addressLine1, string addressLine2, string city, string stateProvince, string countryRegion)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            StateProvince = stateProvince;
            CountryRegion = countryRegion;
        }

        public Address()
        {


        }
    }
}
