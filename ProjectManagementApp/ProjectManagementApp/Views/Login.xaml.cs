using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementApp.Views;
using ProjectManagementApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectManagementApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentView
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            MD5 md5 = new MD5();
            Account account = new Account(tbUserName.Text, md5.HashMd5(tbPassWord.Text));
            if (cbIsStudent.IsChecked == true)
            {
                Student student = account.StudentLogin();
                //StudentForm(student);
                if (student != null)
                {
                    var Form1 = new StudentForm(student);
                    Form1.Show();
                }
                else
                    MessageBox.Show("Sai tai khoan hoac mat khau");

            }
            if (cbIsTeacher.IsChecked == true)
            {
                Teacher teacher = account.TeacherLogin();
                if (teacher != null)
                {
                    var Form1 = new TeacherForm(teacher);
                    Form1.Show();
                }
                else
                    MessageBox.Show("Sai tai khoan hoac mat khau");
            }
        }
    }
}