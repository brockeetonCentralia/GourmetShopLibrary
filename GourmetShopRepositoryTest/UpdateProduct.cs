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
    public partial class UpdateProduct : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        IProductRepository repository;
        public UpdateProduct()
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductID = int.Parse(productIdTextBox.Text),
                ProductName = productNameTextBox.Text,
                SupplierID = int.Parse(supplierIdTextBox.Text),
                UnitPrice = decimal.Parse(unitPriceTextBox.Text),
                Package = packageTextBox.Text,
                IsDiscontinued = false
            };

            repository.UpdateProduct(product);
            LoadProducts();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            this.Close();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
            this.Close();
        }
    }
}
