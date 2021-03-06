﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicer;
using Invoicer.Entities;


namespace Invoicer.Frontend
{
    public partial class ProductForm : Form
    {
        public List<Product> products;
        private InvoiceDbContext _invoiceDbContext = new InvoiceDbContext();

        public ProductForm()
        {
            InitializeComponent();
            ShowList();
        }

        private void ShowList()
        {
            products = ProductManager.GetProducts(_invoiceDbContext);
            productListBox.ValueMember = "Id";
            productListBox.DisplayMember = "Name";
            productListBox.DataSource = products;
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = nameTextBox.Text;
            p.PriceNet = double.Parse(priceTextBox.Text);
            p.Tax = double.Parse(isbnTextBox1.Text);
            ProductManager.AddProduct(p);
            MessageBox.Show("Dodano!");
            ShowList();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var p = productListBox.SelectedItem as Product;
            productListBox.DataSource = null;
            productListBox.DisplayMember = "Name";
            ProductManager.DeleteProduct(p);
            products.Remove(p);
            ShowList();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var p = productListBox.SelectedItem as Product;
            p.Name = nameTextBox.Text;
            p.Tax = double.Parse(isbnTextBox1.Text);
            p.PriceNet = double.Parse(priceTextBox.Text);
            ProductManager.UpdateProduct(p);
            ShowList();
        }
    }
}
