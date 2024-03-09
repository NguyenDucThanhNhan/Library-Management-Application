using PBL_3.DTO;
using PBL_3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static PBL_3.BLL.AccountManagermentForm_BLL;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace PBL_3.BLL
{
    public class AccountManagermentForm_BLL
    {
        public List<AccountList> getList()
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.getList();
        }

        public List<AccountList> SearchAccountById(int id)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.SearchAccountByID(id);
        }
        public List<AccountList> SearchBAccountByName(string Name)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.SearchAccountbyName(Name);
        }
        public List<AccountList> SearchBAccountByPhoneNumber(string phone_number)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.SearchAccountByPhone(phone_number);
        }
        public List<AccountList> SearchBAccountByEmail(string Email)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.SearchBookbyEmail(Email);
        }
        public List<AccountList> SearchBAccountByUser(string User)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.SearchBookbyUser(User);
        }
        public void AddInfor(string name, string phonenumber, string email, string username)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            int id = dal.createNewIdStaff();
            ACCOUNT account = new ACCOUNT()
            {
                ID = id,
                USERNAME = username,
                PASSWORD = HashPassword("00000000")
            };
            STAFF staff = new STAFF()
            {
                ID = id,
                NAME = name,
                ROLE = "Thủ thư",
                PHONENUMBER = phonenumber,
                EMAIL = email
            };
            dal.AddStaff(staff);
            dal.AddAccount(account);
            
        }

        public void deleteAccount(string id)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            dal.deleteAccount(Convert.ToInt32(id));
            dal.deleteStaff(Convert.ToInt32(id));

        }

        public void UpdateAccount(string id, string name, string phonenumber, string email, string username, string password)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            dal.UpdateStaff(Convert.ToInt32(id), name, phonenumber, email);
            dal.UpdateAccount(Convert.ToInt32(id), username, HashPassword(password));
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        public bool isValidPhone(string phoneNumber)
        {
            Regex phonePattern = new Regex(@"^\+?[0-9]{9,15}$");
            return phonePattern.IsMatch(phoneNumber);
        }

        public bool isValidUsername(string username)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.isValidUsername(username);
        }

        public bool isInexistEmail(string email)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.isValidEmail(email);
        }

        public bool isInexistPhonenumber(string phonenumber)
        {
            AccountManagementForm_DAL dal = new AccountManagementForm_DAL();
            return dal.isValidPhonenumber(phonenumber);
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}

