using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoicer;
using Invoicer.Entities;
using Invoiicer.Entities;

namespace Invoicer.Initializers
{
    class InvoiceDbInitializer : DropCreateDatabaseIfModelChanges<InvoiceDbContext>
    {
        protected override void Seed(InvoiceDbContext context)
        {
            IList<Product> products = new List<Product>();
            products.Add(new Product() { Name = "Olowek", PriceNet = 1, Tax = 0.23, Amount = 20 });
            products.Add(new Product() { Name = "Dlugopis", PriceNet = 9, Tax = 0.13, Amount = 15 });
            products.Add(new Product() { Name = "Pioro", PriceNet = 5, Tax = 0.08, Amount = 10 });
            context.Products.AddRange(products);

            IList<Contrahent> companies = new List<Contrahent>();
            companies.Add(new Contrahent() { Name = "Bratex", City = "Bratkowice", Street = "Blotna", FlatNumber = "35A", ZIPCode = "36-071", TaxNumber = "852147963", IsContrahent = true });
            companies.Add(new Contrahent() { Name = "Michalex", City = "Trzciana", Street = "Jakas", FlatNumber = "3", ZIPCode = "36-071", TaxNumber = "336258147", IsContrahent = true });
            companies.Add(new Contrahent() { Name = "Ziomex", City = "Swilcza", Street = "Dobra", FlatNumber = "56", ZIPCode = "36-071", TaxNumber = "255632145", IsContrahent = true });
            companies.Add(new Contrahent() { Name = "Daarex", City = "Przybyszowka", Street = "Krakowska", FlatNumber = "21", ZIPCode = "37-071", TaxNumber = "879654321", IsContrahent = false });
            context.Companies.AddRange(companies);

            IList<Settings> settings = new List<Settings>();
            settings.Add(new Settings() { Name = "InvoiceNumber", Value = "FV" });
            context.Settings.AddRange(settings);

            base.Seed(context);
        }


    }
}
