using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_3.DAL;

namespace PBL_3.BLL
{
    internal class Main_BLL
    {
        public bool isManagerAcc(string username)
        {
            Main_DAL dal = new Main_DAL();
            return dal.isManagerAcc(username);
        }
    }
}
