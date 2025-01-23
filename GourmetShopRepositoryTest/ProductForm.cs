using GourmetShopLibrary.Interfaces;
using GourmetShopLibrary.Models;
using GourmetShopLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GourmetShopRepositoryTest
{
    public partial class ProductForm : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        IProductRepository repository;
        public ProductForm()
        {
            InitializeComponent();
            LoadProducts();
        }
        private void LoadProducts()
        {
            repository = new ProductRepository(conn);
            var products = repository.GetAllProducts();
            dataGridView1.DataSource = products.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductName = productNameTextBox.Text,
                SupplierID = int.Parse(supplierTextBox.Text),
                UnitPrice = decimal.Parse(priceTextBox.Text),
                Package = stockTextBox.Text,
                IsDiscontinued = false
            };

            repository.AddProduct(product);
            LoadProducts();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.ShowDialog();
            this.Close();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.ShowDialog();
            this.Close();
        }
    }
}
