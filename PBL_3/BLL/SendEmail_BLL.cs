using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PBL_3.DAL;
using System.Windows.Forms;

namespace PBL_3.BLL
{
    internal class SendEmail_BLL
    {
        public string SendCode(string toEmail, string code, string name)
        {
            // Lấy giá trị cấu hình từ file config
            string fromEmail = ConfigurationManager.AppSettings["EmailFrom"];
            string fromPassword = ConfigurationManager.AppSettings["EmailPassword"];

            // Khởi tạo SMTP client và thiết lập thông tin
            using (SmtpClient client = new SmtpClient())
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(fromEmail, fromPassword);
                client.EnableSsl = true;

                // Thiết lập nội dung email
                string subject = "[MESSAGE] VERIFY CODE";
                string body = "Dear "+ name + ",\r\n\r\nI hope this email finds you well. We have received a request to reset your information for your account with us. To complete this process, please use the following code:\r\n\r\n" + code + "\r\n\r\nIf you did not request to reset your information, please ignore this email and do not share the code with anyone.\r\n\r\nIf you have any questions or concerns, please do not hesitate to contact us at this email.\r\n\r\nBest regards,\r\nUniversity Library";
                MailMessage message = new MailMessage(fromEmail, toEmail, subject, body);
       
                // Gửi email
                client.Send(message);

                return code;
            }
        }
        
        public void sendMultiEmail()
        {
            Statistic_DAL dal = new Statistic_DAL();
            List<int> idStudent = dal.getStudentIdList();

            foreach (int i in idStudent)
            {
                string email = dal.getEmailByStudentId(i);
                string information = dal.getOverdueInformation(i);
                string name = dal.getNamelByStudentId(i);
                sendReminder(email, information, name);
            }
        }

        public void sendReminder(string toReminder, string information, string name)
        {
            string fromEmail = ConfigurationManager.AppSettings["EmailFrom"];
            string fromPassword = ConfigurationManager.AppSettings["EmailPassword"];

            using (SmtpClient client = new SmtpClient())
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(fromEmail, fromPassword);
                client.EnableSsl = true;

                string subject = "[REMINDER] RETURN BOOKS";
                string body = "Dear " + name + ",\r\n\r\nThis is a crucial reminder that you borrowed some books from our library and it is now overdue: " + information + "\r\n\r\nPlease note that failing to return the book on time may result in your borrowing privileges being suspended. We want to avoid any inconvenience or disruption to your academic pursuits, so we urge you to return the book as soon as possible.\r\n\r\nIf you have any questions or concerns about returning the book, please don't hesitate to contact us.\r\n\r\nThank you for your attention to this matter, and we look forward to seeing you at the library soon.\r\n\r\nBest regards,\r\n\r\nUniversity Library\r\n";
                MailMessage message = new MailMessage(fromEmail, toReminder, subject, body);

                client.Send(message);
            }
        }
    }
}
