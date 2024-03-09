using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_3.DAL
{
    internal class VerifyEmailForm_DAL
    {
        public bool isCorrectUsername(string username)
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

        public bool isCorrectEmail(string username, string email)
        {
            using (QLTV cmd = new QLTV())
            {
                var account = cmd.ACCOUNTs.Where(p => p.USERNAME.Equals(username)).FirstOrDefault();
                if (account == null || !account.STAFF.EMAIL.Equals(email))
                {
                    return false;
                }
                return true;
            }
        }

        public bool isCorrectCode(string code)
        {
            using (QLTV cmd = new QLTV())
            {
                return true;
            }
        }

        public string getNameByUserName(string userName) 
        {
            using (QLTV cmd = new QLTV())
            {
                return cmd.ACCOUNTs.Where(p => p.USERNAME.Equals(userName)).Select(p => p.STAFF.NAME).FirstOrDefault();
            }
        }
    }
}
