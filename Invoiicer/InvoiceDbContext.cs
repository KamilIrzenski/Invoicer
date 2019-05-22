
using Invoiicer.Entities;

namespace Invoicer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InvoiceDbContext : DbContext
    {
       
        public InvoiceDbContext() : base("name=InvoiceDbContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }

   
}