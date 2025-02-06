using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public CustomerCart()
        {
            InitializeComponent();
            // calculate lables with monitary amounts
            // update label with number of items in list
        }

        private void Backtoformbtn_Click(object sender, EventArgs e)
        {
            // link back to first form
        }

        private void Removeitemcartbtn_Click(object sender, EventArgs e)
        {
            // Remove an item form list
            // update lable amounts
            // Update lable with amount of items in cart
        }

        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            // call SP for insert on order
            // call SP for 
            // grab the date for SP orders and pass
        }
    }
}
