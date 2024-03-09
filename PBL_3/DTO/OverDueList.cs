using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_3.DTO
{
    public class OverDueList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Book { get; set; }
        public DateTime BorrowDate { get; set; }
        public int Day { get; set; }
    }
}
