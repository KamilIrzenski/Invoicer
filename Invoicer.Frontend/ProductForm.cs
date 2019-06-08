using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoiicer;
using Invoiicer.Entities;


namespace Invoicer.Frontend
{
    public partial class ProductForm : Form
    {
        public List<Product> products;

        public ProductForm()
        {
            InitializeComponent();
            products = ProductManager.GetProducts();
            productListBox.DataSource = products;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = nameTextBox.Text;
            p.Amount = int.Parse(amountTextBox.Text);
            p.Price = int.Parse(priceTextBox.Text);
            p.ISBN = isbnTextBox1.Text;
            p.Description = descriptionTextBox.Text;

            ProductManager.AddProduct(p);
            MessageBox.Show("Dodano!");
        }
    }
}
