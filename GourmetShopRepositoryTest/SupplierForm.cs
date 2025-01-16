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
    public partial class SupplierForm : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        ISupplierRepository repository;
        public SupplierForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            repository = new SupplierRepository(conn);
            var suppliers = repository.GetAllSuppliers();
            dataGridView1.DataSource = suppliers.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                CompanyName = companyNameTextBox.Text,
                ContactName = contactNameTextBox.Text,
                ContactTitle = contactTitleTextBox.Text,
                City = cityTextBox.Text,
                Country = countryTextBox.Text,
                Phone = phoneTextBox.Text,
                Fax = faxTextBox.Text
            };

            repository.AddSupplier(supplier);
            LoadProducts();
        }
    }
}
