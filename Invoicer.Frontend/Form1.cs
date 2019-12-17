using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicer.Frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listProductButton_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
        }

        private void companiesButton_Click(object sender, EventArgs e)
        {
            CompaniesForm form = new CompaniesForm();
            form.ShowDialog();

        }

        private void creatInvoiceBtn_Click(object sender, EventArgs e)
        {
            CreatInvoiceForm form = new CreatInvoiceForm();
            form.ShowDialog();
        }

        private void invoicesBtn_Click(object sender, EventArgs e)
        {
            InvoicesForm form = new InvoicesForm();
            form.ShowDialog();
        }
    }
}
