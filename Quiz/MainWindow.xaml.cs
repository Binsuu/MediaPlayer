using Microsoft.VisualBasic.Devices;
using Quiz.Model;
using Quiz.ModelView.GradeFive;
using Quiz.ModelView.GradeList;
using Quiz.Pages;
using Quiz.Resource;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Quiz
{

  
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
            {

        DoubleAnimation anim1 = new DoubleAnimation();
        DoubleAnimation anim2 = new DoubleAnimation();
        DoubleAnimation anim3 = new DoubleAnimation();
    

        public int gridHeight { get; set; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
             private  bool _output;
        public bool Output
        {
            get { return _output; }
            set
            {
                _output = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Output"));
            }
        }
        //  public List<Units> Items { get; set; } = new List<Units>();

        public ObservableCollection<Units> Items { get; private set; }
        public ObservableCollection<Topics> ani { get; private set; }
        public string    Subject { get; private set; }
        private string gradecode;
        private string Subjectcode;
        Classes classes = new Classes();
        public MainWindow()
        {
            Output = false;
            DataContext = this;
            ani = new ObservableCollection<Topics>();
            ani.Add(new Topics { Id = "1", Name = "BInod" });
            gridHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height-250;
            Items = new ObservableCollection<Units>();
            var a = Grade.GetGrade().Where(x => x.Id.Equals(gradecode)).SelectMany(x => x.subjects).Where(x => x.Id.Equals(Subjectcode)).SelectMany(x => x.units).ToList();
            foreach (var item in a)
            {
                    Items.Add(new Units(item.Title) { Title = item.Title, ListItems = item.ListItems });
            }
            InitializeComponent();
            GradeContain.Content = Grade.GetGrade().Where(x => x.Id.Equals(gradecode)).Select(x => x.grade).FirstOrDefault();
            Subjectcontain.Content = Grade.GetGrade().Where(x => x.Id.Equals(gradecode)).SelectMany(x => x.subjects).Where(x => x.Id.Equals(Subjectcode)).Select(x=>x.subject).FirstOrDefault();
            //classes = new Classes();
            classes.SelectTab += Click;
            classes.RefreshControlEvent();
            classes.ShowDialog();
          



        }

        private void Changed(object sender, EventArgs e)
        {
            Classes fc = sender as Classes;
            if (fc != null)
            {
               
            }
        }

        public void select_tab()
        {
            try
            {
                tabSubject.SelectedIndex = 1;
            }
            catch
            {
                tabSubject.SelectedIndex = 0;
            }

        }

        private void TabSelection_Changed(Object sender, SelectionChangedEventArgs e) {
           
            Items.Clear();
            Subjectcode = (tabSubject.SelectedIndex + 1).ToString();
            Subjectcontain.Content = ((TabItem) tabSubject.SelectedItem).Header.ToString();
            if (gradecode == null) { gradecode = "1"; }
            var a = Grade.GetGrade().Where(x => x.Id.Equals(gradecode)).SelectMany(x => x.subjects).Where(x => x.Id.Equals(Subjectcode)).SelectMany(x => x.units).ToList();
            foreach (var item in a)
            {
               

                    Items.Add(new Units(item.Title) { Title = item.Title, ListItems = item.ListItems });
            }
          
        }
        public class ListofUnits
        {
            public string Title { get; set; }
            public List<Topics> MyProperty { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataContext = this;
            _output = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SwfPlayer swfPlayer = new SwfPlayer();
            swfPlayer.ShowDialog();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MCQ mCQ = new MCQ();
            mCQ.ShowDialog();
        }
        
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            classes = new Classes();
            classes.SelectTab += Click;
            classes.RefreshControlEvent();
            classes.ShowDialog();
        }

     private void Click(object sender, RoutedEventArgs e)
        {
            gradecode = classes.ClassId.ToString();
            Subjectcode = classes.subjectId.ToString();
            GradeContain.Content = Grade.GetGrade().Where(x => x.Id.Equals(gradecode)).Select(x => x.grade).FirstOrDefault();
            Subjectcontain.Content = Grade.GetGrade().Where(x => x.Id.Equals(gradecode)).SelectMany(x => x.subjects).Where(x => x.Id.Equals(Subjectcode)).Select(x => x.subject).FirstOrDefault();


            tabSubject.SelectedIndex = Convert.ToInt32(Subjectcode)-1;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnChapter_Click(object sender, RoutedEventArgs e)
        {
            DataContext = this;
            var a = ((Button)sender).Tag;
            string b = a.ToString();
            Subjectcode = (tabSubject.SelectedIndex + 1).ToString();
            if (gradecode == null) { gradecode = "1"; }
            var c = Grade.GetGrade().Where(x => x.Id.Equals(gradecode)).SelectMany(x => x.subjects).Where(x => x.Id.Equals(Subjectcode)).SelectMany(x => x.units).SelectMany(x=>x.ListItems).Where(x=>x.Id==b).ToList();
            ani.Clear();


            foreach (var item in c)
            {
                ani.Add(item);
            }



            //foreach (var item in c)
            //{


            //    Items.Add(new Units(item.Title) { Title = item.Title, ListItems = item.ListItems });
            //}

            DoubleAnimation animation = new DoubleAnimation();
           
                animation.From = gridHeight;
                animation.To = 0;
                animation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
                GridMain.BeginAnimation(HeightProperty, animation);

                animation.To = gridHeight;
                animation.From = 0;
                animation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
                GridMain1.BeginAnimation(HeightProperty, animation);
               
                tabSubject.IsEnabled = false;
            ShowGrade.IsEnabled = false;


            //if (expand == false)
            //{
            //    anim1 = new DoubleAnimation(100, TimeSpan.FromSeconds(0.2));
            //    anim2 = new DoubleAnimation(340, TimeSpan.FromSeconds(0.2));
            //    anim3 = new DoubleAnimation(0, 90, TimeSpan.FromSeconds(0.2));

            //    expand = true;
            //}
            //else
            //{
            //    anim1 = new DoubleAnimation(0, TimeSpan.FromSeconds(0.2));
            //    anim2 = new DoubleAnimation(240, TimeSpan.FromSeconds(0.2));
            //    anim3 = new DoubleAnimation(90, 0, TimeSpan.FromSeconds(0.2));
            //    expand = false;
            //}
            //this.BeginAnimation(Canvas.HeightProperty, anim2);
            //GridMain.BeginAnimation(Canvas.HeightProperty, anim1);
            //     GridMain.Height = 0;



            //Storyboard storyboard = new Storyboard();

            //ObjectAnimationUsingKeyFrames oAnimation = new ObjectAnimationUsingKeyFrames();
            //oAnimation.BeginTime = TimeSpan.Zero;
            //Storyboard.SetTargetName(oAnimation, "GridMain");
            //Storyboard.SetTargetProperty(oAnimation, new PropertyPath("(Height)"));

            //DiscreteObjectKeyFrame doKeyFrame = new DiscreteObjectKeyFrame();
            //doKeyFrame.KeyTime = KeyTime.FromTimeSpan(TimeSpan.Zero);
            //doKeyFrame.Value = GridLength.Auto;
            //oAnimation.KeyFrames.Add(doKeyFrame);
            //storyboard.Children.Add(oAnimation);

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.To = gridHeight;
            animation.From = 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
            GridMain.BeginAnimation(HeightProperty, animation);

            animation.From = gridHeight;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
            GridMain1.BeginAnimation(HeightProperty, animation);
          
            tabSubject.IsEnabled = true;
            ShowGrade.IsEnabled = true;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SwfPlayer swfPlayer = new SwfPlayer();
            swfPlayer.ShowDialog();
        }

        //    public static double GetAnimatedHeight(DependencyObject obj)
        //    {
        //        return (double)obj.GetValue(AnimatedHeightProperty);
        //    }

        //    public static void SetAnimatedHeight(DependencyObject obj, double value)
        //    {
        //        obj.SetValue(AnimatedHeightProperty, value);
        //    }

        //    public static readonly DependencyProperty AnimatedHeightProperty =
        //             DependencyProperty.RegisterAttached("AnimatedHeight", typeof(double), typeof(AnimatedPanelBehavior), new UIPropertyMetadata(0d, new PropertyChangedCallback((s, e) =>
        //             {
        //                 FrameworkElement sender = s as FrameworkElement;
        //                 sender.Height = (double)e.NewValue;
        //             })));

    }






}
