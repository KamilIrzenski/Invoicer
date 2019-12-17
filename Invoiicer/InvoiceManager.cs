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
    }
}
