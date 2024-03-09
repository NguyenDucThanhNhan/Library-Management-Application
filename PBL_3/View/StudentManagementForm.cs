using PBL_3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PBL_3
{
    public partial class StudentManagementForm : Form
    {
        bool isClickAdd = false;
        bool isClickUpdate = false;
        string id;
        int numberpage = 1;
        int numberrecord = 14;
        public StudentManagementForm()
        {
            InitializeComponent();
            LoadForm();
            LoadDGV();
        }
        string phonenumber;
        string email;
        public void LoadForm()
        {
            addPanel.Visible = false;
            catalogPanel.Size = new System.Drawing.Size(1510, 600);
            listDGV.Size = new System.Drawing.Size(1445, 497);
            updateBtn.Location = new Point(1191, 10);
            deleteBtn.Location = new Point(1348, 10);

            studentCodeTxt.Text = "";
            nameTxt.Text = "";
            classTxt.Text = "";
            phoneTxt.Text = "";
            emailTxt.Text = "";
        }

        public void ShowAddBar()
        {
            catalogPanel.Size = new System.Drawing.Size(1205, 600);
            addPanel.Visible = true;
            listDGV.Size = new System.Drawing.Size(1135, 497);
            updateBtn.Location = new Point(881, 10);
            deleteBtn.Location = new Point(1038, 10);

            nameError.Visible = false;
            classError.Visible = false;
            phoneError.Visible = false;
            emailError.Visible = false;
            studentCodeError.Visible = false;
        }
        public void LoadDGV()
        {
            StudentManagement_BLL bll = new StudentManagement_BLL();
            listDGV.DataSource = bll.loadrecord(numberpage, numberrecord);
            listDGV.Columns[0].Width = 300;
            listDGV.Columns[0].HeaderText = "STUDENT CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "CLASS";
            listDGV.Columns[3].HeaderText = "PHONE NUMBER";
            listDGV.Columns[4].HeaderText = "EMAIL";
        }

        public void DisplaySearchResultId(int ID)
        {
            StudentManagement_BLL bll = new StudentManagement_BLL();
            listDGV.DataSource = bll.SearchStudentById(ID);
            listDGV.Columns[0].Width = 300;
            listDGV.Columns[0].HeaderText = "STUDENT CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "CLASS";
            listDGV.Columns[3].HeaderText = "PHONE NUMBER";
            listDGV.Columns[4].HeaderText = "EMAIL";
        }
        public void DisplaySearchResultName(string Name)
        {
            StudentManagement_BLL bll = new StudentManagement_BLL();
            listDGV.DataSource = bll.SearchStudentByName(Name);
            listDGV.Columns[0].Width = 300;
            listDGV.Columns[0].HeaderText = "STUDENT CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "CLASS";
            listDGV.Columns[3].HeaderText = "PHONE NUMBER";
            listDGV.Columns[4].HeaderText = "EMAIL";
        }
        public void DisplaySearchResultClass(string Class)
        {
            StudentManagement_BLL bll = new StudentManagement_BLL();
            listDGV.DataSource = bll.SearchStudentByClass(Class);
            listDGV.Columns[0].Width = 300;
            listDGV.Columns[0].HeaderText = "STUDENT CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "CLASS";
            listDGV.Columns[3].HeaderText = "PHONE NUMBER";
            listDGV.Columns[4].HeaderText = "EMAIL";
        }
        public void DisplaySearchResultPhone(string Phone)
        {
            StudentManagement_BLL bll = new StudentManagement_BLL();
            listDGV.DataSource = bll.SearchStudentByPhoneNUmber(Phone);
            listDGV.Columns[0].Width = 300;
            listDGV.Columns[0].HeaderText = "STUDENT CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "CLASS";
            listDGV.Columns[3].HeaderText = "PHONE NUMBER";
            listDGV.Columns[4].HeaderText = "EMAIL";
        }
        public void DisplaySearchResultEmail(string Email)
        {
            StudentManagement_BLL bll = new StudentManagement_BLL();
            listDGV.DataSource = bll.SearchStudentByEmail(Email);
            listDGV.Columns[0].Width = 100;
            listDGV.Columns[0].HeaderText = "STUDENT CODE";
            listDGV.Columns[1].HeaderText = "NAME";
            listDGV.Columns[2].HeaderText = "CLASS";
            listDGV.Columns[3].HeaderText = "PHONE NUMBER";
            listDGV.Columns[4].HeaderText = "EMAIL";
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (isClickAdd == false)
            {
                LoadForm();
                isClickUpdate = false;
                panelLb.Location = new Point(33, 55);
                panelLb.Text = "Add Student";
                studentCodeTxt.Visible = true;
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
                    panelLb.Location = new Point(5, 55);
                    panelLb.Text = "Update Student";
                    studentCodeTxt.Visible = false;
                    studentCodeError.Visible = false;
                    ShowAddBar();
                    isClickUpdate = true;

                    nameTxt.Text = listDGV.SelectedRows[0].Cells[1].Value.ToString();
                    classTxt.Text = listDGV.SelectedRows[0].Cells[2].Value.ToString();
                    phoneTxt.Text = listDGV.SelectedRows[0].Cells[3].Value.ToString();
                    emailTxt.Text = listDGV.SelectedRows[0].Cells[4].Value.ToString();
                    phonenumber = phoneTxt.Text;
                    email = emailTxt.Text;
                    id = listDGV.SelectedRows[0].Cells[0].Value.ToString();
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
                LoadForm();

                StudentManagement_BLL bll = new StudentManagement_BLL();

                foreach (DataGridViewRow i in listDGV.SelectedRows)
                {
                    DialogResult result = MessageBox.Show("If deleting \"" + i.Cells[1].Value.ToString() + "\" student, you will maybe lost some important information about lended book.\nWill you want to continue?", "Delete warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        bll.deleteStudent(i.Cells[0].Value.ToString());
                    }
                }
                LoadDGV();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool valid = true;
            StudentManagement_BLL bll = new StudentManagement_BLL();
            if (studentCodeTxt.Text.Length != 0 && bll.checkmssv(Convert.ToInt32(studentCodeTxt.Text)) && panelLb.Text == "Add Student")
            {
                studentCodeError.Text = "Duplicate Student Code!";
                studentCodeError.Visible = true;
            }

            if (nameTxt.Text.Length == 0)
            {
                nameError.Visible = true;
                valid = false;
            }

            if (classTxt.Text.Length == 0)
            {
                phoneError.Text = "Fill information!";
                classError.Visible = true;
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

            if (studentCodeTxt.Text.Length == 0 && panelLb.Text == "Add Student")
            {
                studentCodeError.Text = "Fill information!";
                studentCodeError.Visible = true;
                valid = false;
            }

            if (phoneTxt.Text.Length != 0 && !bll.isValidPhone(phoneTxt.Text))
            {
                phoneError.Text = "Invalid value";
                phoneError.Visible = true;
                valid = false;
            }

            if (emailTxt.Text.Length != 0 && !bll.IsValidEmail(emailTxt.Text))
            {
                emailError.Text = "Invalid value";
                emailError.Visible = true;
                valid = false;
            }

            if (phoneTxt.Text.Length != 0 && !bll.isInexistPhonenumber(phoneTxt.Text) && panelLb.Text == "Add Student")
            {
                phoneError.Text = "Exist phonenumber";
                phoneError.Visible = true;
                valid = false;
            }

            if (emailTxt.Text.Length != 0 && !bll.isInexistEmail(emailTxt.Text) && panelLb.Text == "Add Student")
            {
                emailError.Text = "Exist email";
                emailError.Visible = true;
                valid = false;
            }

            if (phoneTxt.Text.Length != 0 && !bll.isInexistPhonenumber(phoneTxt.Text) && panelLb.Text == "Update Student" && phoneTxt.Text != phonenumber)
            {
                phoneError.Text = "Exist phonenumber";
                phoneError.Visible = true;
                valid = false;
            }

            if (emailTxt.Text.Length != 0 && !bll.isInexistEmail(emailTxt.Text) && panelLb.Text == "Update Student" && emailTxt.Text != email)
            {
                emailError.Text = "Exist email";
                emailError.Visible = true;
                valid = false;
            }

            if (valid == true)
            {
                if (panelLb.Text.Equals("Add Student"))
                {
                    bll.AddStudent(Convert.ToInt32(studentCodeTxt.Text), nameTxt.Text, classTxt.Text, phoneTxt.Text, emailTxt.Text);
                }
                else
                {
                    bll.UpdateStudent(Convert.ToInt32(id), nameTxt.Text, classTxt.Text, phoneTxt.Text, emailTxt.Text);
                    isClickUpdate = false;
                    LoadForm();
                }
                LoadDGV();
                studentCodeTxt.Text = "";
                nameTxt.Text = "";
                classTxt.Text = "";
                phoneTxt.Text = "";
                emailTxt.Text = "";
                nameError.Visible = false;
                classError.Visible = false;
                phoneError.Visible = false;
                emailError.Visible = false;

            }
        }
        private void studentCodeTxt_Click(object sender, EventArgs e)
        {
            studentCodeError.Visible = false;
        }

        private void nameTxt_Click(object sender, EventArgs e)
        {
            nameError.Visible = false;
        }

        private void classTxt_Click(object sender, EventArgs e)
        {
            classError.Visible = false;
        }

        private void phoneTxt_Click(object sender, EventArgs e)
        {
            phoneError.Visible = false;
        }

        private void emailTxt_Click(object sender, EventArgs e)
        {
            emailError.Visible = false;
        }




        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

            int id;
            if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Student code")
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
            else if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Class")
            {
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string Class = searchTxt.Text;
                    DisplaySearchResultClass(Class);
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

        }

        private void listSearchCb_Click_1(object sender, EventArgs e)
        {
            listSearchCb.Items.Clear();
            listSearchCb.Items.Add("Student code");
            listSearchCb.Items.Add("Name");
            listSearchCb.Items.Add("Class");
            listSearchCb.Items.Add("Phone number");
            listSearchCb.Items.Add("Email");
        }

        private void searchTxt_Click(object sender, EventArgs e)
        {
            searchTxt.Enabled = !string.IsNullOrEmpty(listSearchCb.Text);
            if (!searchTxt.Enabled)
            {
                MessageBox.Show("Please select search object", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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

        private void previous_Click(object sender, EventArgs e)
        {
            if (numberpage - 1 > 0)
            {
                StudentManagement_BLL bll = new StudentManagement_BLL();
                numberpage--;
                listDGV.DataSource = bll.loadrecord(numberpage, numberrecord);
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            StudentManagement_BLL bll = new StudentManagement_BLL();
            if (numberpage-1<bll.count(numberrecord))
            {
                numberpage++;
                listDGV.DataSource = bll.loadrecord(numberpage, numberrecord);

            }
        }
    }
}
