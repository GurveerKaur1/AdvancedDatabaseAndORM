namespace AdvancedDatabaseAndORM.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string? Phone { get; set; }

        public HashSet<CustomerAddress> customerAddresses { get; set; } = new HashSet<CustomerAddress>();
      public Customer( string firstName, string lastName, string companyName, string? phone)
        {
          
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            Phone = phone;
        }

        public Customer()
        {

        }
    }
}
