
using System.Data.Entity.ModelConfiguration.Conventions;
using Invoicer.Entities;
using Invoicer.Initializers;
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
            Database.SetInitializer(new InvoiceDbInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Contrahent> Companies { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Settings> Settings { get; set; }

    }


}