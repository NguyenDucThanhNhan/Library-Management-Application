using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBL_3.BLL;

namespace PBL_3
{
    public partial class BorrowAndReturnForm : Form
    {
        bool isClickBorrow = false;
        int pagenumber = 1;
        int pagesize = 14;
        public BorrowAndReturnForm()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            borrowPanel.Visible = false;
            listPanel.Size = new System.Drawing.Size(1510, 600);
            borrowDGV.Size = new System.Drawing.Size(1445, 497);
            returnBtn.Location = new Point(1338, 10);
            deleteBtn.Location = new Point(1190, 10);
            studentTxt.Text = "";
            bookTxt.Text = "";
            loadDGV();
        }

        public void loadDGV()
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();
            borrowDGV.DataSource = bll.getList(pagenumber,pagesize);
            borrowDGV.Columns[0].HeaderText = "ID";
            borrowDGV.Columns[1].HeaderText = "TITLE BOOK";
            borrowDGV.Columns[2].HeaderText = "STUDENT NAME";
            borrowDGV.Columns[3].HeaderText = "LEND DATE";
            borrowDGV.Columns[4].HeaderText = "RETURN DATE";
            borrowDGV.Columns[5].HeaderText = "OVERDUE";
            borrowDGV.Columns[6].HeaderText = "RETURNED";

