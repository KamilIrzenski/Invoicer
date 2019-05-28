using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoicer;
using Invoiicer.Entities;

namespace Invoiicer
{
    public static class ProductManager
    {
        public static void AddProduct(Product p)
        {
            using (InvoiceDbContext context = new InvoiceDbContext())
            {
                context.Products.Add(p);
                context.SaveChanges();
            }
        }
    }
}
