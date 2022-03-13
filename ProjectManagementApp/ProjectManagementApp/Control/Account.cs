using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Model;
namespace ProjectManagement.Controller
{
    class Account
    {
        public String Username;
        public String Password;
        //method
        public Account()
        {

        }
        public Account(String username, String password)
        {
            this.Username = username;
            this.Password = password;
        }
        public Student StudentLogin()
        {
            using (var context = new DatabaseContext())
            { 
                var student = context.Students.Where(s => s.Username == this.Username & s.Password == this.Password);
                return (Student)student;
            }
        }
        public Teacher TeacherLogin()
        {
            using (var context = new DatabaseContext())
            {
                var teacher = context.Teachers.Where(s => s.Username == this.Username & s.Password == this.Password);
                return (Teacher)teacher;
            }
        }
        
    }
}
