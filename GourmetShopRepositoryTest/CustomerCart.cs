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
        private List<Product> cartlist = new List<Product>();
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public CustomerCart(List<Product> products)
        {
            InitializeComponent();
            cartlist = products;
            LoadCart();
            UpdateCartSummary();
        }

        private void LoadCart()
        {
            CartGridView.Rows.Clear();
            foreach (var product in cartlist)
            {
                //add products to cart 
                CartGridView.Rows.Add();
            }
            UpdateCartSummary();
        }

        private void UpdateCartSummary()
        {
            decimal totalAmount = 0;
            int totalItems = 0;

            foreach (var product in cartlist)
            {
                totalAmount += product.UnitPrice;//need to get quantity somehow
                //totalItems+= product.Quantity; somehow need to get quantity
            }

            lblAmount.Text = totalAmount.ToString();
            lblDataViewAmount.Text = totalItems.ToString();
        }

        private void Backtoformbtn_Click(object sender, EventArgs e)
        {
            CustomerSupplierLookup customerSupplierLookup = new CustomerSupplierLookup();
            customerSupplierLookup.ShowDialog();
            this.Close();
        }

        private void Removeitemcartbtn_Click(object sender, EventArgs e)
        {
            // Remove an item form list
            if (cartlist.Count > 0) 
            { 
                cartlist.RemoveAt(cartlist.Count - 1); 
                CartGridView.Rows.RemoveAt(CartGridView.Rows.Count - 1);
                UpdateCartSummary();
            }
            else
            {
                MessageBox.Show("Cart is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            if (cartlist.Count == 0)
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

                cartlist.Clear();
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
