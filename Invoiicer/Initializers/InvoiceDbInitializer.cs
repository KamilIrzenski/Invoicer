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

            products.Add(new Product() { Name = "Olowek", PriceNet = 1, Tax = 0.23});
            products.Add(new Product() { Name = "Dlugopis", PriceNet = 9, Tax = 0.13 });
            products.Add(new Product() { Name = "Pioro", PriceNet = 5, Tax = 0.08 });

            context.Products.AddRange(products);
            base.Seed(context);
        }


    }
}
