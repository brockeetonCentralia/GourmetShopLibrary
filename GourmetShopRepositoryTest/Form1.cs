using GourmetShopLibrary;
using GourmetShopLibrary.Interfaces;
using GourmetShopLibrary.Models;
using GourmetShopLibrary.Repositories;
using System.Configuration;
using System.Windows.Forms;

namespace GourmetShopRepositoryTest
{
    public partial class Form1 : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            IProductRepository repository = new ProductRepository(conn);
            var products = repository.GetAllProducts();
            dataGridView1.DataSource = products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductName = nameTextBox.Text,
                SupplierID = int.Parse(supplierTextBox.Text),
                UnitPrice = decimal.Parse(priceTextBox.Text),
                Package = int.Parse(stockTextBox.Text),
                IsDiscontinued = false
            };

            IProductRepository repository = new ProductRepository(conn);
            repository.AddProduct(product);
            LoadProducts();
        }
    }
}
