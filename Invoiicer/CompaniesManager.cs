using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public static List<Companies> GetCompanieses()
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                return invoiceDbContext.Companieses.ToList();
            }
            
        }

        public static void DeleteCompanies(Companies c)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Companieses.Remove(c);
                invoiceDbContext.SaveChanges();
            }
        }

        public static void UpdateCompanies(Companies c)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Companieses.AddOrUpdate(c);
                invoiceDbContext.SaveChanges();
            }
        }


    }
}
