using PBL_3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.Native.WinApi;
using System.Xml.Linq;
using PBL_3.DTO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PBL_3.BLL
{
    public class StudentManagement_BLL
    {
        public List<StudentLoad> loadrecord(int page,int numberrecord)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            return dal.GetRecordsByPage(page, numberrecord);
        }
        public bool checkmssv(int id)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            return dal.checkmssv(id);
        }
        public List<StudentLoad> SearchStudentById(int id)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            return dal.SearchStudentByID(id);
        }
        public List<StudentLoad> SearchStudentByName(string Name)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            return dal.SearchStudentByName(Name);
        }
        public int count(int numberrecord)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
          return   dal.count(numberrecord);

        }
        public List<StudentLoad> SearchStudentByClass(string Class)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            return dal.SearchStudentByClass(Class);
        }
        public List<StudentLoad> SearchStudentByPhoneNUmber(string Phone_number)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            return dal.SearchStudentByPhoneNumber(Phone_number);
        }
        public List<StudentLoad> SearchStudentByEmail(string Email)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            return dal.SearchStudentByEmail(Email);
        }
        public void AddStudent(int id,string name, string studentClass, string phonenumber, string email)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            STUDENT student = new STUDENT()
            {
                ID = id,
                NAME = name,
                CLASS = studentClass,
                NUMBER_PHONE = phonenumber,
                EMAIL = email
            };
             dal.AddStudent(student);
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
        public void deleteStudent(string id)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            BorrowAndReturnForm_DAL borrowdal = new BorrowAndReturnForm_DAL();
            borrowdal.deleteRecordHavingIdStudent(Convert.ToInt32(id));
            dal.deleteStudent(Convert.ToInt32(id));
        }

        public void UpdateStudent(int id, string name, string studentClass, string phonenumber, string email)
        {
            StudentManagement_DAL dal = new StudentManagement_DAL();
            dal.UpdateStudent(id, name, studentClass, phonenumber, email) ;
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
    }
}
