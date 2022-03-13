using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectManagementApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherForm : ContentView
    {
        public TeacherForm()
        {
            InitializeComponent();
            //Teacher teacher = new Teacher();
            TeacherName.Content = teacher.Name;
            void ShowListProject(int type)
            {

                var epdProject = new Expander { Header = "Project " + type.ToString() };
                var container = new StackLayout { };
                foreach (var p in teacher.Projects)
                {
                    if (p.Type == type)
                    {
                        var tbProjectName = new Label { Text = p.Name };
                        tbProjectName.MouseDown += new MouseButtonEventHandler(TbClick);
                        container.Children.Add(tbProjectName);
                        void TbClick(object sender, RoutedEventArgs e)
                        {
                            ShowListStudent(p);
                        }
                    }

                }
                ListProject.Children.Add(epdProject);
                epdProject.Content = container;
            }

            ShowListProject(1);
            ShowListProject(2);
            ShowListProject(3);
            void ShowListStudent(Project p)
            {
                //var container = new StackPanel { };
                ListStudent.Children.Clear();
                foreach (var student in p.StudentApply)
                {
                    var tbStudent = new Label
                    {
                        Text = student.Name,
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };
                    var cbStudent = new CheckBox
                    {
                        HorizontalOptions = LayoutOptions.End,
                        VerticalOptions = LayoutOptions.Start
                    };
                    var view = new Grid { };
                    view.Children.Add(tbStudent);
                    view.Children.Add(cbStudent);
                    ListStudent.Children.Add(view);
                }

            }
        }
    }
}