using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_3.DTO
{
    public class BorrowListInfor
    {
        public int id { get; set; }
        public string title { get; set; }
        public string studentName { get; set; }
        public DateTime lendDay { get; set; }
        public DateTime returnDay { get; set; }
        public bool overdue { get; set; }

        public bool returned { get; set; }
    }

}
