using GourmetShopLibrary;
using System.Configuration;
using System.Windows.Forms;

namespace GourmetShopRepositoryTest
{
    public partial class Form1 : Form
    {
        private readonly string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
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
                Name = nameTextBox.Text,
                Price = decimal.Parse(priceTextBox.Text),
                Stock = int.Parse(stockTextBox.Text)
            };

            IProductRepository repository = new ProductRepository(conn);
            repository.AddProduct(product);
            LoadProducts();
        }
    }
}
