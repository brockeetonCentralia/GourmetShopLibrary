using GourmetShopLibrary.Interfaces;
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
        private CartService _cartService;

        public CustomerSupplierLookup()
        {
            
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            _cartService = new CartService();
            _productRepository = new ProductRepository(_connectionString);
        }

        private void SearchSupplierID_Click(object sender, EventArgs e)
        {
            var supplierID = int.Parse(SupplierIDtxt.Text);
            var products = GetbySupplierID(supplierID);
            ProductDGV.DataSource = products;   
        }

        private void ViewCartbtn_Click(object sender, EventArgs e)
        {
            CustomerCart customerCart = new CustomerCart(_cartService);
            customerCart.Show();
        }

        private void AddtoCartbtn_Click(object sender, EventArgs e)
        {
            var product = ProductDGV.SelectedRows[0].DataBoundItem as Product;
            
            _cartService.Add(product);
            MessageBox.Show("Item added sucessfully");
        }

        public List<Product> GetbySupplierID(int supplierID)
        {
            var products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE SupplierId = @SupplierID", connection);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        SupplierID = reader.GetInt32(2),
                        UnitPrice = reader.GetDecimal(3),
                        Package = reader.GetString(4),
                        IsDiscontinued = reader.GetBoolean(5)
                    });
                }
            }
            return products;
        }
    }
}
