using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomersWebApp2.Models;

namespace CustomersWebApp2.Data
{
    public class CustomersWebApp2Context : DbContext
    {
        public CustomersWebApp2Context (DbContextOptions<CustomersWebApp2Context> options)
            : base(options)
        {
        }

        public DbSet<CustomersWebApp2.Models.Customer> Customer { get; set; } = default!;
    }
}
