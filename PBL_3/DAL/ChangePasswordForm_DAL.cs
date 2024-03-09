using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_3.DAL
{
    internal class ChangePasswordForm_DAL
    {
        public void updatePassword(string username, string password)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.ACCOUNTs.Where(p => p.USERNAME.Equals(username)).FirstOrDefault();
                acc.PASSWORD = password;
                cmd.SaveChanges();
            }
        }
    }
}
