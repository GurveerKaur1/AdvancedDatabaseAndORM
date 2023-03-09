using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AdvancedDatabaseAndORM.Models.ViewModel
{
    public class CompareAdrressVM
    {

        private DbSet<Address> addresses;
        private DbSet<Customer> customers;

        public List<SelectListItem> Customers { get; } = new List<SelectListItem>();

        public List<SelectListItem> Addresses { get; } = new List<SelectListItem> ();
        public List<SelectListItem> CustomerAddresses { get; } = new List<SelectListItem>();

        public Address address { get; set; }
        public CustomerAddress customerAddress { get; set; }

        public string addressId1 { get; set; }
        public string customerId1 { get; set; }
        public string customerAddressId1 { get; set; }

        public Customer customer { get; set; }
        
        public CompareAdrressVM(DbSet<Customer> customers, DbSet<Address> addresses)
        {
            foreach (Customer c in customers)
            {
                Customers.Add(new SelectListItem(c.FirstName, c.Id.ToString()));
            }
            foreach (Address a in addresses)
            {
                Addresses.Add(new SelectListItem(a.AddressLine1, a.Id.ToString()));
            }
          

        }

        public CompareAdrressVM()
        {

        }
    }
}
