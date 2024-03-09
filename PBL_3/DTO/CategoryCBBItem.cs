using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_3.DTO
{
    public class CategoryCBBItem
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
