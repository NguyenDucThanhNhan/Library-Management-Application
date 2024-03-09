using PBL_3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PBL_3.DAL.Statistic_DAL;
using PBL_3.DTO;
using System.Data.Entity;
using System.Windows.Forms;

namespace PBL_3.BLL
{
    internal class Statistic_BLL
    {
        public string getNumberOfBorrower()
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.getNumberOfBorrower();
        }

        public string getNumberOfOverdue()
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.getNumberOfOverdue();
        }

        public string getNumberOfBorrowBook()
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.getNumberOfBorrowBook();
        }

        public string getNumberOfBook()
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.getNumberOfBook();
        }

        public List<borrowerStatistic> getStudent(int pagenumber,int numberrecord)
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.getStudent(pagenumber, numberrecord);
        }

        public List<overdueStatistic> getOverdue()
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.getOverdue();
        }

        public void sendMultiEmail()
        {
            SendEmail_BLL bll = new SendEmail_BLL();
            bll.sendMultiEmail();
        }
        public int count(int numberrecord)
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.count(numberrecord);

        }
        public List<DateTime> getDayForChart()
        {
            DateTime currentDate = DateTime.Now;
            List<DateTime> dayList = new List<DateTime>();
            for (int i = 0; i <=6 ; i++)
            {
                DateTime date = currentDate.AddDays(-i);
                dayList.Add(new DateTime(date.Year, date.Month, date.Day));
            }
            return dayList;
        }

        public int GetImagineCharts(DateTime time)
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.GetImagineCharts(time);
        }

        public List<ImagineChart> createList()
        {
            Statistic_DAL dal = new Statistic_DAL();
            List<ImagineChart> list = new List<ImagineChart>();
            List<DateTime> time = getDayForChart();
            foreach(DateTime i in time)
            {
                list.Add(new ImagineChart()
                {
                    date = i,
                    quantity = dal.GetImagineCharts(i)
                });
            }
            return list;
        }

        public List<BookPerCategory> getBookPerCategory(int pagenumber,int numberrecord)
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.getBookPerCategory(pagenumber, numberrecord);
        }
        public int countcate(int numberrecord)
        {
            Statistic_DAL dal = new Statistic_DAL();
            return dal.countcategory( numberrecord);
        }
    }
}
