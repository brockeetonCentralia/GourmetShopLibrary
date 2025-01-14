using GourmetShopLibrary;
using System.Windows.Forms;

namespace GourmetShopRepositoryTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            IProductRepository repository = new ProductRepository("conn");
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

            IProductRepository repository = new ProductRepository("conn");
            repository.AddProduct(product);
            LoadProducts();
        }
    }
}
