using PBL_3.BLL;
using PBL_3.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PBL_3.View
{
    
    public partial class StatisticForm : Form
    {
        int numberpage = 1;
        int numberrecord = 9;
        int numberrecord_1 = 5;
        public StatisticForm()
        {
            InitializeComponent();
            loadForm();
            loadChartList();
        }

        public void loadForm()
        {
            Statistic_BLL bll = new Statistic_BLL();
            borrowerLb.Text = bll.getNumberOfBorrower();
            overdueLb.Text = bll.getNumberOfOverdue();
            borrowLb.Text = bll.getNumberOfBorrowBook();
            bookLb.Text = bll.getNumberOfBook();

            borrowDGV.DataSource = bll.getStudent(numberpage,numberrecord);
            borrowDGV.Columns[0].HeaderText = "NAME";
            borrowDGV.Columns[1].HeaderText = "NUMBER OF BOOKS";

            overdueDGV.DataSource = bll.getOverdue();
            overdueDGV.Columns[0].HeaderText = "NAME";
            overdueDGV.Columns[1].HeaderText = "BOOK";
            overdueDGV.Columns[2].HeaderText = "DAY";
        }

        private void reminderBtn_Click(object sender, EventArgs e)
        {
            Statistic_BLL bll = new Statistic_BLL();
            bll.sendMultiEmail();
        }

        public void loadChartList()
        {
            Statistic_BLL bll = new Statistic_BLL();
            bookDGV.DataSource = bll.createList();
            bookDGV.Columns[0].HeaderText = "DATE";
            bookDGV.Columns[1].HeaderText = "QUANTITY";
            bookDGV.Columns[1].Width = 150;

            categoryDGV.DataSource = bll.getBookPerCategory(numberpage, numberrecord_1);
            categoryDGV.Columns[0].HeaderText = "CATEGORY";
            categoryDGV.Columns[1].HeaderText = "QUANTITY";
            categoryDGV.Columns[1].Width = 150;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            Statistic_BLL bll = new Statistic_BLL();
            if (numberpage - 1 > 0)
            {
                numberpage--;
                borrowDGV.DataSource = bll.getStudent(numberpage, numberrecord);
            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            Statistic_BLL bll = new Statistic_BLL();
            if (numberpage - 1 < bll.count(numberrecord))
            {
                numberpage++;
                borrowDGV.DataSource = bll.getStudent(numberpage, numberrecord);

            }
        }

        private void Previouscategory_Click(object sender, EventArgs e)
        {
            Statistic_BLL bll = new Statistic_BLL();
            if (numberpage - 1 > 0)
            {
                numberpage--;
                categoryDGV.DataSource = bll.getBookPerCategory(numberpage, numberrecord_1);
            }
        }

        private void nextcategory_Click(object sender, EventArgs e)
        {
            Statistic_BLL bll = new Statistic_BLL();
            if (numberpage - 1 < bll.countcate(numberrecord_1))
            {
                numberpage++;
                categoryDGV.DataSource = bll.getBookPerCategory(numberpage, numberrecord_1);
            }
        }
    }
}
