using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdvancedDatabaseAndORM.Models;

namespace AdvancedDatabaseAndORM.Data
{
    public class AdvancedDatabaseAndORMContext : DbContext
    {
        public AdvancedDatabaseAndORMContext (DbContextOptions<AdvancedDatabaseAndORMContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Address { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;

        public DbSet<CustomerAddress> CustomerAddress { get; set; } = default!;

    }
}
