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

            IList<Company> companies = new List<Company>();
            companies.Add(new Company() { Name = "Bratex", City = "Bratkowice", Street = "Blotna", FlatNumber = "35A", ZIPCode = "36-071", TaxNumber = "852147963", IsContrahent = true });
            companies.Add(new Company() { Name = "Michalex", City = "Trzciana", Street = "Jakas", FlatNumber = "3", ZIPCode = "36-071", TaxNumber = "336258147", IsContrahent = true });
            companies.Add(new Company() { Name = "Ziomex", City = "Swilcza", Street = "Dobra", FlatNumber = "56", ZIPCode = "36-071", TaxNumber = "255632145", IsContrahent = true });
            companies.Add(new Company() { Name = "Daarex", City = "Przybyszowka", Street = "Krakowska", FlatNumber = "21", ZIPCode = "37-071", TaxNumber = "879654321", IsContrahent = false});

            context.Companies.AddRange(companies);
            base.Seed(context);
        }


    }
}
