using GourmetShopLibrary.Models;
using GourmetShopLibrary.Repositories;
using Microsoft.Data.SqlClient;
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
    public partial class CustomerSupplierLookup : Form
    {

        private readonly ProductRepository _productRepository;
        private readonly string _connectionString;

        public CustomerSupplierLookup()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            InitializeComponent();
            _productRepository = new ProductRepository(connectionString);
        }

        private void SearchSupplierID_Click(object sender, EventArgs e)
        {
            var supplierID = int.Parse(SupplierIDtxt.Text);
            var product = GetbySupplierID(supplierID);
            var cartlist = new List<Product>();

            cartlist.Add(product);

            ProductDGV.DataSource = cartlist.ToList();
        }

        private void ViewCartbtn_Click(object sender, EventArgs e)
        {
            CustomerSupplierLookup customerSupplierLookup = new CustomerSupplierLookup();
            customerSupplierLookup.Show();
            this.Close();
        }

        private void AddtoCartbtn_Click(object sender, EventArgs e)
        {
            var supplierID = int.Parse(SupplierIDtxt.Text);
            var product = ProductDGV.SelectedRows[0].DataBoundItem as Product;
            var cartlist = new List<Product>();

            cartlist.Add(product);

            //CartGridView.DataSource = cartlist.ToList(); // TODO: Still working on this one @SH
        }

        public Product GetbySupplierID(int supplierID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Product WHERE SupplierId = @SupplierID", connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", supplierID);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                ProductID = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                SupplierID = reader.GetInt32(2),
                                UnitPrice = reader.GetDecimal(3),
                                Package = reader.GetString(4),
                                IsDiscontinued = reader.GetBoolean(5)
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
