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

        public DbSet<AdvancedDatabaseAndORM.Models.Address> Address { get; set; } = default!;
    }
}
