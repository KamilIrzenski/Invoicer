
using Invoiicer.Entities;
using Invoiicer.Initializers;

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
    }

   
}