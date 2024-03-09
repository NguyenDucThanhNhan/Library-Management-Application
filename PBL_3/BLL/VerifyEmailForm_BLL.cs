using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebGrease.Configuration;
using PBL_3.DAL;

namespace PBL_3.BLL
{
    internal class VerifyEmailForm_BLL
    {
        String code;
        public VerifyEmailForm_BLL()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1000, 10000);
            code = randomNumber.ToString();
        }
        public bool isCorrectUsername(string username)
        {
            VerifyEmailForm_DAL dal = new VerifyEmailForm_DAL();
            return dal.isCorrectUsername(username);
        }

        public bool isCorrectEmail(string username, string email)
        {
            VerifyEmailForm_DAL dal = new VerifyEmailForm_DAL();
            return dal.isCorrectEmail(username, email);
        }
  
        public string SendEmail(string toEmail, string username)
        {
            VerifyEmailForm_DAL dal = new VerifyEmailForm_DAL();
            SendEmail_BLL bll = new SendEmail_BLL();
            return bll.SendCode(toEmail, code, dal.getNameByUserName(username));
        }

        public bool isCorrectCode(string codeTxt, string code)
        {
            if (code.Equals(codeTxt))
                return true;
            return false;
        }
    }
}
