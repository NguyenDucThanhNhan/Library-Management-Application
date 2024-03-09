using PBL_3.BLL;
using PBL_3.DTO;
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
    public partial class AccountManagementForm : Form
    {
        bool isClickAdd = false;
        bool isClickUpdate = false;
        string phonenumber;
        string email;
        string username;
        public AccountManagementForm()
        {
            InitializeComponent();
            LoadForm();
            LoadDGV();
        }
        public void LoadForm()
        {
            addPanel.Visible = false;
            listPanel.Size = new System.Drawing.Size(1510, 600);
            listDGV.Size = new System.Drawing.Size(1445, 497);
            updateBtn.Location = new Point(1191, 10);
            deleteBtn.Location = new Point(1348, 10);

            nameTxt.Text = "";
            phoneTxt.Text = "";
            emailTxt.Text = "";
            userTxt.Text = "";
        }

        public void DisplaySearchResultId(int ID)
        {
            AccountManagermentForm_BLL bll = new AccountManagermentForm_BLL();
            listDGV.DataSource = bll.SearchAccountById(ID);
            listDGV.Columns[0].Width = 200;
            listDGV.Columns[0].HeaderText = "STAFF CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "USERNAME";
            listDGV.Columns[3].HeaderText = "ROLE";
            listDGV.Columns[4].HeaderText = "PHONE NUMBER";
            listDGV.Columns[5].HeaderText = "EMAIL";
        }
        public void DisplaySearchResultName(string Name)
        {
            AccountManagermentForm_BLL bll = new AccountManagermentForm_BLL();
            listDGV.DataSource = bll.SearchBAccountByName(Name);
            listDGV.Columns[0].Width = 200;
            listDGV.Columns[0].HeaderText = "STAFF CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "USERNAME";
            listDGV.Columns[3].HeaderText = "ROLE";
            listDGV.Columns[4].HeaderText = "PHONE NUMBER";
            listDGV.Columns[5].HeaderText = "EMAIL";
        }
        public void DisplaySearchResultPhone(string phone_number)
        {
            AccountManagermentForm_BLL bll = new AccountManagermentForm_BLL();
            listDGV.DataSource = bll.SearchBAccountByPhoneNumber(phone_number);
            listDGV.Columns[0].Width = 200;
            listDGV.Columns[0].HeaderText = "STAFF CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "USERNAME";
            listDGV.Columns[3].HeaderText = "ROLE";
            listDGV.Columns[4].HeaderText = "PHONE NUMBER";
            listDGV.Columns[5].HeaderText = "EMAIL";
        }
        public void DisplaySearchResultEmail(string Email)
        {
            AccountManagermentForm_BLL bll = new AccountManagermentForm_BLL();
            listDGV.DataSource = bll.SearchBAccountByEmail(Email);
            listDGV.Columns[0].Width = 200;
            listDGV.Columns[0].HeaderText = "STAFF CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "USERNAME";
            listDGV.Columns[3].HeaderText = "ROLE";
            listDGV.Columns[4].HeaderText = "PHONE NUMBER";
            listDGV.Columns[5].HeaderText = "EMAIL";
        }
        public void DisplaySearchResultUser(string User)
        {
            AccountManagermentForm_BLL bll = new AccountManagermentForm_BLL();
            listDGV.DataSource = bll.SearchBAccountByUser(User);
            listDGV.Columns[0].Width = 200;
            listDGV.Columns[0].HeaderText = "STAFF CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "USERNAME";
            listDGV.Columns[3].HeaderText = "ROLE";
            listDGV.Columns[4].HeaderText = "PHONE NUMBER";
            listDGV.Columns[5].HeaderText = "EMAIL";
        }

        public void ShowAddBar()
        {
            listPanel.Size = new System.Drawing.Size(1205, 600);
            addPanel.Visible = true;
            listDGV.Size = new System.Drawing.Size(1135, 497);
            updateBtn.Location = new Point(881, 10);
            deleteBtn.Location = new Point(1038, 10);
            nameError.Visible = false;
            phoneError.Visible = false;
            emailError.Visible = false;
            userError.Visible = false;
            passwordError.Visible = false;
        }
        public void LoadDGV()
        {
            AccountManagermentForm_BLL bll = new AccountManagermentForm_BLL();
            listDGV.DataSource = bll.getList();
            listDGV.Columns[0].Width = 200;
            listDGV.Columns[0].HeaderText = "STAFF CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "USERNAME";
            listDGV.Columns[3].HeaderText = "ROLE";
            listDGV.Columns[4].HeaderText = "PHONE NUMBER";
            listDGV.Columns[5].HeaderText = "EMAIL";
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (isClickAdd == false)
            {
                LoadForm();
                isClickUpdate = false;
                panelLb.Location = new Point(33, 55);
                panelLb.Text = "Add Account";
                passwordTxt.Visible = false;
                passwordError.Visible = false;
                ShowAddBar();
                isClickAdd = true;
            }
            else
            {
                LoadForm();
                isClickAdd = false;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 1)
            {

                if (isClickUpdate == false)
                {
                    LoadForm();
                    isClickAdd = false;
                    panelLb.Location = new Point(0, 55);
                    panelLb.Text = "Update Account";
                    passwordTxt.Visible = true;
                    passwordError.Visible = true;
                    passwordError.ForeColor = Color.Black;
                    passwordError.Text = "Empty if not change";
                    ShowAddBar();
                    isClickUpdate = true;

                    nameTxt.Text = listDGV.SelectedRows[0].Cells[1].Value.ToString();
                    userTxt.Text = listDGV.SelectedRows[0].Cells[2].Value.ToString();
                    emailTxt.Text = listDGV.SelectedRows[0].Cells[5].Value.ToString();
                    phoneTxt.Text = listDGV.SelectedRows[0].Cells[4].Value.ToString();
                    phonenumber = phoneTxt.Text;
                    email = emailTxt.Text;
                    username = userTxt.Text;
                }
                else
                {
                    LoadForm();
                    isClickUpdate = false;
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count > 0)
            {
                AccountManagermentForm_BLL bll = new AccountManagermentForm_BLL();

                foreach (DataGridViewRow i in listDGV.SelectedRows)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete user " + i.Cells[1].Value.ToString() + "?", "Delete warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bll.deleteAccount(i.Cells[0].Value.ToString());
                    }
                }
                LoadDGV();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool valid = true;
            AccountManagermentForm_BLL bll = new AccountManagermentForm_BLL();
            if (nameTxt.Text.Length == 0)
            {
                nameError.Visible = true;
                valid = false;
            }

            if (userTxt.Text.Length == 0)
            {
                userError.Visible = true;
                valid = false;
            }

            if (phoneTxt.Text.Length == 0)
            {
                phoneError.Text = "Fill information!";
                phoneError.Visible = true;
                valid = false;
            }

            if (emailTxt.Text.Length == 0)
            {
                emailError.Text = "Fill information!";
                emailError.Visible = true;
                valid = false;
            }

            if (emailTxt.Text.Length != 0 && panelLb.Text == "Add Account" && !bll.isInexistEmail(emailTxt.Text))
            {
                emailError.Text = "Exist email!";
                emailError.Visible = true;
                valid = false;
            }

            if (phoneTxt.Text.Length != 0 && !bll.isValidPhone(phoneTxt.Text))
            {
                phoneError.Text = "Invalid value";
                phoneError.Visible = true;
                valid = false;
            }

            if (phoneTxt.Text.Length != 0 && panelLb.Text == "Add Account" && !bll.isInexistPhonenumber(phoneTxt.Text))
            {
                phoneError.Text = "Exist phonenumber";
                phoneError.Visible = true;
                valid = false;
            }

            if (emailTxt.Text.Length != 0 && !bll.IsValidEmail(emailTxt.Text))
            {
                emailError.Text = "Invalid value";
                emailError.Visible = true;
                valid = false;
            }

            if (emailTxt.Text.Length != 0 && panelLb.Text == "Update Account" && emailTxt.Text != email && !bll.isInexistEmail(emailTxt.Text))
            {
                emailError.Text = "Exist email!";
                emailError.Visible = true;
                valid = false;
            }

            if (phoneTxt.Text.Length != 0 && panelLb.Text == "Update Account" && phoneTxt.Text != phonenumber && !bll.isInexistPhonenumber(phoneTxt.Text))
            {
                phoneError.Text = "Exist phonenumber";
                phoneError.Visible = true;
                valid = false;
            }

            if (userTxt.Text.Length != 0 && userTxt.Text.Contains(" "))
            {
                userError.Text = "Cannot having space in username";
                userError.Visible = true;
                valid = false;
            }

            if (userTxt.Text.Length != 0 && panelLb.Text == "Add Account" && !bll.isValidUsername(userTxt.Text))
            {
                userError.Text = "Exist username";
                userError.Visible = true;
                valid = false;
            }

            if (userTxt.Text.Length != 0 && panelLb.Text == "Update Account" && userTxt.Text != username && !bll.isValidUsername(userTxt.Text))
            {
                userError.Text = "Exist username";
                userError.Visible = true;
                valid = false;
            }

            if (panelLb.Text == "Update Account")
            {
                if (passwordTxt.Text.Length > 0 && passwordTxt.Text.Length < 8)
                {
                    passwordError.ForeColor = Color.Red;
                    passwordError.Text = "As least 8 character!";
                    passwordTxt.Visible = true;
                    valid = false;
                    nameError.Visible = false;
                    phoneError.Visible = false;
                    emailError.Visible = false;
                    userError.Visible = false;
                }
            }
            if (valid == true)
            {
                if (panelLb.Text.Equals("Add Account"))
                {
                    bll.AddInfor(nameTxt.Text, phoneTxt.Text, emailTxt.Text, userTxt.Text);
                }
                else
                {
                    bll.UpdateAccount(listDGV.SelectedRows[0].Cells[0].Value.ToString(), nameTxt.Text, phoneTxt.Text, emailTxt.Text, userTxt.Text, passwordTxt.Text);
                    LoadForm();
                }
                LoadDGV();
                nameTxt.Text = "";
                phoneTxt.Text = "";
                emailTxt.Text = "";
                userTxt.Text = "";
                nameError.Visible = false;
                phoneError.Visible = false;
                emailError.Visible = false;
                userError.Visible = false;
            }
        }

        private void listSearchCb_Click(object sender, EventArgs e)
        {
            listSearchCb.Items.Clear();
            listSearchCb.Items.Add("Staff code");
            listSearchCb.Items.Add("Name");
            listSearchCb.Items.Add("Phone number");
            listSearchCb.Items.Add("Email");
            listSearchCb.Items.Add("User name");
        }
        private void searchTxt_Click(object sender, EventArgs e)
        {
            searchTxt.Enabled = !string.IsNullOrEmpty(listSearchCb.Text);
            if (!searchTxt.Enabled)
            {
                MessageBox.Show("Please select search object", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            
            int id;
            if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Staff code")
            {
                if (int.TryParse(searchTxt.Text, out id))
                {
                    DisplaySearchResultId(id);
                }
                else if (string.IsNullOrEmpty(searchTxt.Text))
                {
                    LoadDGV();
                }
            }
            else if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Name")
            {
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string Name = searchTxt.Text;
                        DisplaySearchResultName(Name);
                }
                else
                {
                    LoadDGV();
                }
            }
            else if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Phone number")
            {
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string phone = searchTxt.Text;
                    DisplaySearchResultPhone(phone);
                }
                else
                {
                    LoadDGV();
                }
            }
            else if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Email")
            {
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string Email = searchTxt.Text;
                    DisplaySearchResultEmail(Email);
                }
                else
                {
                    LoadDGV();
                }
            }
            else if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "User name")
            {
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string User = searchTxt.Text;
                    DisplaySearchResultUser(User);
                }
                else
                {
                    LoadDGV();
                }
            }
        }

        private void listSearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSearchCb.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(listSearchCb.Text))
                {
                    searchTxt.Enabled = true;
                }
            }
        }
    }

}
