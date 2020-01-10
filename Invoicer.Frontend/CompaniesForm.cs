using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private BindingList<Contrahent> companiesList;
        DataTable dtTable = new DataTable();

        // public  = new BindingList<Contrahent>();
        //public List<Contrahent> companiesList = new List<Contrahent>();
        public CompaniesForm()
        {
            InitializeComponent();
            ShowList();
            DataTable dtTable = new DataTable();
            using (SqlConnection dbCon =
                new SqlConnection(
                    @"data source =.\SQLEXPRESS; initial catalog = Invoicer; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework")
            ) ;
         
            {
                
            }
            {
                
            }
        }

        private void ShowList()
        {
            using (InvoiceDbContext invoiceDbContext = new InvoiceDbContext())
            {
                companiesList = new BindingList<Contrahent>(invoiceDbContext.Companies.ToList());
                dataGridViewCompanies.DataSource = companiesList;
            }

            // companies = CompaniesManager.GetCompanies();
            //companiesListBox.ValueMember = "Id";
            //companiesListBox.DisplayMember = "Name";
            //companiesListBox.DataSource = companies;
        }

        private void addCompaniesBtn_Click(object sender, EventArgs e)
        {
            Contrahent c = new Contrahent();
            c.Name = nameCompaniesTextBox.Text;
            //c.NIP = nipTextBox.Text;
            c.Street = steetTextBox.Text;
            c.FlatNumber = flatNumberTextBox.Text;
            c.ZIPCode = zipCodeTextBox.Text;
            c.City = cityTextBox.Text;

            CompaniesManager.AddComapnies(c);
            MessageBox.Show("Dodano");
            ShowList();
            this.Refresh();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewCompanies.SelectedRows)
            {
                dataGridViewCompanies.Rows.RemoveAt(item.Index);
                //int selectedIndex = dataGridViewCompanies.SelectedRows[0].Index;
                //int rowID = int.Parse(dataGridViewCompanies[0, selectedIndex].Value.ToString());
                //string sql = "DELETE FROM Contrahent where RowID = @RowID";
            }

            //var c = dataGridViewCompanies.CurrentCell.RowIndex;
            //dataGridViewCompanies.Rows.RemoveAt(c);
            //CompaniesManager.DeleteCompanies(c);
            //companies.Remove(c);
            // ShowList();
        }
    }
}
