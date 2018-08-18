using Quiz.Model;
using Quiz.ModelView;
using Quiz.Pages;
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
using System.Windows.Threading;

namespace Quiz.Resource
{
    /// <summary>
    /// Interaction logic for MCQ.xaml
    /// </summary>
    /// 



    public partial class MCQ : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        private int Dec = 1200;

        public List<Question> Questions { get; private set; }

        int[] ClickAnswer;
        int[] Answer;
        int[] tClick;
        public Question question { get; set; }
        int tQuestion = 5;
        int Total = 0;
        int _score = 0;
        List<int> RndQuestion = new List<int>();
        int qno = 0;


        public MCQ()
        {
            InitializeComponent();

            Questions = QuestionCollection.GetQuestions().Where(x => x.grade.Equals("Five")).SelectMany(x => x.subjects).Where(x => x.subject.Equals("Science")).SelectMany(x => x.questions).Where(x => x.Qno != 0).ToList();

            Total = Questions.Count;
            ClickAnswer = new int[Total];
            Answer = new int[Total];
            tClick = new int[tQuestion];
            Random rnd = new Random();

            Attempt.Content = 0.ToString();
            Remaining.Content = tQuestion.ToString();

            while (RndQuestion.Count < tQuestion)
            {
                int qno = rnd.Next(1, Questions.Count);
                if (!RndQuestion.Contains(qno))
                    RndQuestion.Add(qno);
            }

            question = Questions.Where(x => x.Qno == RndQuestion[qno]).FirstOrDefault();

            DataContext = question;
        }

        private void nxt_Click(object sender, RoutedEventArgs e)
        {

            if (qno < tQuestion-1)
            {
                tClick[qno] = Answer[qno];
                Attempt.Content =  tClick.Where(x => x > 0).Count().ToString();
                question = Questions.Where(x => x.Qno == RndQuestion[qno]).FirstOrDefault();
                DataContext = question;
                qno = qno + 1;
                SelectAns(Answer[qno],qno);
               
            }

        }

        private void prev_Click(object sender, RoutedEventArgs e)
        {
            if (qno > 0)
            {
                tClick[qno] = Answer[qno];
                qno = qno - 1;
                SelectAns(Answer[qno],qno);
                Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                question = Questions.Where(x => x.Qno == RndQuestion[qno]).FirstOrDefault();
                DataContext = question;

            }
        }
        private void SelectAns(int Ans,int qno)
        {
            try
            {

               
                option1.IsChecked = false;
                option2.IsChecked = false;
                option3.IsChecked = false;
                option4.IsChecked = false;
                switch (Ans)
                {
                    case 1:
                        option1.IsChecked = true;
                        return;
                    case 2:
                        option2.IsChecked = true;
                        return;
                    case 3:
                        option3.IsChecked = true;
                        return;
                    case 4:
                        option4.IsChecked = true;
                        return;
                    default:
                        option1.IsChecked = false;
                        option2.IsChecked = false;
                        option3.IsChecked = false;
                        option4.IsChecked = false;
                        
                        return;
                }

            }
            catch
            {
                ;
            }
        }


        private void loaded(object sender, RoutedEventArgs e)
        {
           
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();

        }

        private void dtTicker(object sender, EventArgs e)
        {
            if (Dec > 0)
            {
                timerCount.Content = Dec / 60 + " : " + ((Dec % 60) >= 10 ? (Dec % 60).ToString("00") : "0" + (Dec % 60));
                Dec = Dec - 1;
            }
            else
            {
                option1.IsEnabled = false;
                option2.IsEnabled = false;
                option3.IsEnabled = false;
                option4.IsEnabled = false;
                dt.Stop();
                Score score = new Score("", _score, tQuestion);
                score.ShowDialog();
            }
            //    Timer2.Enabled = True
            //End If
            //If Val(timer) = 0 Then

            //    Panel2.Enabled = False
            //    Timer1.Enabled = False
            //    Timer2.Enabled = False
            //    lblTimer.Visible = True
            //    MsgBox("Time Over", vbInformation, "Message")
            //End If
        }

        private void option2_Checked(object sender, RoutedEventArgs e)
        {
           
            //    If RadioButton2.Checked Then
            //    loadans(QstNO, 2)
            //    If CheckAns(RndQuestion(QstNO), 2) = True Then
            //        If CLickAns(QstNO) = False Then
            //            Score = Score + 1
            //            CLickAns(QstNO) = True

            //        End If
            //    Else
            //        If CLickAns(QstNO) = True Then
            //            Score = Score - 1
            //            CLickAns(QstNO) = False
            //        End If
            //    End If
            //    Label1.Text = Score
            //End If
        }

