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
    public partial class CustomerCart : Form
    {
        private CartService _cartService;

        //private List<Product> cartlist = new List<Product>();
        //private CustomerSupplierLookup _CustomerSupplierLookup;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public CustomerCart(CartService cartService)
        {
            InitializeComponent();
            _cartService = cartService;
            CartGridView.DataSource = _cartService.GetProducts();
            UpdateCartSummary();
        }

        private void UpdateCartSummary()
        {
            decimal totalAmount = 0;
            int totalItems = 0;

            foreach (var product in _cartService.GetProducts())
            {
                totalAmount += product.UnitPrice;//need to get quantity somehow
                //totalItems+= product.Quantity; somehow need to get quantity
            }

            TotalAmountlbl.Text = totalAmount.ToString();
            TotalItemslbl.Text = totalItems.ToString();
        }

        private void Backtoformbtn_Click(object sender, EventArgs e)
        {
            CustomerSupplierLookup customerSupplierLookup = new CustomerSupplierLookup();
            customerSupplierLookup.ShowDialog();
            this.Hide();
        }

        private void Removeitemcartbtn_Click(object sender, EventArgs e)
        {
            var product = CartGridView.SelectedRows[0].DataBoundItem as Product;

            _cartService.Delete(product);

            CartGridView.DataSource = _cartService.GetProducts(); //TODO fix update issue
            CartGridView.Refresh();
            UpdateCartSummary();
        }


        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            if (_cartService.Count() == 0)
            {
                MessageBox.Show("Cart is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //OrderRepository orderRepository = new OrderRepository(conn);
                //int customerId = 1; // need to get customer id from login
                //int orderId = orderRepository.AddOrder(customerId, DateTime.Now);

                //OrderItemRepository orderItemRepository = new OrderItemRepository(conn);
                //foreach (var product in cartlist)
                //{
                //    orderItemRepository.AddOrderItem(orderId, product.ProductID, product.UnitPrice, 1);//need to get quantity once repository is finished
                //}

                MessageBox.Show("Order placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //cartlist.Clear(); // dont think we need this
                CartGridView.Rows.Clear();
                UpdateCartSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
