using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_3.DTO
{
    public class BookList
    {
        
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
        public int Borrowable { get; set; }
    }
}