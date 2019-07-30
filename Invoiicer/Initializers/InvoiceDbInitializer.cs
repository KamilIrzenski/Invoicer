using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoicer;
using Invoicer.Entities;

namespace Invoicer.Initializers
{
    class InvoiceDbInitializer : DropCreateDatabaseIfModelChanges<InvoiceDbContext>
    {
        protected override void Seed(InvoiceDbContext context)
        {
            IList<Product> products = new List<Product>();

            products.Add(new Product() { Name = "Olowek", Description = "Olowek", Amount = 100, ISBN = "1234", Price = 1 });
            products.Add(new Product() { Name = "Dlugopis", Description = "Dlugopis", Amount = 200, ISBN = "2345", Price = 2 });
            products.Add(new Product() { Name = "Pioro", Description = "Pioro", Amount = 300, ISBN = "3456", Price = 3 });

            context.Products.AddRange(products);
            base.Seed(context);
        }


    }
}
