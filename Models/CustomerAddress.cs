namespace AdvancedDatabaseAndORM.Models
{
    public class CustomerAddress
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Address Address { get; set; }
        public int AddressId { get; set; }

        public string AddressType { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public CustomerAddress() { }
    }
}

