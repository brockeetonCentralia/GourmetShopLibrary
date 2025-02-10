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
                totalAmount += product.UnitPrice;
                totalItems = _cartService.Count();
            }

            lblAmount.Text = totalAmount.ToString();
            lblDataViewAmount.Text = totalItems.ToString();
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

            CartGridView.DataSource = _cartService.GetProducts();
            _cartService.Delete(product);
            CartGridView.DataSource = null;
            CartGridView.DataSource = _cartService.GetProducts();
            CartGridView.Refresh();
            UpdateCartSummary();
        }


        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            foreach (var product in _cartService.GetProducts())
            {
                totalAmount += product.UnitPrice;
            }

            string orderNumber = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
            

            if (_cartService.Count() == 0)
            {
                MessageBox.Show("Cart is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Order order = new Order
                {
                    OrderDate = DateTime.Now,
                    OrderNumber = orderNumber,
                    UserID = 2,
                    TotalAmount = totalAmount
                };
                OrderRepository orderRepository = new OrderRepository(conn);
                orderRepository.AddOrder(order);

                MessageBox.Show("Order placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CartGridView.DataSource = null;
                _cartService.ClearCart();
                UpdateCartSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
