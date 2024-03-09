using PBL_3.BLL;
using PBL_3.View;
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
    public partial class MainForm : Form
    {
        string username;
        int numberpagge = 1;
        int numberrecord = 9;
        public MainForm(string username)
        {
            InitializeComponent();
            this.username = username;
            showForm();
        }

        private void showForm()
        {
            MainForm_BLL bll = new MainForm_BLL();
            welcomeLb.Text = bll.getName(username);
            datetimeLb.Text = bll.getDatetime();
            totalBookLb.Text = bll.getTotalBook();
            totalOverdueBookLb.Text = bll.getTotalOverdueBook();
            totalBorrowedBookLb.Text = bll.getTotalBorrowedBook();
            totalStudentLb.Text = bll.getTotalStudent();

            studentDGV.DataSource = bll.GetRecordsByPage(numberpagge,numberrecord);
            studentDGV.Columns[0].Width = 50;
            studentDGV.Columns[2].Width = 150;
            studentDGV.Columns[3].Width = 150;
            studentDGV.Columns[0].HeaderText = "ID";
            studentDGV.Columns[1].HeaderText = "NAME";
            studentDGV.Columns[2].HeaderText = "CLASS";
            studentDGV.Columns[3].HeaderText = "BORROW QUANTITY";

            overdueDGV.DataSource = bll.getOverdue();
            overdueDGV.Columns[0].Width = 50;
            overdueDGV.Columns[2].Width = 150;
            overdueDGV.Columns[3].Width = 150;
            overdueDGV.Columns[0].HeaderText = "ID";
            overdueDGV.Columns[1].HeaderText = "NAME";
            overdueDGV.Columns[2].HeaderText = "BOOK";
            overdueDGV.Columns[3].HeaderText = "BORROW DATE";
            overdueDGV.Columns[4].HeaderText = "DAY";
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            Main main = Application.OpenForms.OfType<Main>().FirstOrDefault();
            main.setColour();
            main.setStudentBtnColour();

            StudentManagementForm studentForm = new StudentManagementForm();
            studentForm.TopLevel = false;
            studentForm.FormBorderStyle = FormBorderStyle.None;
            studentForm.Dock = DockStyle.Fill;
            menuPanel.Controls.Clear();
            menuPanel.Controls.Add(studentForm);
            studentForm.Show();
            studentForm.ShowAddBar();
        }

        private void checkOverdueBtn_Click(object sender, EventArgs e)
        {
            Main main = Application.OpenForms.OfType<Main>().FirstOrDefault();
            main.setColour();
            main.setStatisticBtnColour();

            StatisticForm statistic = new StatisticForm();
            statistic.TopLevel = false;
            statistic.FormBorderStyle = FormBorderStyle.None;
            statistic.Dock = DockStyle.Fill;
            menuPanel.Controls.Clear();
            menuPanel.Controls.Add(statistic);
            statistic.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            MainForm_BLL bll = new MainForm_BLL();
            if (numberpagge - 1 < bll.count(numberrecord))
            {
                numberpagge++;
                studentDGV.DataSource = bll.GetRecordsByPage(numberpagge, numberrecord);

            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (numberpagge - 1 > 0)
            {
                MainForm_BLL bll = new MainForm_BLL();
                numberpagge--;
                studentDGV.DataSource = bll.GetRecordsByPage(numberpagge, numberrecord);
            }
        }
    }
}
