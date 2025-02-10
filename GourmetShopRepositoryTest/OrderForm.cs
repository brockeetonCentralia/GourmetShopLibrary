using GourmetShopLibrary.Interfaces;
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
    public partial class OrderForm : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        IOrderRepository repository;
        public OrderForm()
        {
            InitializeComponent();
            OrderForm_Load();
        }
        private void OrderForm_Load()
        {
            repository = new OrderRepository(conn);
            var orders = repository.GetAllOrders();
            dataGridView1.DataSource = orders.ToList();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            this.Close();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.ShowDialog();
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.ShowDialog();
            this.Close();
        }
    }
}
