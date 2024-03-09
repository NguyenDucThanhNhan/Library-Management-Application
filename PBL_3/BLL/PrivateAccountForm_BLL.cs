using PBL_3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PBL_3.BLL
{
    internal class PrivateAccountForm_BLL
    {
        String code;
        public PrivateAccountForm_BLL()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1000, 10000);
            code = randomNumber.ToString();
        }

        public int getId(string username)
        {
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            return dal.getId(username);
        }

        public string getName(string username)
        {
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            return dal.getName(username);
        }

        public string getPhone(string username)
        {
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            return dal.getPhone(username);
        }

        public string getEmail(string username)
        {
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            return dal.getEmail(username);
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
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            return dal.isValidUsername(username);
        }

        public bool isInexistEmail(string email)
        {
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            return dal.isValidEmail(email);
        }

        public bool isInexistPhonenumber(string phonenumber)
        {
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            return dal.isValidPhonenumber(phonenumber);
        }

        public bool isValidPassword(string password)
        {
            if (password.Length < 8 && password.Length > 0) return false;
            return true;
        }

        public void upDateData(string id, string name, string phone, string email, string username, string password)
        {
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            dal.upDateData(Convert.ToInt32(id), name, phone, email, username, HashPassword(password));
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

        public string SendEmail(string toEmail, string username)
        {
            PrivateAccountForm_DAL dal = new PrivateAccountForm_DAL();
            SendEmail_BLL bll = new SendEmail_BLL();
            return bll.SendCode(toEmail, code, dal.getNameByUserName(username));
        }

        public bool isCorrectCode(string codeTxt, string code)
        {
            if(code == null) return false;
            else
            {
                if (code.Equals(codeTxt))
                    return true;
                return false;
            }
        }
    }
}
