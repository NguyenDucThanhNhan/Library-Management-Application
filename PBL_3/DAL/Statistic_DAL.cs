using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using PBL_3.DTO;

namespace PBL_3.DAL
{
    internal class Statistic_DAL
    {
        public string getNumberOfBorrower()
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.STUDENTs.Count().ToString();
            }
        }

        public string getNumberOfOverdue()
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.LENDED_BOOK.Where(p => p.OVERDUE == true).Count().ToString();
            }
        }

        public string getNumberOfBorrowBook()
        {
            using(QLTV cmd = new QLTV())
            {
                return cmd.LENDED_BOOK.Count().ToString();
            }
        }

        public string getNumberOfBook()
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.BOOKs.Count().ToString();
            }
        }

        public List<borrowerStatistic> getStudent(int pageNumber,int pageSize)
        {
            using (QLTV cmd = new QLTV())
            {
                int skipCount = (pageNumber - 1) * pageSize;
                List<borrowerStatistic> query = cmd.STUDENTs
               .GroupJoin(cmd.LENDED_BOOK, s => s.ID, l => l.ID_STUDENT, (s, g) => new { s, g })
               .OrderByDescending(x => x.g.Count()).
               ThenBy(b=>b.s.ID)
               .Skip(skipCount).Take(pageSize)
               .Select(x => new borrowerStatistic
               {
                   Name = x.s.NAME,
                   numberBook = x.g.Count()
               }).ToList();
                return query;
            }
        }
        public int count(int numberrecord)
        {
            int totalrecord = 0;
            using (QLTV cmd = new QLTV())
            {
                totalrecord = cmd.STUDENTs.Count();

            }
            return totalrecord /= numberrecord;
        }

        public List<overdueStatistic> getOverdue()
        {
            using (QLTV cmd = new QLTV())
            {
                List<overdueStatistic> query = cmd.LENDED_BOOK.OrderByDescending(s => (int)DbFunctions.DiffDays(DbFunctions.AddDays(s.LEND_DAY, s.BOOK.CATEGORY.LEND_NUMBER_DAY), DateTime.Today)).Where(p => p.OVERDUE == true).Select(s => new overdueStatistic
                {
                    Name = s.STUDENT.NAME,
                    Book = s.BOOK.TITLE,
                    Day = (int)DbFunctions.DiffDays(DbFunctions.AddDays(s.LEND_DAY, s.BOOK.CATEGORY.LEND_NUMBER_DAY), DateTime.Today)
                }).ToList();
                return query;
            }
        }

        public List<int> getStudentIdList()
        {
            using(QLTV cmd = new QLTV())
            {
                return cmd.LENDED_BOOK.Where(p => p.OVERDUE == true).Select(p => p.STUDENT.ID).Distinct().ToList();
            }
        }

        public string getOverdueInformation(int studentId)
        {
            using (QLTV cmd = new QLTV())
            {
                string information = "";
                List<OverDueInformation> list = cmd.LENDED_BOOK.Where(p => p.ID_STUDENT == studentId && p.OVERDUE == true).Where(p => p.OVERDUE == true).Select(p => new OverDueInformation
                {
                    Book = p.BOOK.TITLE,
                    Day = (int)DbFunctions.DiffDays(DbFunctions.AddDays(p.LEND_DAY, p.BOOK.CATEGORY.LEND_NUMBER_DAY), DateTime.Today)
                }).ToList();
                foreach (OverDueInformation i in list)
                {
                    if(information.Length != 0)
                    {
                        information += ", ";
                    }
                    information += i.Book + " - " + i.Day + "days";
                }
                return information;
            }
        }

        public string getEmailByStudentId(int studentId)
        {
            using(QLTV cmd = new QLTV())
            {
                return cmd.STUDENTs.Where(p => p.ID == studentId).Select(p => p.EMAIL).FirstOrDefault();
            }
        }

        public string getNamelByStudentId(int studentId)
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.STUDENTs.Where(p => p.ID == studentId).Select(p => p.NAME).FirstOrDefault();
            }
        }

        public int GetImagineCharts(DateTime time)
        {
            using(QLTV cmd = new QLTV())
            {
                DateTime date = new DateTime(time.Year, time.Month, time.Day);
                return cmd.LENDED_BOOK.Count(p => p.LEND_DAY == date);
            }    
        }

        public List<BookPerCategory> getBookPerCategory(int numberpage, int pageSize)
        {
            using (QLTV cmd = new QLTV())
            {
                int skipCount = (numberpage - 1) * pageSize;
                return cmd.CATEGORies.GroupJoin(cmd.BOOKs, b => b.ID, c => c.ID_CATEGORY, (b, c) => new { b, c })
                    .OrderBy(c =>c.b.ID )
                    .Skip(skipCount)
                    .Take(pageSize)
                    .Select(p => new BookPerCategory
                    {
                        category = p.b.NAME,
                        quantity = p.c.Count()
                    })
                    .ToList();
            }
        }

        public int countcategory(int numberrecord)
        {
            int totalrecord = 0;
            using (QLTV cmd = new QLTV())
            {
                totalrecord = cmd.CATEGORies.Count();

            }
            return totalrecord /= numberrecord;
        }
    }
}
