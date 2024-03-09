using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_3.DTO;

namespace PBL_3.DAL
{
    internal class MainForm_DAL
    {
        public string getName(string username)
        {
            using(QLTV cmd = new QLTV())
            {
                return cmd.STAFFs.Where(p => p.ACCOUNT.USERNAME.Equals(username)).Select(p => p.NAME).FirstOrDefault().ToString();
            }
        }

        public string getTotalBook()
        {
            using(QLTV cmd = new QLTV())
            {
                return cmd.BOOKs.Count().ToString();
            }
        }

        public string getTotalOverdueBook()
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.LENDED_BOOK.Where(p => p.OVERDUE == true).Count().ToString();
            }
        }

        public string getTotalBorrowedBook()
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.LENDED_BOOK.Where(p => p.RETURNED == false).Count().ToString();
            }
        }

        public string getTotalStudent()
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.STUDENTs.Count().ToString();
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

        public List<StudenList> GetRecordsByPage(int pageNumber, int pageSize)
        {
            using (QLTV cmd = new QLTV())
            {
                int skipCount = (pageNumber - 1) * pageSize;

                List<StudenList> result = cmd.STUDENTs
                    .GroupJoin(
                        cmd.LENDED_BOOK,
                        s => s.ID,
                        l => l.ID_STUDENT,
                        (s, g) => new { Student = s, LendedBooks = g }
                    )
                    .OrderByDescending(b => b.LendedBooks.Count())
                    .ThenBy(b => b.Student.ID)
                    .Skip(skipCount)
                    .Take(pageSize)
                    .Select(b => new StudenList
                    {
                        ID = b.Student.ID,
                        Name = b.Student.NAME,
                        Class = b.Student.CLASS,
                        numberBook = b.LendedBooks.Count()
                    })
                    .ToList();

                return result;
            }
        }

        public List<OverDueList> getOverdue()
        {
            using (QLTV cmd = new QLTV())
            {
                List<OverDueList> query = cmd.LENDED_BOOK.OrderByDescending(s => (int)DbFunctions.DiffDays(DbFunctions.AddDays(s.LEND_DAY, s.BOOK.CATEGORY.LEND_NUMBER_DAY), DateTime.Today)).Where(p => p.OVERDUE == true).Select(s => new OverDueList
                {
                    ID = s.ID,
                    Name = s.STUDENT.NAME,
                    Book = s.BOOK.TITLE,
                    BorrowDate = s.LEND_DAY,
                    Day = (int)DbFunctions.DiffDays( DbFunctions.AddDays( s.LEND_DAY, s.BOOK.CATEGORY.LEND_NUMBER_DAY), DateTime.Today)
                }).ToList();
                return query;
            }
        }
    }
}
