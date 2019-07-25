
using Invoicer.Entities;
using Invoicer.Initializers;

namespace Invoicer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InvoiceDbContext : DbContext
    {
       
        public InvoiceDbContext() : base("name=InvoiceDbContext")
        {
            Database.SetInitializer(new InvoiceDbInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Companies> Companieses { get; set; }
    }

   
}