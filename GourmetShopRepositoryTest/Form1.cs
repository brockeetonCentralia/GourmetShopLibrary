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
        ISupplierRepository repository;
        IProductRepository productRepository;
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            LoadSuppliers();
        }
        private void LoadSuppliers()
        {
            repository = new SupplierRepository(conn);
            var suppliers = repository.GetAllSuppliers();
            dataGridView1.DataSource = suppliers.ToList();
        }
        private void LoadProducts()
        {
            productRepository = new ProductRepository(conn);
            var products = productRepository.GetAllProducts();
            dataGridView2.DataSource = products.ToList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.ShowDialog();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.ShowDialog();
        }
    }
}
