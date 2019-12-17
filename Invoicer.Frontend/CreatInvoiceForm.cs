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


        public CreatInvoiceForm()
        {
            InitializeComponent();
            ShowList();
            ShowListReceiver();
            DataTimeNow();
            InvoiceNumber();
        }
        private void ShowList()
        {
            products = ProductManager.GetProducts();
            productListBox.ValueMember = "Id";
            productListBox.DisplayMember = "Name";
            productListBox.DataSource = products;

            companies = CompaniesManager.GetCompanies();
            vendorListBox.ValueMember = "Id";
            vendorListBox.DisplayMember = "Name";
            vendorListBox.DataSource = companies;
        }

        private void ShowListReceiver()
        {
            companies = CompaniesManager.GetCompanies();
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
            using (InvoiceDbContext db = new InvoiceDbContext())
            {
                // DbSet<Setting> settings = db.Settings;
                // IList<Setting> qAllSettings = settings.ToList();
                // IList<Setting> qSetting = qAllSettings.Where(x => x.Name == "InvoiceNumber").ToList();
                // IList<string> values = qSetting.Select(x => x.Value).ToList();
                // string value = values.FirstOrDefault();

                string invoiceNumber = string.Empty;
                invoiceNumber = db.Settings.Where(x => x.Name == "InvoiceNumber").Select(x => x.Value).FirstOrDefault();
                month = DateTime.Now.Month;
                year = DateTime.Now.Year;

                maxNumber = db.Invoices.Where(x => x.NumberMonth == month && x.NumberYear == year)
                    .Select(x => x.NumberOrder).DefaultIfEmpty().Max();
                maxNumber++;
                nrInvoiceTextBox.Text = invoiceNumber + "/" + year + "/" + month + "/" + maxNumber;
            }
            //DateTime d = System.DateTime.Now;
            //invno = invno + 1;
            //nrInvoiceTextBox.Text = string.Format("FV/{0:yyyy}/{0:MM}/{1:0000}", d, invno);
        }
        private void ShowListAdded()
        {
            addedListBox.ValueMember = "Id";
            addedListBox.DisplayMember = "Name";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var p = productListBox.SelectedItem as Product;
            p.Amount = Convert.ToInt32(amountTextBox.Text);
            addedListBox.Items.Add(p);
            ShowListAdded();
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
            //i.InvoiceItems = addedListBox.Items;

            InvoiceManager.AddInvoice(i);
            MessageBox.Show("Created");
        }
    }
}
