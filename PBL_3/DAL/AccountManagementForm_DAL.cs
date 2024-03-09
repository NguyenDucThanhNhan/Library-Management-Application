using PBL_3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_3.DAL
{
    internal class AccountManagementForm_DAL
    {
        public List<AccountList> getList()
        {
            using (QLTV cmd = new QLTV())
            {
                var list = cmd.STAFFs.OrderByDescending(p => p.ID).Select(p => new AccountList
                {
                    id = p.ID,
                    name = p.NAME,
                    username = p.ACCOUNT.USERNAME,
                    role = p.ROLE,
                    phonenumber = p.PHONENUMBER,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }
        public List<AccountList> SearchAccountByID(int ID)
        {
            using (QLTV cmd = new QLTV())
            {
                var list = cmd.STAFFs.OrderByDescending(p => p.ID).Where(p => p.ID.ToString().StartsWith(ID.ToString())).Select(p => new AccountList
                {
                    id = p.ID,
                    name = p.NAME,
                    username = p.ACCOUNT.USERNAME,
                    role = p.ROLE,
                    phonenumber = p.PHONENUMBER,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }

        public List<AccountList> SearchAccountbyName(string Name)
        {
            using (QLTV cmd = new QLTV())
            {
                var list = cmd.STAFFs.OrderByDescending(p => p.ID).Where(p => p.NAME.Contains(Name)).Select(p => new AccountList
                {
                    id = p.ID,
                    name = p.NAME,
                    username = p.ACCOUNT.USERNAME,
                    role = p.ROLE,
                    phonenumber = p.PHONENUMBER,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }
        public List<AccountList> SearchAccountByPhone(string phone_number)
        {
            using (QLTV cmd = new QLTV())
            {
                var list = cmd.STAFFs.OrderByDescending(p => p.ID).Where(p => p.PHONENUMBER.StartsWith(phone_number)).Select(p => new AccountList
                {
                    id = p.ID,
                    name = p.NAME,
                    username = p.ACCOUNT.USERNAME,
                    role = p.ROLE,
                    phonenumber = p.PHONENUMBER,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }
        public List<AccountList> SearchBookbyEmail(string Email)
        {
            using (QLTV cmd = new QLTV())
            {
                var list = cmd.STAFFs.OrderByDescending(p => p.ID).Where(p => p.EMAIL.StartsWith(Email)).Select(p => new AccountList
                {
                    id = p.ID,
                    name = p.NAME,
                    username = p.ACCOUNT.USERNAME,
                    role = p.ROLE,
                    phonenumber = p.PHONENUMBER,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }

        public bool isValidUsername(string username)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.ACCOUNTs.Where(p => p.USERNAME == username).FirstOrDefault();
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
        public List<AccountList> SearchBookbyUser(string user)
        {
            using (QLTV cmd = new QLTV())
            {
                var list = cmd.STAFFs.OrderByDescending(p => p.ID).Where(p => p.ACCOUNT.USERNAME.ToString().StartsWith(user.ToString())).Select(p => new AccountList
                {
                    id = p.ID,
                    name = p.NAME,
                    username = p.ACCOUNT.USERNAME,
                    role = p.ROLE,
                    phonenumber = p.PHONENUMBER,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }
        public int createNewIdStaff()
        {
            using (QLTV cmd = new QLTV())
            {
                var id = cmd.STAFFs.Select(p => p.ID).DefaultIfEmpty().Max();
                if (id == 0)
                {
                    return 1;
                }
                else
                {
                    return Convert.ToInt32(id) + 1;
                }
            }
        }
        public void AddAccount(ACCOUNT account)
        {
            using (QLTV cmd = new QLTV())
            {
                cmd.ACCOUNTs.Add(account);
                cmd.SaveChanges();
            }
        }

        public void AddStaff(STAFF staff)
        {
            using (QLTV cmd = new QLTV())
            {
                cmd.STAFFs.Add(staff);
                cmd.SaveChanges();
            }
        }

        public void deleteStaff(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var staff = cmd.STAFFs.Where(p => p.ID == id).FirstOrDefault();
                cmd.STAFFs.Remove(staff);
                cmd.SaveChanges();
            }
        }

        public void deleteAccount(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var account = cmd.ACCOUNTs.Where(p => p.ID == id).FirstOrDefault();
                cmd.ACCOUNTs.Remove(account);
                cmd.SaveChanges();
            }
        }

        public void UpdateStaff(int id, string name, string phonenumber, string email)
        {
            using (var cmd = new QLTV())
            {
                var staff = cmd.STAFFs.Where(p => p.ID == id).FirstOrDefault();
                staff.NAME = name;
                staff.PHONENUMBER = phonenumber;
                staff.EMAIL = email;
                cmd.SaveChanges();
            }
        }
        public void UpdateAccount(int id, string username, string password)
        {
            using (var cmd = new QLTV())
            {
                var account = cmd.ACCOUNTs.Where(p => p.ID == id).FirstOrDefault();
                account.USERNAME = username;
                if(password.Length != 0)
                {
                    account.PASSWORD = password;
                }
                cmd.SaveChanges();
            }
        }
    }
}
