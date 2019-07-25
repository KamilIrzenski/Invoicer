using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoicer.Entities;

namespace Invoicer
{
    public static class CompaniesManager
    {
        public static void AddComapnies(Companies c)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Companieses.Add(c);
                invoiceDbContext.SaveChanges();
            }
        }

    }
}
