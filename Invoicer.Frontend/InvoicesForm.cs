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
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Invoicer.Frontend
{
    public partial class InvoicesForm : Form
    {
        SqlConnection cn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=Invoicer;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        public SqlDataAdapter da;
        DataTable dt = new DataTable();
        
        public InvoicesForm()
        {
            InitializeComponent();

            {
                string command = "select * from Invoices";
                
                da = new SqlDataAdapter(command, cn);
                da.Fill(dt);
                dataGridView.DataSource = dt;
                this.dataGridView.Columns["Reciever_CompanyID"].Visible = false;
                this.dataGridView.Columns["Vendor_CompanyID"].Visible = false;
            }
        }

    }
}