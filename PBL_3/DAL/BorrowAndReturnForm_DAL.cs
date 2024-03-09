using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using PBL_3.DTO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PBL_3.DAL
{
    public class BorrowAndReturnForm_DAL
    {
        public List<BorrowListInfor> getList(int pageNumber, int pageSize)
        {
            using (QLTV cmd = new QLTV())
            {
                int skipCount = (pageNumber - 1) * pageSize;
                List<BorrowListInfor> lend = cmd.LENDED_BOOK.OrderByDescending(p => p.ID)
                  .OrderBy(c => c.ID)
                    .Skip(skipCount)
                    .Take(pageSize)
                 .Select(p => new BorrowListInfor
                 {
                     id = p.ID,
                     title = p.BOOK.TITLE,
                     studentName = p.STUDENT.NAME,
                     lendDay = p.LEND_DAY,
                     returnDay = (DateTime)DbFunctions.AddDays(p.LEND_DAY, p.BOOK.CATEGORY.LEND_NUMBER_DAY),
                     overdue = p.OVERDUE,
                     returned = p.RETURNED
                 }).ToList();
                return lend;
            }
        }
        public bool checkQuanrityBeforeLend(int studentID)
        {
            using (QLTV cmd = new QLTV())
            {
                int count = cmd.LENDED_BOOK.Where(p => p.ID_STUDENT == studentID && p.RETURNED == false).Count();
                if (count >= 5) return false;
                else return true;
            }
        }

        public bool checkDuplicateBook(int bookID, int studentID)
        {
            using (QLTV cmd = new QLTV())
            {
                var book = cmd.BOOKs.Where(p => p.ID == bookID).Select(p => new { p.TITLE, p.AUTHOR, p.PUBLISH_YEAR }).FirstOrDefault();
                if (book == null) return false;
                var check = cmd.LENDED_BOOK.Where(p => p.ID_STUDENT == studentID && p.BOOK.AUTHOR == book.AUTHOR && p.BOOK.TITLE.Equals(book.TITLE) && p.BOOK.PUBLISH_YEAR == book.PUBLISH_YEAR && p.RETURNED == false).FirstOrDefault();
                if (check == null) return false;
                return true;
            }
        }
        public int count(int numberrecord)
        {
            int totalrecord = 0;
            using (QLTV cmd = new QLTV())
            {
                totalrecord = cmd.LENDED_BOOK.Count();

            }
            return totalrecord /= numberrecord;
        }

        public List<BorrowListInfor> SearchLendByTitle(string Title)
        {
            using (QLTV cmd = new QLTV())
            {
                List<BorrowListInfor> lend = cmd.LENDED_BOOK.OrderByDescending(p => p.ID).Where(p => p.BOOK.TITLE.Contains(Title)).Select(p => new BorrowListInfor
                {
                    id = p.ID,
                    title = p.BOOK.TITLE,
                    studentName = p.STUDENT.NAME,
                    lendDay = p.LEND_DAY,
                    returnDay = (DateTime)DbFunctions.AddDays(p.LEND_DAY, p.BOOK.CATEGORY.LEND_NUMBER_DAY),
                    overdue = p.OVERDUE,
                    returned = p.RETURNED
                }).ToList();
                return lend;
            }
        }

        public List<BorrowListInfor> SearchLendByID(int ID)
        {
            using (QLTV cmd = new QLTV())
            {
                List<BorrowListInfor> lend = cmd.LENDED_BOOK.OrderByDescending(p => p.ID).Where(p => p.ID.ToString().StartsWith(ID.ToString())).Select(p => new BorrowListInfor
                {
                    id = p.ID,
                    title = p.BOOK.TITLE,
                    studentName = p.STUDENT.NAME,
                    lendDay = p.LEND_DAY,
                    returnDay = (DateTime)DbFunctions.AddDays(p.LEND_DAY, p.BOOK.CATEGORY.LEND_NUMBER_DAY),
                    overdue = p.OVERDUE,
                    returned = p.RETURNED
                }).ToList();
                return lend;
            }
        }
        public List<BorrowListInfor> SearchLendbyStudent(string Student)
        {
            using (QLTV cmd = new QLTV())
            {
                List<BorrowListInfor> lend = cmd.LENDED_BOOK.OrderByDescending(p => p.ID).Where(p => p.STUDENT.NAME.Contains(Student)).Select(p => new BorrowListInfor
                {
                    id = p.ID,
                    title = p.BOOK.TITLE,
                    studentName = p.STUDENT.NAME,
                    lendDay = p.LEND_DAY,
                    returnDay = (DateTime)DbFunctions.AddDays(p.LEND_DAY, p.BOOK.CATEGORY.LEND_NUMBER_DAY),
                    overdue = p.OVERDUE,
                    returned = p.RETURNED
                }).ToList();
                return lend;
            }
        }
        public List<BorrowListInfor> SearchLendbyday(DateTime lend)
        {
            using (QLTV cmd = new QLTV())
            {
                DateTime time = new DateTime(lend.Year, lend.Month, lend.Day);
                List<BorrowListInfor> lended = cmd.LENDED_BOOK.OrderByDescending(p => p.ID).Where(p => p.LEND_DAY == time).Select(p => new BorrowListInfor
                {
                    id = p.ID,
                    title = p.BOOK.TITLE,
                    studentName = p.STUDENT.NAME,
                    lendDay = p.LEND_DAY,
                    returnDay = (DateTime)DbFunctions.AddDays(p.LEND_DAY, p.BOOK.CATEGORY.LEND_NUMBER_DAY),
                    overdue = p.OVERDUE,
                    returned = p.RETURNED
                }).ToList();
                return lended;
            }
        }
        public bool isOverdueStudent(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var overdue = cmd.LENDED_BOOK.Where(p => p.ID_STUDENT == id && p.OVERDUE == true).FirstOrDefault();
                if (overdue == null)
                    return false;
                return true;
            }
        }

        
        public void addBorrowRecord(LENDED_BOOK lend)
        {
            using (QLTV cmd = new QLTV())
            {
                cmd.LENDED_BOOK.Add(lend);
                cmd.SaveChanges();
            }
        }

        public void updateStatusBook(int id, int type)
        {
            // 0 la da muon
            // 1 la da tra
            using (QLTV cmd = new QLTV())
            {
                var book = cmd.BOOKs.Where(p => p.ID == id).FirstOrDefault();
                if (type == 0)
                {
                    book.STATUS = false;
                }
                else
                {
                    book.STATUS = true;
                }
                cmd.SaveChanges();
            }
        }

        public int isValidIDBook(int id)
        {

            using (QLTV cmd = new QLTV())
            {
                List<BorrowListInfor> borrow = new List<BorrowListInfor>();
                var idBd = cmd.BOOKs.Where(s => s.ID == id).FirstOrDefault();
                if (idBd == null)
                    return 0;

                if (idBd.STATUS == false)
                {
                    return 1;
                }
                else if (idBd.STATUS == true)
                {
                    return 2;
                }
                else if (borrow.Any(x => x.title == idBd.TITLE))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            
            }
        }
               
        
       

        public int isValidIDStudent(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var idBd = cmd.STUDENTs.Where(s => s.ID == id).FirstOrDefault();
                if (idBd == null)
                    return 0;
                var overdue = isOverdueStudent(id);
                if (overdue == true)
                    return 1;
                return 2;
            }
        }

        public int createNewId()
        {
            using (QLTV cmd = new QLTV()) 
            {
                var id = cmd.LENDED_BOOK.Select(p => p.ID).DefaultIfEmpty().Max();
                if (id == 0)
                {
                    return 1;
                }
                else 
                { 
                    return Convert.ToInt32(id) + 1; 
                }
            }
        }
        public void deleteRecord(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var record = cmd.LENDED_BOOK.Where(p => p.ID == id).FirstOrDefault();
                updateStatusBook(record.ID_BOOK, 1);
                cmd.LENDED_BOOK.Remove(record); 
                cmd.SaveChanges();
            }
        }

        public void deleteRecordHavingIdBook(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                List<LENDED_BOOK> record = cmd.LENDED_BOOK.Where(p => p.ID_BOOK == id).ToList();
                foreach(LENDED_BOOK i in record)
                {
                    cmd.LENDED_BOOK.Remove(i);
                }
                cmd.SaveChanges();
            }
        }

        public void deleteRecordHavingIdStudent(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                List<LENDED_BOOK> record = cmd.LENDED_BOOK.Where(p => p.ID_STUDENT == id).ToList();
                foreach (LENDED_BOOK i in record)
                {
                    cmd.LENDED_BOOK.Remove(i);
                }
                cmd.SaveChanges();
            }
        }

        public void returnBook(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var record = cmd.LENDED_BOOK.Where(p => p.ID == id).FirstOrDefault();
                updateStatusBook(record.ID_BOOK, 1);
                record.RETURNED = true;
                cmd.SaveChanges();
            }
        }

        public void Book_renewel(int bookId)
        {
            using (QLTV cmd = new QLTV())
            {
                var book = cmd.BOOKs.SingleOrDefault(b => b.ID == bookId);
                var lending = cmd.LENDED_BOOK.SingleOrDefault(l => l.ID == bookId && l.RETURNED == false);
                BorrowListInfor listInfor = new BorrowListInfor();
                lending.LEND_DAY = DateTime.Now;
                lending.OVERDUE = false;
                cmd.SaveChanges();

            }
        }
    }
}


