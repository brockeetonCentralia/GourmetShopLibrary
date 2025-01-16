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
        IProductRepository repository;
        ISupplierRepository supplierRepository;
        public Form1()
        {
            InitializeComponent();
            LoadProducts();

        }
        private void LoadProducts()
        {
            repository = new ProductRepository(conn);
            supplierRepository = new SupplierRepository(conn);
            var products = repository.GetAllProducts();
            dataGridView1.DataSource = products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
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

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //if (!)
        }
    }
}
