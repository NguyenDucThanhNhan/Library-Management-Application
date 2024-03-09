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
    public partial class VerifyEmailForm : Form
    {
        String code;
        public VerifyEmailForm()
        {
            InitializeComponent();
        }

        private void sendCodeBtn_Click(object sender, EventArgs e)
        {
            if(sendCodeBtn.Text.Equals("Send Code"))
            {
                string username = usernameTb.Text;
                string email = emailTb.Text;

                if (username.Length == 0 || username.Equals("Username"))
                {
                    usernameLb.Text = "Enter your username";
                    usernameLb.ForeColor = Color.Red;
                    return;
                }
                if (email.Length == 0 || email.Equals("Password"))
                {
                    emailLb.Text = "Enter your email";
                    emailLb.ForeColor = Color.Red;
                    return;
                }

                VerifyEmailForm_BLL verifyEmailForm_BLL = new VerifyEmailForm_BLL();

                bool isCorrectUsername = verifyEmailForm_BLL.isCorrectUsername(username);
                if (isCorrectUsername == false)
                {
                    usernameLb.Text = "User doesn't exist";
                    usernameLb.ForeColor = Color.Red;
                    return;
                }

                bool isCorrectEmail = verifyEmailForm_BLL.isCorrectEmail(username, email);
                if (isCorrectEmail == false)
                {
                    emailLb.Text = "Incorrect email";
                    emailLb.ForeColor = Color.Red;
                    return;
                }

                usernameLb.ForeColor = Color.Transparent;
                emailLb.ForeColor = Color.Transparent;
                sendCodeBtn.Text = "Sended Code";

                code = verifyEmailForm_BLL.SendEmail(email, username);
            }
        }

        private void usernameTb_TextChanged(object sender, EventArgs e)
        {
            usernameLb.ForeColor = Color.Transparent;
        }

        private void emailTb_TextChanged(object sender, EventArgs e)
        {
            emailLb.ForeColor = Color.Transparent;
        }

        private void codeTb_TextChanged(object sender, EventArgs e)
        {
            codeLb.ForeColor = Color.Transparent;
        }

        private void usernameTb_Click(object sender, EventArgs e)
        {
            usernameTb.ForeColor = Color.Black;
            if (usernameTb.Text.Equals("Username"))
            {
                usernameTb.Text = "";
            }
        }

        private void emailTb_Click(object sender, EventArgs e)
        {
            emailTb.ForeColor = Color.Black;
            if (emailTb.Text.Equals("E-mail"))
            {
                emailTb.Text = "";
            }
        }

        private void codeTb_Click(object sender, EventArgs e)
        {
            codeTb.ForeColor = Color.Black;
            if (codeTb.Text.Equals("Code"))
            {
                codeTb.Text = "";
            }
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            string codeTxt = codeTb.Text;
            if(code.Length == 0)
            {
                codeLb.Text = "Enter verify code";
                codeLb.ForeColor = Color.Red;
                return;
            }
            VerifyEmailForm_BLL verifyEmailForm_BLL = new VerifyEmailForm_BLL();
            bool isCorrectCode = verifyEmailForm_BLL.isCorrectCode(codeTxt, code);
            if (isCorrectCode == false) 
            {
                codeLb.Text = "Incorrect code";
                codeLb.ForeColor = Color.Red;
                return;
            }
            codeLb.ForeColor = Color.Transparent;
            this.Hide();
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(usernameTb.Text);
            changePasswordForm.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
