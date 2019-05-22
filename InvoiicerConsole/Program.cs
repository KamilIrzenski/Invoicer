using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoicer;
using Invoiicer.Entities;

namespace InvoicerConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                invoiceDbContext.Products.ToList();
            }
            
        }
    }
}
