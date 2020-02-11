using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoicer.Entities;

namespace Invoicer
{
    public static class InvoiceManager
    {
        public static void AddInvoice(Invoice i)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Invoices.Add(i);
                invoiceDbContext.SaveChanges();
            }
        }
        public static void AddInvoiceItems(InvoiceItem ii)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                Product product = invoiceDbContext.Products.Where(x => x.ProductID == ii.Product.ProductID).First();
                ii.Product = product;
                invoiceDbContext.InvoiceItems.Add(ii);
                invoiceDbContext.SaveChanges();
            }
        }
    }
}
