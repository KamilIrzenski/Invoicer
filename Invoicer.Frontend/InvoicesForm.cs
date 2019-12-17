using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicer.Entities;

namespace Invoicer.Frontend
{
    public partial class InvoicesForm : Form
    {
        public List<Invoice> InvoiceList = new List<Invoice>();
        public InvoicesForm()
        {
            InitializeComponent();

            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {

                InvoiceList = invoiceDbContext.Invoices.ToList();
                dataGridView.DataSource = InvoiceList;
            }
        }
    }
}
