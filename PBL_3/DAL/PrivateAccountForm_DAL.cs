using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBL_3.DAL
{
    internal class PrivateAccountForm_DAL
    {
        public int getId(string username)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.ACCOUNTs.Where(p => p.USERNAME == username).FirstOrDefault();
                // trả về id, nếu không có id thì trả về null
                return acc.ID;
            }
        }

        public string getName(string username)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.ACCOUNTs.Where(p => p.USERNAME == username).FirstOrDefault();
                // trả về name, nếu không có id thì trả về null
                return acc?.STAFF.NAME;
            }
        }

        public string getPhone(string username)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.ACCOUNTs.Where(p => p.USERNAME == username).FirstOrDefault();
                // trả về phone number, nếu không có id thì trả về null
                return acc?.STAFF.PHONENUMBER;
            }
        }

        public string getEmail(string username)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.ACCOUNTs.Where(p => p.USERNAME == username).FirstOrDefault();
                // trả về email, nếu không có id thì trả về null
                return acc?.STAFF.EMAIL;
            }
        }

        public bool isValidUsername(string username)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.ACCOUNTs.Where(p => p.USERNAME == username).FirstOrDefault();
                if(acc == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool isValidEmail(string email)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.STAFFs.Where(p => p.EMAIL == email).FirstOrDefault();
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

        public bool isValidPhonenumber(string phonenumber)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.STAFFs.Where(p => p.PHONENUMBER == phonenumber).FirstOrDefault();
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

        public void upDateData(int id, string name, string phone, string email, string username, string password)
        {
            using (QLTV cmd = new QLTV())
            {
                var dataUpdate = cmd.ACCOUNTs.Where(p => p.ID == id).FirstOrDefault();
                dataUpdate.STAFF.PHONENUMBER= phone;
                dataUpdate.STAFF.EMAIL= email;
                dataUpdate.USERNAME = username;
                if (password.Length != 0)
                {
                    dataUpdate.PASSWORD = password;
                }
                cmd.SaveChanges();
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
