using Quiz.Model;
using Quiz.ModelView.GradeList;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Quiz.Pages
{
    /// <summary>
    /// Interaction logic for Classes.xaml
    /// </summary>
    public partial class Classes : Window
    {
        ObservableCollection<Grades> grades = new ObservableCollection<Grades>();
            List<Subjects> subjects = new List<Subjects>();

        public delegate void DelSelectTab(object sender, RoutedEventArgs e);
        private DelSelectTab _SelectTab;
        public DelSelectTab SelectTab {
            get { return _SelectTab; }
            set { _SelectTab = value;}
        }

        public string ClassId { get; set; }
        public string subjectId { get; set; }
        public void RefreshControlEvent()
        {
           this.btnOk.Click += a;
        }
    
        private void a(object sender, RoutedEventArgs e)
        {
            if (e != null) {
                ClassId = cbograde.SelectedValue.ToString();
                subjectId = cboSubject.SelectedValue.ToString();
                this._SelectTab(sender,e); }
        }

    

        public Classes()
        {

            DataContext = this;
            InitializeComponent();
            //subjects = new List<Subjects>();
            //grades = new ObservableCollection<Grades>();
            //subjects.Add(new Subjects { Id = "1", subject = "Maths" });
            //subjects.Add(new Subjects { Id = 2.ToString(), subject = "Science" });
            //subjects.Add(new Subjects { Id = 3.ToString(), subject = "Social" });
            //grades.Add(new Grades { Id = 1.ToString(), grade = "Grade One", subjects = subjects });
            //grades.Add(new Grades { Id = 2.ToString(), grade = "Grade Two", subjects = subjects });
            //grades.Add(new Grades { Id = 3.ToString(), grade = "Grade Three", subjects = subjects });
            //grades.Add(new Grades { Id = 4.ToString() ,grade = "Grade Four", subjects = subjects });
            //grades.Add(new Grades { Id = 5.ToString(), grade = "Grade Five", subjects = subjects });
            //grades.Add(new Grades { Id = 6.ToString(), grade = "Grade six", subjects = subjects });

            //subjects = new List<Subjects>();
            //subjects.Add(new Subjects { Id = "1", subject = "Maths" });
            //subjects.Add(new Subjects { Id = 2.ToString(), subject = "Science" });
            //subjects.Add(new Subjects { Id = 3.ToString(), subject = "Social" });
            //subjects.Add(new Subjects { Id = 3.ToString(), subject = "HPE" });

            //grades.Add(new Grades { Id = 7.ToString(), grade = "Grade Seve", subjects = subjects });
            //grades.Add(new Grades { Id = 8.ToString(), grade = "Grade Eight", subjects = subjects });
            //grades.Add(new Grades { Id = 9.ToString(), grade = "Grade Nine", subjects = subjects });
            //grades.Add(new Grades { Id = 10.ToString(), grade = "Grade Ten", subjects = subjects });

            grades = new ObservableCollection<Grades>(Grade.GetGrade());
            cbograde.ItemsSource = grades;
            cbograde.SelectedValuePath = "Id";
            cbograde.DisplayMemberPath = "grade";
            cbograde.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbograde_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            var a = cbograde.SelectedValue.ToString();

            cboSubject.ItemsSource = grades.Where(x => x.Id == a).SelectMany(x => x.subjects).ToList() ;
            ClassId = cbograde.SelectedValue.ToString();
            cboSubject.SelectedValuePath = "Id";
            cboSubject.DisplayMemberPath = "subject";
            cboSubject.SelectedIndex = 0;
       
            //cbograde.SelectedValue = grades.Select(x => x.Id);
        }

        private void cboSubject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                subjectId = cboSubject.SelectedValue.ToString();
            }
            catch
            {

            }
           
        }
    }

   
}
