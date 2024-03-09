using PBL_3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_3.DAL
{
    public class StudentManagement_DAL
    {

        public List<StudentLoad> GetRecordsByPage(int pageNumber, int pageSize)
        {
            using (QLTV cmd = new QLTV())
            {
                int skipCount = (pageNumber - 1) * pageSize;

                List<StudentLoad> result = cmd.STUDENTs
                    .OrderBy(b => b.ID)
                    .Skip(skipCount)
                    .Take(pageSize)
                    .Select(b => new StudentLoad
                    {
                        mssv = b.ID,
                        name = b.NAME,
                        studentClass = b.CLASS,
                        numberphone = b.NUMBER_PHONE,
                        email = b.EMAIL
                    })
                    .ToList();

                return result;
            }
        }

        public List<StudentLoad> SearchStudentByID(int ID)
        {
            using (QLTV cmd = new QLTV())
            {
                List<StudentLoad> list = cmd.STUDENTs.OrderByDescending(p => p.ID).Where(p => p.ID.ToString().StartsWith(ID.ToString())).Select(p => new StudentLoad
                {
                    mssv = p.ID,
                    name = p.NAME,
                    studentClass = p.CLASS,
                    numberphone = p.NUMBER_PHONE,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }

        public List<StudentLoad> SearchStudentByName(string Name)
        {
            using (QLTV cmd = new QLTV())
            {
                List<StudentLoad> list = cmd.STUDENTs.OrderByDescending(p => p.ID).Where(p => p.NAME.Contains(Name)).Select(p => new StudentLoad
                {
                    mssv   = p.ID,
                    name = p.NAME,
                    studentClass = p.CLASS,
                    numberphone = p.NUMBER_PHONE,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }
        public List<StudentLoad> SearchStudentByClass(string Class)
        {
            using (QLTV cmd = new QLTV())
            {
                List<StudentLoad> list = cmd.STUDENTs.OrderByDescending(p => p.ID).Where(p => p.CLASS.StartsWith(Class)).Select(p => new StudentLoad
                {
                    mssv = p.ID,
                    name = p.NAME,
                    studentClass = p.CLASS,
                    numberphone = p.NUMBER_PHONE,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }
        public List<StudentLoad> SearchStudentByPhoneNumber(string Phone_number)
        {
            using (QLTV cmd = new QLTV())
            {
                List<StudentLoad> list = cmd.STUDENTs.OrderByDescending(p => p.ID).Where(p => p.NUMBER_PHONE.StartsWith(Phone_number)).Select(p => new StudentLoad
                {
                    mssv = p.ID,
                    name = p.NAME,
                    studentClass = p.CLASS,
                    numberphone = p.NUMBER_PHONE,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }
        public List<StudentLoad> SearchStudentByEmail(string Email)
        {
            using (QLTV cmd = new QLTV())
            {
                List<StudentLoad> list = cmd.STUDENTs.OrderByDescending(p => p.ID).Where(p => p.EMAIL.ToString().StartsWith(Email.ToString())).Select(p => new StudentLoad
                {
                    mssv = p.ID,
                    name = p.NAME,
                    studentClass = p.CLASS,
                    numberphone = p.NUMBER_PHONE,
                    email = p.EMAIL
                }).ToList();
                return list;
            }
        }

   

        public void AddStudent(STUDENT student)
        {
            using (QLTV cmd = new QLTV())
            {
                cmd.STUDENTs.Add(student);
                cmd.SaveChanges();
            }
        }
        public bool checkmssv(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.STUDENTs.Where(p => p.ID == id).FirstOrDefault();
                if (acc != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public int count(int numberrecord)
        {
            int totalrecord = 0;
            using(QLTV cmd = new QLTV())
            {
                totalrecord = cmd.STUDENTs.Count();
               
            }
            return totalrecord /= numberrecord;
        }
        public void deleteStudent(int id)
        {
            using (QLTV cmd = new QLTV())
            {
                var student = cmd.STUDENTs.Where(p => p.ID == id).FirstOrDefault();
                cmd.STUDENTs.Remove(student);
                cmd.SaveChanges();
            }
        }

        public void UpdateStudent(int id, string name, string studentClass, string phonenumber, string email)
        {
            using (var cmd = new QLTV())
            {
                var student = cmd.STUDENTs.Where(p => p.ID == id).FirstOrDefault();
                student.NAME = name;
                student.CLASS = studentClass;
                student.NUMBER_PHONE = phonenumber;
                student.EMAIL = email; 
                cmd.SaveChanges();
            }
        }

        public bool isValidEmail(string email)
        {
            using (QLTV cmd = new QLTV())
            {
                var acc = cmd.STUDENTs.Where(p => p.EMAIL == email).FirstOrDefault();
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
                var acc = cmd.STUDENTs.Where(p => p.NUMBER_PHONE == phonenumber).FirstOrDefault();
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
    }
}
