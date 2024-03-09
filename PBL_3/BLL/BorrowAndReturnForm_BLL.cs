using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBL_3.DAL;
using PBL_3.DTO;
namespace PBL_3.BLL
{
    internal class BorrowAndReturnForm_BLL
    {
        public List<BorrowListInfor> getList(int numberpage,int pagsize)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.getList(numberpage, pagsize);
        }
        public int count(int numberrecord)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.count(numberrecord);

        }
        public void addBorrowRecord(string idStudent, string idBook)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();

            LENDED_BOOK lend = new LENDED_BOOK
            {
                ID = dal.createNewId(),
                ID_BOOK = Convert.ToInt32(idBook),
                ID_STUDENT = Convert.ToInt32(idStudent),
                LEND_DAY = DateTime.Now,
                RETURNED = false,
                OVERDUE = false
            };
            dal.addBorrowRecord(lend);
            // 0 la da muon
            // 1 la da tra
            dal.updateStatusBook(Convert.ToInt32(idBook), 0);
        }
        public List<BorrowListInfor> SearchLendByTitle(string Title)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.SearchLendByTitle(Title);
        }
       
        public List<BorrowListInfor> SearchLendById(int ID)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.SearchLendByID(ID);
        }
        public bool checkQuanrityBeforeLend(int studentID)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.checkQuanrityBeforeLend(studentID);
        }

        public bool checkDuplicateBook(int bookid, int studentid)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.checkDuplicateBook(bookid, studentid);
        }
        public List<BorrowListInfor> SearchLendByStudent(string student)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.SearchLendbyStudent(student);
        }
        public List<BorrowListInfor> SearchLendByDay(DateTime Lend)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.SearchLendbyday(Lend);
        }
        public int isValidIDBook(string id) 
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.isValidIDBook(Convert.ToInt32(id));
        }


        public int isValidIDStudent(string id)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            return dal.isValidIDStudent(Convert.ToInt32(id));
        }

        public void deleteRecord(string id)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            dal.deleteRecord(Convert.ToInt32(id));
        }

        public void returnBook(string id)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            dal.returnBook(Convert.ToInt32(id));
        }

        public void Book_renewel(int id)
        {
            BorrowAndReturnForm_DAL dal = new BorrowAndReturnForm_DAL();
            dal.Book_renewel(id);
        }
    }
}
