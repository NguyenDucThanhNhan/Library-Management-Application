using PBL_3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_3.DTO;

namespace PBL_3.BLL
{
    internal class MainForm_BLL
    {
        public string getName(string username)
        {
            MainForm_DAL dal = new MainForm_DAL();
            return dal.getName(username);
        }

        public string getDatetime()
        {
            string month = DateTime.Now.ToString("MMMM");
            string day = DateTime.Now.Day.ToString();
            string year = DateTime.Now.Year.ToString();
            string dayInWeek = DateTime.Now.DayOfWeek.ToString();

            return month + " " + day + ", " + year + " | " + dayInWeek;
        }

        public string getTotalBook()
        {
            MainForm_DAL dal = new MainForm_DAL();
            return dal.getTotalBook();
        }

        public string getTotalOverdueBook()
        {
            MainForm_DAL dal = new MainForm_DAL();
            return dal.getTotalOverdueBook();
        }

        public string getTotalBorrowedBook()
        {
            MainForm_DAL dal = new MainForm_DAL();
            return dal.getTotalBorrowedBook();
        }

        public string getTotalStudent()
        {
            MainForm_DAL dal = new MainForm_DAL();
            return dal.getTotalStudent();
        }

        public List<StudenList> GetRecordsByPage(int numberpage, int numberrecord)
        {
            MainForm_DAL dal = new MainForm_DAL();
            return dal.GetRecordsByPage(numberpage, numberrecord);
        }
        public int count(int numberrecord)
        {
            MainForm_DAL dal = new MainForm_DAL();
            return dal.count( numberrecord);
        }
        public List<OverDueList> getOverdue()
        {
            MainForm_DAL dal = new MainForm_DAL();
            return dal.getOverdue();
        }
    }
}
