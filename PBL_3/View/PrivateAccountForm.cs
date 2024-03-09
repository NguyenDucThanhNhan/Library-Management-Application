using PBL_3.BLL;
using PBL_3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PBL_3
{
    public partial class PrivateAccountForm : Form
    {
        string username;
        string code;
        bool editIsClicked = false;
        bool isSendedCode = false;
        public delegate void changeUsername(string username);
        public changeUsername change;
        public PrivateAccountForm(string usernameAcc)
        {
            InitializeComponent();
            username = usernameAcc;
            loadTxt();
        }
        string phonenumber;
        string email;
        public void loadTxt()
        {
            PrivateAccountForm_BLL bll = new PrivateAccountForm_BLL();
            idTxt.Text = bll.getId(username).ToString();
            nameTxt.Text = bll.getName(username);
            roleTxt.Text = "Thủ thư";
            phoneTxt.Text = bll.getPhone(username);
            emailTxt.Text = bll.getEmail(username);
            usernameTxt.Text = username;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            PrivateAccountForm_BLL bll = new PrivateAccountForm_BLL();
            if (editIsClicked == false)
            {
                phonenumber = phoneTxt.Text;
                email = emailTxt.Text;
                editBtn.Text = "VALIDATE";

                editIsClicked = true;
                phoneTxt.ReadOnly = false;
                emailTxt.ReadOnly = false;
                usernameTxt.ReadOnly = false;
                passwordTxt.ReadOnly = false;

                cancelBtn.Visible = true;
                sendCodeBtn.Visible = true;
                sendCodeTxt.Visible = true;
                passwordLb.Visible = true;

                sendCodeTxt.Text = "";
            }
            else
            {
                if (sendCodeTxt.Text.Length != 0)
                {
                    if (bll.isCorrectCode(sendCodeTxt.Text, code))
                    {

                        editBtn.Text = "EDIT";
                        sendCodeBtn.Text = "Send code";

                        editIsClicked = false;
                        cancelBtn.Visible = false;
                        sendCodeBtn.Visible = false;
                        sendCodeTxt.Visible = false;
                        isSendedCode = false;
                        bll.upDateData(idTxt.Text, nameTxt.Text, phoneTxt.Text, emailTxt.Text, usernameTxt.Text, passwordTxt.Text);
                        username = usernameTxt.Text;
                        change(username);

                        phoneTxt.ReadOnly = true;
                        emailTxt.ReadOnly = true;
                        usernameTxt.ReadOnly = true;
                        passwordTxt.ReadOnly = true;

                        phoneLb.Visible = false;
                        emailLb.Visible = false;
                        usernameLb.Visible = false;
                        passwordLb.Visible = false;
                        sendCodeLb.Visible = false;
                        passwordLb.Visible = false;

                        nameTxt.ForeColor = Color.White;
                        phoneTxt.ForeColor = Color.White;
                        emailTxt.ForeColor = Color.White;
                        usernameTxt.ForeColor = Color.White;
                        passwordTxt.ForeColor = Color.White;
                    }
                    else
                    {
                        sendCodeError.Text = "Incorrect code";
                        sendCodeError.Visible = true;
                    }

                }
                else
                {
                    sendCodeError.Text = "Empty value";
                    sendCodeError.Visible = true;
                }
            }
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            PrivateAccountForm_BLL bll = new PrivateAccountForm_BLL();
            if (nameTxt.Text == bll.getName(username))
            {
                nameTxt.ForeColor = Color.White;
            }
            else
            {
                nameTxt.ForeColor = Color.FromArgb(247, 88, 103);
            }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            PrivateAccountForm_BLL bll = new PrivateAccountForm_BLL();
            if (phoneTxt.Text == bll.getPhone(username))
            {
                phoneTxt.ForeColor = Color.White;
            }
            else
            {
                phoneTxt.ForeColor = Color.FromArgb(247, 88, 103);
            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            PrivateAccountForm_BLL bll = new PrivateAccountForm_BLL();
            if (emailTxt.Text == bll.getEmail(username))
            {
                emailTxt.ForeColor = Color.White;
            }
            else
            {
                emailTxt.ForeColor = Color.FromArgb(247, 88, 103);
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            PrivateAccountForm_BLL bll = new PrivateAccountForm_BLL();
            if (usernameTxt.Text == username)
            {
                usernameTxt.ForeColor = Color.White;
            }
            else
            {
                usernameTxt.ForeColor = Color.FromArgb(247, 88, 103);
            }
        }

        private void sendCodeBtn_Click(object sender, EventArgs e)
        {
            if (isSendedCode == false)
            {
                PrivateAccountForm_BLL bll = new PrivateAccountForm_BLL();
                bool valid = true;
                passwordLb.ForeColor = Color.White;
                passwordLb.Text = "Empty if not changed";

                if (phoneTxt.Text.Length == 0)
                {
                    phoneLb.Location = new Point(330, 415);
                    phoneLb.Text = "Empty Value";
                    phoneLb.Visible = true;
                    valid = false;
                }
                else
                {
                    if (!bll.isValidPhone(phoneTxt.Text))
                    {
                        valid = false;
                        phoneLb.Location = new Point(282, 415);
                        phoneLb.Text = "Invalid phonenumber";
                        phoneLb.Visible = true;
                    }
                    if (!bll.isInexistPhonenumber(phoneTxt.Text) && phoneTxt.Text != phonenumber)
                    {
                        valid = false;
                        phoneLb.Location = new Point(282, 415);
                        phoneLb.Text = "Exist phonenumber";
                        phoneLb.Visible = true;
                    }

                }

                if (emailTxt.Text.Length == 0)
                {
                    emailLb.Location = new Point(330, 500);
                    emailLb.Text = "Empty Value";
                    emailLb.Visible = true;
                    valid = false;
                }
                else
                {
                    if (!bll.IsValidEmail(emailTxt.Text))
                    {
                        valid = false;
                        emailLb.Location = new Point(332, 500);
                        emailLb.Text = "Invalid email";
                        emailLb.Visible = true;
                    }
                    if (!bll.isInexistEmail(emailTxt.Text) && emailTxt.Text != email)
                    {
                        valid = false;
                        emailLb.Location = new Point(332, 500);
                        emailLb.Text = "Exist email";
                        emailLb.Visible = true;
                    }
                }

                if (usernameTxt.Text.Length == 0)
                {
                    usernameLb.Location = new Point(1075, 146);
                    usernameLb.Text = "Empty Value";
                    usernameLb.Visible = true;
                    valid = false;
                }
                else
                {
                    if (!bll.isValidUsername(usernameTxt.Text) && usernameTxt.Text != username)
                    {
                        valid = false;
                        usernameLb.Location = new Point(1030, 146);
                        usernameLb.Text = "Exist username";
                        usernameLb.Visible = true;
                    }
                }

                if (!bll.isValidPassword(passwordTxt.Text))
                {
                    valid = false;
                    passwordLb.ForeColor = Color.Red;
                    passwordLb.Text = "As least 8 characters";
                }

                if (valid == true)
                {
                    code = bll.SendEmail(emailTxt.Text, username);
                    sendCodeBtn.Text = "Sended code";
                    sendCodeLb.Text = "Please check email " + emailTxt.Text + " to get code!";
                    sendCodeLb.Visible = true;
                    isSendedCode = true;

                    phoneLb.Visible = false;
                    emailLb.Visible = false;
                    usernameLb.Visible = false;
                    passwordLb.Visible = false;

                    phoneTxt.ReadOnly = true;
                    emailTxt.ReadOnly = true;
                    usernameTxt.ReadOnly = true;
                    passwordTxt.ReadOnly = true;
                }
            }
        }

        private void sendCodeTxt_Click(object sender, EventArgs e)
        {
            sendCodeError.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            editBtn.Text = "EDIT";
            editIsClicked = false;
            cancelBtn.Visible = false;
            sendCodeBtn.Visible = false;
            sendCodeTxt.Visible = false;
            isSendedCode = false;

            phoneTxt.ReadOnly = true;
            emailTxt.ReadOnly = true;
            usernameTxt.ReadOnly = true;
            passwordTxt.ReadOnly = true;

            phoneLb.Visible = false;
            emailLb.Visible = false;
            usernameLb.Visible = false;
            passwordLb.Visible = false;
            sendCodeTxt.Visible = false;
            sendCodeLb.Visible = false;

            nameTxt.ForeColor = Color.White;
            phoneTxt.ForeColor = Color.White;
            emailTxt.ForeColor = Color.White;
            usernameTxt.ForeColor = Color.White;
            passwordTxt.ForeColor = Color.White;

            sendCodeTxt.Text = "";
            sendCodeLb.Text = "";
            sendCodeBtn.Text = "Send code";

            loadTxt();
        }
    }
}
