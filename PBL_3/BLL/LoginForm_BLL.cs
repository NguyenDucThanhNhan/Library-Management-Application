using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PBL_3.DAL;

namespace PBL_3.BLL
{
    internal class LoginForm_BLL
    {
        public bool isCorrectUser(string username)
        {
            LoginForm_DAL dal = new LoginForm_DAL();
            return dal.isCorrectUser(username);
        }

        public bool isCorrectPassword(string username, string password)
        {
            string passwordHashed = HashPassword(password);
            LoginForm_DAL dal = new LoginForm_DAL();
            return dal.isCorrectPassword(username, passwordHashed);
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
