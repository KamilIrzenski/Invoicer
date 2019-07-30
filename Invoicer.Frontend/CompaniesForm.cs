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
    public partial class CompaniesForm : Form
    {
        public List<Companies> companies;
        public CompaniesForm()
        {
            InitializeComponent();
            companies = CompaniesManager.GetCompanieses();
            companiesListBox.DataSource = companies;
        }

        private void addCompaniesBtn_Click(object sender, EventArgs e)
        {
            Companies c = new Companies();
            c.NameCompanies = nameCompaniesTextBox.Text;
            c.NIP = nipTextBox.Text;
            c.Street = steetTextBox.Text;
            c.FlatNumber = int.Parse(flatNumberTextBox.Text);
            c.ZIPCode = zipCodeTextBox.Text;
            c.City = cityTextBox.Text;
           
            CompaniesManager.AddComapnies(c);
            MessageBox.Show("Dodano");


        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
