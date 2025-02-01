using GourmetShopLibrary;
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
        ValidateUserLogin validateUserLogin;
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
            string username = userNameTxtBox.Text.Trim();
            string password = passwordTxtBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ValidateUserLogin validateUserLogin = new ValidateUserLogin(conn);

            if (validateUserLogin.ValidateUser(username, password))
            {
                /////this needs to show user interface once created
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (validateUserLogin.ValidateUser(username, password))
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
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
