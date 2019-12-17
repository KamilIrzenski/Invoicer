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
        public static void AddComapnies(Contrahent c)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Companies.Add(c);
                invoiceDbContext.SaveChanges();
            }
        }

        public static List<Contrahent> GetCompanies()
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                return invoiceDbContext.Companies.ToList();
            }

        }

        public static void DeleteCompanies(Contrahent c)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Companies.Attach(c);
                invoiceDbContext.Companies.Remove(c);
                invoiceDbContext.SaveChanges();
            }
        }

        public static void UpdateCompanies(Contrahent c)
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Companies.AddOrUpdate(c);
                invoiceDbContext.SaveChanges();
            }
        }


    }
}
