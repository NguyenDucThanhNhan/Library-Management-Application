using Microsoft.Ajax.Utilities;
using PBL_3.DTO;
using PBL_3.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Guna.UI2.Native.WinApi;

namespace PBL_3.DAL
{
    public class BookManagementForm_DAL
    {
        
        public List<CategoryCBBItem> GetCategoryCBBItems()
        {

            using (QLTV cmd = new QLTV())
            {
                List<CategoryCBBItem> query = cmd.CATEGORies.Select(s => new CategoryCBBItem
                {
                    id = s.ID,
                    name = s.NAME
                }).ToList();
                return query;
            }
        }
        public bool isInexistCategory(string category)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.CATEGORies.Where(p => p.NAME == category).FirstOrDefault();
                if (acc == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void AddBook(BOOK book)
        {
            using (QLTV cmd = new QLTV())
            {
                
                cmd.BOOKs.Add(book);
                cmd.SaveChanges();
               
            }
        }

        public int createNewId()
        {
            using (QLTV cmd = new QLTV())
            {
                var id = cmd.BOOKs.Select(p => p.ID).DefaultIfEmpty().Max();
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

        public void deleteBook(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var book = cmd.BOOKs.Where(p => p.ID == id).FirstOrDefault();
                cmd.BOOKs.Remove(book);
                cmd.SaveChanges();
            }
        }

        public void UpdateBook(string title, string author, string idCategory, int publishYear, string titleUp, string authorUp, string idCategoryUp, int publishYearUp)
        {
            using (QLTV cmd = new QLTV())
            {
                List<BOOK> books = cmd.BOOKs.Where(p => p.AUTHOR == author && p.TITLE == title && p.PUBLISH_YEAR == publishYear).ToList();
                foreach (BOOK book in books)
                {
                    book.TITLE = titleUp;
                    book.AUTHOR = authorUp;
                    book.ID_CATEGORY = Convert.ToInt32(idCategoryUp);
                    book.PUBLISH_YEAR = publishYearUp;
                }
                cmd.SaveChanges();
            }
        }

        public List<BookDelete> deleteList(string title, string author, int publishYear)
        {
            using (QLTV cmd = new QLTV())
            {
                List<BookDelete> list = cmd.BOOKs.Where(p => p.TITLE == title && p.AUTHOR == author && p.PUBLISH_YEAR == publishYear).Select(p => new BookDelete
                {
                    id = p.ID,
                    borrowable = p.STATUS
                }).ToList();
                return list;
            }
        }
        public List<BookList> LoadRecord(int page, int recordnum)
        {
            using (QLTV cmd = new QLTV())
            {
                List<BookList> result = new List<BookList>();

                int skipCount = (page - 1) * recordnum;
                int takeCount = recordnum;

                List<string> previousTitles = cmd.BOOKs
                    .OrderBy(b => b.ID)
                    .Take(skipCount)
                    .Select(b => b.TITLE)
                    .ToList();

                result = cmd.BOOKs
                    .OrderBy(b => b.ID)
                    .Skip(skipCount)
                    .Take(takeCount)
                    .GroupBy(b => b.TITLE)
                    .SelectMany(g => g.Take(1))
                    .Where(b => !previousTitles.Contains(b.TITLE))
                    .Select(b => new BookList
                    {
                        Title = b.TITLE,
                        Author = b.AUTHOR,
                        Category = b.CATEGORY.NAME,
                        Location = b.CATEGORY.LOCATION,
                        Year = b.PUBLISH_YEAR
                    })
                    .ToList();

                List<string> distinctTitles = result.Select(b => b.Title).ToList();

                foreach (BookList book in result)
                {
                    if (distinctTitles.Contains(book.Title))
                    {
                        book.Quantity = getQuantityByTitle(book.Title, book.Author, book.Year);
                        book.Borrowable = getBorrowableNumberByTitle(book.Title, book.Author, book.Year);
                        distinctTitles.Remove(book.Title);
                    }
                }

                return result;
            }
        }



        public int count(int numberrecord)
        {
            int totalrecord = 0;
            using (QLTV cmd = new QLTV())
            {
                totalrecord = cmd.BOOKs.Count();

            }
            return totalrecord /= numberrecord;
        }

        public int getQuantityByTitle(string title, string author, int publishYear)
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.BOOKs.Where(p => p.TITLE == title && p.AUTHOR == author && p.PUBLISH_YEAR == publishYear).Count();
            }
        }