        private void option3_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void option4_Checked(object sender, RoutedEventArgs e)
        {
            
        }
        private void option1_Checked(object sender, RoutedEventArgs e)
        {
           
        }


        private bool CheckAns(int Qno, int Ans)
        {
            var q = Questions.Where(x => x.Qno == Qno).Select(x => x.answers).FirstOrDefault();
            switch (Ans)
            {
                case 1:
                    if (q[0].Option1.isCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (q[0].Option2.isCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (q[0].Option3.isCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 4:
                    if (q[0].Option4.isCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;

            }

        }

        private void option4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (option4.IsChecked == true)
                {
                    Answer[qno] = 4;
                    tClick[qno] = 4;
                    Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                    Remaining.Content = tClick.Where(x => x == 0).Count().ToString();
                    option1.IsChecked = false;
                    option3.IsChecked = false;
                    option2.IsChecked = false;
                    if (CheckAns(RndQuestion[qno], 4))
                    {
                        ClickAnswer[qno] = 1;
                        _score += 1;
                    }
                    else
                    {
                        ClickAnswer[qno] = 0;
                    }
                }
                else
                {
                    Answer[qno] = 0;
                    tClick[qno] = 0;
                    Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                    Remaining.Content = tClick.Where(x => x == 0).Count().ToString();
                }

            }
            catch
            {

            }
        }

        private void option1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (option1.IsChecked == true)
                {
                    Answer[qno] = 1;
                    tClick[qno] = 1;
                    Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                    Remaining.Content = tClick.Where(x => x == 0).Count().ToString();
                    option2.IsChecked = false;
                    option3.IsChecked = false;
                    option4.IsChecked = false;
                    if (CheckAns(RndQuestion[qno], 1))
                    {
                        ClickAnswer[qno] = 1;
                        _score += 1;
                    }
                    else
                    {
                        ClickAnswer[qno] = 0;
                    }
                }
                else
                {
                    Answer[qno] = 0;
                    tClick[qno] = 0;
                    Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                    Remaining.Content = tClick.Where(x => x == 0).Count().ToString();
                }

            }
            catch { }
        }

        private void option2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (option2.IsChecked == true)
                {
                    Answer[qno] = 2;
                    tClick[qno] = 2;
                    Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                    Remaining.Content = tClick.Where(x => x == 0).Count().ToString();
                    option1.IsChecked = false;
                    option3.IsChecked = false;
                    option4.IsChecked = false;
                    if (CheckAns(RndQuestion[qno], 2))
                    {
                        if (ClickAnswer[qno] == 0)
                        {
                            ClickAnswer[qno] = 1;
                            _score += 1;
                        }
                    }
                    else
                    {
                        if (ClickAnswer[qno] == 1)
                        {
                            _score -= 1;
                            ClickAnswer[qno] = 0;
                        }
                    }
                }
                else
                {
                    Answer[qno] = 0;
                    tClick[qno] = 0;
                    Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                    Remaining.Content = tClick.Where(x => x == 0).Count().ToString();
                }

            }
            catch { }
        }

        private void option3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (option3.IsChecked == true)
                {
                    Answer[qno] = 3;
                    tClick[qno] = 3;
                    Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                    Remaining.Content = tClick.Where(x => x == 0).Count().ToString();
                    option1.IsChecked = false;
                    option2.IsChecked = false;
                    option4.IsChecked = false;
                    if (CheckAns(RndQuestion[qno], 3))
                    {
                        ClickAnswer[qno] = 1;
                        _score += 1;
                    }
                    else
                    {
                        ClickAnswer[qno] = 0;
                    }
                }
                else
                {
                    Answer[qno] = 0;
                    tClick[qno] = 0;
                    Attempt.Content = tClick.Where(x => x > 0).Count().ToString();
                    Remaining.Content = tClick.Where(x => x == 0).Count().ToString();
                }

            }
            catch
            {
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dt.Stop();
            timerCount.Content = "00:00";
            option1.IsEnabled = false;
            option2.IsEnabled = false;
            option3.IsEnabled = false;
            option4.IsEnabled = false;
            Score score = new Score("", _score, tQuestion);
            score.ShowDialog();
        }
    }

}
