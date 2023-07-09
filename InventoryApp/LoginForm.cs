using Inventory.Business.Layer.UserRepository;
using InventoryApp.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository=new UserRepository();

        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
            set
            {
                txtEmail.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
            bool isValidUser = _userRepository.IfExists(Email, Password);
            DataTable dt = _userRepository.GetUserByEmail(Email);
            if (isValidUser)
            {
                DataRow row = dt.Rows[0];

                SessionHelper.UserName = row["FirstName"].ToString();
                SessionHelper.UserRole = row["UserRole"].ToString();
                SessionHelper.UserID = Convert.ToInt32(row["UserID"].ToString());

                MasterMDIForm masterForm = new MasterMDIForm();
                masterForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login info", "Invalid Login");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //btnLogin_Click(sender, e);
                LoginUser();
            }
        }
    }
}
