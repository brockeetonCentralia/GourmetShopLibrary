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
    public partial class UpdateSupplier : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        ISupplierRepository repository;
        public UpdateSupplier()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            repository = new SupplierRepository(conn);
            var suppliers = repository.GetAllSuppliers();
            dataGridView1.DataSource = suppliers.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                SupplierID = int.Parse(supplierIdTextBox.Text),
                CompanyName = companyNameTextBox.Text,
                ContactName = contactNameTextBox.Text,
                ContactTitle = contactTitleTextBox.Text,
                City = cityTextBox.Text,
                Country = countryTextBox.Text,
                Phone = phoneTextBox.Text,
                Fax = faxTextBox.Text
            };

            repository.UpdateSupplier(supplier);
            LoadSuppliers();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.ShowDialog();
            this.Close();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!deleteSupplierIdTextBox.Text.Equals(String.Empty))
            {
                repository.DeleteSupplier(Convert.ToInt32(deleteSupplierIdTextBox.Text));
                LoadSuppliers();
            }
        }
    }
}
