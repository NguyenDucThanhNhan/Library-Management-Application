using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_3.BLL;
using static Guna.UI2.Native.WinApi;

namespace PBL_3.View
{
    public partial class Main : Form
    {
        string usernameAcc;
        public Main(string usernameAcc)
        {
            InitializeComponent();
            this.usernameAcc = usernameAcc;
            container_main(new MainForm(usernameAcc));
        }

        public void setColour()
        {
            bookBtn.FillColor = Color.FromArgb(53, 51, 52);
            borrowBtn.FillColor = Color.FromArgb(53, 51, 52);
            accountBtn.FillColor = Color.FromArgb(53, 51, 52);
            studentBtn.FillColor = Color.FromArgb(53, 51, 52);
            mainBtn.FillColor = Color.FromArgb(53, 51, 52);
            statisticBtn.FillColor = Color.FromArgb(53, 51, 52);
        }

        public void setStudentBtnColour()
        {
            studentBtn.FillColor = Color.FromArgb(247, 88, 103);
        }

        public void setStatisticBtnColour()
        {
            statisticBtn.FillColor = Color.FromArgb(247, 88, 103);
        }

        private void container_main(object _form)
        {
            if (menuPanel.Controls.Count > 0) menuPanel.Controls.Clear();

            MainForm fm = _form as MainForm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            menuPanel.Controls.Add(fm);
            menuPanel.Tag = fm;
            fm.Show();

        }
        private void container_Sv(object _form)
        {
            if (menuPanel.Controls.Count > 0) menuPanel.Controls.Clear();

            StudentManagementForm fm = _form as StudentManagementForm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            menuPanel.Controls.Add(fm);
            menuPanel.Tag = fm;
            fm.Show();
        }

        private void container_Account(bool check)
        {
            if (menuPanel.Controls.Count > 0) menuPanel.Controls.Clear();

            if (check)
            {
                AccountManagementForm fm = new AccountManagementForm();
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;
                menuPanel.Controls.Add(fm);
                menuPanel.Tag = fm;
                fm.Show();
            }
            else
            {
                
                PrivateAccountForm fm = new PrivateAccountForm(usernameAcc);
                fm.change += changeUsername;
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;
                menuPanel.Controls.Add(fm);
                menuPanel.Tag = fm;
                fm.Show();
            }
        }

        private void container_Book(object _form)
        {
    
            if (menuPanel.Controls.Count > 0) menuPanel.Controls.Clear();

            BookManagementForm fm = _form as BookManagementForm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            menuPanel.Controls.Add(fm);
            menuPanel.Tag = fm;
            fm.Show();
        }

        private void container_Borrow(object _form)
        {
            if (menuPanel.Controls.Count > 0) menuPanel.Controls.Clear();

            BorrowAndReturnForm fm = _form as BorrowAndReturnForm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            menuPanel.Controls.Add(fm);
            menuPanel.Tag = fm;
            fm.Show();
        }

        private void container_Statistic(object _form)
        {
            if (menuPanel.Controls.Count > 0) menuPanel.Controls.Clear();

            StatisticForm fm = _form as StatisticForm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            menuPanel.Controls.Add(fm);
            menuPanel.Tag = fm;
            fm.Show();
            
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            
            setColour();
            studentBtn.FillColor = Color.FromArgb(247, 88, 103);
            container_Sv(new StudentManagementForm());
           
        }



        private void mainBtn_Click(object sender, EventArgs e)
        {
            setColour();
            mainBtn.FillColor = Color.FromArgb(247, 88, 103);
            container_main(new MainForm(usernameAcc));
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            
            setColour();
            bookBtn.FillColor = Color.FromArgb(247, 88, 103);

            container_Book(new BookManagementForm());
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
           
            setColour();
            borrowBtn.FillColor = Color.FromArgb(247, 88, 103);
            container_Borrow(new BorrowAndReturnForm());
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
           
            setColour();
            accountBtn.FillColor = Color.FromArgb(247, 88, 103);

            Main_BLL bll = new Main_BLL();
            bool isManagerAcc = bll.isManagerAcc(usernameAcc);
            

            //true -> form manager
            //false -> form private
            container_Account(isManagerAcc);
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            setColour();
            statisticBtn.FillColor = Color.FromArgb(247, 88, 103);

            container_Statistic(new StatisticForm());
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        public void changeUsername(string newUsername)
        {
            usernameAcc = newUsername;
        }

     
    }
}