        public int getBorrowableNumberByTitle(string title, string author, int publishYear)
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.BOOKs.Where(p => p.TITLE == title && p.AUTHOR == author && p.PUBLISH_YEAR == publishYear && p.STATUS == true).Count();
            }
        }

        public List<BookList> SearchBookbyTitle(string Title)
        {
            using (QLTV cmd = new QLTV())
            {
                List < BookList > query = cmd.BOOKs.OrderBy(p => p.TITLE).Where(p => p.TITLE.Contains(Title)).Select(s => new BookList
                {
                    Title = s.TITLE,
                    Author = s.AUTHOR,
                    Category = s.CATEGORY.NAME,
                    Location = s.CATEGORY.LOCATION,
                    Year = s.PUBLISH_YEAR
                }).Distinct().ToList();
                foreach (BookList i in query)
                {
                    i.Quantity = getQuantityByTitle(i.Title, i.Author, i.Year);
                    i.Borrowable = getBorrowableNumberByTitle(i.Title, i.Author, i.Year);
                }
                return query;
            }
        }
        public List<BookList> SearchBookbyAuthor(string Author)
        {
            using (QLTV cmd = new QLTV())
            {
                List < BookList > query = cmd.BOOKs.OrderBy(p => p.TITLE).Where(p => p.AUTHOR.Contains(Author)).Select(s => new BookList
                {
                    Title = s.TITLE,
                    Author = s.AUTHOR,
                    Category = s.CATEGORY.NAME,
                    Location = s.CATEGORY.LOCATION,
                    Year = s.PUBLISH_YEAR
                }).Distinct().ToList();
                foreach (BookList i in query)
                {
                    i.Quantity = getQuantityByTitle(i.Title, i.Author, i.Year);
                    i.Borrowable = getBorrowableNumberByTitle(i.Title, i.Author, i.Year);
                }
                return query;
            }
        }
        public List<BookList> SearchBookbyCategory(string Category)
        {
            using (QLTV cmd = new QLTV())
            {
                List<BookList> query = cmd.BOOKs.OrderBy(p => p.TITLE).Where(p => p.CATEGORY.NAME.Contains(Category)).Select(s => new BookList
                {
                    Title = s.TITLE,
                    Author = s.AUTHOR,
                    Category = s.CATEGORY.NAME,
                    Location = s.CATEGORY.LOCATION,
                    Year = s.PUBLISH_YEAR
                }).Distinct().ToList();
                foreach (BookList i in query)
                {
                    i.Quantity = getQuantityByTitle(i.Title, i.Author, i.Year);
                    i.Borrowable = getBorrowableNumberByTitle(i.Title, i.Author, i.Year);
                }
                return query;
            }
        }
        public List<BookList> SearchBookbyPublishYear(int Publish_year)
        {
            using (QLTV cmd = new QLTV())
            {
                List<BookList> query = cmd.BOOKs.OrderBy(p => p.TITLE).Where(p => p.PUBLISH_YEAR.ToString().StartsWith(Publish_year.ToString())).Select(s => new BookList
                {
                    Title = s.TITLE,
                    Author = s.AUTHOR,
                    Category = s.CATEGORY.NAME,
                    Location = s.CATEGORY.LOCATION,
                    Year = s.PUBLISH_YEAR
                }).Distinct().ToList();
                foreach (BookList i in query)
                {
                    i.Quantity = getQuantityByTitle(i.Title, i.Author, i.Year);
                    i.Borrowable = getBorrowableNumberByTitle(i.Title, i.Author, i.Year);
                }
                return query;
            }
        }
        public void AddCategory(CATEGORY category)
        {
            using (QLTV cmd = new QLTV())
            {
                cmd.CATEGORies.Add(category);
                cmd.SaveChanges();
            }
        }

        public int createNewIdCategory()
        {
            using (QLTV cmd = new QLTV())
            {
                var id = cmd.CATEGORies.Select(p => p.ID).Max();
                    return Convert.ToInt32(id) + 1;
            }
        }
    }
}