            borrowDGV.Columns[0].Width = 100;
            borrowDGV.Columns[3].Width = 150;
            borrowDGV.Columns[4].Width = 150;
            borrowDGV.Columns[5].Width = 100;
            borrowDGV.Columns[6].Width = 120;

        }
        public void DisplaySearchResultTitle(string Title)
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();
            borrowDGV.DataSource = bll.SearchLendByTitle(Title);
            borrowDGV.Columns[0].HeaderText = "ID";
            borrowDGV.Columns[1].HeaderText = "TITLE BOOK";
            borrowDGV.Columns[2].HeaderText = "STUDENT NAME";
            borrowDGV.Columns[3].HeaderText = "LEND DATE";
            borrowDGV.Columns[4].HeaderText = "RETURN DATE";
            borrowDGV.Columns[5].HeaderText = "OVERDUE";
            borrowDGV.Columns[6].HeaderText = "RETURNED";


            borrowDGV.Columns[0].Width = 100;
            borrowDGV.Columns[3].Width = 150;
            borrowDGV.Columns[4].Width = 150;
            borrowDGV.Columns[5].Width = 100;
            borrowDGV.Columns[6].Width = 120;

        }

        public void DisplaySearchResultId(int ID)
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();
            borrowDGV.DataSource = bll.SearchLendById(ID);
            borrowDGV.Columns[0].HeaderText = "ID";
            borrowDGV.Columns[1].HeaderText = "TITLE BOOK";
            borrowDGV.Columns[2].HeaderText = "STUDENT NAME";
            borrowDGV.Columns[3].HeaderText = "LEND DATE";
            borrowDGV.Columns[4].HeaderText = "RETURN DATE";
            borrowDGV.Columns[5].HeaderText = "OVERDUE";
            borrowDGV.Columns[6].HeaderText = "RETURNED";

            borrowDGV.Columns[0].Width = 100;
            borrowDGV.Columns[3].Width = 150;
            borrowDGV.Columns[4].Width = 150;
            borrowDGV.Columns[5].Width = 100;
            borrowDGV.Columns[6].Width = 120;
        }

        public void DisplaySearchResulStudent(string Student)
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();
            borrowDGV.DataSource = bll.SearchLendByStudent(Student);
            borrowDGV.Columns[0].HeaderText = "ID";
            borrowDGV.Columns[1].HeaderText = "TITLE BOOK";
            borrowDGV.Columns[2].HeaderText = "STUDENT NAME";
            borrowDGV.Columns[3].HeaderText = "LEND DATE";
            borrowDGV.Columns[4].HeaderText = "RETURN DATE";
            borrowDGV.Columns[5].HeaderText = "OVERDUE";
            borrowDGV.Columns[6].HeaderText = "RETURNED";


            borrowDGV.Columns[0].Width = 100;
            borrowDGV.Columns[3].Width = 150;
            borrowDGV.Columns[4].Width = 150;
            borrowDGV.Columns[5].Width = 100;
            borrowDGV.Columns[6].Width = 120;
        }
        public void DisplaySearchResultLend_Day(DateTime lend)
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();
            borrowDGV.DataSource = bll.SearchLendByDay(lend);
            borrowDGV.Columns[0].HeaderText = "ID";
            borrowDGV.Columns[1].HeaderText = "TITLE BOOK";
            borrowDGV.Columns[2].HeaderText = "STUDENT NAME";
            borrowDGV.Columns[3].HeaderText = "LEND DATE";
            borrowDGV.Columns[4].HeaderText = "RETURN DATE";
            borrowDGV.Columns[5].HeaderText = "OVERDUE";
            borrowDGV.Columns[6].HeaderText = "RETURNED";


            borrowDGV.Columns[0].Width = 100;
            borrowDGV.Columns[3].Width = 150;
            borrowDGV.Columns[4].Width = 150;
            borrowDGV.Columns[5].Width = 100;
            borrowDGV.Columns[6].Width = 120;
        }
        public void ShowAddBar()
        {
            listPanel.Size = new System.Drawing.Size(1205, 600);
            borrowPanel.Visible = true;
            borrowDGV.Size = new System.Drawing.Size(1135, 497);
            returnBtn.Location = new Point(1038, 10);
            deleteBtn.Location = new Point(880, 10);

            bookError.Visible = false;
            studentError.Visible = false;
        }

        private void borrrowBtn_Click(object sender, EventArgs e)
        {
            if (isClickBorrow == false)
            {
                ShowAddBar();
                isClickBorrow = true;
            }
            else
            {
                LoadForm();
                isClickBorrow = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();

            string idBook = bookTxt.Text;
            string idStudent = studentTxt.Text;


            // = 0 -> k ton tai
            // = 1 -> da dc muon
            // = 2 -> dm duoc
            if (idBook.Length == 0)
            {
                bookError.Text = "Fill information";
                bookError.Visible = true;
            }
            if (idStudent.Length == 0)
            {
                studentError.Text = "Fill information";
                studentError.Visible = true;
            }
            if (idStudent.Length != 0 && idBook.Length != 0)
            {
                int checkIdBook = bll.isValidIDBook(idBook);
                int checkIdStudent = bll.isValidIDStudent(idStudent);
                if (checkIdStudent == 0)
                {
                    studentError.Text = "Id doesn't exist";
                    studentError.Visible = true;
                }
                if (checkIdStudent == 1)
                {
                    studentError.Text = "Having overdue book";
                    studentError.Visible = true;
                }
                if (checkIdStudent == 2)
                {
                    studentError.Visible = false;
                }
                if (checkIdBook == 0)
                {
                    bookError.Text = "Id doesn't exist";
                    bookError.Visible = true;
                }
                if (checkIdBook == 1)
                {
                    bookError.Text = "Book has borrowed";
                    bookError.Visible = true;
                }
                if (checkIdBook == 2)
                {
                    bookError.Visible = false;
                }

                if (bll.checkQuanrityBeforeLend(Convert.ToInt32(idStudent)) == false)
                {
                    studentError.Text = "Having borrowed 5 books";
                    studentError.Visible = true;
                    return;
                }
                if (bll.checkDuplicateBook(Convert.ToInt32(idBook), Convert.ToInt32(idStudent)) == true)
                {
                    bookError.Text = "Can't borrow same books";
                    bookError.Visible = true;
                    return;
                }

                if (checkIdBook == 2 && checkIdStudent == 2)
                {
                    bll.addBorrowRecord(idStudent, idBook);
                    studentTxt.Text = "";
                    bookTxt.Text = "";
                    bookError.Visible = false;
                    studentError.Visible = false;
                    loadDGV();
                    LoadForm();
                }

            }

        }

        private void bookTxt_Click(object sender, EventArgs e)
        {
            bookError.Visible = false;
        }

        private void studentTxt_Click(object sender, EventArgs e)
        {
            studentError.Visible = false;
        }

        private void saveAndContinueBtn_Click(object sender, EventArgs e)
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();

            string idBook = bookTxt.Text;
            string idStudent = studentTxt.Text;


            // = 0 -> k ton tai
            // = 1 -> da dc muon
            // = 2 -> dm duoc
            if (idBook.Length == 0)
            {
                bookError.Text = "Fill information";
                bookError.Visible = true;
            }
            if (idStudent.Length == 0)
            {
                studentError.Text = "Fill information";
                studentError.Visible = true;
            }
            if (idStudent.Length != 0 && idBook.Length != 0)
            {
                int checkIdBook = bll.isValidIDBook(idBook);
                int checkIdStudent = bll.isValidIDStudent(idStudent);
                if (checkIdStudent == 0)
                {
                    studentError.Text = "Id doesn't exist";
                    studentError.Visible = true;
                }
                if (checkIdStudent == 1)
                {
                    studentError.Text = "Having overdue book";
                    studentError.Visible = true;
                }
                if (checkIdStudent == 2)
                {
                    studentError.Visible = false;
                }
                if (checkIdBook == 0)
                {
                    bookError.Text = "Id doesn't exist";
                    bookError.Visible = true;
                }
                if (checkIdBook == 1)
                {
                    bookError.Text = "Book has borrowed";
                    bookError.Visible = true;
                }
                if (checkIdBook == 2)
                {
                    bookError.Visible = false;
                }

                if (bll.checkQuanrityBeforeLend(Convert.ToInt32(idStudent)) == false)
                {
                    studentError.Text = "Having borrowed 5 books";
                    studentError.Visible = true;
                    return;
                }
                if (bll.checkDuplicateBook(Convert.ToInt32(idBook), Convert.ToInt32(idStudent)) == true)
                {
                    bookError.Text = "Can't borrow same books";
                    bookError.Visible = true;
                    return;
                }

                if (checkIdBook == 2 && checkIdStudent == 2)
                {
                    bll.addBorrowRecord(idStudent, idBook);
                    studentTxt.Text = "";
                    bookTxt.Text = "";
                    bookError.Visible = false;
                    studentError.Visible = false;
                    loadDGV();
                }

            }

        }


        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (borrowDGV.SelectedRows.Count > 0)
            {
                BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();

                foreach (DataGridViewRow i in borrowDGV.SelectedRows)
                {
                    bll.returnBook(i.Cells[0].Value.ToString());
                }
                loadDGV();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(borrowDGV.SelectedRows.Count > 0)
            {
                BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();

                foreach (DataGridViewRow i in  borrowDGV.SelectedRows)
                {
                    bll.deleteRecord(i.Cells[0].Value.ToString());
                }
                loadDGV();
            }
        }

        private void book_renewal_Click(object sender, EventArgs e)
        {
            if(borrowDGV.SelectedRows.Count == 1)
            {
                if (borrowDGV.SelectedRows[0].Cells[6].Value.ToString() == "False")
                {
                    BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();
                    int id = Convert.ToInt32(borrowDGV.SelectedRows[0].Cells[0].Value.ToString());
                    bll.Book_renewel(id);
                    loadDGV();
                }
                else
                {
                    MessageBox.Show("Can't renew returned book");
                }
            }
            
        }


        private void alldate_Click(object sender, EventArgs e)
        {
           
            loadDGV();

        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
           
            DisplaySearchResultLend_Day(timePicker.Value);
        }

        private void listSearchCb_Click(object sender, EventArgs e)
        {
            listSearchCb.Items.Clear();
            listSearchCb.Items.Add("ID");
            listSearchCb.Items.Add("Student");
            listSearchCb.Items.Add("Title");
            listSearchCb.Items.Add("Lend date");
            
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            
            int id;

            if (listSearchCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select search object", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (listSearchCb.SelectedItem.ToString() == "ID")
            {
              
                if (int.TryParse(searchTxt.Text, out id))
                {
                    DisplaySearchResultId(id);
                }
                else if (string.IsNullOrEmpty(searchTxt.Text))
                {
                    loadDGV();
                }
            }
            else if (listSearchCb.SelectedItem.ToString() == "Title")
            {
              
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string Title = searchTxt.Text;
                    DisplaySearchResultTitle(Title);
                }
                else
                {
                    loadDGV();
                }
            }
            else if (listSearchCb.SelectedItem.ToString() == "Student")
            {
               
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string Student = searchTxt.Text;
                    DisplaySearchResulStudent(Student);
                }
                else
                {
                    loadDGV();
                }
            }
            else if (listSearchCb.SelectedItem.ToString() == "Lend date")
            {
               
                timePicker_ValueChanged(sender, e);
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
                if (listSearchCb.SelectedItem.ToString() == "Lend date")
                {
                    timePicker.Visible = true;
                    alldate.Visible = true;
                }

                else
                {
                    timePicker.Visible = false;
                    alldate.Visible = false;
                }
            }
        }

        private void searchTxt_Click(object sender, EventArgs e)
        {
            searchTxt.Enabled = !string.IsNullOrEmpty(listSearchCb.Text);
            if (!searchTxt.Enabled)
            {
                MessageBox.Show("Please select search object", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();
            if (pagenumber - 1 > 0)
            {
                pagenumber--;
                borrowDGV.DataSource = bll.getList(pagenumber, pagesize);
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            BorrowAndReturnForm_BLL bll = new BorrowAndReturnForm_BLL();
            if (pagenumber - 1 < bll.count(pagesize))
            {
                pagenumber++;
                borrowDGV.DataSource = bll.getList(pagenumber, pagesize);

            }
        }
    }
}
