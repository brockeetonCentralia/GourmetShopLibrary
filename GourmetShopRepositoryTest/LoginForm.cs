using GourmetShopLibrary;
using GourmetShopLibrary.Models;
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
    public partial class LoginForm : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void userNameTxtBox_Enter(object sender, EventArgs e)
        {
            if (userNameTxtBox.Text == "Username")
            {
                userNameTxtBox.Text = "";
                userNameTxtBox.ForeColor = Color.Black;
            }
        }

        private void userNameTxtBox_Leave(object sender, EventArgs e)
        {
            if (userNameTxtBox.Text == "")
            {
                userNameTxtBox.Text = "Username";
                userNameTxtBox.ForeColor = Color.LightGray;
            }
        }

        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "Password")
            {
                passwordTxtBox.Text = "";
                passwordTxtBox.ForeColor = Color.Black;
            }
        }

        private void passwordTxtBox_Leave(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "")
            {
                passwordTxtBox.Text = "Password";
                passwordTxtBox.ForeColor = Color.LightGray;
            }
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            string userLogin = userNameTxtBox.Text;
            string userPassword = passwordTxtBox.Text;

            ValidateUserLogin validateUserLogin = new ValidateUserLogin(conn);
            int roleID = validateUserLogin.ValidateUser(userLogin, userPassword);

            if (string.IsNullOrWhiteSpace(userLogin) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roleID == 1)
            {
                string role = (roleID == 1) ? "Admin" : "Unknown";
                this.Hide();
                MessageBox.Show($"Login successful! Welcome {role}.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 adminForm = new Form1();
                adminForm.Show();
            }
            if (roleID == 2)
            {
                string role = (roleID == 2) ? "Customer" : "Unknown";
                this.Hide();
                MessageBox.Show($"Login successful! Welcome {role}.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerSupplierLookup customerSupplierLookup = new CustomerSupplierLookup();
                customerSupplierLookup.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            userNameTxtBox.Text = "Username";
            userNameTxtBox.ForeColor = Color.LightGray;
            passwordTxtBox.Text = "Password";
            passwordTxtBox.ForeColor = Color.LightGray;
        }
    }
}
