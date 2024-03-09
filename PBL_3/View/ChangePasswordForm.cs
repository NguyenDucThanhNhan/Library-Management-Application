using PBL_3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_3
{
    public partial class ChangePasswordForm : Form
    {
        string username;
        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string newpass = newTb.Text;
            string confirm = confirmTb.Text;

            if (newpass.Length == 0 || newpass.Equals("New Password"))
            {
                newLb.Text = "Enter your new password";
                newLb.ForeColor = Color.Red;
                return;
            }
            if (confirm.Length == 0 || confirm.Equals("Confirm Password"))
            {
                confirmLb.Text = "Enter your confirm password";
                confirmLb.ForeColor = Color.Red;
                return;
            }

            ChangePasswordForm_BLL changePasswordForm_BLL = new ChangePasswordForm_BLL();

            bool isValidPassword = changePasswordForm_BLL.isValidPassword(newpass);
            if (isValidPassword == false)
            {
                newLb.Text = "At least 8 characters";
                newLb.ForeColor = Color.Red;
                return;
            }

            if (newpass.Equals(confirm) == false)
            {
                confirmLb.Text = "Not same new password";
                confirmLb.ForeColor = Color.Red;
                return;
            }

            newLb.ForeColor = Color.Transparent;
            confirmLb.ForeColor = Color.Transparent;
            changePasswordForm_BLL.updatePassword(username, newpass);
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void newTb_TextChanged(object sender, EventArgs e)
        {
            newLb.ForeColor = Color.Transparent;
        }

        private void confirmTb_TextChanged(object sender, EventArgs e)
        {
            confirmLb.ForeColor = Color.Transparent;
        }

        private void newTb_Click(object sender, EventArgs e)
        {
            newTb.ForeColor = Color.Black;
            if (newTb.Text.Equals("New Password"))
            {
                newTb.Text = "";
            }
        }

        private void confirmTb_Click(object sender, EventArgs e)
        {
            confirmTb.ForeColor = Color.Black;
            if (confirmTb.Text.Equals("Confirm Password"))
            {
                confirmTb.Text = "";
            }
        }
    }
}
