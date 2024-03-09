using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_3.DAL;

namespace PBL_3.DAL
{
    internal class Main_DAL
    {
        public bool isManagerAcc(string username)
        {
            using(QLTV cmd = new QLTV()) 
            {
                var role = cmd.ACCOUNTs.Where(p => p.USERNAME.Equals(username)).Select(p => p.STAFF.ROLE).FirstOrDefault();
                if (role.Equals("Quản lý"))
                    return true;
                else
                    return false;
            }
        }
    }
}
