using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_3.BLL;
using PBL_3.View;

namespace PBL_3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;

            if (username.Length == 0)
            {
                usernameLb.Text = "Enter your username";
                usernameLb.ForeColor = Color.Red;
                return;
            }
            if (password.Length == 0)
            {
                passwordLb.Text = "Enter your password";
                passwordLb.ForeColor = Color.Red;
                return;
            }

            LoginForm_BLL loginForm_bll = new LoginForm_BLL();

            bool isCorrectUser = loginForm_bll.isCorrectUser(username);
            if(isCorrectUser == false)
            {
                usernameLb.Text = "User doesn't exist";
                usernameLb.ForeColor = Color.Red;
                return;
            }

            bool isCorrectPassword = loginForm_bll.isCorrectPassword(username, password);
            if (isCorrectPassword == false)
            {
                passwordLb.Text = "Incorrect password";
                passwordLb.ForeColor = Color.Red;
                return;
            }

            usernameLb.ForeColor = Color.Transparent;
            passwordLb.ForeColor = Color.Transparent;
            this.Hide();
            Main form = new Main(username);
            form.Show();
        }

        private void usernameTb_TextChanged(object sender, EventArgs e)
        {
            usernameLb.ForeColor = Color.Transparent;
        }

        private void passwordTb_TextChanged(object sender, EventArgs e)
        {
            passwordLb.ForeColor = Color.Transparent;
        }

        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerifyEmailForm verify = new VerifyEmailForm();
            verify.Show();
        }
        private void hidepass_Click(object sender, EventArgs e)
        {
            hidepass.Visible = false;
            showpass.Visible = true;
            passwordTb.PasswordChar = '\0';
            return;
        }
        private void showpass_Click(object sender, EventArgs e)
        {
            showpass.Visible = false;
            hidepass.Visible = true;
            passwordTb.PasswordChar = '*';
            return;
        }

       
    }
}
