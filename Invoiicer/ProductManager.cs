using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoicer;
using Invoicer.Entities;

namespace Invoicer
{
    public static class ProductManager
    {
        public static void AddProduct(Product p)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Products.Add(p);
                invoiceDbContext.SaveChanges();
            }
        }

        public static List<Product> GetProducts()
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                return invoiceDbContext.Products.ToList();
            }
        }

        public static void DeleteProduct(Product p)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Products.Attach(p);
                invoiceDbContext.Products.Remove(p);
                invoiceDbContext.SaveChanges();
            }
        }

        public static void UpdateProduct(Product p)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Products.AddOrUpdate(p);
                invoiceDbContext.SaveChanges();
            }
        }

    }
}
