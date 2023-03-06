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

        public string PostalCode { get; set; }
        public CustomerAddress CustomerAddress { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Address()
        {


        }
    }
}
