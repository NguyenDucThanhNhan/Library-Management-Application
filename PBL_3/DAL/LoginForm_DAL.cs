using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_3.DAL
{
    internal class LoginForm_DAL
    {
        public bool isCorrectUser(string username)
        {
            using (QLTV cmd = new QLTV())
            {
                var usernameDb = cmd.ACCOUNTs.Where(p => p.USERNAME.Equals(username)).FirstOrDefault();
                if (usernameDb == null)
                {
                    return false;
                }
                return true;
            }
        }

        public bool isCorrectPassword(string username, string password)
        {
            using (QLTV cmd = new QLTV())
            {
                var account = cmd.ACCOUNTs.Where(p => p.USERNAME.Equals(username)).FirstOrDefault();
                if (account == null || account.PASSWORD.Equals(password) == false)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
