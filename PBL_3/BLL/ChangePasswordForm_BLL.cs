using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PBL_3.DAL;

namespace PBL_3.BLL
{
    internal class ChangePasswordForm_BLL
    {
        public bool isValidPassword(string password)
        {
            if(password.Length < 8)
            {
                return false;
            }
            return true;
        }

        public void updatePassword(string username, string password)
        {
            string passwordHashed = HashPassword(password);
            ChangePasswordForm_DAL dal = new ChangePasswordForm_DAL();
            dal.updatePassword(username, passwordHashed);
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
