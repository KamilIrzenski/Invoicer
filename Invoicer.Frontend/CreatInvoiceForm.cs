using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicer.Entities;
using Invoiicer.Entities;

namespace Invoicer.Frontend
{
    public partial class CreatInvoiceForm : Form
    {
        public List<Contrahent> companies;
        public List<Product> products;
        private static int invno = 0;
        private int maxNumber = 0;
        private int month = 0;
        private int year = 0;
        private InvoiceDbContext InvoiceDbContext = new InvoiceDbContext();


        public CreatInvoiceForm()
        {
            InitializeComponent();
            ShowList();
            ShowListReceiver();
            DataTimeNow();
            InvoiceNumber();
        }

        protected override void InitLayout()
        {
            base.InitLayout();


        }

        private void ShowList()
        {
            products = ProductManager.GetProducts(InvoiceDbContext);
            productListBox.ValueMember = "Id";
            productListBox.DisplayMember = "Name";
            productListBox.DataSource = products;
            companies = InvoiceDbContext.Companies.ToList();
            vendorListBox.ValueMember = "Id";
            vendorListBox.DisplayMember = "Name";
            vendorListBox.DataSource = companies;
        }

        private void ShowListReceiver()
        {
            companies = InvoiceDbContext.Companies.ToList();
            receiverListBox.ValueMember = "Id";
            receiverListBox.DisplayMember = "Name";
            receiverListBox.DataSource = companies;
        }

        private void DataTimeNow()
        {
            dateTextBox.Text = DateTime.Now.ToShortDateString();
        }

        private void InvoiceNumber()
        {

            {
                string invoiceNumber = string.Empty;
                invoiceNumber = InvoiceDbContext.Settings.Where(x => x.Name == "InvoiceNumber").Select(x => x.Value).FirstOrDefault();
                month = DateTime.Now.Month;
                year = DateTime.Now.Year;

                maxNumber = InvoiceDbContext.Invoices.Where(x => x.NumberMonth == month && x.NumberYear == year)
                    .Select(x => x.NumberOrder).DefaultIfEmpty().Max();
                maxNumber++;
                nrInvoiceTextBox.Text = invoiceNumber + "/" + year + "/" + month + "/" + maxNumber;
            }

        }
        private void ShowListAdded()
        {
            addedListBox.ValueMember = "Id";
            addedListBox.DisplayMember = "ItemName";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            InvoiceItem ii = new InvoiceItem();
            ii.Product = productListBox.SelectedItem as Product;
            ii.Quantity = Convert.ToInt32(amountTextBox.Text);
            ii.InvoiceID = maxNumber;
            addedListBox.Items.Add(ii);
            ShowListAdded();
            InvoiceDbContext.InvoiceItems.Add(ii);
            InvoiceDbContext.SaveChanges();
        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            Invoice i = new Invoice();

            i.Vendor = vendorListBox.SelectedItem as Contrahent;
            i.Reciever = receiverListBox.SelectedItem as Contrahent;
            i.IssuingDate = Convert.ToDateTime(dateTextBox.Text.ToString());
            i.NumberOrder = maxNumber;
            i.PaymentDate = Convert.ToDateTime(dateTimePicker1.Text);
            i.NumberMonth = month;
            i.NumberYear = year;
            InvoiceDbContext.Invoices.Add(i);
            InvoiceDbContext.SaveChanges();
            MessageBox.Show("Created");
            this.Hide();
            Refresha();
        }

        private void Refresha()
        {
            CreatInvoiceForm cIF = new CreatInvoiceForm();
            cIF.ShowDialog();
        }
    }
}
