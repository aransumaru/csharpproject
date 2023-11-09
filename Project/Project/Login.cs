using Project.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;

namespace Project
{
    public partial class Login : Form
    {
        UserServices userServices = new UserServices();
        public Login()
        {

            InitializeComponent();
            passwordText.PasswordChar = '*';
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string account = usernameText.Text;
            string password = passwordText.Text;
            bool isAuthenticated = userServices.ValidateLogin(account, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!");
                NodeManagement mainForm = new NodeManagement();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {

        }
    }
}
