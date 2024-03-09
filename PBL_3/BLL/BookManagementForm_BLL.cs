using PBL_3.DAL;
using PBL_3.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace PBL_3.BLL
{
    public class BookManagement_BLL
    {
       public List<CategoryCBBItem> GetCategoryCBBItems()
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.GetCategoryCBBItems();
        }
        public List<BookList> SearchBookByTitle(string Title)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.SearchBookbyTitle(Title);
        }
        public bool isInexistCategory(string category)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.isInexistCategory(category);
        }
        public int count(int numberrecord)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.count(numberrecord);

        }
        public List<BookList> searchbookbyAuthor(string Author)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.SearchBookbyAuthor(Author);
        }
        public List<BookList> loadRecord(int page,int numberrecord)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.LoadRecord(page,numberrecord);
        }
        public List<BookList> searchbookbycategory(string Category)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.SearchBookbyCategory(Category);
        }
        public List<BookList> searchbookbyPublishYear(int publish_year)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.SearchBookbyPublishYear(publish_year);
        }
        public void UpdateBook(string title, string author, string idCategory, int publishYear, string titleUp, string authorUp, string idCategoryUp, int publishYearUp)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            dal.UpdateBook(title, author, idCategory, publishYear, titleUp, authorUp, idCategoryUp, publishYearUp);
        }
        public void AddBook(int quantity,string title, string author, string idcategory, int publishYear)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
          
            for (int i = 0; i < quantity; i++)
            {
                BOOK book = new BOOK()
                {
                    ID = dal.createNewId(),
                    TITLE = title,
                    AUTHOR = author,
                    ID_CATEGORY = Convert.ToInt32(idcategory),
                    PUBLISH_YEAR = publishYear,
                    STATUS = true
                };
                dal.AddBook(book);
               
            }
        }

        public void deleteBook(string id)
        {
            BorrowAndReturnForm_DAL borrrowdal = new BorrowAndReturnForm_DAL();
            borrrowdal.deleteRecordHavingIdBook(Convert.ToInt32(id));
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            dal.deleteBook(Convert.ToInt32(id));
        }

       
        public List<BookDelete> deleteList(string title, string author, int publishYear)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            return dal.deleteList(title, author, publishYear);
        }

        public void AddCategory(string name, string lendNumberDay, string location)
        {
            BookManagementForm_DAL dal = new BookManagementForm_DAL();
            CATEGORY category = new CATEGORY()
            {
                ID = dal.createNewIdCategory(),
                NAME = name,
                LEND_NUMBER_DAY = Convert.ToInt32(lendNumberDay),
                LOCATION = location
            };
            dal.AddCategory(category);
        }
    }
}
